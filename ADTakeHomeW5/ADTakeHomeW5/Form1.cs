using System.Data;
using System.Diagnostics;

namespace ADTakeHomeW5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dtProdukSimpan = new DataTable();
        DataTable dtProdukTampil = new DataTable();
        DataTable dtCategory = new DataTable();

        public List<string> listIDproduct = new List<string>();
        public List<string> listnamaproduct = new List<string>();
        public List<Int64> listharga = new List<Int64>();
        public List<Int32> liststock = new List<Int32>();
        public List<string> listIDcategoryproduct = new List<string>();

        public List<string> listIDcategorycategory = new List<string>();
        public List<string> listnamacategory = new List<string>();

        public bool ceksama = true;
        public int idproductbaru;
        public string selectedcell;
        public string hurufpertama;
        string angka0id = "00";
        private void Form1_Load(object sender, EventArgs e)
        {
            dtProdukSimpan.Columns.Add("ID Product");
            dtProdukSimpan.Columns.Add("Nama Product");
            dtProdukSimpan.Columns.Add("Harga");
            dtProdukSimpan.Columns.Add("Stock");
            dtProdukSimpan.Columns.Add("ID Category");

            dtProdukTampil.Columns.Add("ID Product");
            dtProdukTampil.Columns.Add("Nama Product");
            dtProdukTampil.Columns.Add("Harga");
            dtProdukTampil.Columns.Add("Stock");
            dtProdukTampil.Columns.Add("ID Category");

            dtCategory.Columns.Add("ID Category");
            dtCategory.Columns.Add("Nama Category");

            listIDcategorycategory.Add("C1");
            listIDcategorycategory.Add("C2");
            listIDcategorycategory.Add("C3");
            listIDcategorycategory.Add("C4");
            listIDcategorycategory.Add("C5");
            listnamacategory.Add("Jas");
            listnamacategory.Add("T-Shirt");
            listnamacategory.Add("Rok");
            listnamacategory.Add("Celana");
            listnamacategory.Add("Cawat");

            listIDproduct.Add("J001");
            listIDproduct.Add("T001");
            listIDproduct.Add("T002");
            listIDproduct.Add("R001");
            listIDproduct.Add("J002");
            listIDproduct.Add("C001");
            listIDproduct.Add("C002");
            listIDproduct.Add("R002");
            listnamaproduct.Add("Jas Hitam");
            listnamaproduct.Add("T-Shirt Blackpink");
            listnamaproduct.Add("T-Shirt Obsessive");
            listnamaproduct.Add("Rok Mini");
            listnamaproduct.Add("Jeans Biru");
            listnamaproduct.Add("Celana Pendek Coklat");
            listnamaproduct.Add("Cawat Blink-blink");
            listnamaproduct.Add("Rocca Shirt");
            listharga.Add(100000);
            listharga.Add(70000);
            listharga.Add(75000);
            listharga.Add(82000);
            listharga.Add(90000);
            listharga.Add(60000);
            listharga.Add(1000000);
            listharga.Add(50000);
            liststock.Add(10);
            liststock.Add(20);
            liststock.Add(16);
            liststock.Add(26);
            liststock.Add(5);
            liststock.Add(11);
            liststock.Add(1);
            liststock.Add(8);
            listIDcategoryproduct.Add("C1");
            listIDcategoryproduct.Add("C2");
            listIDcategoryproduct.Add("C2");
            listIDcategoryproduct.Add("C3");
            listIDcategoryproduct.Add("C4");
            listIDcategoryproduct.Add("C4");
            listIDcategoryproduct.Add("C5");
            listIDcategoryproduct.Add("C2");

            for (int i = 0; i < listIDcategorycategory.Count; i++)
            {
                dtCategory.Rows.Add(listIDcategorycategory[i], listnamacategory[i]);
                combocategoryproduct.Items.Add(listnamacategory[i]);
                combofilter.Items.Add(listnamacategory[i]);
            }
            for (int i = 0; i < listIDcategoryproduct.Count; i++)
            {

                dtProdukSimpan.Rows.Add(listIDproduct[i], listnamaproduct[i], listharga[i], liststock[i], listIDcategoryproduct[i]);
            }

            dgvcategory.DataSource = dtCategory;
            dgvproduct.DataSource = dtProdukSimpan;
            dgvcategory.ClearSelection();
            dgvproduct.ClearSelection();
            dgvcategory.CurrentCell = null;
            dgvproduct.CurrentCell = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonaddproduct_Click(object sender, EventArgs e)
        {
            if (textboxnamaproduct.Text == "" && textboxhargaproduct.Text == "" && textboxstockproduct.Text == "" && combocategoryproduct.SelectedValue == null)
            {
                MessageBox.Show("Fill all of the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                hurufpertama = textboxnamaproduct.Text.Substring(0, 1).ToUpper();

                for (int i = 0; i < listIDproduct.Count; i++)
                {
                    if (textboxnamaproduct.Text == listnamaproduct[i])
                    {
                        ceksama = false;
                    }

                }

                for (int i = 0; i < listIDproduct.Count; i++)
                {
                    if (textboxnamaproduct.Text.Substring(0, 1).ToUpper() == listIDproduct[i].Substring(0, 1).ToUpper())
                    {
                        idproductbaru = Convert.ToInt32(listIDproduct[i].Substring(1)) + 1;
                    }
                }
                if (idproductbaru > 99)
                {
                    angka0id = "";
                }
                else if (idproductbaru > 9)
                {
                    angka0id = "0";
                }

                listIDproduct.Add(textboxnamaproduct.Text.Substring(0, 1).ToUpper() + angka0id + idproductbaru);
                listnamaproduct.Add(textboxnamaproduct.Text);
                listharga.Add(Convert.ToInt64(textboxhargaproduct.Text));
                liststock.Add(Convert.ToInt32(textboxstockproduct.Text));
                listIDcategoryproduct.Add(listIDcategorycategory[combocategoryproduct.SelectedIndex]);

                dtProdukSimpan.Rows.Clear();
                for (int i = 0; i < listnamaproduct.Count; i++)
                {
                    dtProdukSimpan.Rows.Add(listIDproduct[i], listnamaproduct[i], listharga[i], liststock[i], listIDcategoryproduct[i]);
                }

                textboxnamaproduct.Text = null;
                textboxhargaproduct.Text = null;
                textboxstockproduct.Text = null;
                combocategoryproduct.Text = null;

            }
        }
        private void buttoneditproduct_Click(object sender, EventArgs e)
        {
            if (dgvproduct.CurrentCell == null)
            {
                MessageBox.Show("You Need To Select First", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (textboxnamaproduct.Text == "" || textboxhargaproduct.Text == "" || textboxstockproduct.Text == "" || combocategoryproduct.Text == "")
                {
                    MessageBox.Show("Please fill all the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    for (int i = 0; i < listIDproduct.Count; i++)
                    {
                        if (selectedcell == listIDproduct[i])
                        {
                            listnamaproduct[i] = textboxnamaproduct.Text;
                            listharga[i] = Convert.ToInt64(textboxhargaproduct.Text);
                            liststock[i] = Convert.ToInt32(textboxstockproduct.Text);
                            listIDcategoryproduct[i] = listIDcategorycategory[combocategoryproduct.SelectedIndex];

                            if (Convert.ToInt32(textboxstockproduct.Text) == 0)
                            {
                                listIDproduct.RemoveAt(i);
                                listnamaproduct.RemoveAt(i);
                                listharga.RemoveAt(i);
                                liststock.RemoveAt(i);
                                listIDcategoryproduct.RemoveAt(i);

                            }
                            textboxnamaproduct.Text = null;
                            textboxhargaproduct.Text = null;
                            textboxstockproduct.Text = null;
                            combocategoryproduct.Text = null;

                            dtProdukSimpan.Rows.Clear();
                            for (int j = 0; j < listnamaproduct.Count; j++)
                            {
                                dtProdukSimpan.Rows.Add(listIDproduct[j], listnamaproduct[j], listharga[j], liststock[j], listIDcategoryproduct[j]);
                            }
                        }
                    }

                }
            }
            dgvproduct.ClearSelection();
            dgvproduct.CurrentCell = null;
        }

        private void buttonremoveproduct_Click(object sender, EventArgs e)
        {
            if (dgvproduct.CurrentCell == null)
            {
                MessageBox.Show("You Need To Select First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                for (int i = 0; i < listIDproduct.Count; i++)
                {
                    if (selectedcell == listIDproduct[i])
                    {
                        listIDproduct.RemoveAt(i);
                        listnamaproduct.RemoveAt(i);
                        listharga.RemoveAt(i);
                        liststock.RemoveAt(i);
                        listIDcategoryproduct.RemoveAt(i);
                        textboxnamaproduct.Text = null;
                        textboxhargaproduct.Text = null;
                        textboxstockproduct.Text = null;
                        combocategoryproduct.Text = null;

                        dtProdukSimpan.Rows.Clear();
                        for (int j = 0; j < listnamaproduct.Count; j++)
                        {
                            dtProdukSimpan.Rows.Add(listIDproduct[j], listnamaproduct[j], listharga[j], liststock[j], listIDcategoryproduct[j]);
                        }

                        dgvproduct.ClearSelection();
                        dgvproduct.CurrentCell = null;
                        selectedcell = "";
                    }
                }
            }
        }

        private void buttonaddcategory_Click(object sender, EventArgs e)
        {
            string tampungan = "";
            ceksama = true;



            if (textboxcategory.Text == "")
            {
                MessageBox.Show("Please fill all the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                for (int i = 0; i < listIDcategorycategory.Count; i++)
                {
                    tampungan = listIDcategorycategory[i].Substring(1);
                }
                string categoryname = textboxcategory.Text;
                string categoryID = "C" + (Convert.ToInt32(tampungan) + 1);

                for (int i = 0; i < listIDcategorycategory.Count; i++)
                {
                    if (categoryname == listnamacategory[i])
                    {
                        ceksama = false;
                    }

                }
                if (ceksama == false)
                {
                    MessageBox.Show("Category name already exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dtCategory.Rows.Add(categoryID, categoryname);
                    listIDcategorycategory.Add("C" + Convert.ToInt32(tampungan) + 1);
                    listnamacategory.Add(textboxcategory.Text);

                    combofilter.Items.Clear();
                    for (int i = 0; i < listnamacategory.Count; i++)
                    {
                        combofilter.Items.Add(listnamacategory[i]);
                    }

                    combocategoryproduct.Items.Clear();
                    for (int i = 0; i < listnamacategory.Count; i++)
                    {
                        combocategoryproduct.Items.Add(listnamacategory[i]);
                    }
                }
                textboxcategory.Clear();
            }
        }

        private void buttonremovecategory_Click(object sender, EventArgs e)
        {
            if (dgvcategory.CurrentCell == null)
            {
                MessageBox.Show("You Need To Select First", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string selecteditem = listIDcategorycategory[dgvcategory.CurrentCell.RowIndex];
                listIDcategorycategory.RemoveAt(dgvcategory.CurrentCell.RowIndex);
                listnamacategory.RemoveAt(dgvcategory.CurrentCell.RowIndex);
                dtCategory.Rows.RemoveAt(dgvcategory.CurrentCell.RowIndex);

                for (int i = listIDcategoryproduct.Count - 1; i >= 0; i--)
                {
                    if (selecteditem == listIDcategoryproduct[i])
                    {
                        dtProdukSimpan.Rows.RemoveAt((int)i);
                        listIDcategoryproduct.RemoveAt(i);
                        listnamaproduct.RemoveAt(i);
                        listharga.RemoveAt(i);
                        liststock.RemoveAt(i);
                        listIDproduct.RemoveAt(i);

                    }
                }
                combofilter.Items.Clear();
                for (int i = 0; i < listnamacategory.Count; i++)
                {
                    combofilter.Items.Add(listnamacategory[i]);
                }

                combocategoryproduct.Items.Clear();
                for (int i = 0; i < listnamacategory.Count; i++)
                {
                    combocategoryproduct.Items.Add(listnamacategory[i]);
                }

                dgvcategory.ClearSelection();
                dgvcategory.CurrentCell = null;
            }
        }

        private void textboxhargaproduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textboxstockproduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dgvproduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedcell = dgvproduct.SelectedCells[0].Value.ToString();
            if (dgvproduct.CurrentCell == null)
            {
                MessageBox.Show("Select dulu bang", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                for (int i = 0; i < listIDproduct.Count; i++)
                {
                    if (selectedcell == listIDproduct[i])
                    {
                        textboxnamaproduct.Text = listnamaproduct[i];
                        textboxhargaproduct.Text = listharga[i].ToString();
                        textboxstockproduct.Text = liststock[i].ToString();
                        foreach (DataRow a in dtCategory.Rows)
                        {
                            if (listIDcategoryproduct[i] == a[0].ToString())
                            {
                                combocategoryproduct.Text = a[1].ToString();
                            }
                        }
                    }
                }


            }
        }

        private void buttonall_Click(object sender, EventArgs e)
        {
            dtProdukSimpan.Rows.Clear();
            for (int j = 0; j < listnamaproduct.Count; j++)
            {
                dtProdukSimpan.Rows.Add(listIDproduct[j], listnamaproduct[j], listharga[j], liststock[j], listIDcategoryproduct[j]);
            }

            combofilter.Text = "";
            combofilter.Enabled = false;
        }

        private void buttonfilter_Click(object sender, EventArgs e)
        {
            combofilter.Enabled = true;

        }

        private void combofilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtProdukSimpan.Rows.Clear();
            for (int i = 0; i < listIDcategoryproduct.Count; i++)
            {
                if (listIDcategorycategory[combofilter.SelectedIndex] == listIDcategoryproduct[i])
                {
                    dtProdukSimpan.Rows.Add(listIDproduct[i], listnamaproduct[i], listharga[i], liststock[i], listIDcategoryproduct[i]);
                }
            }
        }
    }
}