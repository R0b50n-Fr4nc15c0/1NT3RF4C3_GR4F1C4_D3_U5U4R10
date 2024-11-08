using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomba
{
    public partial class Form1 : Form
    {
        string filename { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            File.WriteAllText(filename, textBox1.Text);
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            var resultado = ofd.ShowDialog(this);
            filename = ofd.FileName;
            if (resultado == DialogResult.OK)
            {
                string text = File.ReadAllText(filename);
                textBox1.Text = text;
                label1.Text = filename;
            }
        }
    }
}
