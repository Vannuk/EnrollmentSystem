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
    public partial class ScholarshipReportForm : Form
    {
        public ScholarshipReportForm()
        {
            InitializeComponent();
        }

        private void ScholarshipReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scholarshipDataSet.PAYMENTS' table. You can move, or remove it, as needed.
            this.pAYMENTSTableAdapter.Fill(this.scholarshipDataSet.PAYMENTS);
            // TODO: This line of code loads data into the 'scholarshipReportDataSet.PAYMENTS' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
        }
    }
}
