namespace Tyuiu.SbrodovSV.Sprint6.Task4.V20
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxResult_SSV = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SSV = new System.Windows.Forms.TextBox();
            this.groupBoxTask_SSV = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxInput_SSV = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStopStep_SSV = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_SSV = new System.Windows.Forms.TextBox();
            this.buttonDone_SSV = new System.Windows.Forms.Button();
            this.buttonSave_SSV = new System.Windows.Forms.Button();
            this.buttonHelp_SSV = new System.Windows.Forms.Button();
            this.chartFunction_SSV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBoxResult_SSV.SuspendLayout();
            this.groupBoxTask_SSV.SuspendLayout();
            this.groupBoxInput_SSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SSV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxResult_SSV
            // 
            this.groupBoxResult_SSV.Controls.Add(this.textBoxResult_SSV);
            this.groupBoxResult_SSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_SSV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_SSV.Name = "groupBoxResult_SSV";
            this.groupBoxResult_SSV.Size = new System.Drawing.Size(270, 462);
            this.groupBoxResult_SSV.TabIndex = 0;
            this.groupBoxResult_SSV.TabStop = false;
            this.groupBoxResult_SSV.Text = "Вывод:";
            // 
            // textBoxResult_SSV
            // 
            this.textBoxResult_SSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_SSV.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult_SSV.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxResult_SSV.Multiline = true;
            this.textBoxResult_SSV.Name = "textBoxResult_SSV";
            this.textBoxResult_SSV.ReadOnly = true;
            this.textBoxResult_SSV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SSV.Size = new System.Drawing.Size(264, 443);
            this.textBoxResult_SSV.TabIndex = 0;
            // 
            // groupBoxTask_SSV
            // 
            this.groupBoxTask_SSV.Controls.Add(this.textBox1);
            this.groupBoxTask_SSV.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTask_SSV.Name = "groupBoxTask_SSV";
            this.groupBoxTask_SSV.Size = new System.Drawing.Size(436, 62);
            this.groupBoxTask_SSV.TabIndex = 1;
            this.groupBoxTask_SSV.TabStop = false;
            this.groupBoxTask_SSV.Text = "Условие:";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(430, 43);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Протабулировать функцию f(x) а заданном диапозоне от -5 до 5.\r\nРезультат вывести " +
    "в textBox. Построить график функции и сохранить в файл\r\nOutPutTask4V20.txt по на" +
    "жатию кнопки.\r\n\r\n";
            // 
            // groupBoxInput_SSV
            // 
            this.groupBoxInput_SSV.Controls.Add(this.label2);
            this.groupBoxInput_SSV.Controls.Add(this.label1);
            this.groupBoxInput_SSV.Controls.Add(this.textBoxStopStep_SSV);
            this.groupBoxInput_SSV.Controls.Add(this.textBoxStartStep_SSV);
            this.groupBoxInput_SSV.Location = new System.Drawing.Point(445, 3);
            this.groupBoxInput_SSV.Name = "groupBoxInput_SSV";
            this.groupBoxInput_SSV.Size = new System.Drawing.Size(258, 62);
            this.groupBoxInput_SSV.TabIndex = 1;
            this.groupBoxInput_SSV.TabStop = false;
            this.groupBoxInput_SSV.Text = "Ввод данных:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Конец шага:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Старт шага:";
            // 
            // textBoxStopStep_SSV
            // 
            this.textBoxStopStep_SSV.Location = new System.Drawing.Point(129, 28);
            this.textBoxStopStep_SSV.Name = "textBoxStopStep_SSV";
            this.textBoxStopStep_SSV.Size = new System.Drawing.Size(123, 20);
            this.textBoxStopStep_SSV.TabIndex = 0;
            this.textBoxStopStep_SSV.Text = "5";
            // 
            // textBoxStartStep_SSV
            // 
            this.textBoxStartStep_SSV.Location = new System.Drawing.Point(6, 29);
            this.textBoxStartStep_SSV.Name = "textBoxStartStep_SSV";
            this.textBoxStartStep_SSV.Size = new System.Drawing.Size(117, 20);
            this.textBoxStartStep_SSV.TabIndex = 0;
            this.textBoxStartStep_SSV.Text = "-5";
            // 
            // buttonDone_SSV
            // 
            this.buttonDone_SSV.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_SSV.Location = new System.Drawing.Point(709, 3);
            this.buttonDone_SSV.Name = "buttonDone_SSV";
            this.buttonDone_SSV.Size = new System.Drawing.Size(75, 61);
            this.buttonDone_SSV.TabIndex = 2;
            this.buttonDone_SSV.Text = "Выполнить";
            this.buttonDone_SSV.UseVisualStyleBackColor = false;
            this.buttonDone_SSV.Click += new System.EventHandler(this.buttonDone_SSV_Click);
            // 
            // buttonSave_SSV
            // 
            this.buttonSave_SSV.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSave_SSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_SSV.Location = new System.Drawing.Point(786, 3);
            this.buttonSave_SSV.Name = "buttonSave_SSV";
            this.buttonSave_SSV.Size = new System.Drawing.Size(75, 61);
            this.buttonSave_SSV.TabIndex = 3;
            this.buttonSave_SSV.Text = "Сохранить";
            this.buttonSave_SSV.UseVisualStyleBackColor = false;
            this.buttonSave_SSV.Click += new System.EventHandler(this.buttonSave_SSV_Click);
            // 
            // buttonHelp_SSV
            // 
            this.buttonHelp_SSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SSV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_SSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_SSV.Location = new System.Drawing.Point(882, 15);
            this.buttonHelp_SSV.Name = "buttonHelp_SSV";
            this.buttonHelp_SSV.Size = new System.Drawing.Size(75, 61);
            this.buttonHelp_SSV.TabIndex = 4;
            this.buttonHelp_SSV.Text = "Справка";
            this.buttonHelp_SSV.UseVisualStyleBackColor = false;
            this.buttonHelp_SSV.Click += new System.EventHandler(this.buttonHelp_SSV_Click);
            // 
            // chartFunction_SSV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_SSV.ChartAreas.Add(chartArea1);
            this.chartFunction_SSV.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFunction_SSV.Legends.Add(legend1);
            this.chartFunction_SSV.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_SSV.Name = "chartFunction_SSV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_SSV.Series.Add(series1);
            this.chartFunction_SSV.Size = new System.Drawing.Size(669, 467);
            this.chartFunction_SSV.TabIndex = 5;
            this.chartFunction_SSV.Text = "chartFunction_SSV";
            title1.Name = "Title1";
            title1.Text = "График функции f(x)";
            this.chartFunction_SSV.Titles.Add(title1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxResult_SSV);
            this.panel1.Location = new System.Drawing.Point(12, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 462);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxTask_SSV);
            this.panel2.Controls.Add(this.groupBoxInput_SSV);
            this.panel2.Controls.Add(this.buttonDone_SSV);
            this.panel2.Controls.Add(this.buttonSave_SSV);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 68);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chartFunction_SSV);
            this.panel3.Location = new System.Drawing.Point(288, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(669, 467);
            this.panel3.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 560);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonHelp_SSV);
            this.MinimumSize = new System.Drawing.Size(985, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 20 | Сбродов С. В";
            this.groupBoxResult_SSV.ResumeLayout(false);
            this.groupBoxResult_SSV.PerformLayout();
            this.groupBoxTask_SSV.ResumeLayout(false);
            this.groupBoxTask_SSV.PerformLayout();
            this.groupBoxInput_SSV.ResumeLayout(false);
            this.groupBoxInput_SSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SSV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxResult_SSV;
        private System.Windows.Forms.TextBox textBoxResult_SSV;
        private System.Windows.Forms.GroupBox groupBoxTask_SSV;
        private System.Windows.Forms.GroupBox groupBoxInput_SSV;
        private System.Windows.Forms.Button buttonDone_SSV;
        private System.Windows.Forms.Button buttonSave_SSV;
        private System.Windows.Forms.Button buttonHelp_SSV;
        private System.Windows.Forms.TextBox textBoxStopStep_SSV;
        private System.Windows.Forms.TextBox textBoxStartStep_SSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SSV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

