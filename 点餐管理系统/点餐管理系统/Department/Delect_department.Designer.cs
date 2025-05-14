namespace 点餐管理系统.Department
{
    partial class Delect_department
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delect_department));
            this.dgvDepartment = new System.Windows.Forms.DataGridView();
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
            this.dgvDepartment.Size = new System.Drawing.Size(1196, 540);
            this.dgvDepartment.TabIndex = 0;
            this.dgvDepartment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartment_CellContentClick);
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnok.Location = new System.Drawing.Point(322, 633);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(129, 58);
            this.btnok.TabIndex = 1;
            this.btnok.Text = "删除";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btncance
            // 
            this.btncance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btncance.Location = new System.Drawing.Point(729, 633);
            this.btncance.Name = "btncance";
            this.btncance.Size = new System.Drawing.Size(129, 58);
            this.btncance.TabIndex = 2;
            this.btncance.Text = "返回";
            this.btncance.UseVisualStyleBackColor = true;
            this.btncance.Click += new System.EventHandler(this.btncance_Click);
            // 
            // Delect_department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1220, 757);
            this.Controls.Add(this.btncance);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.dgvDepartment);
            this.Name = "Delect_department";
            this.Text = "Delect_department";
            this.Load += new System.EventHandler(this.Delect_department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDepartment;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btncance;
    }
}