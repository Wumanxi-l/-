namespace 点餐管理系统.Tdishes
{
    partial class Upate_dishes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Upate_dishes));
            this.dgvDishes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cboCatagoryId = new System.Windows.Forms.ComboBox();
            this.classificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selesDataSet12 = new 点餐管理系统.selesDataSet12();
            this.cboTastes = new System.Windows.Forms.ComboBox();
            this.tasteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selesDataSet13 = new 点餐管理系统.selesDataSet13();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.txtDescn = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCance = new System.Windows.Forms.Button();
            this.pic_Dishes = new System.Windows.Forms.PictureBox();
            this.btnPic = new System.Windows.Forms.Button();
            this.classificationTableAdapter = new 点餐管理系统.selesDataSet12TableAdapters.ClassificationTableAdapter();
            this.tasteTableAdapter = new 点餐管理系统.selesDataSet13TableAdapters.tasteTableAdapter();
            this.txtListPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selesDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selesDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Dishes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDishes
            // 
            this.dgvDishes.BackgroundColor = System.Drawing.Color.White;
            this.dgvDishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDishes.Location = new System.Drawing.Point(12, 12);
            this.dgvDishes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDishes.Name = "dgvDishes";
            this.dgvDishes.RowHeadersWidth = 82;
            this.dgvDishes.RowTemplate.Height = 37;
            this.dgvDishes.Size = new System.Drawing.Size(1188, 332);
            this.dgvDishes.TabIndex = 0;
            this.dgvDishes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDishes_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 374);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "菜品编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(318, 374);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "类别名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(616, 372);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "菜品价格";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(21, 456);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "菜品名称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(318, 456);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "菜品口味";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(632, 454);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 33);
            this.label6.TabIndex = 6;
            this.label6.Text = "销量";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(616, 548);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 33);
            this.label7.TabIndex = 7;
            this.label7.Text = "菜品详情";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtId.Location = new System.Drawing.Point(172, 368);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(136, 44);
            this.txtId.TabIndex = 8;
            // 
            // cboCatagoryId
            // 
            this.cboCatagoryId.DataSource = this.classificationBindingSource;
            this.cboCatagoryId.DisplayMember = "classification_Name";
            this.cboCatagoryId.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboCatagoryId.FormattingEnabled = true;
            this.cboCatagoryId.Location = new System.Drawing.Point(468, 368);
            this.cboCatagoryId.Margin = new System.Windows.Forms.Padding(4);
            this.cboCatagoryId.Name = "cboCatagoryId";
            this.cboCatagoryId.Size = new System.Drawing.Size(136, 41);
            this.cboCatagoryId.TabIndex = 9;
            this.cboCatagoryId.ValueMember = "classification_ID";
            // 
            // classificationBindingSource
            // 
            this.classificationBindingSource.DataMember = "Classification";
            this.classificationBindingSource.DataSource = this.selesDataSet12;
            // 
            // selesDataSet12
            // 
            this.selesDataSet12.DataSetName = "selesDataSet12";
            this.selesDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboTastes
            // 
            this.cboTastes.DataSource = this.tasteBindingSource;
            this.cboTastes.DisplayMember = "tasteName";
            this.cboTastes.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboTastes.FormattingEnabled = true;
            this.cboTastes.Location = new System.Drawing.Point(468, 450);
            this.cboTastes.Margin = new System.Windows.Forms.Padding(4);
            this.cboTastes.Name = "cboTastes";
            this.cboTastes.Size = new System.Drawing.Size(136, 41);
            this.cboTastes.TabIndex = 10;
            this.cboTastes.ValueMember = "tasteId";
            // 
            // tasteBindingSource
            // 
            this.tasteBindingSource.DataMember = "taste";
            this.tasteBindingSource.DataSource = this.selesDataSet13;
            // 
            // selesDataSet13
            // 
            this.selesDataSet13.DataSetName = "selesDataSet13";
            this.selesDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(172, 448);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 44);
            this.txtName.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPrice.Location = new System.Drawing.Point(767, 366);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(136, 44);
            this.txtPrice.TabIndex = 12;
            // 
            // txtSales
            // 
            this.txtSales.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSales.Location = new System.Drawing.Point(767, 450);
            this.txtSales.Margin = new System.Windows.Forms.Padding(4);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(136, 44);
            this.txtSales.TabIndex = 13;
            // 
            // txtDescn
            // 
            this.txtDescn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDescn.Location = new System.Drawing.Point(767, 546);
            this.txtDescn.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescn.Name = "txtDescn";
            this.txtDescn.Size = new System.Drawing.Size(136, 44);
            this.txtDescn.TabIndex = 14;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.Location = new System.Drawing.Point(276, 644);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(144, 52);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "修改";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCance
            // 
            this.btnCance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCance.Location = new System.Drawing.Point(606, 644);
            this.btnCance.Margin = new System.Windows.Forms.Padding(4);
            this.btnCance.Name = "btnCance";
            this.btnCance.Size = new System.Drawing.Size(144, 52);
            this.btnCance.TabIndex = 16;
            this.btnCance.Text = "关闭";
            this.btnCance.UseVisualStyleBackColor = true;
            this.btnCance.Click += new System.EventHandler(this.btnCance_Click);
            // 
            // pic_Dishes
            // 
            this.pic_Dishes.BackColor = System.Drawing.Color.White;
            this.pic_Dishes.Location = new System.Drawing.Point(962, 368);
            this.pic_Dishes.Margin = new System.Windows.Forms.Padding(4);
            this.pic_Dishes.Name = "pic_Dishes";
            this.pic_Dishes.Size = new System.Drawing.Size(190, 204);
            this.pic_Dishes.TabIndex = 17;
            this.pic_Dishes.TabStop = false;
            this.pic_Dishes.Click += new System.EventHandler(this.pic_Dishes_Click);
            // 
            // btnPic
            // 
            this.btnPic.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPic.Location = new System.Drawing.Point(962, 604);
            this.btnPic.Margin = new System.Windows.Forms.Padding(4);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(152, 48);
            this.btnPic.TabIndex = 18;
            this.btnPic.Text = "选择图片";
            this.btnPic.UseVisualStyleBackColor = true;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // classificationTableAdapter
            // 
            this.classificationTableAdapter.ClearBeforeFill = true;
            // 
            // tasteTableAdapter
            // 
            this.tasteTableAdapter.ClearBeforeFill = true;
            // 
            // txtListPrice
            // 
            this.txtListPrice.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtListPrice.Location = new System.Drawing.Point(172, 546);
            this.txtListPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtListPrice.Name = "txtListPrice";
            this.txtListPrice.Size = new System.Drawing.Size(136, 44);
            this.txtListPrice.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(21, 550);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 33);
            this.label8.TabIndex = 20;
            this.label8.Text = "成本价格";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(330, 550);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 33);
            this.label9.TabIndex = 21;
            this.label9.Text = "库存";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQty.Location = new System.Drawing.Point(468, 548);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(136, 44);
            this.txtQty.TabIndex = 22;
            // 
            // Upate_dishes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1206, 726);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtListPrice);
            this.Controls.Add(this.btnPic);
            this.Controls.Add(this.pic_Dishes);
            this.Controls.Add(this.btnCance);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtDescn);
            this.Controls.Add(this.txtSales);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cboTastes);
            this.Controls.Add(this.cboCatagoryId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDishes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Upate_dishes";
            this.Text = "Upate_dishes";
            this.Load += new System.EventHandler(this.Upate_dishes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selesDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selesDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Dishes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDishes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cboCatagoryId;
        private System.Windows.Forms.ComboBox cboTastes;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.TextBox txtDescn;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCance;
        private System.Windows.Forms.PictureBox pic_Dishes;
        private System.Windows.Forms.Button btnPic;
        private selesDataSet12 selesDataSet12;
        private System.Windows.Forms.BindingSource classificationBindingSource;
        private selesDataSet12TableAdapters.ClassificationTableAdapter classificationTableAdapter;
        private selesDataSet13 selesDataSet13;
        private System.Windows.Forms.BindingSource tasteBindingSource;
        private selesDataSet13TableAdapters.tasteTableAdapter tasteTableAdapter;
        private System.Windows.Forms.TextBox txtListPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQty;
    }
}