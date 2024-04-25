namespace EXAU3___CASTAÑEDA
{
    partial class Frm_Ejercicio02
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvCantidad = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnDoughnut = new System.Windows.Forms.RadioButton();
            this.rbtnLineal = new System.Windows.Forms.RadioButton();
            this.rbtnPyramid = new System.Windows.Forms.RadioButton();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.chart2L = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1D = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2L)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1D)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCantidad
            // 
            this.dgvCantidad.AllowUserToAddRows = false;
            this.dgvCantidad.AllowUserToDeleteRows = false;
            this.dgvCantidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCantidad.Location = new System.Drawing.Point(36, 97);
            this.dgvCantidad.Name = "dgvCantidad";
            this.dgvCantidad.ReadOnly = true;
            this.dgvCantidad.Size = new System.Drawing.Size(374, 146);
            this.dgvCantidad.TabIndex = 0;
            this.dgvCantidad.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCantidad_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ejercicio 02";
            // 
            // rbtnDoughnut
            // 
            this.rbtnDoughnut.AutoSize = true;
            this.rbtnDoughnut.Location = new System.Drawing.Point(37, 336);
            this.rbtnDoughnut.Name = "rbtnDoughnut";
            this.rbtnDoughnut.Size = new System.Drawing.Size(72, 17);
            this.rbtnDoughnut.TabIndex = 4;
            this.rbtnDoughnut.TabStop = true;
            this.rbtnDoughnut.Text = "Doughnut";
            this.rbtnDoughnut.UseVisualStyleBackColor = true;
            this.rbtnDoughnut.CheckedChanged += new System.EventHandler(this.rbtnDoughnut_CheckedChanged);
            // 
            // rbtnLineal
            // 
            this.rbtnLineal.AutoSize = true;
            this.rbtnLineal.Location = new System.Drawing.Point(186, 336);
            this.rbtnLineal.Name = "rbtnLineal";
            this.rbtnLineal.Size = new System.Drawing.Size(53, 17);
            this.rbtnLineal.TabIndex = 5;
            this.rbtnLineal.TabStop = true;
            this.rbtnLineal.Text = "Lineal";
            this.rbtnLineal.UseVisualStyleBackColor = true;
            this.rbtnLineal.CheckedChanged += new System.EventHandler(this.rtnLineal_CheckedChanged);
            // 
            // rbtnPyramid
            // 
            this.rbtnPyramid.AutoSize = true;
            this.rbtnPyramid.Location = new System.Drawing.Point(326, 336);
            this.rbtnPyramid.Name = "rbtnPyramid";
            this.rbtnPyramid.Size = new System.Drawing.Size(62, 17);
            this.rbtnPyramid.TabIndex = 6;
            this.rbtnPyramid.TabStop = true;
            this.rbtnPyramid.Text = "Pyramid";
            this.rbtnPyramid.UseVisualStyleBackColor = true;
            this.rbtnPyramid.CheckedChanged += new System.EventHandler(this.rbtnPyramid_CheckedChanged);
            // 
            // chart3
            // 
            chartArea4.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart3.Legends.Add(legend4);
            this.chart3.Location = new System.Drawing.Point(58, 393);
            this.chart3.Name = "chart3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart3.Series.Add(series4);
            this.chart3.Size = new System.Drawing.Size(322, 296);
            this.chart3.TabIndex = 9;
            this.chart3.Text = "chart3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gráficos Estadísticos";
            // 
            // chart2L
            // 
            chartArea5.Name = "ChartArea1";
            this.chart2L.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart2L.Legends.Add(legend5);
            this.chart2L.Location = new System.Drawing.Point(58, 393);
            this.chart2L.Name = "chart2L";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart2L.Series.Add(series5);
            this.chart2L.Size = new System.Drawing.Size(322, 296);
            this.chart2L.TabIndex = 11;
            this.chart2L.Text = "chart2";
            // 
            // chart1D
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1D.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1D.Legends.Add(legend6);
            this.chart1D.Location = new System.Drawing.Point(58, 393);
            this.chart1D.Name = "chart1D";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1D.Series.Add(series6);
            this.chart1D.Size = new System.Drawing.Size(322, 296);
            this.chart1D.TabIndex = 12;
            this.chart1D.Text = "chart1";
            // 
            // Frm_Ejercicio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 726);
            this.Controls.Add(this.chart1D);
            this.Controls.Add(this.chart2L);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.rbtnPyramid);
            this.Controls.Add(this.rbtnLineal);
            this.Controls.Add(this.rbtnDoughnut);
            this.Controls.Add(this.dgvCantidad);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Ejercicio02";
            this.Text = "Frm_Ejercicio02";
            this.Load += new System.EventHandler(this.Frm_Ejercicio02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2L)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1D)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnDoughnut;
        private System.Windows.Forms.RadioButton rbtnLineal;
        private System.Windows.Forms.RadioButton rbtnPyramid;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2L;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1D;
    }
}