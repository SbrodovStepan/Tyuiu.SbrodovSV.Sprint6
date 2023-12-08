using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SbrodovSV.Sprint6.Task6.V22.Lib;
using System.IO;

namespace Tyuiu.SbrodovSV.Sprint6.Task6.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService dataService = new DataService();
        private void buttonDone_SSV_Click(object sender, EventArgs e)
        {
            textBoxResult_SSV.Text = dataService.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_SSV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_SSV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SSV.ShowDialog();
            openFilePath = openFileDialogTask_SSV.FileName;
            textBoxInput_SSV.Text = File.ReadAllText(openFilePath);
            groupBoxResult_SSV.Text = groupBoxResult_SSV.Text + " " + openFileDialogTask_SSV.FileName;
            buttonDone_SSV.Enabled = true;
        }
    }
}
