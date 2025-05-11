namespace 点餐管理系统
{
    partial class delect_supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delect_supplier));
            this.dgvsupplier = new System.Windows.Forms.DataGridView();
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
            this.dgvsupplier.Size = new System.Drawing.Size(1196, 540);
            this.dgvsupplier.TabIndex = 0;
            this.dgvsupplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsupplier_CellContentClick);
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("宋体", 12F);
            this.btnok.Location = new System.Drawing.Point(323, 637);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(140, 51);
            this.btnok.TabIndex = 1;
            this.btnok.Text = "删除";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btncance
            // 
            this.btncance.Font = new System.Drawing.Font("宋体", 12F);
            this.btncance.Location = new System.Drawing.Point(768, 637);
            this.btncance.Name = "btncance";
            this.btncance.Size = new System.Drawing.Size(140, 51);
            this.btncance.TabIndex = 2;
            this.btncance.Text = "取消";
            this.btncance.UseVisualStyleBackColor = true;
            this.btncance.Click += new System.EventHandler(this.btncance_Click);
            // 
            // delect_supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1220, 757);
            this.Controls.Add(this.btncance);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.dgvsupplier);
            this.Name = "delect_supplier";
            this.Text = "delect_supplier";
            this.Load += new System.EventHandler(this.delect_supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsupplier;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btncance;
    }
}