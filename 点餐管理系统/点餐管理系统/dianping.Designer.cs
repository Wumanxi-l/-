namespace 点餐管理系统
{
    partial class dianping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dianping));
            this.dgvdianping = new System.Windows.Forms.DataGridView();
            this.btnCance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdianping)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdianping
            // 
            this.dgvdianping.BackgroundColor = System.Drawing.Color.White;
            this.dgvdianping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdianping.Location = new System.Drawing.Point(12, 12);
            this.dgvdianping.Name = "dgvdianping";
            this.dgvdianping.RowHeadersWidth = 82;
            this.dgvdianping.RowTemplate.Height = 37;
            this.dgvdianping.Size = new System.Drawing.Size(1196, 554);
            this.dgvdianping.TabIndex = 0;
            // 
            // btnCance
            // 
            this.btnCance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCance.Location = new System.Drawing.Point(503, 637);
            this.btnCance.Name = "btnCance";
            this.btnCance.Size = new System.Drawing.Size(188, 69);
            this.btnCance.TabIndex = 1;
            this.btnCance.Text = "返回";
            this.btnCance.UseVisualStyleBackColor = true;
            this.btnCance.Click += new System.EventHandler(this.btnCance_Click);
            // 
            // dianping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1220, 757);
            this.Controls.Add(this.btnCance);
            this.Controls.Add(this.dgvdianping);
            this.Name = "dianping";
            this.Text = "dianping";
            this.Load += new System.EventHandler(this.dianping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdianping)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdianping;
        private System.Windows.Forms.Button btnCance;
    }
}