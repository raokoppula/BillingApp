using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingApp
{
    public partial class BillingAppMDI : Form
    {
        MainMenu mainMenu = new MainMenu();

        public BillingAppMDI()
        {
            InitializeComponent();
        }

        private void BillingAppMDI_Load(object sender, EventArgs e)
        {
            this.Menu = mainMenu;
            CenterToScreen();
            mainMenu.GetForm().BackColor = Color.Blue;
        }


        private void createCompanyMenuItem_Click(object sender, EventArgs e)
        {
            CreateCompany createCompany = new CreateCompany();
            createCompany.MdiParent = this;
            createCompany.StartPosition = FormStartPosition.CenterScreen;
           
            createCompany.Show();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salesorderClousuresToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void itemMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemMaster itemMaster = new ItemMaster();
            itemMaster.MdiParent = this;
            itemMaster.StartPosition = FormStartPosition.CenterScreen;

            itemMaster.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales frmSales = new Sales();
            frmSales.MdiParent = this;
            frmSales.StartPosition = FormStartPosition.CenterScreen;

            frmSales.Show();
        }

        private void retailCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Customer frmRetailCustomer = new Customer();
            frmRetailCustomer.MdiParent = this;
            frmRetailCustomer.StartPosition = FormStartPosition.CenterScreen;

            frmRetailCustomer.Show();
        }

        private void mISReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
