namespace LogicaDifusaGra
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblValorLinguistico = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // grafica
            // 
            this.grafica.BackColor = System.Drawing.Color.Transparent;
            this.grafica.BorderlineColor = System.Drawing.Color.DarkRed;
            this.grafica.BorderlineWidth = 2;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.Name = "ChartArea1";
            this.grafica.ChartAreas.Add(chartArea1);
            this.grafica.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.grafica.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            legend1.Name = "Legend1";
            this.grafica.Legends.Add(legend1);
            this.grafica.Location = new System.Drawing.Point(0, 0);
            this.grafica.Name = "grafica";
            this.grafica.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "Muy cercas";
            series1.Name = "muyCercas";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "Cercas";
            series2.Name = "cercas";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.LegendText = "Lejos";
            series3.Name = "lejos";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.LegendText = "Muy Lejos";
            series4.Name = "muyLejos";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.LegendText = "Puntero";
            series5.Name = "puntero";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.LegendText = "ESP32";
            series6.Name = "esp32";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.LegendText = "punteroH";
            series7.Name = "Series7";
            this.grafica.Series.Add(series1);
            this.grafica.Series.Add(series2);
            this.grafica.Series.Add(series3);
            this.grafica.Series.Add(series4);
            this.grafica.Series.Add(series5);
            this.grafica.Series.Add(series6);
            this.grafica.Series.Add(series7);
            this.grafica.Size = new System.Drawing.Size(1092, 374);
            this.grafica.TabIndex = 0;
            this.grafica.Text = "chart1";
            this.grafica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f);
            // 
            // btnGraficar
            // 
            this.btnGraficar.BackColor = System.Drawing.Color.Transparent;
            this.btnGraficar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGraficar.Location = new System.Drawing.Point(929, 359);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(75, 23);
            this.btnGraficar.TabIndex = 1;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = false;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Enabled = false;
            this.hScrollBar1.Location = new System.Drawing.Point(83, 359);
            this.hScrollBar1.Maximum = 160;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(825, 33);
            this.hScrollBar1.TabIndex = 2;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(926, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor\r\nlingüístico:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Location = new System.Drawing.Point(929, 167);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(111, 35);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Consultar API";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Font = new System.Drawing.Font("Georgia", 12F);
            this.lblDistancia.Location = new System.Drawing.Point(1008, 224);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(18, 18);
            this.lblDistancia.TabIndex = 6;
            this.lblDistancia.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F);
            this.label2.Location = new System.Drawing.Point(926, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Distancia \r\nSensor:";
            // 
            // lblValorLinguistico
            // 
            this.lblValorLinguistico.AutoSize = true;
            this.lblValorLinguistico.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorLinguistico.Location = new System.Drawing.Point(1025, 139);
            this.lblValorLinguistico.Name = "lblValorLinguistico";
            this.lblValorLinguistico.Size = new System.Drawing.Size(38, 16);
            this.lblValorLinguistico.TabIndex = 8;
            this.lblValorLinguistico.Text = "none";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1092, 419);
            this.Controls.Add(this.lblValorLinguistico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.grafica);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGraficar;
        public System.Windows.Forms.DataVisualization.Charting.Chart grafica;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblValorLinguistico;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

