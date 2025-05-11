namespace 点餐管理系统.Department
{
    partial class Update_department
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_department));
            this.dgvDepartment = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtmanager = new System.Windows.Forms.TextBox();
            this.txtdescr = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btncance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDepartment
            // 
            this.dgvDepartment.BackgroundColor = System.Drawing.Color.White;
            this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartment.Location = new System.Drawing.Point(12, 12);
            this.dgvDepartment.Name = "dgvDepartment";
            this.dgvDepartment.RowHeadersWidth = 82;
            this.dgvDepartment.RowTemplate.Height = 37;
            this.dgvDepartment.Size = new System.Drawing.Size(1196, 438);
            this.dgvDepartment.TabIndex = 0;
            this.dgvDepartment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartment_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(35, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "部门编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(436, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "部门名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(864, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "部门经理";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(35, 596);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "部门描述";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtid.Location = new System.Drawing.Point(184, 497);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(183, 44);
            this.txtid.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtname.Location = new System.Drawing.Point(585, 497);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(183, 44);
            this.txtname.TabIndex = 6;
            // 
            // txtmanager
            // 
            this.txtmanager.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtmanager.Location = new System.Drawing.Point(1013, 497);
            this.txtmanager.Name = "txtmanager";
            this.txtmanager.Size = new System.Drawing.Size(183, 44);
            this.txtmanager.TabIndex = 7;
            // 
            // txtdescr
            // 
            this.txtdescr.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtdescr.Location = new System.Drawing.Point(184, 593);
            this.txtdescr.Name = "txtdescr";
            this.txtdescr.Size = new System.Drawing.Size(1012, 44);
            this.txtdescr.TabIndex = 8;
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnok.Location = new System.Drawing.Point(383, 672);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(119, 51);
            this.btnok.TabIndex = 9;
            this.btnok.Text = "修改";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btncance
            // 
            this.btncance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btncance.Location = new System.Drawing.Point(749, 672);
            this.btncance.Name = "btncance";
            this.btncance.Size = new System.Drawing.Size(119, 51);
            this.btncance.TabIndex = 10;
            this.btncance.Text = "返回";
            this.btncance.UseVisualStyleBackColor = true;
            this.btncance.Click += new System.EventHandler(this.btncance_Click);
            // 
            // Update_department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1220, 757);
            this.Controls.Add(this.btncance);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtdescr);
            this.Controls.Add(this.txtmanager);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDepartment);
            this.Name = "Update_department";
            this.Text = "Update_department";
            this.Load += new System.EventHandler(this.Update_department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtmanager;
        private System.Windows.Forms.TextBox txtdescr;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btncance;
    }
}