using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SbrodovSV.Sprint6.Task4.V20.Lib;
using System.IO;

namespace Tyuiu.SbrodovSV.Sprint6.Task4.V20
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
                int startStep = Convert.ToInt32(textBoxStartStep_SSV.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_SSV.Text);

                int len = dataService.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = dataService.GetMassFunction(startStep, stopStep);

                this.chartFunction_SSV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SSV.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_SSV.Text = "";

                chartFunction_SSV.Series[0].Points.Clear();
                for (int i  = 0; i < len; i++, startStep++)
                {
                    this.chartFunction_SSV.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_SSV.AppendText(valueArray[i] + Environment.NewLine);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_SSV_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V20.txt";
                File.WriteAllText(path, textBoxResult_SSV.Text);

                DialogResult dialogResult = MessageBox.Show(this, $"Файл {path} сохранён успешно!\n Открыть его?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if ( dialogResult == DialogResult.Yes )
                {
                    //System.Diagnostics.Process.Start( path );
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void buttonHelp_SSV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУб-23-2 Сбродов Степан Владимирович", "Сообщение");
        }
    }
}
