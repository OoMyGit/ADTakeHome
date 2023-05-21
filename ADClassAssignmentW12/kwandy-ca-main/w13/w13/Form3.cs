using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace w13
{
    public partial class Form3 : Form
    {
        string connectionString = "server=localhost; uid=root; pwd=isbmantap; database=premier_league";
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        DataTable dtTeam = new DataTable();
        DataTable dtX = new DataTable();
        DataTable dtA = new DataTable();
        public Form3()
        {
            InitializeComponent();
        }

        public void GenerateDGV1()
        {
            DataTable dtB = new DataTable();
            sqlQuery = "SELECT m.manager_name as 'Manager Name',t.team_name as 'Team',m.birthdate as 'Birthdate',n.nation as 'Nationality'\r\nFROM premier_league.manager m,premier_league.team t,premier_league.nationality n\r\nWHERE t.manager_id = m.manager_id AND m.nationality_id = n.nationality_id AND m.working = 1 AND t.team_id = '" + comboteam.SelectedValue.ToString() + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtB);
            dgv1.DataSource = dtB;
        }

        public void GenerateDGV2()
        {
            DataTable dtC = new DataTable();
            sqlQuery = "SELECT a.manager_name AS 'Manager Name',n.nation AS 'Nationality',a.birthdate AS 'Birthdate'\r\nFROM premier_league.manager a, premier_league.nationality n\r\nWHERE a.nationality_id = n.nationality_id AND a.working = 0;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtC);
            dgv2.DataSource = dtC;
        }

        private void Form3_Load(object sender, EventArgs e)
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

            GenerateDGV2();
        }

        private void comboteam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtA = new DataTable();

            sqlConnect = new MySqlConnection(connectionString);
            sqlQuery = "SELECT m.manager_name as 'Manager Name',t.team_name as 'Team',m.birthdate as 'Birthdate',n.nation as 'Nationality'\r\nFROM premier_league.manager m,premier_league.team t,premier_league.nationality n\r\nWHERE t.manager_id = m.manager_id AND m.nationality_id = n.nationality_id AND t.team_id = '" + comboteam.SelectedValue.ToString() + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtA);

            dgv1.DataSource = dtA;
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            DataGridViewRow rowselect = dgv2.Rows[dgv2.SelectedCells[0].RowIndex];
            string row = rowselect.Cells[0].Value.ToString();

            dtX = new DataTable();
            sqlQuery = "SELECT manager_id as 'ID' FROM manager WHERE manager_name = '"+ row +"'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtX);
            string idmanager = dtX.Rows[0]["ID"].ToString();


            string updateQuery1 = "UPDATE manager SET working = 0 WHERE (manager_id) = (SELECT manager_id from team m WHERE m.team_id = '" + comboteam.SelectedValue.ToString() + "');";
            string updateQuery2 = "UPDATE team SET manager_id = '" + idmanager + "' WHERE team_id = '" + comboteam.SelectedValue.ToString() + "';";
            string updateQuery3 = "UPDATE manager SET working = 1 WHERE manager_id = '" + idmanager + "';";
            Execute(updateQuery1);
            Execute(updateQuery2);
            Execute(updateQuery3);
            MessageBox.Show("MANAGER UPDATED");
            GenerateDGV1();
            GenerateDGV2();
        }

        private void Execute(string query)
        {
            try
            {
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(query, sqlConnect);
                if (sqlCommand.ExecuteNonQuery() == 1)
                {

                }
                else
                {
                    MessageBox.Show("MANAGER NOT UPDATED");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnect.Close();
        }

    }
}
