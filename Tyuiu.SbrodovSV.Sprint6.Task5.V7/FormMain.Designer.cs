namespace Tyuiu.SbrodovSV.Sprint6.Task5.V7
{
    partial class FormMain_SSV
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHelp_SSV = new System.Windows.Forms.Button();
            this.buttonOpenFile_SSV = new System.Windows.Forms.Button();
            this.buttonDone_SSV = new System.Windows.Forms.Button();
            this.groupBoxTask_SSV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SSV = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxResult_SSV = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_SSV = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartDiag_SSV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.groupBoxTask_SSV.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxResult_SSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SSV)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_SSV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHelp_SSV);
            this.panel1.Controls.Add(this.buttonOpenFile_SSV);
            this.panel1.Controls.Add(this.buttonDone_SSV);
            this.panel1.Controls.Add(this.groupBoxTask_SSV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 80);
            this.panel1.TabIndex = 0;
            // 
            // buttonHelp_SSV
            // 
            this.buttonHelp_SSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SSV.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_SSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_SSV.Location = new System.Drawing.Point(615, 12);
            this.buttonHelp_SSV.Name = "buttonHelp_SSV";
            this.buttonHelp_SSV.Size = new System.Drawing.Size(75, 55);
            this.buttonHelp_SSV.TabIndex = 0;
            this.buttonHelp_SSV.Text = "Справка";
            this.buttonHelp_SSV.UseVisualStyleBackColor = false;
            this.buttonHelp_SSV.Click += new System.EventHandler(this.buttonHelp_SSV_Click);
            // 
            // buttonOpenFile_SSV
            // 
            this.buttonOpenFile_SSV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenFile_SSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_SSV.Location = new System.Drawing.Point(534, 12);
            this.buttonOpenFile_SSV.Name = "buttonOpenFile_SSV";
            this.buttonOpenFile_SSV.Size = new System.Drawing.Size(75, 55);
            this.buttonOpenFile_SSV.TabIndex = 0;
            this.buttonOpenFile_SSV.Text = "Открыть файл";
            this.buttonOpenFile_SSV.UseVisualStyleBackColor = false;
            this.buttonOpenFile_SSV.Click += new System.EventHandler(this.buttonOpenFile_SSV_Click);
            // 
            // buttonDone_SSV
            // 
            this.buttonDone_SSV.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_SSV.Location = new System.Drawing.Point(453, 12);
            this.buttonDone_SSV.Name = "buttonDone_SSV";
            this.buttonDone_SSV.Size = new System.Drawing.Size(75, 55);
            this.buttonDone_SSV.TabIndex = 0;
            this.buttonDone_SSV.Text = "Выполнить";
            this.buttonDone_SSV.UseVisualStyleBackColor = false;
            this.buttonDone_SSV.Click += new System.EventHandler(this.buttonDone_SSV_Click);
            // 
            // groupBoxTask_SSV
            // 
            this.groupBoxTask_SSV.Controls.Add(this.textBoxTask_SSV);
            this.groupBoxTask_SSV.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTask_SSV.Name = "groupBoxTask_SSV";
            this.groupBoxTask_SSV.Size = new System.Drawing.Size(444, 71);
            this.groupBoxTask_SSV.TabIndex = 0;
            this.groupBoxTask_SSV.TabStop = false;
            this.groupBoxTask_SSV.Text = "Условие:";
            // 
            // textBoxTask_SSV
            // 
            this.textBoxTask_SSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_SSV.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_SSV.Multiline = true;
            this.textBoxTask_SSV.Name = "textBoxTask_SSV";
            this.textBoxTask_SSV.Size = new System.Drawing.Size(438, 52);
            this.textBoxTask_SSV.TabIndex = 0;
            this.textBoxTask_SSV.Text = "Прочитать данные из файлы InPutFileTask5V7.txt. Вывести в dataGridView\r\nЗначения " +
    "больше 5 и построить диаграмму по этим значениям\r\n";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxResult_SSV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 381);
            this.panel2.TabIndex = 1;
            // 
            // groupBoxResult_SSV
            // 
            this.groupBoxResult_SSV.Controls.Add(this.dataGridViewResult_SSV);
            this.groupBoxResult_SSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_SSV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_SSV.Name = "groupBoxResult_SSV";
            this.groupBoxResult_SSV.Size = new System.Drawing.Size(200, 381);
            this.groupBoxResult_SSV.TabIndex = 0;
            this.groupBoxResult_SSV.TabStop = false;
            this.groupBoxResult_SSV.Text = " Вывод данных:";
            // 
            // dataGridViewResult_SSV
            // 
            this.dataGridViewResult_SSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_SSV.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult_SSV.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewResult_SSV.Name = "dataGridViewResult_SSV";
            this.dataGridViewResult_SSV.RowHeadersVisible = false;
            this.dataGridViewResult_SSV.Size = new System.Drawing.Size(194, 362);
            this.dataGridViewResult_SSV.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chartDiag_SSV);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 80);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 381);
            this.panel3.TabIndex = 2;
            // 
            // chartDiag_SSV
            // 
            chartArea7.Name = "ChartArea1";
            this.chartDiag_SSV.ChartAreas.Add(chartArea7);
            this.chartDiag_SSV.Dock = System.Windows.Forms.DockStyle.Fill;
            legend7.Name = "Legend1";
            this.chartDiag_SSV.Legends.Add(legend7);
            this.chartDiag_SSV.Location = new System.Drawing.Point(0, 0);
            this.chartDiag_SSV.Name = "chartDiag_SSV";
            series7.ChartArea = "ChartArea1";
            series7.IsVisibleInLegend = false;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartDiag_SSV.Series.Add(series7);
            this.chartDiag_SSV.Size = new System.Drawing.Size(499, 381);
            this.chartDiag_SSV.TabIndex = 0;
            this.chartDiag_SSV.Text = "chart1";
            // 
            // FormMain_SSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 461);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(715, 500);
            this.Name = "FormMain_SSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 7 | Сбродов С. В";
            this.panel1.ResumeLayout(false);
            this.groupBoxTask_SSV.ResumeLayout(false);
            this.groupBoxTask_SSV.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBoxResult_SSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SSV)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_SSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonHelp_SSV;
        private System.Windows.Forms.Button buttonOpenFile_SSV;
        private System.Windows.Forms.Button buttonDone_SSV;
        private System.Windows.Forms.GroupBox groupBoxTask_SSV;
        private System.Windows.Forms.GroupBox groupBoxResult_SSV;
        private System.Windows.Forms.DataGridView dataGridViewResult_SSV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_SSV;
        private System.Windows.Forms.TextBox textBoxTask_SSV;
    }
}

