namespace 点餐管理系统
{
    partial class customer_select_orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer_select_orders));
            this.dgvDishes = new System.Windows.Forms.DataGridView();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnDelect = new System.Windows.Forms.Button();
            this.btnCance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDishes
            // 
            this.dgvDishes.BackgroundColor = System.Drawing.Color.White;
            this.dgvDishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDishes.Location = new System.Drawing.Point(8, 12);
            this.dgvDishes.Name = "dgvDishes";
            this.dgvDishes.RowHeadersWidth = 82;
            this.dgvDishes.RowTemplate.Height = 37;
            this.dgvDishes.Size = new System.Drawing.Size(1213, 522);
            this.dgvDishes.TabIndex = 0;
            this.dgvDishes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnWrite
            // 
            this.btnWrite.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWrite.Location = new System.Drawing.Point(105, 629);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(153, 69);
            this.btnWrite.TabIndex = 1;
            this.btnWrite.Text = "进行点评";
            this.btnWrite.UseVisualStyleBackColor = true;
            // 
            // btnDelect
            // 
            this.btnDelect.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelect.Location = new System.Drawing.Point(502, 629);
            this.btnDelect.Name = "btnDelect";
            this.btnDelect.Size = new System.Drawing.Size(153, 69);
            this.btnDelect.TabIndex = 2;
            this.btnDelect.Text = "删除订单";
            this.btnDelect.UseVisualStyleBackColor = true;
            // 
            // btnCance
            // 
            this.btnCance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCance.Location = new System.Drawing.Point(944, 629);
            this.btnCance.Name = "btnCance";
            this.btnCance.Size = new System.Drawing.Size(153, 69);
            this.btnCance.TabIndex = 3;
            this.btnCance.Text = "返回";
            this.btnCance.UseVisualStyleBackColor = true;
            this.btnCance.Click += new System.EventHandler(this.btnCance_Click);
            // 
            // customer_select_orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1233, 792);
            this.Controls.Add(this.btnCance);
            this.Controls.Add(this.btnDelect);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.dgvDishes);
            this.Name = "customer_select_orders";
            this.Text = "customer_select_orders";
            this.Load += new System.EventHandler(this.customer_select_orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDishes;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnDelect;
        private System.Windows.Forms.Button btnCance;
    }
}