using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Diagnostics;
using Microsoft.Win32;

namespace UdpNetwork
{
    public partial class FormClient : Form
    {
        private string IP;                                          //本机IP地址
        private Int32 port;                                         //监听端口号
        private string filePath;                                    //程序物理路径
        private string IPPath;                                      //共享文件夹IP路径
        private string userName;                                    //共享文件夹用户名
        private string passWord;                                    //共享文件夹密码
        private string srcPath;                                     //需要拷贝的文件夹路径
        private string aimPath;                                     //拷贝目的文件夹路径
        private const string iniFileName = "Config.ini";            //配置文件路径
        
        private Thread thrListener;                                 //连接线程
        private UdpClient udpClientRecv;                            //Udp类
        private IPEndPoint receivePoint;                            //用于监听的Ipv4地址和端口的网络终结点，用于创建UdpClient类
        private Process pr;                                         //进程类，用于保存打开和关闭文件的进程（暂未出bug）
        private byte[] recvData = new byte[1024];                   //接收的数据，必须为字节

        private const string orderOPEN = "OPEN";                    //Udp报文为orderOPEN时启动程序
        private const string orderCLOSE = "CLOSE";                  //Udp报文为orderCLOSE时关闭程序
        private const string orderSHUTDOWN = "SHUTDOWN";            //Udp报文为orderSHUTDOWN时关机
        private const string orderCOPY = "COPY";                    //Udp报文为orderCOPY时拷贝应用程序

        private static string path = AppDomain.CurrentDomain.BaseDirectory + iniFileName;  //指定ini文件的路径
        private IniFile ini = new IniFile(path);
        private bool copySucceedFlag;                               //判断拷贝文件是否成功标志位


        public FormClient()
        {
            InitializeComponent();
        }

        //加载程序主体窗口并从配置文件中获取参数
        private void FormClient_Load(object sender, EventArgs e)
        {                     
            //从配置文件Config.ini中获取初始值
            //IP = ini.IniReadValue("Config", "IP");
            port = Int32.Parse(ini.IniReadValue("Config", "Port"));
            filePath = ini.IniReadValue("Config", "FilePath");
            IPPath = ini.IniReadValue("Copy", "IPPath");
            userName = ini.IniReadValue("Copy", "Username");
            passWord = ini.IniReadValue("Copy", "Password");
            srcPath = ini.IniReadValue("Copy", "SrcPath");
            aimPath = ini.IniReadValue("Copy", "AimPath");

            //得到本机IPV4地址
            IP = GetLocalIP();

            //初始化文本框内容
            IPV4TextBox.Text = IP;
            portTextBox.Text = port.ToString();
            filePathTextBox.Text = filePath;
            folderIPTextBox.Text = IPPath;
            usernameTextBox.Text = userName;
            passwordTextBox.Text = passWord;
            srcPathTextBox.Text = srcPath;
            aimPathTextBox.Text = aimPath;

            //创建线程thrListener运行ReceiveMessage开始监听
            thrListener = new Thread(new ThreadStart(ReceiveMessage));
            thrListener.Start();
        }

        //关闭程序主体窗口时自动保存数据
        private void FormClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            //参数保存到配置文件
            ini.IniWriteValue("Config", "IP", IP);
            ini.IniWriteValue("Config", "Port", port.ToString());
            ini.IniWriteValue("Config", "FilePath", filePath);
            ini.IniWriteValue("Copy", "IPPath", IPPath);
            ini.IniWriteValue("Copy", "Username", userName);
            ini.IniWriteValue("Copy", "Password", passWord);
            ini.IniWriteValue("Copy", "SrcPath", srcPath);
            ini.IniWriteValue("Copy", "AimPath", aimPath);

            //强制关闭程序，关闭线程，关闭UdpClient
            thrListener.Abort();
            udpClientRecv.Close();
            Environment.Exit(0);
        }

