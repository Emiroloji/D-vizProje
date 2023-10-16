namespace Döviz_proje
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tlUsd = new System.Windows.Forms.Label();
            this.tlEuro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.usdTl = new System.Windows.Forms.Label();
            this.euroTl = new System.Windows.Forms.Label();
            this.usdEuro = new System.Windows.Forms.Label();
            this.euroUsd = new System.Windows.Forms.Label();
            this.dovizProjeDataSet = new Döviz_proje.DovizProjeDataSet();
            this.dovizProjeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dovizProjeDataSet2 = new Döviz_proje.DovizProjeDataSet2();
            this.dövizKurlariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dövizKurlariTableAdapter = new Döviz_proje.DovizProjeDataSet2TableAdapters.DövizKurlariTableAdapter();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dovizProjeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dovizProjeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dovizProjeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dövizKurlariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "TL-USD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "TL-EURO";
            // 
            // tlUsd
            // 
            this.tlUsd.AutoSize = true;
            this.tlUsd.BackColor = System.Drawing.Color.Transparent;
            this.tlUsd.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tlUsd.ForeColor = System.Drawing.Color.White;
            this.tlUsd.Location = new System.Drawing.Point(178, 33);
            this.tlUsd.Name = "tlUsd";
            this.tlUsd.Size = new System.Drawing.Size(31, 30);
            this.tlUsd.TabIndex = 2;
            this.tlUsd.Text = "0";
            // 
            // tlEuro
            // 
            this.tlEuro.AutoSize = true;
            this.tlEuro.BackColor = System.Drawing.Color.Transparent;
            this.tlEuro.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tlEuro.ForeColor = System.Drawing.Color.White;
            this.tlEuro.Location = new System.Drawing.Point(181, 80);
            this.tlEuro.Name = "tlEuro";
            this.tlEuro.Size = new System.Drawing.Size(29, 30);
            this.tlEuro.TabIndex = 3;
            this.tlEuro.Text = "o";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "USD-TL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "EURO-TL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "USD-EURO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 30);
            this.label6.TabIndex = 7;
            this.label6.Text = "EURO-USD";
            // 
            // usdTl
            // 
            this.usdTl.AutoSize = true;
            this.usdTl.BackColor = System.Drawing.Color.Transparent;
            this.usdTl.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usdTl.ForeColor = System.Drawing.Color.White;
            this.usdTl.Location = new System.Drawing.Point(181, 121);
            this.usdTl.Name = "usdTl";
            this.usdTl.Size = new System.Drawing.Size(29, 30);
            this.usdTl.TabIndex = 8;
            this.usdTl.Text = "o";
            // 
            // euroTl
            // 
            this.euroTl.AutoSize = true;
            this.euroTl.BackColor = System.Drawing.Color.Transparent;
            this.euroTl.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.euroTl.ForeColor = System.Drawing.Color.White;
            this.euroTl.Location = new System.Drawing.Point(181, 159);
            this.euroTl.Name = "euroTl";
            this.euroTl.Size = new System.Drawing.Size(29, 30);
            this.euroTl.TabIndex = 9;
            this.euroTl.Text = "o";
            // 
            // usdEuro
            // 
            this.usdEuro.AutoSize = true;
            this.usdEuro.BackColor = System.Drawing.Color.Transparent;
            this.usdEuro.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usdEuro.ForeColor = System.Drawing.Color.White;
            this.usdEuro.Location = new System.Drawing.Point(181, 194);
            this.usdEuro.Name = "usdEuro";
            this.usdEuro.Size = new System.Drawing.Size(29, 30);
            this.usdEuro.TabIndex = 10;
            this.usdEuro.Text = "o";
            // 
            // euroUsd
            // 
            this.euroUsd.AutoSize = true;
            this.euroUsd.BackColor = System.Drawing.Color.Transparent;
            this.euroUsd.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.euroUsd.ForeColor = System.Drawing.Color.White;
            this.euroUsd.Location = new System.Drawing.Point(181, 231);
            this.euroUsd.Name = "euroUsd";
            this.euroUsd.Size = new System.Drawing.Size(29, 30);
            this.euroUsd.TabIndex = 11;
            this.euroUsd.Text = "o";
            // 
            // dovizProjeDataSet
            // 
            this.dovizProjeDataSet.DataSetName = "DovizProjeDataSet";
            this.dovizProjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dovizProjeDataSetBindingSource
            // 
            this.dovizProjeDataSetBindingSource.DataSource = this.dovizProjeDataSet;
            this.dovizProjeDataSetBindingSource.Position = 0;
            // 
            // dovizProjeDataSet2
            // 
            this.dovizProjeDataSet2.DataSetName = "DovizProjeDataSet2";
            this.dovizProjeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dövizKurlariBindingSource
            // 
            this.dövizKurlariBindingSource.DataMember = "DövizKurlari";
            this.dövizKurlariBindingSource.DataSource = this.dovizProjeDataSet2;
            // 
            // dövizKurlariTableAdapter
            // 
            this.dövizKurlariTableAdapter.ClearBeforeFill = true;
            // 
            // chart
            // 
            this.chart.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart.BorderSkin.BorderColor = System.Drawing.Color.White;
            this.chart.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(30, 264);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(472, 416);
            this.chart.TabIndex = 14;
            this.chart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Döviz_proje.Properties.Resources._6204070;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1353, 692);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.euroUsd);
            this.Controls.Add(this.usdEuro);
            this.Controls.Add(this.euroTl);
            this.Controls.Add(this.usdTl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tlEuro);
            this.Controls.Add(this.tlUsd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "DÖVİZ PROJE";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dovizProjeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dovizProjeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dovizProjeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dövizKurlariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tlUsd;
        private System.Windows.Forms.Label tlEuro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label usdTl;
        private System.Windows.Forms.Label euroTl;
        private System.Windows.Forms.Label usdEuro;
        private System.Windows.Forms.Label euroUsd;
        private System.Windows.Forms.BindingSource dovizProjeDataSetBindingSource;
        private DovizProjeDataSet dovizProjeDataSet;
        private DovizProjeDataSet2 dovizProjeDataSet2;
        private System.Windows.Forms.BindingSource dövizKurlariBindingSource;
        private DovizProjeDataSet2TableAdapters.DövizKurlariTableAdapter dövizKurlariTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}

