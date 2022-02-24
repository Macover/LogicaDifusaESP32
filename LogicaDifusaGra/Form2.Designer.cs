namespace LogicaDifusaGra
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.grafica2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblvalorLinguistico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grafica2)).BeginInit();
            this.SuspendLayout();
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(46, 387);
            this.hScrollBar1.Maximum = 33;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(720, 33);
            this.hScrollBar1.TabIndex = 3;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // grafica2
            // 
            this.grafica2.BackColor = System.Drawing.Color.Transparent;
            this.grafica2.BorderlineColor = System.Drawing.Color.DarkRed;
            this.grafica2.BorderlineWidth = 2;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.Name = "ChartArea1";
            this.grafica2.ChartAreas.Add(chartArea1);
            this.grafica2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.grafica2.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            legend1.Name = "Legend1";
            this.grafica2.Legends.Add(legend1);
            this.grafica2.Location = new System.Drawing.Point(0, 0);
            this.grafica2.Name = "grafica2";
            this.grafica2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "Mañana";
            series1.Name = "maniana";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "Dia";
            series2.Name = "dia";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.LegendText = "Noche";
            series3.Name = "noche";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.LegendText = "Puntero";
            series4.Name = "puntero";
            this.grafica2.Series.Add(series1);
            this.grafica2.Series.Add(series2);
            this.grafica2.Series.Add(series3);
            this.grafica2.Series.Add(series4);
            this.grafica2.Size = new System.Drawing.Size(857, 374);
            this.grafica2.TabIndex = 4;
            this.grafica2.Text = "chart1";
            // 
            // lblvalorLinguistico
            // 
            this.lblvalorLinguistico.AutoSize = true;
            this.lblvalorLinguistico.Location = new System.Drawing.Point(736, 142);
            this.lblvalorLinguistico.Name = "lblvalorLinguistico";
            this.lblvalorLinguistico.Size = new System.Drawing.Size(16, 13);
            this.lblvalorLinguistico.TabIndex = 5;
            this.lblvalorLinguistico.Text = "...";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.lblvalorLinguistico);
            this.Controls.Add(this.grafica2);
            this.Controls.Add(this.hScrollBar1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.grafica2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.HScrollBar hScrollBar1;
        public System.Windows.Forms.DataVisualization.Charting.Chart grafica2;
        private System.Windows.Forms.Label lblvalorLinguistico;
    }
}