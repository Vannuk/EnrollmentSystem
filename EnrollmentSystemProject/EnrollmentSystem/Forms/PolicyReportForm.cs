using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystemProject.EnrollmentSystem.Forms
{
    public partial class PolicyReportForm : Form
    {
        public PolicyReportForm()
        {
            InitializeComponent();
        }

        private void PolicyReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'policyIncomeDataSet.PAYMENTS' table. You can move, or remove it, as needed.
            this.pAYMENTSTableAdapter.Fill(this.policyIncomeDataSet.PAYMENTS);
            // TODO: This line of code loads data into the 'policyInComeDataSet.PAYMENTS' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'policyIncomeDataSet.PAYMENTS' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
        }
    }
}
