using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADTakeHomeW6
{
    public partial class Form1 : Form
    {
        public static int n;
        Label label1 = new Label();
        public TextBox textbox1 = new TextBox();
        Button tombol1 = new Button();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Input Guess Attempts";
            label1.Location = new Point(100, 100);
            this.Controls.Add(label1);

            textbox1.Location = new Point(100, 200);
            this.Controls.Add(textbox1);

            tombol1.Text = "PLAY";
            tombol1.Visible = true;
            tombol1.Location = new Point(100, 300);
            this.Controls.Add(tombol1);
            tombol1.Click += tombol1_Click;
        }
        public void tombol1_Click(object sender, EventArgs e)
        {
            if (textbox1.Text.All(char.IsDigit) == false || Convert.ToInt32(textbox1.Text) <= 3)
            {
                MessageBox.Show("Please Enter A Correct Input", "Invalid Input");
            }
            else
            {
                n = Convert.ToInt32(textbox1.Text);
                Form2 form2 = new Form2();
                form2.ShowDialog();
                this.Close();
            }
        }
    }
}
