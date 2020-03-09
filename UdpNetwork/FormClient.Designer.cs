namespace UdpNetwork
{
    partial class FormClient
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.IPLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.IPV4TextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.folderIPTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.srcPathTextBox = new System.Windows.Forms.TextBox();
            this.aimPathTextBox = new System.Windows.Forms.TextBox();
            this.共享文件夹IP地址label = new System.Windows.Forms.Label();
            this.账号label = new System.Windows.Forms.Label();
            this.密码label = new System.Windows.Forms.Label();
            this.源路径label = new System.Windows.Forms.Label();
            this.目标路径label = new System.Windows.Forms.Label();
            this.saveDataButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.BackColor = System.Drawing.SystemColors.Window;
            this.IPLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IPLabel.ForeColor = System.Drawing.Color.Olive;
            this.IPLabel.Location = new System.Drawing.Point(20, 20);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(109, 21);
            this.IPLabel.TabIndex = 0;
            this.IPLabel.Text = "本机IPV4地址";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.BackColor = System.Drawing.SystemColors.Window;
            this.portLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.portLabel.ForeColor = System.Drawing.Color.Olive;
            this.portLabel.Location = new System.Drawing.Point(20, 60);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(90, 21);
            this.portLabel.TabIndex = 1;
            this.portLabel.Text = "监听端口号";
            // 
            // IPV4TextBox
            // 
            this.IPV4TextBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.IPV4TextBox.ForeColor = System.Drawing.Color.Olive;
            this.IPV4TextBox.Location = new System.Drawing.Point(185, 20);
            this.IPV4TextBox.Name = "IPV4TextBox";
            this.IPV4TextBox.Size = new System.Drawing.Size(160, 21);
            this.IPV4TextBox.TabIndex = 2;
            // 
            // portTextBox
            // 
            this.portTextBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.portTextBox.ForeColor = System.Drawing.Color.Olive;
            this.portTextBox.Location = new System.Drawing.Point(185, 60);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(160, 21);
            this.portTextBox.TabIndex = 3;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Listening";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMenuItem,
            this.hideMenuItem,
            this.exitMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
            // 
            // showMenuItem
            // 
            this.showMenuItem.Name = "showMenuItem";
            this.showMenuItem.Size = new System.Drawing.Size(100, 22);
            this.showMenuItem.Text = "显示";
            this.showMenuItem.Click += new System.EventHandler(this.showMenuItem_Click);
            // 
            // hideMenuItem
            // 
            this.hideMenuItem.Name = "hideMenuItem";
            this.hideMenuItem.Size = new System.Drawing.Size(100, 22);
            this.hideMenuItem.Text = "隐藏";
            this.hideMenuItem.Click += new System.EventHandler(this.hideMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitMenuItem.Text = "退出";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.Window;
            this.checkBox1.Location = new System.Drawing.Point(268, 371);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "开机启动";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.BackColor = System.Drawing.SystemColors.Window;
            this.filePathLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.filePathLabel.ForeColor = System.Drawing.Color.Olive;
            this.filePathLabel.Location = new System.Drawing.Point(20, 100);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(106, 21);
            this.filePathLabel.TabIndex = 6;
            this.filePathLabel.Text = "程序运行路径";
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.filePathTextBox.ForeColor = System.Drawing.Color.Olive;
            this.filePathTextBox.Location = new System.Drawing.Point(185, 100);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(160, 21);
            this.filePathTextBox.TabIndex = 7;
            // 
            // folderIPTextBox
            // 
            this.folderIPTextBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.folderIPTextBox.ForeColor = System.Drawing.Color.Olive;
            this.folderIPTextBox.Location = new System.Drawing.Point(185, 140);
            this.folderIPTextBox.Name = "folderIPTextBox";
            this.folderIPTextBox.Size = new System.Drawing.Size(160, 21);
            this.folderIPTextBox.TabIndex = 8;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.usernameTextBox.ForeColor = System.Drawing.Color.Olive;
            this.usernameTextBox.Location = new System.Drawing.Point(185, 180);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(160, 21);
            this.usernameTextBox.TabIndex = 9;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.passwordTextBox.ForeColor = System.Drawing.Color.Olive;
            this.passwordTextBox.Location = new System.Drawing.Point(185, 220);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(160, 21);
            this.passwordTextBox.TabIndex = 10;
            // 
            // srcPathTextBox
            // 
            this.srcPathTextBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.srcPathTextBox.ForeColor = System.Drawing.Color.Olive;
            this.srcPathTextBox.Location = new System.Drawing.Point(185, 260);
            this.srcPathTextBox.Name = "srcPathTextBox";
            this.srcPathTextBox.Size = new System.Drawing.Size(160, 21);
            this.srcPathTextBox.TabIndex = 11;
            // 
            // aimPathTextBox
            // 
            this.aimPathTextBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.aimPathTextBox.ForeColor = System.Drawing.Color.Olive;
            this.aimPathTextBox.Location = new System.Drawing.Point(185, 300);
            this.aimPathTextBox.Name = "aimPathTextBox";
            this.aimPathTextBox.Size = new System.Drawing.Size(160, 21);
            this.aimPathTextBox.TabIndex = 12;
            // 
            // 共享文件夹IP地址label
            // 
            this.共享文件夹IP地址label.AutoSize = true;
            this.共享文件夹IP地址label.BackColor = System.Drawing.SystemColors.Window;
            this.共享文件夹IP地址label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.共享文件夹IP地址label.ForeColor = System.Drawing.Color.Olive;
            this.共享文件夹IP地址label.Location = new System.Drawing.Point(20, 140);
            this.共享文件夹IP地址label.Name = "共享文件夹IP地址label";
            this.共享文件夹IP地址label.Size = new System.Drawing.Size(137, 21);
            this.共享文件夹IP地址label.TabIndex = 13;
            this.共享文件夹IP地址label.Text = "共享文件夹IP地址";
            // 
            // 账号label
            // 
            this.账号label.AutoSize = true;
            this.账号label.BackColor = System.Drawing.SystemColors.Window;
            this.账号label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.账号label.ForeColor = System.Drawing.Color.Olive;
            this.账号label.Location = new System.Drawing.Point(20, 180);
            this.账号label.Name = "账号label";
            this.账号label.Size = new System.Drawing.Size(42, 21);
            this.账号label.TabIndex = 14;
            this.账号label.Text = "账号";
            // 
            // 密码label
            // 
            this.密码label.AutoSize = true;
            this.密码label.BackColor = System.Drawing.SystemColors.Window;
            this.密码label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.密码label.ForeColor = System.Drawing.Color.Olive;
            this.密码label.Location = new System.Drawing.Point(20, 220);
            this.密码label.Name = "密码label";
            this.密码label.Size = new System.Drawing.Size(42, 21);
            this.密码label.TabIndex = 15;
            this.密码label.Text = "密码";
            // 
            // 源路径label
            // 
            this.源路径label.AutoSize = true;
            this.源路径label.BackColor = System.Drawing.SystemColors.Window;
            this.源路径label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.源路径label.ForeColor = System.Drawing.Color.Olive;
            this.源路径label.Location = new System.Drawing.Point(20, 260);
            this.源路径label.Name = "源路径label";
            this.源路径label.Size = new System.Drawing.Size(90, 21);
            this.源路径label.TabIndex = 16;
            this.源路径label.Text = "拷贝源路径";
            // 
            // 目标路径label
            // 
            this.目标路径label.AutoSize = true;
            this.目标路径label.BackColor = System.Drawing.SystemColors.Window;
            this.目标路径label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.目标路径label.ForeColor = System.Drawing.Color.Olive;
            this.目标路径label.Location = new System.Drawing.Point(20, 300);
            this.目标路径label.Name = "目标路径label";
            this.目标路径label.Size = new System.Drawing.Size(106, 21);
            this.目标路径label.TabIndex = 17;
            this.目标路径label.Text = "拷贝目标路径";
            // 
            // saveDataButton
            // 
            this.saveDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.saveDataButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveDataButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveDataButton.Location = new System.Drawing.Point(24, 351);
            this.saveDataButton.Name = "saveDataButton";
            this.saveDataButton.Size = new System.Drawing.Size(99, 36);
            this.saveDataButton.TabIndex = 18;
            this.saveDataButton.Text = "保存数据";
            this.saveDataButton.UseVisualStyleBackColor = false;
            this.saveDataButton.Click += new System.EventHandler(this.saveDataButton_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.saveDataButton);
            this.Controls.Add(this.目标路径label);
            this.Controls.Add(this.源路径label);
            this.Controls.Add(this.密码label);
            this.Controls.Add(this.账号label);
            this.Controls.Add(this.共享文件夹IP地址label);
            this.Controls.Add(this.aimPathTextBox);
            this.Controls.Add(this.srcPathTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.folderIPTextBox);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.IPV4TextBox);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.IPLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Olive;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClient";
            this.ShowInTaskbar = false;
            this.Text = "Listening";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClient_FormClosing);
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.SizeChanged += new System.EventHandler(this.FormClient_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox IPV4TextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.TextBox folderIPTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox srcPathTextBox;
        private System.Windows.Forms.TextBox aimPathTextBox;
        private System.Windows.Forms.Label 共享文件夹IP地址label;
        private System.Windows.Forms.Label 账号label;
        private System.Windows.Forms.Label 密码label;
        private System.Windows.Forms.Label 源路径label;
        private System.Windows.Forms.Label 目标路径label;
        private System.Windows.Forms.Button saveDataButton;
    }
}

