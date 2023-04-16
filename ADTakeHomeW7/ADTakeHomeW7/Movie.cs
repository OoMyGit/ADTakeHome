using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADTakeHomeW7
{
    public class Movie
    {
        private string moviename;
        private string movietrail;
        private string movietrailem;
        private string moviesynopsis;
        PictureBox movieposter = new PictureBox();
        Label movielabel = new Label();
        List<PlayingTime> playtime = new List<PlayingTime>();

        public string MovieName
        {
            get { return moviename; }
            set { moviename = value; }
        }
        public string MovieTrail
        {
            get { return movietrail; }
            set { movietrail = value; }
        }
        public string MovieTrailEm
        {
            get { return movietrailem; }
            set { movietrailem = value; }
        }
        public string MovieSynopsis
        {
            get { return moviesynopsis; }
            set { moviesynopsis = value; }
        }
        public PictureBox MoviePoster
        {
            get { return movieposter; }
            set { movieposter = value; }
        }
        public Label MovieLabel
        {
            get { return movielabel; }
            set { movielabel = value; }
        }
        public List<PlayingTime> PlayTime
        {
            get { return playtime; }
            set { playtime = value; }
        }
        public class PlayingTime : Movie
        {
            string time;
            Button[,] seats;

            public string Time
            {
                get { return time; }
                set { time = value; }
            }
            public Button[,] Seats
            {
                get { return seats; }
                set { seats = value; }
            }
        }
    }
}
