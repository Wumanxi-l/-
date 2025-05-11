namespace 点餐管理系统
{
    partial class update_supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_supplier));
            this.dgvsupplier = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtemname = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.txtyou = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btncance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvsupplier
            // 
            this.dgvsupplier.BackgroundColor = System.Drawing.Color.White;
            this.dgvsupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsupplier.Location = new System.Drawing.Point(12, 12);
            this.dgvsupplier.Name = "dgvsupplier";
            this.dgvsupplier.RowHeadersWidth = 82;
            this.dgvsupplier.RowTemplate.Height = 37;
            this.dgvsupplier.Size = new System.Drawing.Size(1196, 438);
            this.dgvsupplier.TabIndex = 0;
            this.dgvsupplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsupplier_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(28, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "供应商编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(406, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "供应商名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(776, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "联系人姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(28, 565);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "电话号码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(457, 563);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "地址";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(776, 566);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 33);
            this.label6.TabIndex = 6;
            this.label6.Text = "邮政编号";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(222, 474);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(163, 35);
            this.txtid.TabIndex = 7;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(587, 474);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(163, 35);
            this.txtname.TabIndex = 8;
            // 
            // txtemname
            // 
            this.txtemname.Location = new System.Drawing.Point(957, 472);
            this.txtemname.Name = "txtemname";
            this.txtemname.Size = new System.Drawing.Size(163, 35);
            this.txtemname.TabIndex = 9;
            this.txtemname.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(222, 563);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(163, 35);
            this.txtphone.TabIndex = 10;
            this.txtphone.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtadd
            // 
            this.txtadd.Location = new System.Drawing.Point(587, 563);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(163, 35);
            this.txtadd.TabIndex = 11;
            // 
            // txtyou
            // 
            this.txtyou.Location = new System.Drawing.Point(957, 563);
            this.txtyou.Name = "txtyou";
            this.txtyou.Size = new System.Drawing.Size(163, 35);
            this.txtyou.TabIndex = 12;
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("宋体", 12F);
            this.btnok.Location = new System.Drawing.Point(360, 643);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(141, 59);
            this.btnok.TabIndex = 13;
            this.btnok.Text = "修改";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncance
            // 
            this.btncance.Font = new System.Drawing.Font("宋体", 12F);
            this.btncance.Location = new System.Drawing.Point(654, 643);
            this.btncance.Name = "btncance";
            this.btncance.Size = new System.Drawing.Size(141, 59);
            this.btncance.TabIndex = 14;
            this.btncance.Text = "取消";
            this.btncance.UseVisualStyleBackColor = true;
            this.btncance.Click += new System.EventHandler(this.btncance_Click);
            // 
            // update_supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1220, 757);
            this.Controls.Add(this.btncance);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtyou);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtemname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvsupplier);
            this.Name = "update_supplier";
            this.Text = "update_supplier";
            this.Load += new System.EventHandler(this.update_supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtemname;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.TextBox txtyou;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btncance;
    }
}