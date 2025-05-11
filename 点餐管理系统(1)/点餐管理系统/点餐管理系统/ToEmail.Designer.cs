namespace 点餐管理系统
{
    partial class ToEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToEmail));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtToMial = new System.Windows.Forms.TextBox();
            this.txtFromMail = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtUserPwd = new System.Windows.Forms.TextBox();
            this.txtServerAddress = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(116, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "收件人邮箱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(116, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "发件人邮箱";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(116, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "发件人账号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(84, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "发件人授权码";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(116, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 50);
            this.label5.TabIndex = 0;
            this.label5.Text = "服务地址";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(116, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 47);
            this.label6.TabIndex = 0;
            this.label6.Text = "邮件主题";
            // 
            // txtToMial
            // 
            this.txtToMial.Location = new System.Drawing.Point(297, 88);
            this.txtToMial.Name = "txtToMial";
            this.txtToMial.Size = new System.Drawing.Size(220, 35);
            this.txtToMial.TabIndex = 4;
            // 
            // txtFromMail
            // 
            this.txtFromMail.Location = new System.Drawing.Point(297, 161);
            this.txtFromMail.Name = "txtFromMail";
            this.txtFromMail.Size = new System.Drawing.Size(220, 35);
            this.txtFromMail.TabIndex = 5;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(297, 233);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(220, 35);
            this.txtUserId.TabIndex = 6;
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.Location = new System.Drawing.Point(297, 315);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.Size = new System.Drawing.Size(242, 35);
            this.txtUserPwd.TabIndex = 7;
            // 
            // txtServerAddress
            // 
            this.txtServerAddress.Location = new System.Drawing.Point(297, 391);
            this.txtServerAddress.Name = "txtServerAddress";
            this.txtServerAddress.Size = new System.Drawing.Size(220, 35);
            this.txtServerAddress.TabIndex = 8;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(297, 462);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(220, 35);
            this.txtSubject.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(323, 619);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 59);
            this.button1.TabIndex = 10;
            this.button1.Text = "发送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(656, 619);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 59);
            this.button2.TabIndex = 11;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(118, 527);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 33);
            this.label7.TabIndex = 12;
            this.label7.Text = "邮件内容";
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(297, 531);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(722, 35);
            this.txtBody.TabIndex = 13;
            // 
            // ToEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1162, 738);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtServerAddress);
            this.Controls.Add(this.txtUserPwd);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.txtFromMail);
            this.Controls.Add(this.txtToMial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ToEmail";
            this.Text = "ToEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtToMial;
        private System.Windows.Forms.TextBox txtFromMail;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtUserPwd;
        private System.Windows.Forms.TextBox txtServerAddress;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBody;
    }
}