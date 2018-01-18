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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_MouseDown(object sender, MouseEventArgs e)
        {
            DialogResult netice = colorDialog1.ShowDialog();
            if (netice == DialogResult.OK)
            {
                txtRengi.BackColor = colorDialog1.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem setir = new ListViewItem();
            setir.UseItemStyleForSubItems = false;
            setir.Text = txtAdi.Text;
            setir.SubItems.Add(comboBox1.SelectedItem.ToString());
            setir.SubItems.Add("");
            setir.SubItems[2].BackColor = txtRengi.BackColor;
            double qiymeti = (double)numericUpDown1.Value * double.Parse(txtQiymeti.Text);
            setir.SubItems.Add(qiymeti.ToString());

            listView1.Items.Add(setir);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
