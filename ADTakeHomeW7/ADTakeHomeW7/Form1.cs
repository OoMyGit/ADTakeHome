using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADTakeHomeW7
{
    public partial class Form1 : Form
    {
        Panel panel1 = new Panel();
        Panel panel2 = new Panel();
        Label label1 = new Label();
        PictureBox pictureBox1 = new PictureBox();
        Button button1 = new Button();
        WebBrowser webBrowser1 = new WebBrowser();
        Button playtrailer = new Button();
        Button buyticket = new Button();
        Button back = new Button();
        Button reset = new Button();
        Button reserve = new Button();
        List<string> reservedseatindex = new List<string>();
        Button[] jam = new Button[3];
        Button[,] btn = new Button[10,10];
        string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };


        List<Movie> listmovie = new List<Movie>();
        string[] mov = Properties.Resources.MovieNameList.Split('\n');
        string[] movtrail = Properties.Resources.Trail.Split('\n');
        string[] movtrailem = Properties.Resources.TrailEm.Split('\n');

        public Form1()
        {
            InitializeComponent();
        }

        private void MoviePoster_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel2.Show();
            pictureBox1 = (PictureBox)sender;
            pictureBox1.Location = new Point(20, 20);
            pictureBox1.Size = new Size(500, 700);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro Med", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = Color.Black;
            this.label1.Location = new System.Drawing.Point(550, 30);
            this.label1.Size = new System.Drawing.Size(500, 150);
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
            this.label1.Text = pictureBox1.Tag.ToString();

            this.playtrailer.BackColor = System.Drawing.Color.CadetBlue;
            this.playtrailer.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playtrailer.ForeColor = System.Drawing.Color.Black;
            this.playtrailer.Location = new System.Drawing.Point(600, 100);
            this.playtrailer.Size = new System.Drawing.Size(120, 50);
            this.playtrailer.Text = "Watch Trailer";
            this.playtrailer.Click += Playtrailer_Click;

            this.buyticket.BackColor = System.Drawing.Color.CadetBlue;
            this.buyticket.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyticket.ForeColor = System.Drawing.Color.Black;
            this.buyticket.Location = new System.Drawing.Point(850, 100);
            this.buyticket.Size = new System.Drawing.Size(120, 50);
            this.buyticket.Text = "Buy Seats";
            this.buyticket.Click += Buyseat_Click;

            this.back.BackColor = System.Drawing.Color.CadetBlue;
            this.back.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.Black;
            this.back.Location = new System.Drawing.Point(1100, 100);
            this.back.Size = new System.Drawing.Size(80, 50);
            this.back.Text = "Back";
            this.back.Click += Back_Click;

            this.panel1.Controls.Add(pictureBox1);
            this.panel1.Controls.Add(buyticket);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(back);
            this.panel1.Controls.Add(playtrailer);
        }

        private void Playtrailer_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            string urltrail;
            string emtrail;
            foreach(Movie film in listmovie)
            {
                if(label1.Text==film.MovieName)
                {
                    urltrail = film.MovieTrail;
                    emtrail = film.MovieTrailEm;
                    string html = "<html> <head>";
                    html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
                    html += emtrail;
                    html += "</head> </html>";
                    webBrowser1.DocumentText = html;
                    webBrowser1.Location = new System.Drawing.Point(550, 150);
                    webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
                    webBrowser1.Name = "webBrowser1";
                    webBrowser1.Size = new System.Drawing.Size(600, 600);
                    webBrowser1.TabIndex = 0;
                    webBrowser1.Url = new System.Uri(urltrail, System.UriKind.Absolute);
                    panel1.Controls.Add(webBrowser1);
                }    
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            pictureBox1.Hide();
            Button1_Click(sender, e);
        }

        private void Buyseat_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Show();
            for (int i = 0; i < 3;i++)
            {
                jam[i].Tag = jam[i].Text;
                panel1.Controls.Add(jam[i]);
            }
        }

        private void jam_Click(object sender, EventArgs e)
        {
            Button clickedjam = (Button)sender;
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel2.Show();
            pictureBox1.Location = new Point(20, 20);
            pictureBox1.Size = new Size(500, 700);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro Med", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = Color.Black;
            this.label1.Location = new System.Drawing.Point(550, 30);
            this.label1.Size = new System.Drawing.Size(500, 150);
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
            this.label1.Text = pictureBox1.Tag.ToString();

            this.reserve.BackColor = System.Drawing.Color.CadetBlue;
            this.reserve.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserve.ForeColor = System.Drawing.Color.Black;
            this.reserve.Location = new System.Drawing.Point(600, 100);
            this.reserve.Size = new System.Drawing.Size(120, 50);
            this.reserve.Text = "Reserve";
            this.reserve.Click += Reserve_Click;

            this.reset.BackColor = System.Drawing.Color.CadetBlue;
            this.reset.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.Color.Black;
            this.reset.Location = new System.Drawing.Point(850, 100);
            this.reset.Size = new System.Drawing.Size(120, 50);
            this.reset.Text = "Reset";
            this.reset.Click += Reset_Click;

            this.back.BackColor = System.Drawing.Color.CadetBlue;
            this.back.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.Black;
            this.back.Location = new System.Drawing.Point(1100, 100);
            this.back.Size = new System.Drawing.Size(80, 50);
            this.back.Text = "Back";
            this.back.Click += Back_Click;

            foreach (Movie film in listmovie)
            {
                if (label1.Text == film.MovieName)
                {
                    foreach (Movie.PlayingTime jamtayang in film.PlayTime)
                    {
                        if (jamtayang.Time == clickedjam.Text)
                        {
                            jamtayang.Seats = btn;
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    panel1.Controls.Add(jamtayang.Seats[i, j]);
                                }
                            }
                            break;
                            break;
                        }
                        
                    }
                }
            }
            
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    string indexurutbtn = btn[i, j].Tag.ToString();
                    if (reservedseatindex.Contains(indexurutbtn))
                    {
                        btn[i, j].BackColor = Color.Red;
                        btn[i, j].Enabled = false;
                    }
                    
                }
            }

            this.panel1.Controls.Add(pictureBox1);
            this.panel1.Controls.Add(reset);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(back);
            this.panel1.Controls.Add(reserve);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string a = btn.Tag.ToString();

            if (btn.BackColor == Color.Yellow)
            {
                btn.BackColor = Color.White;
            }
            else
            {
                btn.BackColor = Color.Yellow;
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    btn[i, j].BackColor = Color.White;
                    btn[i, j].Enabled = true;
                }
            }
            foreach (Movie film in listmovie)
            {
                if (label1.Text == film.MovieName)
                {
                    foreach (Movie.PlayingTime jamtayang in film.PlayTime)
                    {
                        jamtayang.Seats = btn;
                    }
                }
            }
        }

        private void Reserve_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (btn[i, j].BackColor == Color.Yellow)
                    {
                        btn[i, j].BackColor = Color.Red;
                        btn[i, j].Enabled = false;
                    }
                }
            }
            foreach (Movie film in listmovie)
            {
                if (label1.Text == film.MovieName)
                {
                    foreach (Movie.PlayingTime jamtayang in film.PlayTime)
                    {
                        jamtayang.Seats = btn;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 900);
            this.panel1.TabIndex = 1;
            this.panel2.Location = new System.Drawing.Point(541, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 670);
            this.panel2.TabIndex = 1;
            this.Controls.Add(this.panel1);
            this.panel1.Controls.Add(this.panel2);
            panel2.Hide();

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro Med", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = Color.Black;
            this.label1.Location = new System.Drawing.Point(332, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(838, 195);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To";

            this.pictureBox1.BackColor = System.Drawing.Color.DarkKhaki;
            this.pictureBox1.ErrorImage = Properties.Resources.logoapp;
            this.pictureBox1.Image = Properties.Resources.logoapp;
            this.pictureBox1.InitialImage = Properties.Resources.logoapp;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(325, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(573, 155);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;

            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Minion Pro Med", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(403, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(432, 81);
            this.button1.TabIndex = 1;
            this.button1.Text = "ENTER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += Button1_Click;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);


            int x = 600;
            int y = 200;
            int urutbutton = 1;
            int index = 0;
            int seatnum = 1;
            Random rnd = new Random();

            int maxoccu = rnd.Next(1, 71);
            int nambah = 1;
            while (nambah <= maxoccu)
            {
                int rndnum = rnd.Next(1, 101);
                if (!reservedseatindex.Contains(rndnum.ToString()))
                {
                    reservedseatindex.Add(rndnum.ToString());
                    nambah++;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].Location = new Point(x, y);
                    btn[i, j].Size = new Size(50, 50);
                    btn[i, j].Text = alphabet[index] + seatnum.ToString();
                    btn[i, j].Tag = urutbutton.ToString();
                    btn[i, j].BackColor = Color.White;
                    btn[i, j].Click += btn_Click;
                    this.Controls.Add(btn[i, j]);
                    urutbutton++;
                    x += 50;
                    seatnum++;
                }
                seatnum = 1;
                index++;
                x = 600;
                y += 50;
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    string indexurutbtn = btn[i, j].Tag.ToString();
                    if (reservedseatindex.Contains(indexurutbtn))
                    {
                        btn[i, j].BackColor = Color.Red;
                        btn[i, j].Enabled = false;
                    }
                    foreach (Movie film in listmovie)
                    {
                        if (label1.Text == film.MovieName)
                        {
                            foreach (Movie.PlayingTime jamtayang in film.PlayTime)
                            {
                                jamtayang.Seats = btn;
                            }
                        }
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Bitmap[] posterimg = new Bitmap[8];
            posterimg[0] = Properties.Resources.film65;
            posterimg[1] = Properties.Resources.avatar;
            posterimg[2] = Properties.Resources.avengers;
            posterimg[3] = Properties.Resources.dungeon;
            posterimg[4] = Properties.Resources.guardian;
            posterimg[5] = Properties.Resources.johnwick;
            posterimg[6] = Properties.Resources.mariobros;
            posterimg[7] = Properties.Resources.topgun;
            int x = 12;
            for (int i = 0; i < 3; i++)
            {
                jam[i] = new Button();
                jam[i].BackColor = Color.CadetBlue;
                jam[i].ForeColor = Color.Black;
                jam[i].Location = new Point(560 + (i*55), 200);
                jam[i].Text = x.ToString() + ".00";
                jam[i].Size = new Size(50, 30);
                jam[i].Click += jam_Click;
                x += 3;
            }

            for (int i = 0; i < mov.Length; i++)
            {
                Movie movie = new Movie();
                Movie.PlayingTime jamtayang = new Movie.PlayingTime();
                movie.MovieName = mov[i];
                movie.MovieTrail = movtrail[i];
                movie.MovieTrailEm = movtrailem[i];

                movie.MoviePoster = new PictureBox();
                movie.MoviePoster.SizeMode = PictureBoxSizeMode.StretchImage;
                movie.MoviePoster.Image = posterimg[i];
                movie.MoviePoster.Size = new Size(200, 300);
                movie.MoviePoster.Tag = mov[i];
                movie.MoviePoster.Click += MoviePoster_Click;

                movie.MovieLabel = new Label();
                movie.MovieLabel.AutoSize = true;
                movie.MovieLabel.Font = new System.Drawing.Font("Minion Pro Med", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                movie.MovieLabel.ForeColor = Color.Black;
                movie.MovieLabel.Size = new System.Drawing.Size(400, 30);
                movie.MovieLabel.Text = mov[i];
                movie.MovieLabel.TextAlign = ContentAlignment.MiddleCenter;

                for (int j = 0; j < 3; j++)
                {
                    jamtayang.Time = jam[j].Text;
                    movie.PlayTime.Add(jamtayang);
                }

                if (i >= 0 && i < 4)
                {
                    movie.MoviePoster.Location = new Point(70 + (i * 250), 55);
                    if (i == 0)
                    {
                        movie.MovieLabel.Location = new System.Drawing.Point(150, 380);
                    }
                    if (i == 1)
                    {
                        movie.MovieLabel.Location = new System.Drawing.Point(335, 380);
                    }
                    if (i == 2)
                    {
                        movie.MovieLabel.Location = new System.Drawing.Point(600, 380);
                    }
                    if (i == 3)
                    {
                        movie.MovieLabel.Location = new System.Drawing.Point(790, 380);
                    }
                }
                else
                {
                    movie.MovieLabel.Location = new System.Drawing.Point(75 + ((i - 4) * 250), 780);
                    movie.MoviePoster.Location = new Point(70 + ((i - 4) * 250), 455);
                    if (i == 4)
                    {
                        movie.MovieLabel.Location = new System.Drawing.Point(70, 780);
                    }
                    if (i == 5)
                    {
                        movie.MovieLabel.Location = new System.Drawing.Point(350, 780);
                    }
                    if (i == 6)
                    {
                        movie.MovieLabel.Location = new System.Drawing.Point(575, 780);
                    }
                    if (i == 7)
                    {
                        movie.MovieLabel.Location = new System.Drawing.Point(850, 780);
                    }
                }
                listmovie.Add(movie);
            }
            ShowingMainMenu();
        }

        public void ShowingMainMenu()
        {
            foreach (Movie film in listmovie)
            {
                this.panel1.Controls.Add(film.MovieLabel);
                this.panel1.Controls.Add(film.MoviePoster);
            }
        }
    }
}
