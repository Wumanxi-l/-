namespace 点餐管理系统.Order
{
    partial class Proform
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proform));
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.dgvprofrom = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btncance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprofrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 82;
            this.dgvEmployee.RowTemplate.Height = 37;
            this.dgvEmployee.Size = new System.Drawing.Size(1186, 314);
            this.dgvEmployee.TabIndex = 0;
            // 
            // dgvprofrom
            // 
            this.dgvprofrom.BackgroundColor = System.Drawing.Color.White;
            this.dgvprofrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprofrom.Location = new System.Drawing.Point(12, 332);
            this.dgvprofrom.Name = "dgvprofrom";
            this.dgvprofrom.RowHeadersWidth = 82;
            this.dgvprofrom.RowTemplate.Height = 37;
            this.dgvprofrom.Size = new System.Drawing.Size(533, 307);
            this.dgvprofrom.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(584, 332);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(614, 307);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // btncance
            // 
            this.btncance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btncance.Location = new System.Drawing.Point(545, 662);
            this.btncance.Name = "btncance";
            this.btncance.Size = new System.Drawing.Size(123, 43);
            this.btncance.TabIndex = 3;
            this.btncance.Text = "返回";
            this.btncance.UseVisualStyleBackColor = true;
            this.btncance.Click += new System.EventHandler(this.btncance_Click);
            // 
            // Proform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1210, 726);
            this.Controls.Add(this.btncance);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dgvprofrom);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "Proform";
            this.Text = "Select_Order";
            this.Load += new System.EventHandler(this.Proform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprofrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridView dgvprofrom;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btncance;
    }
}