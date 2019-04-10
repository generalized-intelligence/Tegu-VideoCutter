using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoCutGUI
{
    public partial class frmErr : Form
    {
        public Dictionary<string, Exception> ex_files;
        public frmErr(Dictionary<string, Exception> Ex_files)
        {
            InitializeComponent();
            ex_files = Ex_files;
            foreach(var item in ex_files)
            {
                lstErr.Items.Add(item.Key);
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            var DlgFile = new SaveFileDialog();   //显示选择文件对话框 
            DlgFile.InitialDirectory = "c:\\";
            DlgFile.Filter = "txt files (*.txt)|*.txt";
            DlgFile.FilterIndex = 1;
            DlgFile.RestoreDirectory = true;
            string[] files = ex_files.Keys.ToArray<string>();
            if (DlgFile.ShowDialog() == DialogResult.OK)
            {
                string path = DlgFile.FileName;
                try
                {
                    System.IO.File.WriteAllLines(path, files, Encoding.UTF8);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
