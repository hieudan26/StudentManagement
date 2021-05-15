
namespace GUI_StudentManagement.Student
{
    partial class StaticStudent
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PanelFemale = new System.Windows.Forms.Panel();
            this.LabelFemale = new System.Windows.Forms.Label();
            this.PanelMale = new System.Windows.Forms.Panel();
            this.LabelMale = new System.Windows.Forms.Label();
            this.PanelTotal = new System.Windows.Forms.Panel();
            this.LabelTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.PanelFemale.SuspendLayout();
            this.PanelMale.SuspendLayout();
            this.PanelTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(31, 300);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Gender";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(291, 175);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // PanelFemale
            // 
            this.PanelFemale.BackColor = System.Drawing.Color.Red;
            this.PanelFemale.Controls.Add(this.LabelFemale);
            this.PanelFemale.Location = new System.Drawing.Point(173, 154);
            this.PanelFemale.Name = "PanelFemale";
            this.PanelFemale.Size = new System.Drawing.Size(149, 100);
            this.PanelFemale.TabIndex = 9;
            this.PanelFemale.MouseEnter += new System.EventHandler(this.LabelFemale_MouseEnter);
            this.PanelFemale.MouseLeave += new System.EventHandler(this.LabelFemale_MouseLeave);
            // 
            // LabelFemale
            // 
            this.LabelFemale.AutoSize = true;
            this.LabelFemale.Location = new System.Drawing.Point(37, 48);
            this.LabelFemale.Name = "LabelFemale";
            this.LabelFemale.Size = new System.Drawing.Size(41, 13);
            this.LabelFemale.TabIndex = 1;
            this.LabelFemale.Text = "Female";
            // 
            // PanelMale
            // 
            this.PanelMale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PanelMale.Controls.Add(this.LabelMale);
            this.PanelMale.Location = new System.Drawing.Point(8, 154);
            this.PanelMale.Name = "PanelMale";
            this.PanelMale.Size = new System.Drawing.Size(137, 100);
            this.PanelMale.TabIndex = 8;
            this.PanelMale.MouseEnter += new System.EventHandler(this.LabelMale_MouseEnter);
            this.PanelMale.MouseLeave += new System.EventHandler(this.LabelMale_MouseLeave);
            // 
            // LabelMale
            // 
            this.LabelMale.AutoSize = true;
            this.LabelMale.Location = new System.Drawing.Point(40, 48);
            this.LabelMale.Name = "LabelMale";
            this.LabelMale.Size = new System.Drawing.Size(30, 13);
            this.LabelMale.TabIndex = 2;
            this.LabelMale.Text = "Male";
            // 
            // PanelTotal
            // 
            this.PanelTotal.BackColor = System.Drawing.Color.Yellow;
            this.PanelTotal.Controls.Add(this.LabelTotal);
            this.PanelTotal.Location = new System.Drawing.Point(51, 34);
            this.PanelTotal.Name = "PanelTotal";
            this.PanelTotal.Size = new System.Drawing.Size(200, 100);
            this.PanelTotal.TabIndex = 7;
            this.PanelTotal.MouseEnter += new System.EventHandler(this.LabelTotal_MouseEnter);
            this.PanelTotal.MouseLeave += new System.EventHandler(this.LabelTotal_MouseLeave);
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Location = new System.Drawing.Point(53, 45);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(31, 13);
            this.LabelTotal.TabIndex = 0;
            this.LabelTotal.Text = "Total";
            // 
            // StaticStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 509);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.PanelFemale);
            this.Controls.Add(this.PanelMale);
            this.Controls.Add(this.PanelTotal);
            this.Name = "StaticStudent";
            this.Text = "StaticStudent";
            this.Load += new System.EventHandler(this.StaticForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.PanelFemale.ResumeLayout(false);
            this.PanelFemale.PerformLayout();
            this.PanelMale.ResumeLayout(false);
            this.PanelMale.PerformLayout();
            this.PanelTotal.ResumeLayout(false);
            this.PanelTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel PanelFemale;
        private System.Windows.Forms.Label LabelFemale;
        private System.Windows.Forms.Panel PanelMale;
        private System.Windows.Forms.Label LabelMale;
        private System.Windows.Forms.Panel PanelTotal;
        private System.Windows.Forms.Label LabelTotal;
    }
}