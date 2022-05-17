using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstProject
{
    public partial class frm_inventory : Form
    {
        private MyDatabase myDB = new MyDatabase();
        public frm_inventory()
        {
            InitializeComponent();
        }
        private void load_dgvInventory()
        {
            dgv_inventory.DataSource = this.myDB.executeSqlCommand("SELECT * FROM tbl_product");
        }

        private void frm_inventory_Load(object sender, EventArgs e)
        {
            load_dgvInventory();
            dgv_inventory.Columns[0].HeaderText = "ID";
            dgv_inventory.Columns[1].HeaderText = "Barcode";
            dgv_inventory.Columns[2].HeaderText = "Product";
            dgv_inventory.Columns[3].HeaderText = "Price";
            dgv_inventory.Columns[4].HeaderText = "Quantity";
        }

        private void dgv_inventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dgv_inventory.CurrentRow.Cells[0].Value.ToString();
            txt_barcode.Text = dgv_inventory.CurrentRow.Cells[1].Value.ToString();
            txt_product.Text = dgv_inventory.CurrentRow.Cells[2].Value.ToString();
            txt_price.Text = dgv_inventory.CurrentRow.Cells[3].Value.ToString();
            txt_quantity.Text = dgv_inventory.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_barcode.Text == "" || txt_product.Text == "" || txt_price.Text == "" || txt_quantity.Text == "")
            {
                MessageBox.Show("Please fill the information", "Warning");
                return;
            }
            DataTable checkItem = new DataTable();
            checkItem = this.myDB.executeSqlCommand($"SELECT * FROM tbl_product WHERE barcode='{txt_barcode.Text}'");
            if (checkItem.Rows.Count > 0)
            {
                MessageBox.Show("The barcode is duplicate", "Warning");
                return;
            }
            string sqlCommand = $"INSERT INTO tbl_product (barcode, name, price, quantity) VALUES('{txt_barcode.Text}', '{txt_product.Text}', '{txt_price.Text}', '{txt_quantity.Text}')";
            this.myDB.executeSqlCommand(sqlCommand);
            MessageBox.Show("The data is added", "Complete");
            load_dgvInventory();
            clearTextboxes();
        }
        private void clearTextboxes()
        {
            txt_id.Clear();
            txt_barcode.Clear();
            txt_product.Clear();
            txt_price.Clear();
            txt_quantity.Clear();
        }
    }
}
