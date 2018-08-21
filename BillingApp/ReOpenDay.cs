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
    public partial class ReOpenDay : Form
    {
        public ReOpenDay()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReOpenDay_Load(object sender, EventArgs e)
        {
            lblCurrentDate.Text = System.DateTime.Now.ToShortDateString();
            lblSystemStatus.Text = "Open";
            dtPickerOpenFor.Value = DateTime.Now;
            dtPickerOpenFor.Enabled = false;
            btnSave.Enabled = false;
        }
    }
}
