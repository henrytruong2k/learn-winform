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
    public partial class frm_user : Form
    {
        private MyDatabase myDB = new MyDatabase();
        public frm_user()
        {
            InitializeComponent();
        }
        private void load_userAccount()
        {
            dgv_userAccount.DataSource = this.myDB.executeSqlCommand("SELECT * FROM tbl_userAccount");
        }
        private void frm_user_Load(object sender, EventArgs e)
        {
            load_userAccount();
            dgv_userAccount.Columns[0].HeaderText = "ID";
            dgv_userAccount.Columns[1].HeaderText = "Username";
            dgv_userAccount.Columns[2].HeaderText = "Password";
            dgv_userAccount.Columns[3].HeaderText = "FirstName";
            dgv_userAccount.Columns[4].HeaderText = "LastName";
        }

        private void dgv_userAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dgv_userAccount.CurrentRow.Cells[0].Value.ToString();
            txt_username.Text = dgv_userAccount.CurrentRow.Cells[1].Value.ToString();
            txt_password.Text = dgv_userAccount.CurrentRow.Cells[2].Value.ToString();
            txt_firstname.Text = dgv_userAccount.CurrentRow.Cells[3].Value.ToString();
            txt_lastname.Text = dgv_userAccount.CurrentRow.Cells[4].Value.ToString();

            if (dgv_userAccount.CurrentRow.Cells[1].Value.ToString() == frm_main._username)
            {
                txt_password.ReadOnly = false;
            } 
            else
            {
                txt_password.ReadOnly = true;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_password.Text == "" || txt_firstname.Text == "" || txt_lastname.Text == "")
            {
                MessageBox.Show("Please fill the information", "Warning");
                return;
            }
            DataTable checkItem = new DataTable();
            checkItem = this.myDB.executeSqlCommand($"SELECT * FROM tbl_userAccount WHERE username='{txt_username.Text}'");
            if (checkItem.Rows.Count > 0)
            {
                MessageBox.Show($"The username: {txt_username.Text} is duplicate", "Warning");
                return;
            }
            string sqlCommand = $"INSERT INTO tbl_userAccount (username, password, firstName, lastName) VALUES('{txt_username.Text}', '{txt_password.Text}', '{txt_firstname.Text}', '{txt_lastname.Text}')";
            this.myDB.executeSqlCommand(sqlCommand);
            MessageBox.Show("The data is added", "Complete");
            load_userAccount();
            clearTextboxes();
        }
        private void clearTextboxes()
        {
            txt_id.Clear();
            txt_username.Clear();
            txt_password.Clear();
            txt_firstname.Clear();
            txt_lastname.Clear();
        }
    }
}
