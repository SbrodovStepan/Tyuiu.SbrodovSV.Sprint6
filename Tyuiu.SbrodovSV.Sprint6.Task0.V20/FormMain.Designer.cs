namespace Tyuiu.SbrodovSV.Sprint6.Task0.V20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_SSV));
            this.groupBoxTask__SSV = new System.Windows.Forms.GroupBox();
            this.textBoxTask__SSV = new System.Windows.Forms.TextBox();
            this.groupBoxVarIn__SSV = new System.Windows.Forms.GroupBox();
            this.labelVarA__SSV = new System.Windows.Forms.Label();
            this.textBoxInVarA__SSV = new System.Windows.Forms.TextBox();
            this.groupBoxVarOut__SSV = new System.Windows.Forms.GroupBox();
            this.labelRes__SSV = new System.Windows.Forms.Label();
            this.textBoxResult__SSV = new System.Windows.Forms.TextBox();
            this.buttonDone__SSV = new System.Windows.Forms.Button();
            this.buttonHelp__SSV = new System.Windows.Forms.Button();
            this.pictureBoxFormula__SSV = new System.Windows.Forms.PictureBox();
            this.groupBoxTask__SSV.SuspendLayout();
            this.groupBoxVarIn__SSV.SuspendLayout();
            this.groupBoxVarOut__SSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula__SSV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask__SSV
            // 
            this.groupBoxTask__SSV.Controls.Add(this.pictureBoxFormula__SSV);
            this.groupBoxTask__SSV.Controls.Add(this.textBoxTask__SSV);
            this.groupBoxTask__SSV.Location = new System.Drawing.Point(12, 21);
            this.groupBoxTask__SSV.Name = "groupBoxTask__SSV";
            this.groupBoxTask__SSV.Size = new System.Drawing.Size(455, 158);
            this.groupBoxTask__SSV.TabIndex = 0;
            this.groupBoxTask__SSV.TabStop = false;
            this.groupBoxTask__SSV.Text = "Условие";
            // 
            // textBoxTask__SSV
            // 
            this.textBoxTask__SSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTask__SSV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask__SSV.Location = new System.Drawing.Point(11, 19);
            this.textBoxTask__SSV.Multiline = true;
            this.textBoxTask__SSV.Name = "textBoxTask__SSV";
            this.textBoxTask__SSV.ReadOnly = true;
            this.textBoxTask__SSV.Size = new System.Drawing.Size(284, 133);
            this.textBoxTask__SSV.TabIndex = 0;
            this.textBoxTask__SSV.TabStop = false;
            this.textBoxTask__SSV.Text = "Вычислить значение по формуле";
            // 
            // groupBoxVarIn__SSV
            // 
            this.groupBoxVarIn__SSV.Controls.Add(this.labelVarA__SSV);
            this.groupBoxVarIn__SSV.Controls.Add(this.textBoxInVarA__SSV);
            this.groupBoxVarIn__SSV.Location = new System.Drawing.Point(18, 185);
            this.groupBoxVarIn__SSV.Name = "groupBoxVarIn__SSV";
            this.groupBoxVarIn__SSV.Size = new System.Drawing.Size(289, 92);
            this.groupBoxVarIn__SSV.TabIndex = 1;
            this.groupBoxVarIn__SSV.TabStop = false;
            this.groupBoxVarIn__SSV.Text = "Ввод данных";
            // 
            // labelVarA__SSV
            // 
            this.labelVarA__SSV.AutoSize = true;
            this.labelVarA__SSV.Location = new System.Drawing.Point(6, 29);
            this.labelVarA__SSV.Name = "labelVarA__SSV";
            this.labelVarA__SSV.Size = new System.Drawing.Size(84, 13);
            this.labelVarA__SSV.TabIndex = 1;
            this.labelVarA__SSV.Text = "Переменная A:";
            // 
            // textBoxInVarA__SSV
            // 
            this.textBoxInVarA__SSV.AccessibleDescription = "";
            this.textBoxInVarA__SSV.AccessibleName = "";
            this.textBoxInVarA__SSV.Location = new System.Drawing.Point(9, 45);
            this.textBoxInVarA__SSV.Name = "textBoxInVarA__SSV";
            this.textBoxInVarA__SSV.Size = new System.Drawing.Size(81, 20);
            this.textBoxInVarA__SSV.TabIndex = 2;
            this.textBoxInVarA__SSV.Tag = "";
            this.textBoxInVarA__SSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInVarA_KeyPress);
            // 
            // groupBoxVarOut__SSV
            // 
            this.groupBoxVarOut__SSV.Controls.Add(this.labelRes__SSV);
            this.groupBoxVarOut__SSV.Controls.Add(this.textBoxResult__SSV);
            this.groupBoxVarOut__SSV.Location = new System.Drawing.Point(313, 185);
            this.groupBoxVarOut__SSV.Name = "groupBoxVarOut__SSV";
            this.groupBoxVarOut__SSV.Size = new System.Drawing.Size(154, 92);
            this.groupBoxVarOut__SSV.TabIndex = 1;
            this.groupBoxVarOut__SSV.TabStop = false;
            this.groupBoxVarOut__SSV.Text = "Вывод данных";
            // 
            // labelRes__SSV
            // 
            this.labelRes__SSV.AutoSize = true;
            this.labelRes__SSV.Location = new System.Drawing.Point(6, 29);
            this.labelRes__SSV.Name = "labelRes__SSV";
            this.labelRes__SSV.Size = new System.Drawing.Size(62, 13);
            this.labelRes__SSV.TabIndex = 1;
            this.labelRes__SSV.Text = "Результат:";
            // 
            // textBoxResult__SSV
            // 
            this.textBoxResult__SSV.Location = new System.Drawing.Point(6, 48);
            this.textBoxResult__SSV.Name = "textBoxResult__SSV";
            this.textBoxResult__SSV.ReadOnly = true;
            this.textBoxResult__SSV.Size = new System.Drawing.Size(141, 20);
            this.textBoxResult__SSV.TabIndex = 3;
            this.textBoxResult__SSV.TabStop = false;
            // 
            // buttonDone__SSV
            // 
            this.buttonDone__SSV.Location = new System.Drawing.Point(355, 284);
            this.buttonDone__SSV.Name = "buttonDone__SSV";
            this.buttonDone__SSV.Size = new System.Drawing.Size(112, 32);
            this.buttonDone__SSV.TabIndex = 2;
            this.buttonDone__SSV.Text = "Выполнить";
            this.buttonDone__SSV.UseVisualStyleBackColor = true;
            this.buttonDone__SSV.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonHelp__SSV
            // 
            this.buttonHelp__SSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp__SSV.Location = new System.Drawing.Point(314, 284);
            this.buttonHelp__SSV.Name = "buttonHelp__SSV";
            this.buttonHelp__SSV.Size = new System.Drawing.Size(35, 32);
            this.buttonHelp__SSV.TabIndex = 6;
            this.buttonHelp__SSV.Text = "?";
            this.buttonHelp__SSV.UseVisualStyleBackColor = true;
            this.buttonHelp__SSV.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // pictureBoxFormula__SSV
            // 
            this.pictureBoxFormula__SSV.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxFormula__SSV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula__SSV.Image")));
            this.pictureBoxFormula__SSV.Location = new System.Drawing.Point(307, 19);
            this.pictureBoxFormula__SSV.Name = "pictureBoxFormula__SSV";
            this.pictureBoxFormula__SSV.Size = new System.Drawing.Size(141, 61);
            this.pictureBoxFormula__SSV.TabIndex = 1;
            this.pictureBoxFormula__SSV.TabStop = false;
            // 
            // FormMain_SSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 324);
            this.Controls.Add(this.buttonHelp__SSV);
            this.Controls.Add(this.buttonDone__SSV);
            this.Controls.Add(this.groupBoxVarOut__SSV);
            this.Controls.Add(this.groupBoxVarIn__SSV);
            this.Controls.Add(this.groupBoxTask__SSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_SSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 20 | Сбродов С. В";
            this.groupBoxTask__SSV.ResumeLayout(false);
            this.groupBoxTask__SSV.PerformLayout();
            this.groupBoxVarIn__SSV.ResumeLayout(false);
            this.groupBoxVarIn__SSV.PerformLayout();
            this.groupBoxVarOut__SSV.ResumeLayout(false);
            this.groupBoxVarOut__SSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula__SSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask__SSV;
        private System.Windows.Forms.TextBox textBoxTask__SSV;
        private System.Windows.Forms.GroupBox groupBoxVarIn__SSV;
        private System.Windows.Forms.GroupBox groupBoxVarOut__SSV;
        private System.Windows.Forms.TextBox textBoxInVarA__SSV;
        private System.Windows.Forms.Label labelVarA__SSV;
        private System.Windows.Forms.TextBox textBoxResult__SSV;
        private System.Windows.Forms.Label labelRes__SSV;
        private System.Windows.Forms.Button buttonDone__SSV;
        private System.Windows.Forms.Button buttonHelp__SSV;
        private System.Windows.Forms.PictureBox pictureBoxFormula__SSV;
    }
}

