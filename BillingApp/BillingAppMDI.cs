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
            //mainMenu.MenuItems.Add(new MenuItem("CreateComp", //Items.Add(CreateCompany);
            //Application.Run(new CreateCompany());
            CreateCompany createCompany = new CreateCompany();
            createCompany.MdiParent = this;
            createCompany.StartPosition = FormStartPosition.CenterScreen;
           
            createCompany.Show();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