        //监听特定端口的线程函数
        private void ReceiveMessage()
        {
            //processIsOpened判断进程是否已被打开，true进程已经存在，false进程不存在
            bool processIsOpened = false;
            //设置监听接收数据包IP和端口
            receivePoint = new IPEndPoint(IPAddress.Parse(IP), port);
            udpClientRecv = new UdpClient(receivePoint);
            //为进程类对象指定运行的程序，物理路径。
            pr = new Process();         
            pr.StartInfo.FileName = filePath;
            //获取程序不具有扩展名的文件名（即为.exe程序的进程名）
            string programName = System.IO.Path.GetFileNameWithoutExtension(filePath);

            while (true)
            {
                try
                {
                    //开始监听端口接收数据包
                    recvData = udpClientRecv.Receive(ref receivePoint);
                    //数据包以ASCII方式解码
                    string message = Encoding.ASCII.GetString(recvData, 0, recvData.Length);
                    if (message == orderOPEN)
                    {
                        //程序进程已经存在，弹出消息提示框
                        if (programIsStarted(programName))
                        {
                            InformationShow("程序正在运行，请不要重复打开。", "提示", 3);
                        }
                        //程序进程不存在，运行程序
                        else
                        {
                            InformationShow("正在打开程序。", "提示", 2);
                            if (pr.Start())
                            {
                                InformationShow("打开成功。", "提示", 3);
                            }
                            else
                            {
                                InformationShow("打开失败。", "提示", 3);
                            }
                        }
                    }
                    else if (message == orderCLOSE)
                    {
                        //程序进程存在，关闭程序
                        if (programIsStarted(programName))
                        {
                            InformationShow("正在关闭程序。", "提示", 2);
                            pr.Kill();
                        }
                        //程序进程不存在，弹出消息提示框
                        else
                        {
                            InformationShow("程序未运行，请先打开程序。", "提示", 3);
                        }
                    }
                    else if (message == orderSHUTDOWN)
                    {
                        InformationShow("系统将在3分钟后自动关机。", "提示", 3);
                        Process shutdownProcess = new Process();//实例化一个独立进程
                        shutdownProcess.StartInfo.FileName = "cmd.exe";//进程打开的文件为Cmd
                        shutdownProcess.StartInfo.UseShellExecute = false;//是否启动系统外壳选否
                        shutdownProcess.StartInfo.RedirectStandardInput = true;//这是是否从StandardInput输入
                        shutdownProcess.StartInfo.CreateNoWindow = true;//这里是启动程序是否显示窗体
                        shutdownProcess.Start();//启动
                        shutdownProcess.StandardInput.WriteLine("shutdown -s -t 180");//运行关机命令shutdown (-s)是关机 (-t)是延迟的时间 这里用秒计算 10就是10秒后关机
                        shutdownProcess.StandardInput.WriteLine("exit");
                    }
                    else if (message == orderCOPY)
                    {
                        if (programIsStarted(programName))
                        {
                            InformationShow("进行文件拷贝需要关闭程序。" + Environment.NewLine + "正在关闭程序。", "提示", 3);
                            pr.Kill();
                        }

                        if (connectState(IPPath, userName, passWord))
                        {
                            //先删除目标路径下文件夹内所有文件，以保证不会有残留文件影响新拷贝文件的正常使用
                            delectDir(aimPath);
                            //连接共享文件夹成功，进行文件拷贝工作
                            copySucceedFlag = true;
                            CopyDir(srcPath, aimPath);
                            if (copySucceedFlag == true)
                            {
                                InformationShow("文件夹拷贝成功。", "提示", 5);
                            }
                            else
                            {
                                InformationShow("文件夹拷贝失败。", "提示", 5);
                            }
                        }
                        else
                        {
                            InformationShow("连接失败。", "提示", 5);
                        }
                    }
                }
                catch (Exception ex)
                {
                    InformationShow(ex.ToString(), "错误", 5);
                }       
            }           
        }

        //判断程序programName是否已经运行，返回true代表已经在进程中运行，返回false代表未在进程中运行
        private bool programIsStarted(string programName)
        {
            bool processIsStartedFlag = false;
            foreach (Process singleProc in Process.GetProcesses())
            {
                if (singleProc.ProcessName == programName)
                {
                    processIsStartedFlag = true;
                    break;
                }
            }
            return processIsStartedFlag;
        }

