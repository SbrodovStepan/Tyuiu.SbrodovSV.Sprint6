﻿namespace Tyuiu.SbrodovSV.Sprint6.Task0.V20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.textBoxTask__SSV = new System.Windows.Forms.TextBox();
            this.groupBoxVarIn = new System.Windows.Forms.GroupBox();
            this.labelVarA = new System.Windows.Forms.Label();
            this.textBoxInVarA__SSV = new System.Windows.Forms.TextBox();
            this.groupBoxVarOut = new System.Windows.Forms.GroupBox();
            this.labelRes = new System.Windows.Forms.Label();
            this.textBoxResult__SSV = new System.Windows.Forms.TextBox();
            this.buttonDone__SSV = new System.Windows.Forms.Button();
            this.buttonHelp__SSV = new System.Windows.Forms.Button();
            this.pictureBoxFormula_ = new System.Windows.Forms.PictureBox();
            this.groupBoxTask.SuspendLayout();
            this.groupBoxVarIn.SuspendLayout();
            this.groupBoxVarOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.pictureBoxFormula_);
            this.groupBoxTask.Controls.Add(this.textBoxTask__SSV);
            this.groupBoxTask.Location = new System.Drawing.Point(12, 21);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(455, 158);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
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
            // groupBoxVarIn
            // 
            this.groupBoxVarIn.Controls.Add(this.labelVarA);
            this.groupBoxVarIn.Controls.Add(this.textBoxInVarA__SSV);
            this.groupBoxVarIn.Location = new System.Drawing.Point(18, 185);
            this.groupBoxVarIn.Name = "groupBoxVarIn";
            this.groupBoxVarIn.Size = new System.Drawing.Size(289, 92);
            this.groupBoxVarIn.TabIndex = 1;
            this.groupBoxVarIn.TabStop = false;
            this.groupBoxVarIn.Text = "Ввод данных";
            // 
            // labelVarA
            // 
            this.labelVarA.AutoSize = true;
            this.labelVarA.Location = new System.Drawing.Point(6, 29);
            this.labelVarA.Name = "labelVarA";
            this.labelVarA.Size = new System.Drawing.Size(84, 13);
            this.labelVarA.TabIndex = 1;
            this.labelVarA.Text = "Переменная A:";
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
            // groupBoxVarOut
            // 
            this.groupBoxVarOut.Controls.Add(this.labelRes);
            this.groupBoxVarOut.Controls.Add(this.textBoxResult__SSV);
            this.groupBoxVarOut.Location = new System.Drawing.Point(313, 185);
            this.groupBoxVarOut.Name = "groupBoxVarOut";
            this.groupBoxVarOut.Size = new System.Drawing.Size(154, 92);
            this.groupBoxVarOut.TabIndex = 1;
            this.groupBoxVarOut.TabStop = false;
            this.groupBoxVarOut.Text = "Вывод данных";
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Location = new System.Drawing.Point(6, 29);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(62, 13);
            this.labelRes.TabIndex = 1;
            this.labelRes.Text = "Результат:";
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
            // pictureBoxFormula_
            // 
            this.pictureBoxFormula_.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxFormula_.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_.Image")));
            this.pictureBoxFormula_.Location = new System.Drawing.Point(307, 19);
            this.pictureBoxFormula_.Name = "pictureBoxFormula_";
            this.pictureBoxFormula_.Size = new System.Drawing.Size(141, 61);
            this.pictureBoxFormula_.TabIndex = 1;
            this.pictureBoxFormula_.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 324);
            this.Controls.Add(this.buttonHelp__SSV);
            this.Controls.Add(this.buttonDone__SSV);
            this.Controls.Add(this.groupBoxVarOut);
            this.Controls.Add(this.groupBoxVarIn);
            this.Controls.Add(this.groupBoxTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 20 | Сбродов С. В";
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.groupBoxVarIn.ResumeLayout(false);
            this.groupBoxVarIn.PerformLayout();
            this.groupBoxVarOut.ResumeLayout(false);
            this.groupBoxVarOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.TextBox textBoxTask__SSV;
        private System.Windows.Forms.GroupBox groupBoxVarIn;
        private System.Windows.Forms.GroupBox groupBoxVarOut;
        private System.Windows.Forms.TextBox textBoxInVarA__SSV;
        private System.Windows.Forms.Label labelVarA;
        private System.Windows.Forms.TextBox textBoxResult__SSV;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Button buttonDone__SSV;
        private System.Windows.Forms.Button buttonHelp__SSV;
        private System.Windows.Forms.PictureBox pictureBoxFormula_;
    }
}

