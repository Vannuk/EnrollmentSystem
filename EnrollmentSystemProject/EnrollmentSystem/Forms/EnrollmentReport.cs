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
    public partial class EnrollmentReport : Form
    {
        public EnrollmentReport()
        {
            InitializeComponent();
        }

        private void EnrollmentReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentEnrollmentsDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.studentEnrollmentsDataSet.Students);
            // TODO: This line of code loads data into the 'enrollmentStudentDataSet.Students' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
        }
    }
}
