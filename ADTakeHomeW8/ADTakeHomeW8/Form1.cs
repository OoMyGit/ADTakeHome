using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ADTakeHomeW8
{
    public partial class Form1 : Form
    {
        string connectionString = "server=localhost; uid=root; pwd=isbmantap; database=premier_league";
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        DataTable dtTeam = new DataTable();
        int yellow; int red;  int goal; int penalty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection(connectionString);
            label1.Visible = false;
            label2.Visible = false;
            combo1.Visible = false;
            combo2.Visible = false;
            dgv1.Visible = false;
            dgv2.Visible = false;
            dgv3.Visible = false;
            labelaway.Visible = false;
            labelhome.Visible = false;
            labelmatchdetail.Visible = false;
            buttonfind.Visible = false;
            labelname.Visible = false;
            labelteam.Visible = false;
            labelpos.Visible = false;
            labelnat.Visible = false;
            labelnum.Visible = false;
            labelyellow.Visible = false;
            labelred.Visible = false;
            labelgoal.Visible = false;
            labelpenalty.Visible = false;
            labelplayername.Visible = false;
            labelplayerteam.Visible = false;
            labelplayerpos.Visible = false;
            labelplayernat.Visible = false;
            labelplayernum.Visible = false;
            labelplayeryellow.Visible = false;
            labelplayerred.Visible = false;
            labelplayergoal.Visible = false;
            labelplayerpenalty.Visible = false;

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            combo1.SelectedIndex = 0;
            combo2.SelectedIndex = 0;
            label1.Visible = true;
            label2.Visible = true;
            combo1.Visible = true;
            combo2.Visible = true;
            dgv1.Visible = false;
            dgv2.Visible = false;
            dgv3.Visible = false;
            labelaway.Visible = false;
            labelawayteam.Visible = false;
            labelhome.Visible = false;
            labelhometeam.Visible = false;
            labelmatchdetail.Visible = false;
            buttonfind.Visible = true;
            labelname.Visible = true;
            labelteam.Visible = true;
            labelpos.Visible = true;
            labelnat.Visible = true;
            labelnum.Visible = true;
            labelyellow.Visible = true;
            labelred.Visible = true;
            labelgoal.Visible = true;
            labelpenalty.Visible = true;
            labelplayername.Visible = true;
            labelplayerteam.Visible = true;
            labelplayerpos.Visible = true;
            labelplayernat.Visible = true;
            labelplayernum.Visible = true;
            labelplayeryellow.Visible = true;
            labelplayerred.Visible = true;
            labelplayergoal.Visible = true;
            labelplayerpenalty.Visible = true;
            label1.Text = "Select Team : ";
            label2.Text = "Select Player : ";
            sqlQuery = "SELECT team_name as 'Team Name' FROM premier_league.team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);

            combo1.DataSource = dtTeam;
            combo1.DisplayMember = "Team Name";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            combo1.SelectedIndex = 0;
            combo2.SelectedIndex = 0;
            label1.Visible = true;
            label2.Visible = true;
            combo1.Visible = true;
            combo2.Visible = true;
            dgv1.Visible = true;
            dgv2.Visible = true;
            dgv3.Visible = true;
            labelaway.Visible = true;
            labelawayteam.Visible = true;
            labelhome.Visible = true;
            labelhometeam.Visible = true;
            labelmatchdetail.Visible = true;
            buttonfind.Visible = true;
            labelname.Visible = false;
            labelteam.Visible = false;
            labelpos.Visible = false;
            labelnat.Visible = false;
            labelnum.Visible = false;
            labelyellow.Visible = false;
            labelred.Visible = false;
            labelgoal.Visible = false;
            labelpenalty.Visible = false;
            labelplayername.Visible = false;
            labelplayerteam.Visible = false;
            labelplayerpos.Visible = false;
            labelplayernat.Visible = false;
            labelplayernum.Visible = false;
            labelplayeryellow.Visible = false;
            labelplayerred.Visible = false;
            labelplayergoal.Visible = false;
            labelplayerpenalty.Visible = false;
            label1.Text = "Select Team : ";
            label2.Text = "Select Match : ";
            sqlQuery = "SELECT team_name as 'Team Name' FROM premier_league.team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);

            combo1.DataSource = dtTeam;
            combo1.DisplayMember = "Team Name";
        }

        private void buttonfind_Click(object sender, EventArgs e)
        {
            if (!labelmatchdetail.Visible && buttonfind.Visible)
            {
                yellow = 0; red = 0; goal = 0; penalty = 0;
                DataTable dtPlayerData = new DataTable();
                string x = combo1.Text;
                string y = combo2.Text;
                sqlQuery = $"SELECT p.player_name,t.team_name,IF(p.playing_pos='G','Goal Keeper',IF(p.playing_pos='M','Middle-Fielder',IF(p.playing_pos='D','Defender','Forward/Striker')))as'Position',n.nation as 'Nationality',p.team_number as 'Number' FROM player p,nationality n, team t WHERE p.team_id=t.team_id AND p.player_name='{y}' AND t.team_name ='{x}' AND n.nationality_id=p.nationality_id";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPlayerData);
                labelplayername.Text = dtPlayerData.Rows[0][0].ToString();
                labelplayerteam.Text = dtPlayerData.Rows[0][1].ToString();
                labelplayerpos.Text = dtPlayerData.Rows[0][2].ToString();
                labelplayernat.Text = dtPlayerData.Rows[0][3].ToString();
                labelplayernum.Text = "#" + dtPlayerData.Rows[0][4].ToString();

                DataTable dtPlayerID = new DataTable();
                sqlQuery = $"SELECT player_id FROM player WHERE player_name='{y}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPlayerID);

                DataTable dtPlayerStat = new DataTable();
                string z = dtPlayerID.Rows[0][0].ToString();
                sqlQuery = $"SELECT d.type FROM dmatch d WHERE d.player_id='{z}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPlayerStat);

                for (int i = 0; i < dtPlayerStat.Rows.Count; i++)
                {
                    if (dtPlayerStat.Rows[i][0].ToString() == "CY")
                    {
                        yellow++;
                    }
                    else if (dtPlayerStat.Rows[i][0].ToString() == "CR")
                    {
                        red++;
                    }
                    else if (dtPlayerStat.Rows[i][0].ToString() == "GO")
                    {
                        goal++;
                    }
                    else if (dtPlayerStat.Rows[i][0].ToString() == "PM")
                    {
                        penalty++;
                    }
                }
                labelplayeryellow.Text = yellow.ToString();
                labelplayerred.Text = red.ToString();
                labelplayergoal.Text = goal.ToString();
                labelplayerpenalty.Text = penalty.ToString();

            }
            else if (labelmatchdetail.Visible && buttonfind.Visible)
            {
                DataTable dtHomeTeam = new DataTable();
                string x = labelhometeam.Text;
                sqlQuery = $"SELECT t.team_name as 'Team', p.player_name as 'Player',IF(p.playing_pos='G','Goal Keeper',IF(p.playing_pos='M','Middle-Fielder',IF(p.playing_pos='D','Defender','Forward/Striker')))as'Position' FROM player p, team t WHERE p.team_id=t.team_id AND t.team_name='{x}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtHomeTeam);
                dgv1.DataSource = dtHomeTeam;

                DataTable dtAwayTeam = new DataTable();
                string y = labelawayteam.Text;
                sqlQuery = $"SELECT t.team_name as 'Team', p.player_name as 'Player',IF(p.playing_pos='G','Goal Keeper',IF(p.playing_pos='M','Middle-Fielder',IF(p.playing_pos='D','Defender','Forward/Striker')))as'Position' FROM player p, team t WHERE p.team_id=t.team_id AND t.team_name='{y}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtAwayTeam);
                dgv2.DataSource = dtAwayTeam;

                DataTable dtDetails = new DataTable();
                string z = combo2.SelectedValue.ToString();
                sqlQuery = $"SELECT d.minute as 'Minute', t.team_name as'Team',p.player_name as'Player',IF(d.type='CY','Yellow Card',IF(d.type='CR','Red Card',IF(d.type='GO','Goal',IF(d.type='GP','Goal Penalty',IF(d.type='GW','Own Goal','Penalty Miss'))))) as 'Type' FROM dmatch d,team t,player p WHERE d.team_id=t.team_id AND d.player_id=p.player_id AND d.match_id='{z}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtDetails);
                dgv3.DataSource = dtDetails;
            }
        }

        private void combo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!labelmatchdetail.Visible)
            {
                DataTable dtPlayer = new DataTable();
                string x = combo1.Text;
                dtPlayer.Rows.Clear();
                dtPlayer.Columns.Clear();
                sqlQuery = $"SELECT p.player_name as 'Player' FROM player p,premier_league.team t WHERE p.team_id=t.team_id and t.team_name='{x}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPlayer);

                combo2.DataSource = dtPlayer;
                combo2.DisplayMember = "Player";
            }
            else if (labelmatchdetail.Visible)
            {
                DataTable dtMatch = new DataTable();
                string x = combo1.Text;
                sqlQuery = $"SELECT m.match_date as 'Date', Team1.team_name as 'Team Home',Team2.team_name as 'Team Away',m.match_id as'ID' FROM team Team1,team Team2, premier_league.match m WHERE (Team1.team_name='{x}' or Team2.team_name='{x}') AND Team1.team_id=m.team_home AND Team2.team_id=m.team_away;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtMatch);

                combo2.DataSource = dtMatch;
                combo2.DisplayMember = "Date";

                combo2.ValueMember = "Team Home";
                if (combo2.SelectedValue != null)
                {
                    labelhometeam.Text = combo2.SelectedValue.ToString();
                }

                combo2.ValueMember = "Team Away";
                if (combo2.SelectedValue != null)
                {
                    labelawayteam.Text = combo2.SelectedValue.ToString();
                }
                combo2.ValueMember = "ID";
            }
        }

        private void combo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!labelmatchdetail.Visible)
            {

            }
            else if (labelmatchdetail.Visible)
            {
                DataTable dtMatch = new DataTable();
                string x = combo2.SelectedValue.ToString();
                sqlQuery = $"select Team1.team_name as 'Team Home', Team2.team_name as 'Team Away' FROM premier_league.match m, team Team1, team Team2 WHERE m.team_home = Team1.team_id and m.team_away = Team2.team_id and m.match_id = '{x}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtMatch);

                combo2.ValueMember = "Team Home";
                if (combo2.SelectedValue != null)
                {
                    labelhometeam.Text = combo2.SelectedValue.ToString();
                }

                combo2.ValueMember = "Team Away";
                if (combo2.SelectedValue != null)
                {
                    labelawayteam.Text = combo2.SelectedValue.ToString();
                }
                combo2.ValueMember = "ID";
            }
        }
    }
}
