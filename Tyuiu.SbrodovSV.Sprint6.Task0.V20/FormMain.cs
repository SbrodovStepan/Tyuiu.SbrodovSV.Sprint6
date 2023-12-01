using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SbrodovSV.Sprint6.Task0.V20.Lib;

namespace Tyuiu.SbrodovSV.Sprint6.Task0.V20
{
    public partial class FormMain_SSV : Form
    {
        DataService dataService = new DataService();
        public FormMain_SSV()
        {
            InitializeComponent();
        }

        private void textBoxInVarA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }


        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxResult__SSV.Text = Convert.ToString(dataService.Calculate(int.Parse(textBoxInVarA__SSV.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы АСОиУб-23-2 Сбродов Степан Владимирович", "Сообщение");
        }
    }
}
