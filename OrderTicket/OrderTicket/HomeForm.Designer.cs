﻿namespace OrderTicket
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.列车信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.网上购票用户注册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyPwdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.longinButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.usernameTip = new System.Windows.Forms.Label();
            this.pwdTip = new System.Windows.Forms.Label();
            this.loginTip = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.列车信息查询ToolStripMenuItem,
            this.网上购票用户注册ToolStripMenuItem,
            this.ModifyPwdToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(1336, 28);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // 列车信息查询ToolStripMenuItem
            // 
            this.列车信息查询ToolStripMenuItem.Name = "列车信息查询ToolStripMenuItem";
            this.列车信息查询ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.列车信息查询ToolStripMenuItem.Text = "列车信息查询";
            this.列车信息查询ToolStripMenuItem.Click += new System.EventHandler(this.列车信息查询ToolStripMenuItem_Click);
            // 
            // 网上购票用户注册ToolStripMenuItem
            // 
            this.网上购票用户注册ToolStripMenuItem.Name = "网上购票用户注册ToolStripMenuItem";
            this.网上购票用户注册ToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.网上购票用户注册ToolStripMenuItem.Text = "网上购票用户注册";
            this.网上购票用户注册ToolStripMenuItem.Click += new System.EventHandler(this.网上购票用户注册ToolStripMenuItem_Click);
            // 
            // ModifyPwdToolStripMenuItem
            // 
            this.ModifyPwdToolStripMenuItem.Name = "ModifyPwdToolStripMenuItem";
            this.ModifyPwdToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.ModifyPwdToolStripMenuItem.Text = "忘记密码";
            this.ModifyPwdToolStripMenuItem.Click += new System.EventHandler(this.ModifyPwdToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextbox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.usernameTextbox.Location = new System.Drawing.Point(532, 306);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(387, 24);
            this.usernameTextbox.TabIndex = 1;
            this.usernameTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextbox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwordTextbox.Location = new System.Drawing.Point(532, 431);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(387, 24);
            this.passwordTextbox.TabIndex = 2;
            this.passwordTextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // longinButton
            // 
            this.longinButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("longinButton.BackgroundImage")));
            this.longinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.longinButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.longinButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.longinButton.Location = new System.Drawing.Point(445, 551);
            this.longinButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.longinButton.Name = "longinButton";
            this.longinButton.Size = new System.Drawing.Size(127, 49);
            this.longinButton.TabIndex = 3;
            this.longinButton.Text = "登录";
            this.longinButton.UseVisualStyleBackColor = true;
            this.longinButton.Click += new System.EventHandler(this.longinButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelButton.Location = new System.Drawing.Point(832, 551);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(121, 49);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // usernameTip
            // 
            this.usernameTip.AutoSize = true;
            this.usernameTip.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usernameTip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.usernameTip.ForeColor = System.Drawing.Color.Red;
            this.usernameTip.Location = new System.Drawing.Point(659, 369);
            this.usernameTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameTip.Name = "usernameTip";
            this.usernameTip.Size = new System.Drawing.Size(136, 24);
            this.usernameTip.TabIndex = 5;
            this.usernameTip.Text = "请先输入账户！";
            this.usernameTip.Visible = false;
            // 
            // pwdTip
            // 
            this.pwdTip.AutoSize = true;
            this.pwdTip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwdTip.ForeColor = System.Drawing.Color.Red;
            this.pwdTip.Location = new System.Drawing.Point(659, 500);
            this.pwdTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pwdTip.Name = "pwdTip";
            this.pwdTip.Size = new System.Drawing.Size(136, 24);
            this.pwdTip.TabIndex = 6;
            this.pwdTip.Text = "请先输入密码！";
            this.pwdTip.Visible = false;
            // 
            // loginTip
            // 
            this.loginTip.AutoSize = true;
            this.loginTip.BackColor = System.Drawing.SystemColors.Control;
            this.loginTip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginTip.ForeColor = System.Drawing.Color.Red;
            this.loginTip.Location = new System.Drawing.Point(635, 245);
            this.loginTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginTip.Name = "loginTip";
            this.loginTip.Size = new System.Drawing.Size(172, 24);
            this.loginTip.TabIndex = 7;
            this.loginTip.Text = "账户或者密码错误！";
            this.loginTip.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OrderTicket.Properties.Resources._1_gaitubao_104x104;
            this.pictureBox1.Location = new System.Drawing.Point(12, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1336, 889);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginTip);
            this.Controls.Add(this.pwdTip);
            this.Controls.Add(this.usernameTip);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.longinButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomeForm";
            this.Text = "火车票订票管理系统";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem 列车信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 网上购票用户注册ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModifyPwdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button longinButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label usernameTip;
        private System.Windows.Forms.Label pwdTip;
        private System.Windows.Forms.Label loginTip;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

