namespace Tp_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBoxWeb = new System.Windows.Forms.TextBox();
            this.textBoxRest = new System.Windows.Forms.TextBox();
            this.textBoxWCF = new System.Windows.Forms.TextBox();
            this.buttonWeb = new System.Windows.Forms.Button();
            this.buttonWCF = new System.Windows.Forms.Button();
            this.buttonRest = new System.Windows.Forms.Button();
            this.buttonWCFM = new System.Windows.Forms.Button();
            this.textBoxWCFM = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonDate = new System.Windows.Forms.Button();
            this.textBoxWCFMDate = new System.Windows.Forms.TextBox();
            this.buttonWCFD = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxWeb
            // 
            this.textBoxWeb.Location = new System.Drawing.Point(126, 24);
            this.textBoxWeb.Multiline = true;
            this.textBoxWeb.Name = "textBoxWeb";
            this.textBoxWeb.Size = new System.Drawing.Size(646, 75);
            this.textBoxWeb.TabIndex = 0;
            // 
            // textBoxRest
            // 
            this.textBoxRest.Location = new System.Drawing.Point(126, 218);
            this.textBoxRest.Multiline = true;
            this.textBoxRest.Name = "textBoxRest";
            this.textBoxRest.Size = new System.Drawing.Size(646, 75);
            this.textBoxRest.TabIndex = 1;
            // 
            // textBoxWCF
            // 
            this.textBoxWCF.Location = new System.Drawing.Point(126, 116);
            this.textBoxWCF.Multiline = true;
            this.textBoxWCF.Name = "textBoxWCF";
            this.textBoxWCF.Size = new System.Drawing.Size(646, 75);
            this.textBoxWCF.TabIndex = 2;
            // 
            // buttonWeb
            // 
            this.buttonWeb.Location = new System.Drawing.Point(23, 24);
            this.buttonWeb.Name = "buttonWeb";
            this.buttonWeb.Size = new System.Drawing.Size(97, 23);
            this.buttonWeb.TabIndex = 3;
            this.buttonWeb.Text = "Service Web";
            this.buttonWeb.UseVisualStyleBackColor = true;
            this.buttonWeb.Click += new System.EventHandler(this.buttonWeb_Click);
            // 
            // buttonWCF
            // 
            this.buttonWCF.Location = new System.Drawing.Point(23, 114);
            this.buttonWCF.Name = "buttonWCF";
            this.buttonWCF.Size = new System.Drawing.Size(97, 23);
            this.buttonWCF.TabIndex = 4;
            this.buttonWCF.Text = "Service WCF";
            this.buttonWCF.UseVisualStyleBackColor = true;
            this.buttonWCF.Click += new System.EventHandler(this.buttonWCF_Click);
            // 
            // buttonRest
            // 
            this.buttonRest.Location = new System.Drawing.Point(23, 218);
            this.buttonRest.Name = "buttonRest";
            this.buttonRest.Size = new System.Drawing.Size(97, 23);
            this.buttonRest.TabIndex = 5;
            this.buttonRest.Text = "Service Rest";
            this.buttonRest.UseVisualStyleBackColor = true;
            this.buttonRest.Click += new System.EventHandler(this.buttonRest_Click);
            // 
            // buttonWCFM
            // 
            this.buttonWCFM.Location = new System.Drawing.Point(23, 308);
            this.buttonWCFM.Name = "buttonWCFM";
            this.buttonWCFM.Size = new System.Drawing.Size(97, 23);
            this.buttonWCFM.TabIndex = 6;
            this.buttonWCFM.Text = "Service WCFM";
            this.buttonWCFM.UseVisualStyleBackColor = true;
            this.buttonWCFM.Click += new System.EventHandler(this.buttonWCFM_Click);
            // 
            // textBoxWCFM
            // 
            this.textBoxWCFM.Location = new System.Drawing.Point(126, 308);
            this.textBoxWCFM.Multiline = true;
            this.textBoxWCFM.Name = "textBoxWCFM";
            this.textBoxWCFM.Size = new System.Drawing.Size(646, 75);
            this.textBoxWCFM.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 402);
            this.dateTimePicker1.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // buttonDate
            // 
            this.buttonDate.Location = new System.Drawing.Point(23, 402);
            this.buttonDate.Name = "buttonDate";
            this.buttonDate.Size = new System.Drawing.Size(97, 23);
            this.buttonDate.TabIndex = 9;
            this.buttonDate.Text = "Get Temp";
            this.buttonDate.UseVisualStyleBackColor = true;
            this.buttonDate.Click += new System.EventHandler(this.buttonDate_Click);
            // 
            // textBoxWCFMDate
            // 
            this.textBoxWCFMDate.Location = new System.Drawing.Point(312, 402);
            this.textBoxWCFMDate.Multiline = true;
            this.textBoxWCFMDate.Name = "textBoxWCFMDate";
            this.textBoxWCFMDate.Size = new System.Drawing.Size(460, 23);
            this.textBoxWCFMDate.TabIndex = 10;
            // 
            // buttonWCFD
            // 
            this.buttonWCFD.Location = new System.Drawing.Point(23, 444);
            this.buttonWCFD.Name = "buttonWCFD";
            this.buttonWCFD.Size = new System.Drawing.Size(97, 23);
            this.buttonWCFD.TabIndex = 11;
            this.buttonWCFD.Text = "Get Temp";
            this.buttonWCFD.UseVisualStyleBackColor = true;
            this.buttonWCFD.Click += new System.EventHandler(this.buttonWCFD_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(126, 447);
            this.dateTimePicker2.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(313, 447);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(459, 207);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 666);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.buttonWCFD);
            this.Controls.Add(this.textBoxWCFMDate);
            this.Controls.Add(this.buttonDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxWCFM);
            this.Controls.Add(this.buttonWCFM);
            this.Controls.Add(this.buttonRest);
            this.Controls.Add(this.buttonWCF);
            this.Controls.Add(this.buttonWeb);
            this.Controls.Add(this.textBoxWCF);
            this.Controls.Add(this.textBoxRest);
            this.Controls.Add(this.textBoxWeb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWeb;
        private System.Windows.Forms.TextBox textBoxRest;
        private System.Windows.Forms.TextBox textBoxWCF;
        private System.Windows.Forms.Button buttonWeb;
        private System.Windows.Forms.Button buttonWCF;
        private System.Windows.Forms.Button buttonRest;
        private System.Windows.Forms.Button buttonWCFM;
        private System.Windows.Forms.TextBox textBoxWCFM;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonDate;
        private System.Windows.Forms.TextBox textBoxWCFMDate;
        private System.Windows.Forms.Button buttonWCFD;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

