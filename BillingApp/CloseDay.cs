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
    public partial class CloseDay : Form
    {
        public CloseDay()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseDay_Load(object sender, EventArgs e)
        {
            lblSystemDate.Text = System.DateTime.Now.ToShortDateString();
            lblSystemStatus.Text = "Open";
            lblSystemDate.Text = DateTime.Now.ToShortDateString();
            //dtPickerOpenFor.Enabled = false;
            btnSave.Enabled = false;
        }
    }
}
