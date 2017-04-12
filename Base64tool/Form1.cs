using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base64tool
{
    public partial class Form1 : Form
    {
        Processor proc = new Processor();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                proc.Filepath = ofd.FileName;
                Base64Box.Text = proc.Base64;
                //label1.Text = Base64Box.Text.Length.ToString();
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();

            if (sfd.FileName != "")
            {
                sfd.OpenFile().Write(proc.Filebytes,0,proc.Filebytes.Length);
            }
        }

        private void Base64Box_TextChanged(object sender, EventArgs e)
        {
            proc.Base64 = Base64Box.Text;
            label1.Text = Base64Box.Text.Length.ToString();
        }
    }
}
