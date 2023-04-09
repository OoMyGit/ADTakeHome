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

namespace ADTakeHomeW6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //main props
        Button[,] btn = new Button[(Form1.n), 5];
        Button[] keyboard = new Button[qwertylist.Length];
        Random random = new Random();

        //keyword
        public static string keyword;
        public static string keywordchecker;   //to check for multiple character input      (extra point dongg bangg +10)
        public static char[] keywordchar = new char[5];

        //importing word from txt files     (extra point juga dong bangg +10)
        public static string text = File.ReadAllText(@"C:\Users\ASUS\Downloads\Wordle Word List.txt", Encoding.UTF8);
        public static string[] textlist = text.Split(new Char[] {','});

        //keyboard props
        public static string qwerty = "Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Enter,Z,X,C,V,B,N,M,Delete";
        public static string [] qwertylist = qwerty.Split(new Char[] { ',' });

        //button position index
        public static int currentbuttonrow = 0;
        public static int currentbuttoncolumn = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
            keyword = textlist[random.Next(textlist.Length)];
            keywordchecker = keyword;
            
            //printing button
            int X = 50;
            int Y = 50;
            for (int i = 0; i < Form1.n; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].Size = new Size(50, 50);
                    btn[i, j].Location = new Point(X * (j + 1), Y * (i + 1));
                    btn[i, j].Visible = true;
                    btn[i, j].BackColor = Color.White;
                    this.Controls.Add(btn[i, j]);
                }
            }

            //printing keyboard
            for (int j = 0; j < qwertylist.Length; j++)
            {
                keyboard[j] = new Button();
                keyboard[j].Text = qwertylist[j];
                keyboard[j].BackColor = Color.LightGray;
                if(j==19 || j==27)
                {
                    keyboard[j].Size = new Size(50, 40);
                }
                else
                {
                    keyboard[j].Size = new Size(40, 40);
                }
                if(j>=0 && j < 10)
                {
                    int x = 350;
                    int y = 100;
                    keyboard[j].Location = new Point(x + ((j + 1) * 40), y + ((1 + 1) * 40));
                }
                if (j >= 10 && j < 19)
                {
                    int x = 375;
                    int y = 100;
                    keyboard[j].Location = new Point(x + ((j-10 + 1) * 40), y + ((2 + 1) * 40));
                }
                if (j >= 19 && j < 28)
                {
                    int x = 375;
                    int y = 100;
                    if (j == 19)
                    {
                        keyboard[j].Location = new Point((x + ((j - 19 + 1) * 40)-10), y + ((3 + 1) * 40));
                    }
                    else if (j==27)
                    {
                        keyboard[j].Location = new Point((x + ((j - 19 + 1) * 40)), y + ((3 + 1) * 40));
                    }
                    else
                    {
                        keyboard[j].Location = new Point(x + ((j - 19 + 1) * 40), y + ((3 + 1) * 40));
                    }
                }
                keyboard[j].Visible = true;
                keyboard[j].BackColor = Color.White;
                keyboard[j].Click += keyboard_Click;
                this.Controls.Add(keyboard[j]);
            }
        }
        private void keyboard_Click(object sender, EventArgs e)
        {
            Button clickedkeyboard = sender as Button;
            if (currentbuttonrow < Form1.n)
            {
                if (clickedkeyboard.Text != "Enter" && clickedkeyboard.Text != "Delete" && currentbuttoncolumn < 5)
                {
                    btn[currentbuttonrow, currentbuttoncolumn].Text = clickedkeyboard.Text;
                    currentbuttoncolumn++;
                }
                else if (clickedkeyboard.Text == "Delete" && currentbuttoncolumn > 0)
                {
                    currentbuttoncolumn--;
                    btn[currentbuttonrow, currentbuttoncolumn].Text = "";
                }
                else if (clickedkeyboard.Text == "Enter")
                {
                    keywordchar = keyword.ToCharArray();
                    string wordlistchecker = "";
                    if (currentbuttoncolumn < 5)
                    {
                        MessageBox.Show("Please Fill All Of The Box", "All Box Not Filled", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        //checking if the inputed answer is on the word list
                        for (int i=0; i<currentbuttoncolumn;i++)
                        {
                            wordlistchecker += btn[currentbuttonrow, i].Text;
                        }
                        if(textlist.Contains(wordlistchecker.ToLower()))
                        {
                            for (int i = 0; i < keywordchar.Length; i++)
                            {
                                if (btn[currentbuttonrow, i].Text.ToLower() == keywordchar[i].ToString())
                                {
                                    btn[currentbuttonrow, i].BackColor = Color.LightGreen;
                                    keywordchecker = keywordchecker.Remove(i, 1);
                                    keywordchecker = keywordchecker.Insert(i, "$");
                                }
                            }
                            for (int i = 0; i < keywordchar.Length; i++)
                            {
                                if (keywordchecker.ToString().Contains(btn[currentbuttonrow, i].Text.ToLower()) && btn[currentbuttonrow, i].BackColor==Color.White)
                                {
                                    btn[currentbuttonrow, i].BackColor = Color.LightYellow;
                                }
                            }

                            //lose checking
                            if (currentbuttonrow == Form1.n - 1 && currentbuttoncolumn == 5 && keywordchecker != "$$$$$")
                            {
                                currentbuttoncolumn = 5;
                                currentbuttonrow = Form1.n;
                                MessageBox.Show("YOU LOSE! The Word is : " + keyword.ToUpper(), "GAME OVER", MessageBoxButtons.OK);
                            }

                            currentbuttonrow++;
                            currentbuttoncolumn = 0;

                            //win checking
                            if (keywordchecker == "$$$$$")
                            {
                                currentbuttoncolumn = 5;
                                currentbuttonrow = Form1.n;
                                MessageBox.Show("You Got The Word !!!", "GAME WIN", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show(wordlistchecker + " Is Not A Word!", "Error", MessageBoxButtons.OK);
                        }
                    }
                    keywordchecker = keyword;
                }
            }
        }
    }
}
