using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButtonMusko.Checked = true;
            checkBox.Checked = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ime = textBoxIme.Text;
            string prezime = textBoxPrezime.Text;
            string pol = "";
            bool student = checkBox.Checked;
            if (radioButtonMusko.Checked) pol = "Musko";
            else pol = "Zensko";

            dataGridView1.Rows.Add(ime, prezime, pol, student);
            Ocisti();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ocisti();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void Ocisti()
        {
            textBoxIme.Clear();
            textBoxPrezime.Clear();
            checkBox.Checked = false;
            radioButtonMusko.Checked = true;
        }
    }
}
