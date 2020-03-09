namespace UdpNetwork
{
    partial class NewMessageShow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OKButton = new System.Windows.Forms.Button();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.testLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timeCountLabel3 = new System.Windows.Forms.Label();
            this.timeCountLabel2 = new System.Windows.Forms.Label();
            this.timeCountLabel1 = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.messagePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OKButton.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OKButton.Location = new System.Drawing.Point(420, 40);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(100, 40);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "确 定";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            this.OKButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OKButton_KeyPress);
            // 
            // messagePanel
            // 
            this.messagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messagePanel.BackColor = System.Drawing.SystemColors.Window;
            this.messagePanel.Controls.Add(this.testLabel);
            this.messagePanel.Controls.Add(this.messageLabel);
            this.messagePanel.Location = new System.Drawing.Point(0, 0);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(580, 190);
            this.messagePanel.TabIndex = 2;
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.testLabel.Location = new System.Drawing.Point(4, 4);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(203, 12);
            this.testLabel.TabIndex = 1;
            this.testLabel.Text = "用于测试消息提示框标题宽度的Label";
            this.testLabel.Visible = false;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.messageLabel.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.messageLabel.Location = new System.Drawing.Point(150, 70);
            this.messageLabel.MaximumSize = new System.Drawing.Size(1000, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(110, 31);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "输出信息";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.timeCountLabel3);
            this.panel2.Controls.Add(this.timeCountLabel2);
            this.panel2.Controls.Add(this.timeCountLabel1);
            this.panel2.Controls.Add(this.OKButton);
            this.panel2.Location = new System.Drawing.Point(0, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 120);
            this.panel2.TabIndex = 3;
            // 
            // timeCountLabel3
            // 
            this.timeCountLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.timeCountLabel3.AutoSize = true;
            this.timeCountLabel3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeCountLabel3.Location = new System.Drawing.Point(232, 47);
            this.timeCountLabel3.Name = "timeCountLabel3";
            this.timeCountLabel3.Size = new System.Drawing.Size(172, 27);
            this.timeCountLabel3.TabIndex = 3;
            this.timeCountLabel3.Text = "秒之后自动关闭。";
            // 
            // timeCountLabel2
            // 
            this.timeCountLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.timeCountLabel2.AutoSize = true;
            this.timeCountLabel2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeCountLabel2.Location = new System.Drawing.Point(198, 47);
            this.timeCountLabel2.Name = "timeCountLabel2";
            this.timeCountLabel2.Size = new System.Drawing.Size(28, 27);
            this.timeCountLabel2.TabIndex = 2;
            this.timeCountLabel2.Text = "N";
            // 
            // timeCountLabel1
            // 
            this.timeCountLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.timeCountLabel1.AutoSize = true;
            this.timeCountLabel1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeCountLabel1.Location = new System.Drawing.Point(20, 47);
            this.timeCountLabel1.Name = "timeCountLabel1";
            this.timeCountLabel1.Size = new System.Drawing.Size(172, 27);
            this.timeCountLabel1.TabIndex = 1;
            this.timeCountLabel1.Text = "提示：该窗口将于";
            // 
            // imageBox
            // 
            this.imageBox.BackgroundImage = global::UdpNetwork.Properties.Resources.Bulbasaur;
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageBox.Location = new System.Drawing.Point(50, 50);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(80, 80);
            this.imageBox.TabIndex = 1;
            this.imageBox.TabStop = false;
            // 
            // NewMessageShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.messagePanel);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewMessageShow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewMessageShow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewMessageShow_FormClosing);
            this.messagePanel.ResumeLayout(false);
            this.messagePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Label timeCountLabel3;
        private System.Windows.Forms.Label timeCountLabel2;
        private System.Windows.Forms.Label timeCountLabel1;
    }
}