        //获得当前主机的Ipv4地址
        private string GetLocalIP()
        {
            try
            {
                string HostName = Dns.GetHostName(); //得到主机名
                IPHostEntry IpEntry = Dns.GetHostEntry(HostName);
                for (int i = 0; i < IpEntry.AddressList.Length; i++)
                {
                    //从IP地址列表中筛选出IPv4类型的IP地址
                    //AddressFamily.InterNetwork表示此IP为IPv4,
                    //AddressFamily.InterNetworkV6表示此地址为IPv6类型
                    if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        return IpEntry.AddressList[i].ToString();
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                InformationShow("获取本机IP出错:" + ex.ToString(), "错误", 5);
                return "";
            }
        }

        //连接远程共享文件夹，IP路径path，账号名userName，密码passWord，连接成功返回true，失败返回false
        private bool connectState(string path, string userName, string passWord)
        {
            bool Flag = false;
            Process proc = new Process();
            try
            {
                proc.StartInfo.FileName = "cmd.exe";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardInput = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();
                string dosLine = @"net use " + path + " /User:" + userName + " " + passWord + " /PERSISTENT:YES";
                proc.StandardInput.WriteLine(dosLine);
                proc.StandardInput.WriteLine("exit");
                while (!proc.HasExited)
                {
                    proc.WaitForExit(1000);
                }
                string errormsg = proc.StandardError.ReadToEnd();
                proc.StandardError.Close();
                if (string.IsNullOrEmpty(errormsg))
                {
                    Flag = true;
                }
                else
                {
                    throw new Exception(errormsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                proc.Close();
                proc.Dispose();
            }
            return Flag;
        }

        //删除目标路径文件夹下的所有文件及文件夹
        private void delectDir(string srcPath)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(srcPath);
                FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //返回目录中所有文件和子目录
                foreach (FileSystemInfo i in fileinfo)
                {
                    if (i is DirectoryInfo)            //判断是否文件夹
                    {
                        DirectoryInfo subdir = new DirectoryInfo(i.FullName);
                        subdir.Delete(true);          //删除子目录和文件
                    }
                    else
                    {
                        File.Delete(i.FullName);      //删除指定文件
                    }
                }
            }
            catch (Exception delectException)
            {
                InformationShow(delectException.ToString(), "错误", 5);
            }
        }

        //将源路径srcPath下的所有文件及文件夹拷贝到目标路径aimPath的文件夹下
        private void CopyDir(string srcPath, string aimPath)
        {
            try
            {
                // 检查目标目录是否以目录分割字符结束如果不是则添加之
                if (aimPath[aimPath.Length - 1] != Path.DirectorySeparatorChar)
                    aimPath += Path.DirectorySeparatorChar;
                // 判断目标目录是否存在如果不存在则新建之
                if (!Directory.Exists(aimPath))
                    Directory.CreateDirectory(aimPath);
                //得到源目录的文件列表，该里面是包含文件以及目录路径的一个数组
                //如果你指向copy目标文件下面的文件而不包含目录请使用下面的方法
                //string[] fileList = Directory.GetFiles(srcPath);
                string[] fileList = Directory.GetFileSystemEntries(srcPath);
                //遍历所有的文件和目录
                foreach (string file in fileList)
                {
                    //先当作目录处理如果存在这个目录就递归Copy该目录下面的文件
                    if (Directory.Exists(file))
                        CopyDir(file, aimPath + Path.GetFileName(file));
                    //否则直接Copy文件
                    else
                        File.Copy(file, aimPath + Path.GetFileName(file), true);
                }
            }
            catch (Exception ee)
            {
                copySucceedFlag = false;
                //throw new Exception(ee.ToString());
            }
        }

        //自动最小化程序窗口并显示通知栏图标
        private void FormClient_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide(); //或者是this.Visible = false;
                this.notifyIcon1.Visible = true;
            }
        }

        //通知栏图标菜单栏的显示/隐藏/退出函数
        private void showMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }
        private void hideMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要退出程序吗？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                notifyIcon1.Visible = false;
                this.Close();
                this.Dispose();
                Application.Exit();
            }
        }

        //双击通知栏图标实现显示和隐藏程序主体界面
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
        }

        //设置和取消开机自启动
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked) //设置开机自启动  
                {
                    string path = Application.ExecutablePath;
                    RegistryKey rk = Registry.LocalMachine;
                    RegistryKey rk2 = rk.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                    rk2.SetValue("UdpClient", path);
                    rk2.Close();
                    rk.Close();
                    InformationShow("设置开机自启动，需要修改注册表。", "提示", 3);
                }
                else //取消开机自启动  
                {
                    string path = Application.ExecutablePath;
                    RegistryKey rk = Registry.LocalMachine;
                    RegistryKey rk2 = rk.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                    rk2.DeleteValue("UdpClient", false);
                    rk2.Close();
                    rk.Close();
                    InformationShow("取消开机自启动，需要修改注册表。", "提示", 3);
                }
            }
            catch (Exception ex)
            {
                InformationShow(ex.ToString(), "错误", 10);
            }  
        }

        //点击保存数据按钮事件，保存当前文本框内数据到Config.ini，并应用当前参数监听端口
        private void saveDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                //根据文本框输入内容来修改配置文件参数
                IP = IPV4TextBox.Text;
                port = Int32.Parse(portTextBox.Text);
                filePath = filePathTextBox.Text;
                IPPath = folderIPTextBox.Text;
                userName = usernameTextBox.Text;
                passWord = passwordTextBox.Text;
                srcPath = srcPathTextBox.Text;
                aimPath = aimPathTextBox.Text;
                //写入Config.ini配置文件
                ini.IniWriteValue("Config", "IP", IP);
                ini.IniWriteValue("Config", "Port", port.ToString());
                ini.IniWriteValue("Config", "FilePath", filePath);
                ini.IniWriteValue("Copy", "IPPath", IPPath);
                ini.IniWriteValue("Copy", "Username", userName);
                ini.IniWriteValue("Copy", "Password", passWord);
                ini.IniWriteValue("Copy", "SrcPath", srcPath);
                ini.IniWriteValue("Copy", "AimPath", aimPath);

                //重新设置监听IP，端口
                receivePoint = new IPEndPoint(IPAddress.Parse(IP), port);
                udpClientRecv = new UdpClient(receivePoint);
            }
            catch(Exception exUdp)
            {
                if(exUdp.GetType() == typeof(SocketException))
                {
                    //MessageBox.Show(new NewMessageShow(3000), "SocketException捕获成功!");
                }
            }
            finally
            {
                //修改进程的物理路径
                pr.StartInfo.FileName = filePath;
                InformationShow("已保存当前参数到配置文件，并使用当前参数运行端口监听。", "提示", 3);
            }
        }

        //弹出提示框,text为提示框正文信息，caption为提示框标题，interval为设置的提示框自动关闭时间（单位：秒）
        public void InformationShow(string text = "", string caption = "", int interval = 3)
        {
            this.Invoke((EventHandler)(delegate
            {
                NewMessageShow informationShow = new NewMessageShow();
                informationShow.Show(this, text, caption, interval);
            }));
        }
    }
}
