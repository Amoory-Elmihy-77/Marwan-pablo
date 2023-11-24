using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void oper_KeyPress(object sender, KeyPressEventArgs e)
        {
            string f = fileName.Text;
            if(e.KeyChar == 'c') {
                StreamWriter nsw = new StreamWriter(f);
                nsw.Close();
            }
            else if(e.KeyChar == 'd') {
                File.Delete(f);
            }
            else if (e.KeyChar == 'o') {
                StreamReader sr = new StreamReader(f);
                show.Text = sr.ReadToEnd();
                sr.Close();
            }
            else if (e.KeyChar == 's') {
                StreamWriter sw = new StreamWriter(f, true);
                sw.WriteLine(show.Text);
                sw.Close();
            }
            else if (e.KeyChar == '?') {
                MessageBox.Show("press c => creation\npress d => deletion\npress o => open and show content\npress s => save changes");
            }
        }
    }
}
