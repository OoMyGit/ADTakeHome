using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w13
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

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.Dock = DockStyle.Fill;
            form2.TopLevel = false;
            form2.ControlBox = false;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(form2);
            form2.Show();
        }

        private void editManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.FormBorderStyle = FormBorderStyle.None;
            form3.Dock = DockStyle.Fill;
            form3.TopLevel = false;
            form3.ControlBox = false;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(form3);
            form3.Show();
        }

        private void deletePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.FormBorderStyle = FormBorderStyle.None;
            form4.Dock = DockStyle.Fill;
            form4.TopLevel = false;
            form4.ControlBox = false;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(form4);
            form4.Show();
        }
    }
}
