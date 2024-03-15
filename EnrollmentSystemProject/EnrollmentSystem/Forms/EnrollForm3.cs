using EnrollmentSystemProject.EnrollmentSystem.Classes;
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
    public partial class EnrollForm3 : Form
    {
        private SubMenuForm subMenuForm;
        private Enrollment enrollment;

        public EnrollForm3(Enrollment enrollment,SubMenuForm parentForm)
        {
            InitializeComponent();
            this.enrollment = enrollment;
            subMenuForm = parentForm;
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            //DECLARE
            //INPUT
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            //PROCESS
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opf.FileName);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
                enrollment.RegDate = DateTime.Parse(DTPReg.Text);
                enrollment.UserID = TxtEmpID.Text;
                if (CHKWeekDay.Checked)
                {
                    if (CHKAMorning1.Checked)
                    {
                        enrollment.StudyTime = "WeekDay Morning(M1):7:45am - 10:45am";
                    }
                    else if (CHKAMorning2.Checked)
                    {
                        enrollment.StudyTime = "WeekDay Morning(M2:11:00am - 2:00pm)";
                    }
                    else if (CHKAAfternoon.Checked)
                    {
                        enrollment.StudyTime = "WeekDay Afternoon:2:15pm - 5:15pm";
                    }
                    else if (CHKAEvening.Checked)
                    {
                        enrollment.StudyTime = "WeekDay Evening:5:30pm - 8:30pm";
                    }
                }
                else if (CHKWeekend.Checked)
                {
                    enrollment.StudyTime = "Weekend";
                }
                if (enrollment.InsertEnrollStudent(enrollment))
                {
                    //Output
                    MessageBox.Show("Student Enrollment Data is Insert Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clearall();
                }
                else
                {
                    MessageBox.Show("Student Enrollment Data is Insert Unsuccessfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            EnrollForm2 enrollForm2 = new EnrollForm2(subMenuForm, enrollment);
            subMenuForm.ShowBackButtonEnroll(this, enrollForm2);
        }
        private void Clearall()
        {
            TxtEmpID.Clear();
            CHKWeekDay.Checked = false;
            CHKAMorning1.Checked = false;
            CHKAMorning2.Checked = false;
            CHKAAfternoon.Checked = false;
            CHKAEvening.Checked = false;
            CHKWeekend.Checked = false;
        }
    }
}
