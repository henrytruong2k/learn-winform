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

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmUser == null)
            {
                frmUser = new frm_user();
                frmUser.MdiParent = this;
                frmUser.FormClosed += FrmUser_FormClosed; ;
                frmUser.Show();
            }
            else
            {
                frmUser.Activate();
            }
        }

        private void FrmUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmUser = null;
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmInventory == null)
            {
                frmInventory = new frm_inventory();
                frmInventory.MdiParent = this;
                frmInventory.FormClosed += FrmInventory_FormClosed;
                frmInventory.Show();
            }
            else
            {
                frmInventory.Activate();
            }
        }
        private void FrmInventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmInventory = null;
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmSetting == null)
            {
                frmSetting = new frm_setting();
                frmSetting.MdiParent = this;
                frmSetting.FormClosed += FrmSetting_FormClosed;
                frmSetting.Show();
            }
            else
            {
                frmSetting.Activate();
            }
        }

        private void FrmSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSetting = null;
        }

        private void cashierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCashier == null)
            {
                frmCashier = new frm_cashier();
                frmCashier.MdiParent = this;
                frmCashier.FormClosed += FrmSetting_FormClosed1; ;
                frmCashier.Show();
            }
            else
            {
                frmCashier.Activate();
            }
        }

        private void FrmSetting_FormClosed1(object sender, FormClosedEventArgs e)
        {
            frmCashier = null;
        }
    }
}
