# UdpClient
15连屏的从机控制程序
默认以管理员方式开机自启动程序并隐藏到图标栏，读取配置文件并建立socket持续监听指定端口。
根据主机控制程序发送的广播控制指令，执行运行文件，结束进程，指定文件目录分发与删除，定时关闭服务器。

从机控制程序界面。

![iamge](https://github.com/Lucifinil0409/UdpClient/blob/master/UdpNetwork/showPic/%E6%8E%A7%E5%88%B6%E7%A8%8B%E5%BA%8F%E2%80%94%E2%80%94%E4%BB%8E%E6%9C%BA%E7%AB%AF.png)

配置文件实例。

![image](https://github.com/Lucifinil0409/UdpClient/blob/master/UdpNetwork/showPic/%E6%8E%A7%E5%88%B6%E7%A8%8B%E5%BA%8F%E2%80%94%E2%80%94%E9%85%8D%E7%BD%AE%E6%96%87%E4%BB%B6%E7%A4%BA%E4%BE%8B.png)

添加了一个非模态信息提示框，用来显示控制信息和报错信息。
倒计时结束自动关闭提示框，以不影响15连屏拼接显示内容。

![image](https://github.com/Lucifinil0409/UdpClient/blob/master/UdpNetwork/showPic/%E6%8E%A7%E5%88%B6%E7%A8%8B%E5%BA%8F%E2%80%94%E2%80%94%E6%B6%88%E6%81%AF%E6%A1%86.png)
