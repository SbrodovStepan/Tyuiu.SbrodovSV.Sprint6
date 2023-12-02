namespace Tyuiu.SbrodovSV.Sprint6.Task1.V10
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
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResult_SSV = new System.Windows.Forms.TextBox();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SSV = new System.Windows.Forms.TextBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStopStep_SSV = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_SSV = new System.Windows.Forms.TextBox();
            this.buttonHelp_SSV = new System.Windows.Forms.Button();
            this.buttonDone_SSV = new System.Windows.Forms.Button();
            this.groupBoxResult.SuspendLayout();
            this.groupBoxTask.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.label1);
            this.groupBoxResult.Controls.Add(this.textBoxResult_SSV);
            this.groupBoxResult.Location = new System.Drawing.Point(508, 12);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(241, 292);
            this.groupBoxResult.TabIndex = 0;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Ввод данных";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Результат:";
            // 
            // textBoxResult_SSV
            // 
            this.textBoxResult_SSV.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxResult_SSV.Location = new System.Drawing.Point(6, 38);
            this.textBoxResult_SSV.Multiline = true;
            this.textBoxResult_SSV.Name = "textBoxResult_SSV";
            this.textBoxResult_SSV.ReadOnly = true;
            this.textBoxResult_SSV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SSV.Size = new System.Drawing.Size(224, 249);
            this.textBoxResult_SSV.TabIndex = 3;
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.textBoxTask_SSV);
            this.groupBoxTask.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(490, 227);
            this.groupBoxTask.TabIndex = 7;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            // 
            // textBoxTask_SSV
            // 
            this.textBoxTask_SSV.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_SSV.Multiline = true;
            this.textBoxTask_SSV.Name = "textBoxTask_SSV";
            this.textBoxTask_SSV.ReadOnly = true;
            this.textBoxTask_SSV.Size = new System.Drawing.Size(477, 201);
            this.textBoxTask_SSV.TabIndex = 0;
            this.textBoxTask_SSV.Text = "Протабулировать функцию f(x) на заданном диапозоне\r\nРезультат вывести в виде табл" +
    "ицы";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.label3);
            this.groupBoxInput.Controls.Add(this.label2);
            this.groupBoxInput.Controls.Add(this.textBoxStopStep_SSV);
            this.groupBoxInput.Controls.Add(this.textBoxStartStep_SSV);
            this.groupBoxInput.Location = new System.Drawing.Point(13, 241);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(280, 63);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Конец шага:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Старт шага:";
            // 
            // textBoxStopStep_SSV
            // 
            this.textBoxStopStep_SSV.Location = new System.Drawing.Point(145, 33);
            this.textBoxStopStep_SSV.Name = "textBoxStopStep_SSV";
            this.textBoxStopStep_SSV.Size = new System.Drawing.Size(129, 20);
            this.textBoxStopStep_SSV.TabIndex = 1;
            this.textBoxStopStep_SSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_SSV_KeyPress);
            // 
            // textBoxStartStep_SSV
            // 
            this.textBoxStartStep_SSV.Location = new System.Drawing.Point(7, 33);
            this.textBoxStartStep_SSV.Name = "textBoxStartStep_SSV";
            this.textBoxStartStep_SSV.Size = new System.Drawing.Size(132, 20);
            this.textBoxStartStep_SSV.TabIndex = 0;
            this.textBoxStartStep_SSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_SSV_KeyPress);
            // 
            // buttonHelp_SSV
            // 
            this.buttonHelp_SSV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_SSV.Location = new System.Drawing.Point(299, 241);
            this.buttonHelp_SSV.Name = "buttonHelp_SSV";
            this.buttonHelp_SSV.Size = new System.Drawing.Size(75, 53);
            this.buttonHelp_SSV.TabIndex = 2;
            this.buttonHelp_SSV.Text = "Справка";
            this.buttonHelp_SSV.UseVisualStyleBackColor = false;
            this.buttonHelp_SSV.Click += new System.EventHandler(this.buttonHelp_SSV_Click);
            // 
            // buttonDone_SSV
            // 
            this.buttonDone_SSV.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonDone_SSV.Location = new System.Drawing.Point(374, 241);
            this.buttonDone_SSV.Name = "buttonDone_SSV";
            this.buttonDone_SSV.Size = new System.Drawing.Size(128, 54);
            this.buttonDone_SSV.TabIndex = 2;
            this.buttonDone_SSV.Text = "Выполнить";
            this.buttonDone_SSV.UseVisualStyleBackColor = false;
            this.buttonDone_SSV.Click += new System.EventHandler(this.buttonDone_SSV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 316);
            this.Controls.Add(this.buttonDone_SSV);
            this.Controls.Add(this.buttonHelp_SSV);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.groupBoxTask);
            this.Controls.Add(this.groupBoxResult);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 10 | Сбродов С. В";
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxResult_SSV;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStopStep_SSV;
        private System.Windows.Forms.TextBox textBoxStartStep_SSV;
        private System.Windows.Forms.Button buttonHelp_SSV;
        private System.Windows.Forms.Button buttonDone_SSV;
        private System.Windows.Forms.TextBox textBoxTask_SSV;
    }
}

