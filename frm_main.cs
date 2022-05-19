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
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }
        frm_inventory frmInventory;
        frm_user frmUser;
        frm_setting frmSetting;
        frm_cashier frmCashier;

        private void userToolStripMenuItem_Click(object sender, EventArgs e) => CreateOrActive(frmUser);
        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e) => CreateOrActive(frmInventory);
        private void settingToolStripMenuItem_Click(object sender, EventArgs e) => CreateOrActive(frmSetting);
        private void cashierToolStripMenuItem_Click(object sender, EventArgs e) => CreateOrActive(frmCashier);

        private void CreateOrActive<T>(T form) where T : Form
        {
            if (form == null)
            {
                form = Activator.CreateInstance<T>();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                form.Activate();
            }
        }

    }
}
