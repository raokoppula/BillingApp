using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingApp
{
    public partial class SelectCompany : Form
    {
        string constr;

        public SelectCompany()
        {
            InitializeComponent();

            constr = ConfigurationManager.ConnectionStrings["conBillingApp"].ConnectionString;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void SelectCompany_Load(object sender, EventArgs e)
        {
            LoadCompanies();
        }

        public void LoadCompanies()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.ConnectionString = constr;
                con.Open();

                DataTable dataTable = new DataTable();
              
                string cmdstr = "SELECT CompanyName as 'Company Name', Address, City, State, Phone FROM tblCompany";
                using (SqlCommand cmd = new SqlCommand(cmdstr, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);
                }

                dgViewSelectCompanies.DataSource = dataTable;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
