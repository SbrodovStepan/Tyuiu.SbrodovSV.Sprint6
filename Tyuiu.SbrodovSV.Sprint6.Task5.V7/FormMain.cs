using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SbrodovSV.Sprint6.Task5.V7.Lib;
using System.IO;

namespace Tyuiu.SbrodovSV.Sprint6.Task5.V7
{
    public partial class FormMain_SSV : Form
    {
        public FormMain_SSV()
        {
            InitializeComponent();
        }

        DataService dataService = new DataService();

        string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask5V7.txt";
        private void buttonDone_SSV_Click(object sender, EventArgs e)
        {
                dataGridViewResult_SSV.ColumnCount = 2;
                dataGridViewResult_SSV.Columns[0].Width = 20;
                dataGridViewResult_SSV.Columns[1].Width = 50;

                this.chartDiag_SSV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartDiag_SSV.ChartAreas[0].AxisY.Title = "Ось Y";

                chartDiag_SSV.Series[0].Points.Clear();

                double[] numsMass = new double[dataService.len];

                numsMass = dataService.LoadFromDataFile(path);
                for (int i = 0; i < numsMass.Length; i++)
                {
                    dataGridViewResult_SSV.Rows.Add(i.ToString(), numsMass[i].ToString());
                    chartDiag_SSV.Series[0].Points.AddXY(i, numsMass[i]);
                }
        }

        private void buttonOpenFile_SSV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_SSV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУб-23-2 Сбродов Степан Владимирович", "Сообщение");
        }
    }
}
