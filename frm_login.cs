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
    public partial class frm_login : Form
    {
        private MyDatabase myDB = new MyDatabase();
        public frm_login()
        {
            InitializeComponent();
            txt_username.Text = "admin";
            txt_password.Text = "123456";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable loginTable = new DataTable();
                loginTable = this.myDB.executeSqlCommand($"SELECT * FROM tbl_userAccount WHERE username='{txt_username.Text}' AND password='{txt_password.Text}'");
                if (loginTable.Rows.Count > 0)
                {
                    MessageBox.Show("You logged in");
                    frm_main frm_Main = new frm_main(txt_username.Text);
                    frm_Main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or password is wrong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.btn_login;
        }

        
    }
}
