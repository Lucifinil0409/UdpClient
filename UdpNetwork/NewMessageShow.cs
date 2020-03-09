using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdpNetwork
{
    public partial class NewMessageShow : Form
    {
        private Thread timeoutThread;       //倒计时线程
        private bool autoClose = false;     //是否是自动关闭，还是直接点击确定或关闭按钮关闭
        //控制文本框的最大宽度/高度（高度暂时用不上)
        private const int formMaxWidth = 1200;
        private const int formMaxHeight = 1000;

        public NewMessageShow()
        {
            InitializeComponent();
        }

        public void Show(IWin32Window owner, string text = "", string caption = "", int secondsTimeout = 3)
        {
            try
            {
                //根据提示消息的大小自动调整消息提示框尺寸
                sizeAutoChange(text, caption);
                //显示在所有窗体的最上方
                this.TopMost = true;
                //显示消息提示窗
                base.Show(owner);
                //开启倒计时自动关闭提示窗线程
                timeoutThread = new Thread(autoCloseThread);
                timeoutThread.IsBackground = true;
                timeoutThread.Start(secondsTimeout);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        //根据提示消息的大小自动调整消息提示框尺寸
        private void sizeAutoChange(string text, string caption)
        {
            //width，height为窗口默认尺寸
            int width = this.Size.Width;
            int height = this.Size.Height;
            
            testLabel.Text = caption;     
            this.Text = caption;
            messageLabel.Text = text;
            //先通过标题长度比较宽度是否要改变
            if (testLabel.Width > formMaxWidth)
            {
                width = formMaxWidth;
            }
            else if (testLabel.Width + 40 > width)
            {
                width = testLabel.Width + 40;
            }
            /*else
            {
                width = 600;
            }*/
            //将测试用label改写为空串，也可不用，已经设置该label的可见性visable=false
            testLabel.Text = "";
            //根据文本内容的宽度修改提示框宽度，不需与最大值比较因为已经设置了文本框的MaximumSize=1000
            if ((220 + messageLabel.Width) > width)
            {
                width = 220 + messageLabel.Width;
            }
            /*else
            {
                width = width;
            }*/
            //根据文本内容行数增加提示框高度，fontHeight为当前字号的高度
            int fontHeight = messageLabel.Font.Height;
            if ((messageLabel.Height / fontHeight) > 2)
            {
                height += fontHeight * (messageLabel.Height / fontHeight - 2);
            }
            //重绘提示框大小
            this.Size = new System.Drawing.Size(width, height);
        }

        //自动关闭线程
        private void autoCloseThread(object timeObj)
        {
            try
            {
                //设置延迟关闭消息框的默认时间3秒
                int time = 3 * 10;
                try
                {
                    time = (int)timeObj * 10;                     
                }
                catch
                {
                    //设置时间失败
                    time = 3 * 10;
                }
                finally
                {
                    timeCountLabel2.Invoke((EventHandler)(delegate
                    {
                        timeCountLabel2.Text = (time / 10).ToString();
                    }));
                }
                while (time > 0)
                {
                    //线程每次挂起100毫秒
                    Thread.Sleep(100);
                    time--;
                    //更新倒计时                 
                    if (time % 10 == 0)
                    {
                        //委托给创建timeCountLabel2的线程才能修改显示的text内容
                        timeCountLabel2.Invoke((EventHandler)(delegate
                        {
                            timeCountLabel2.Text = (time / 10).ToString();
                        }));
                    }    
                }
                //计时结束设置窗口自动关闭标志autoclose并关闭消息提示窗口，需要委托给创建该窗口的线程执行
                this.Invoke((EventHandler)(delegate
                {
                    autoClose = true;
                    this.Close();
                }));       
            }
            catch(Exception threadException)
            {
                if(threadException.GetType()== typeof(ThreadAbortException))
                {
                    //中止计时线程抛出异常，不做处理
                }          
            }
        }

        //点击确定按钮关闭线程
        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //按下回车键触发OKButton的点击事件
        private void OKButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar == 13) //确定Enter
            {
                OKButton.PerformClick();
            }
        }

        //关闭窗口时若线程存在需要关闭线程并释放资源
        private void NewMessageShow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timeoutThread != null)
            {
                if (timeoutThread.IsAlive && !autoClose)
                {
                    try
                    {
                        timeoutThread.Abort();
                    }
                    catch { }
                }
            }
            this.Dispose();
        }
    }
}
