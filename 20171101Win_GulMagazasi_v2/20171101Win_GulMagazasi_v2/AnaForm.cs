using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20171101Win_GulMagazasi_v2
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "bmu" && textBox2.Text == "123")
            {
                Form1 f = new Form1();
                this.Hide();
                f.Show();              
            }
            else
            {
                MessageBox.Show("Düzgün ad vəya şifrə daxil etməmisiniz");
            }
        }
    }
}
