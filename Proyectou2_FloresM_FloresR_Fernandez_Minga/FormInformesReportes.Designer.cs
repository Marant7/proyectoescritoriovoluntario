namespace Proyectou2_FloresM_FloresR_Fernandez_Minga
{
    partial class FormInformesReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformesReportes));
            this.dgvAnimales = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnMostrarAdoptante = new System.Windows.Forms.Button();
            this.dgvAdoptante = new System.Windows.Forms.DataGridView();
            this.chartDonaciones = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGenerarGrafico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdoptante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDonaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAnimales
            // 
            this.dgvAnimales.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvAnimales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimales.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvAnimales.Location = new System.Drawing.Point(42, 53);
            this.dgvAnimales.Name = "dgvAnimales";
            this.dgvAnimales.RowHeadersWidth = 51;
            this.dgvAnimales.RowTemplate.Height = 24;
            this.dgvAnimales.Size = new System.Drawing.Size(439, 172);
            this.dgvAnimales.TabIndex = 11;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Cyan;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.Black;
            this.btnMostrar.Location = new System.Drawing.Point(109, 12);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(303, 35);
            this.btnMostrar.TabIndex = 12;
            this.btnMostrar.Text = "Mostrar Animales Registrados";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnMostrarAdoptante
            // 
            this.btnMostrarAdoptante.BackColor = System.Drawing.Color.Cyan;
            this.btnMostrarAdoptante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarAdoptante.ForeColor = System.Drawing.Color.Black;
            this.btnMostrarAdoptante.Location = new System.Drawing.Point(109, 238);
            this.btnMostrarAdoptante.Name = "btnMostrarAdoptante";
            this.btnMostrarAdoptante.Size = new System.Drawing.Size(303, 36);
            this.btnMostrarAdoptante.TabIndex = 13;
            this.btnMostrarAdoptante.Text = "Mostrar Adoptantes Registrados";
            this.btnMostrarAdoptante.UseVisualStyleBackColor = false;
            this.btnMostrarAdoptante.Click += new System.EventHandler(this.btnMostrarAdoptante_Click);
            // 
            // dgvAdoptante
            // 
            this.dgvAdoptante.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvAdoptante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAdoptante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdoptante.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvAdoptante.Location = new System.Drawing.Point(42, 280);
            this.dgvAdoptante.Name = "dgvAdoptante";
            this.dgvAdoptante.RowHeadersWidth = 51;
            this.dgvAdoptante.RowTemplate.Height = 24;
            this.dgvAdoptante.Size = new System.Drawing.Size(439, 184);
            this.dgvAdoptante.TabIndex = 22;
            // 
            // chartDonaciones
            // 
            this.chartDonaciones.BorderlineColor = System.Drawing.Color.RoyalBlue;
            chartArea1.Name = "ChartArea1";
            this.chartDonaciones.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDonaciones.Legends.Add(legend1);
            this.chartDonaciones.Location = new System.Drawing.Point(97, 522);
            this.chartDonaciones.Name = "chartDonaciones";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Donaciones";
            this.chartDonaciones.Series.Add(series1);
            this.chartDonaciones.Size = new System.Drawing.Size(328, 205);
            this.chartDonaciones.TabIndex = 23;
            this.chartDonaciones.Text = "chart1";
            // 
            // btnGenerarGrafico
            // 
            this.btnGenerarGrafico.BackColor = System.Drawing.Color.Cyan;
            this.btnGenerarGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarGrafico.Location = new System.Drawing.Point(109, 480);
            this.btnGenerarGrafico.Name = "btnGenerarGrafico";
            this.btnGenerarGrafico.Size = new System.Drawing.Size(303, 34);
            this.btnGenerarGrafico.TabIndex = 24;
            this.btnGenerarGrafico.Text = "Generar Grafico";
            this.btnGenerarGrafico.UseVisualStyleBackColor = false;
            this.btnGenerarGrafico.Click += new System.EventHandler(this.btnGenerarGrafico_Click);
            // 
            // FormInformesReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(524, 742);
            this.Controls.Add(this.btnGenerarGrafico);
            this.Controls.Add(this.chartDonaciones);
            this.Controls.Add(this.dgvAdoptante);
            this.Controls.Add(this.btnMostrarAdoptante);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dgvAnimales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInformesReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInformesReportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdoptante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDonaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAnimales;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnMostrarAdoptante;
        private System.Windows.Forms.DataGridView dgvAdoptante;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDonaciones;
        private System.Windows.Forms.Button btnGenerarGrafico;
    }
}