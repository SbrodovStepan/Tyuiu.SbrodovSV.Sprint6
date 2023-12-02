using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SbrodovSV.Sprint6.Task1.V10.Lib;

namespace Tyuiu.SbrodovSV.Sprint6.Task1.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService dataService = new DataService();
        private void buttonDone_SSV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = int.Parse(textBoxStartStep_SSV.Text);
                int stopStep = int.Parse(textBoxStopStep_SSV.Text);

                string strLine;

                int len = dataService.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = dataService.GetMassFunction(startStep, stopStep);
                textBoxResult_SSV.Text = "";
                textBoxResult_SSV.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_SSV.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_SSV.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++, startStep++)
                {
                    strLine = String.Format("|{0,5:d}     | {1, 6:f2}   |", startStep, valueArray[i]);
                    textBoxResult_SSV.AppendText(strLine + Environment.NewLine);
                }

                textBoxResult_SSV.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SSV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-23-2 Сбродов Степан Владимирович", "Сообщение");
        }

        private void textBoxStartStep_SSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}
