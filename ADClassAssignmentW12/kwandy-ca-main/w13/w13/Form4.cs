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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace w13
{
    public partial class Form4 : Form
    {
        string connectionString = "server=localhost; uid=root; pwd=isbmantap; database=premier_league";
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        DataTable dtTeam = new DataTable();
        DataTable dtNat = new DataTable();
        DataTable dtA = new DataTable();
        public Form4()
        {
            InitializeComponent();
        }

        public void GenerateDGV()
        {
            DataTable dtB = new DataTable();
            sqlQuery = "SELECT p.player_id,p.player_name as 'Name', n.nation as 'Nationality',p.playing_pos as 'Playing Position',p.team_number as 'Number',p.height as 'Height' ,p.weight as 'Weight',p.birthdate as 'Birthdate'\r\nFROM premier_league.nationality n, premier_league.player p, premier_league.team t\r\nWHERE n.nationality_id = p.nationality_id AND p.team_id = '" + comboteam.SelectedValue.ToString() + "'AND STATUS = 1\r\nGROUP BY p.player_id ORDER BY 2 ASC;";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtB);
            dataGridView1.DataSource = dtB;
            dataGridView1.Columns["player_id"].Visible = false;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            dtTeam = new DataTable();
            sqlConnect = new MySqlConnection(connectionString);
            sqlQuery = "SELECT p.team_id as 'Team ID', t.team_name as 'Team Name'\r\nFROM premier_league.player p, premier_league.team t\r\nWHERE p.team_id = t.team_id\r\nGROUP BY p.team_id\r\nORDER BY 2 ASC;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            comboteam.DataSource = dtTeam;
            comboteam.DisplayMember = "Team Name";
            comboteam.ValueMember = "Team ID";
        }

        private void comboteam_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateDGV();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 11)
            {
                try
                {
                    DataGridViewRow rowselect = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
                    string deleteQuery = "UPDATE player SET status = 0 WHERE player_id = '" + rowselect.Cells["player_id"].Value.ToString() + "';";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(deleteQuery, sqlConnect);

                    if (sqlCommand.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("PLAYER DELETED");
                        GenerateDGV();                    
                    }
                    else
                    {
                        MessageBox.Show("PLAYER NOT DELETED");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                sqlConnect.Close();
            }
            else
            {
                MessageBox.Show("A Team Must Contains 11 Players", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
