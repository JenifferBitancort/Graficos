namespace _37___Graficos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.comboTipoGrafico = new System.Windows.Forms.ComboBox();
            this.comboCores = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonValoresAle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gráfico";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor de X";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor de Y";
            // 
            // textBoxX
            // 
            this.textBoxX.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX.Location = new System.Drawing.Point(21, 82);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(119, 26);
            this.textBoxX.TabIndex = 3;
            this.textBoxX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX_KeyPress);
            // 
            // textBoxY
            // 
            this.textBoxY.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxY.Location = new System.Drawing.Point(151, 82);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(119, 26);
            this.textBoxY.TabIndex = 4;
            this.textBoxY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxY_KeyPress);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInserir.Location = new System.Drawing.Point(21, 124);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(250, 36);
            this.buttonInserir.TabIndex = 5;
            this.buttonInserir.Text = "Inserir valores no Gráfico";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Location = new System.Drawing.Point(21, 343);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(250, 36);
            this.buttonLimpar.TabIndex = 6;
            this.buttonLimpar.Text = "Limpar Gráfico";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // comboTipoGrafico
            // 
            this.comboTipoGrafico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipoGrafico.FormattingEnabled = true;
            this.comboTipoGrafico.Location = new System.Drawing.Point(21, 395);
            this.comboTipoGrafico.Name = "comboTipoGrafico";
            this.comboTipoGrafico.Size = new System.Drawing.Size(250, 25);
            this.comboTipoGrafico.TabIndex = 7;
            this.comboTipoGrafico.SelectedIndexChanged += new System.EventHandler(this.comboTipoGrafico_SelectedIndexChanged);
            // 
            // comboCores
            // 
            this.comboCores.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCores.FormattingEnabled = true;
            this.comboCores.Location = new System.Drawing.Point(291, 395);
            this.comboCores.Name = "comboCores";
            this.comboCores.Size = new System.Drawing.Size(250, 25);
            this.comboCores.TabIndex = 8;
            this.comboCores.SelectedIndexChanged += new System.EventHandler(this.comboCores_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(556, 399);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Gráfico 3D";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonValoresAle
            // 
            this.buttonValoresAle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValoresAle.Location = new System.Drawing.Point(652, 385);
            this.buttonValoresAle.Name = "buttonValoresAle";
            this.buttonValoresAle.Size = new System.Drawing.Size(136, 43);
            this.buttonValoresAle.TabIndex = 10;
            this.buttonValoresAle.Text = "Inserir valores aleatórios";
            this.buttonValoresAle.UseVisualStyleBackColor = true;
            this.buttonValoresAle.Click += new System.EventHandler(this.buttonValoresAle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y});
            this.dataGridView1.Location = new System.Drawing.Point(21, 166);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(250, 154);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // x
            // 
            this.x.HeaderText = "Eixo X";
            this.x.Name = "x";
            this.x.ReadOnly = true;
            // 
            // y
            // 
            this.y.HeaderText = "Eixo Y";
            this.y.Name = "y";
            this.y.ReadOnly = true;
            // 
            // grafico
            // 
            chartArea3.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.grafico.Legends.Add(legend3);
            this.grafico.Location = new System.Drawing.Point(291, 12);
            this.grafico.Name = "grafico";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "X vs Y";
            this.grafico.Series.Add(series3);
            this.grafico.Size = new System.Drawing.Size(497, 356);
            this.grafico.TabIndex = 12;
            this.grafico.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 438);
            this.Controls.Add(this.grafico);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonValoresAle);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboCores);
            this.Controls.Add(this.comboTipoGrafico);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.ComboBox comboTipoGrafico;
        private System.Windows.Forms.ComboBox comboCores;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonValoresAle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Timer timer1;
    }
}

