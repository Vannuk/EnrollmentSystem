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
    public partial class PaymentForm : Form
    {
        PaymentEnroll pay = new PaymentEnroll();
        public PaymentForm()
        {
            InitializeComponent();
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
                pictureBox3.Image = new Bitmap(opf.FileName);
                //fileName = opf.FileName;
            }
        }

        private void BtnBrowse1_Click(object sender, EventArgs e)
        {
            //DECLARE


            //INPUT
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            //PROCESS
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(opf.FileName);
                //fileName = opf.FileName;
            }
        }
        private void BtnPSave_Click(object sender, EventArgs e)
        {
            //Declare
            int ItemNo1,ItemNo2,ItemNo3;
            int Qty1,Qty2,Qty3;
            float UP1, UP2, UP3;
            float SCS1, SCS2, SCS3;
            float Amd1, Amd2, Amd3;
            float CasP1, CasP2, CasP3;
          
            //Input
            pay.InvoiceNo = TxtInvoiceNo.Text;
            pay.TeamName = TxtTeamName.Text;
            pay.StudID = TxtID.Text;
            pay.FullNameEN = TxtFullname.Text;
            pay.StudyTime = TxtShift.Text;
            pay.Program = TxtProgram.Text;
            pay.Batch = TxtBatchMajor.Text;
            pay.PaymentDate = DateTime.Parse(DTPPayment.Text);
            pay.Description1 = TxtPDD1.Text;
            pay.Description2 = TxtPDD2.Text;
            pay.Description3 = TxtPDD3.Text;
            pay.Total = float.Parse(TxtTotal.Text);
            pay.UserID = TxtUserID.Text;
            //Process
            if(int.TryParse(TxtPDNo1.Text, out ItemNo1))
            {
                pay.ItemNo1 = ItemNo1;
            }
            else
            {
                pay.ItemNo1 = 0;
            }
            if (int.TryParse(TxtPDNo2.Text, out ItemNo2))
            {
                pay.ItemNo2 = ItemNo2;
            }
            else
            {
                pay.ItemNo2 = 0;
            }
            if (int.TryParse(TxtPDNo3.Text, out ItemNo3))
            {
                pay.ItemNo3 = ItemNo3;
            }
            else
            {
                pay.ItemNo3 = 0;
            }
            if (int.TryParse(TxtPDQ1.Text, out Qty1))
            {
                pay.Qty1 = Qty1;
            }
            else
            {
                pay.Qty1 = 0;
            }
            if (int.TryParse(TxtPDQ2.Text, out Qty2))
            {
                pay.Qty2 = Qty2;
            }
            else
            {
                pay.Qty2 = 0;
            }
            if (int.TryParse(TxtPDQ3.Text, out Qty3))
            {
                pay.Qty3 = Qty3;
            }
            else
            {
                pay.Qty3 = 0;
            }
            if (float.TryParse(TxtPDUP1.Text, out UP1))
            {
                pay.UnitPrice1 = UP1;
            }
            else
            {
                pay.UnitPrice2 = 0;
            }
            if (float.TryParse(TxtPDUP2.Text, out UP2))
            {
                pay.UnitPrice2 = UP2;
            }
            else
            {
                pay.UnitPrice2 = 0;
            }
            if (float.TryParse(TxtPDUP3.Text, out UP3))
            {
                pay.UnitPrice3 = UP3;
            }
            else
            {
                pay.UnitPrice3 = 0;
            }
            if (float.TryParse(TxtPDScholarship1.Text, out SCS1))
            {
                pay.Scholarship1 = SCS1;
            }
            else
            {
                pay.Scholarship1 = 0;
            }
            if (float.TryParse(TxtPDScholarship2.Text, out SCS2))
            {
                pay.Scholarship2 = SCS2;
            }
            else
            {
                pay.Scholarship2 = 0;
            }
            if (float.TryParse(TxtPDScholarship3.Text, out SCS3))
            {
                pay.Scholarship3 = SCS3;
            }
            else
            {
                pay.Scholarship3 = 0;
            }
            if (float.TryParse(TxtPDAmoutD1.Text, out Amd1))
            {
                pay.AmountDuo1 = Amd1;
            }
            else
            {
                pay.AmountDuo1 = 0;
            }
            if (float.TryParse(TxtPDAmoutD2.Text, out Amd2))
            {
                pay.AmountDuo2 = Amd2;
            }
            else
            {
                pay.AmountDuo2 = 0;
            }
            if (float.TryParse(TxtPDAmoutD3.Text, out Amd3))
            {
                pay.AmountDuo3 = Amd3;
            }
            else
            {
                pay.AmountDuo3 = 0;
            }
            if (float.TryParse(TxtPDCashPaid1.Text, out CasP1))
            {
                pay.CashPaid1 = CasP1;
            }
            else
            {
                pay.CashPaid1 = 0;
            }
            if (float.TryParse(TxtPDCashPaid2.Text, out CasP2))
            {
                pay.CashPaid2 = CasP2;
            }
            else
            {
                pay.CashPaid2 = 0;
            }
            if (float.TryParse(TxtPDCashPaid3.Text, out CasP3))
            {
                pay.CashPaid3 = CasP3;
            }
            else
            {
                pay.CashPaid3 = 0;
            }
            if (pay.InsertPaymentStudent())
            {
                //Output
                MessageBox.Show("Insert Payment Successful!");
                Clearall();
            }
            else
            {
                MessageBox.Show("Insert Payment Failed....!");
            }
        }

        private void TxtID_DoubleClick(object sender, EventArgs e)
        {
            //Declare

            //Input
            pay.StudID = TxtID.Text;
            //Process
            if (pay.SearchStudentInformation())
            {
                //Output
                TxtFullname.Text = pay.FullNameEN;
                TxtShift.Text = pay.StudyTime;
                TxtProgram.Text = pay.Program;
            }
            else
            {
                MessageBox.Show("It is not found..!");
            }
        }
        private void TxtPDCashPaid1_DoubleClick(object sender, EventArgs e)
        {
            TxtPDCashPaid1.Text = pay.AmountDuo1.ToString();
        }

        private void TxtTotal_DoubleClick(object sender, EventArgs e)
        {
            //Declare
            float sum = 0.0f;
            //Input
            TxtPDCashPaid1.Text = pay.AmountDuo1.ToString();
            TxtPDCashPaid2.Text = pay.AmountDuo2.ToString();
            TxtPDCashPaid3.Text = pay.AmountDuo3.ToString();
            //Process
            sum = pay.AmountDuo1 + pay.AmountDuo2 + pay.AmountDuo3;
            //Output
            TxtTotal.Text = sum.ToString();
        }

        private void TxtPDCashPaid2_DoubleClick(object sender, EventArgs e)
        {
            TxtPDCashPaid2.Text = pay.AmountDuo2.ToString();
        }

        private void TxtPDCashPaid3_DoubleClick(object sender, EventArgs e)
        {
            TxtPDCashPaid3.Text = pay.AmountDuo3.ToString();
        }

        private void BtnPClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtPDAmoutD1_DoubleClick(object sender, EventArgs e)
        {
            //Declare
            float TotalPrice = 0.0f;
            //Input
            pay.UnitPrice1 = float.Parse(TxtPDUP1.Text);
            pay.Scholarship1 = float.Parse(TxtPDScholarship1.Text);
            pay.Qty1 = int.Parse(TxtPDQ1.Text);
            //Process
            TotalPrice = pay.Qty1 * pay.UnitPrice1;
            //Output 
            pay.AmountDuo1 = TotalPrice - (TotalPrice * pay.Scholarship1);
            TxtPDAmoutD1.Text = pay.AmountDuo1.ToString();
        }

        private void TxtPDAmoutD2_DoubleClick(object sender, EventArgs e)
        {
            //Declare
            float TotalPrice2 = 0.0f;
            //Input
            pay.UnitPrice2 = float.Parse(TxtPDUP2.Text);
            pay.Scholarship2 = float.Parse(TxtPDScholarship2.Text);
            pay.Qty2 = int.Parse(TxtPDQ2.Text);
            //Process
            TotalPrice2 = pay.Qty2 * pay.UnitPrice2;
            //Output 
            pay.AmountDuo2 = TotalPrice2 - (TotalPrice2 * pay.Scholarship2);
            TxtPDAmoutD2.Text = pay.AmountDuo2.ToString();
        }

        private void TxtPDAmoutD3_DoubleClick(object sender, EventArgs e)
        {
            //Declare
            float TotalPrice3 = 0.0f;
            //Input
            pay.UnitPrice3 = float.Parse(TxtPDUP3.Text);
            pay.Scholarship3 = float.Parse(TxtPDScholarship3.Text);
            pay.Qty3 = int.Parse(TxtPDQ3.Text);
            //Process
            TotalPrice3 = pay.Qty3 * pay.UnitPrice3;
            //Output 
            pay.AmountDuo3 = TotalPrice3 - (TotalPrice3 * pay.Scholarship3);
            TxtPDAmoutD3.Text = pay.AmountDuo3.ToString();
        }
        private void Clearall()
        {
            TxtID.Clear();
            TxtFullname.Clear();
            TxtBatchMajor.Clear();
            TxtAOU.Clear();
            TxtProgram.Clear();
            TxtShift.Clear();
            TxtTeamName.Clear();
            TxtInvoiceNo.Clear();
            TxtPDAmoutD1.Clear();
            TxtPDAmoutD2.Clear();
            TxtPDAmoutD3.Clear();
            TxtPDCashPaid1.Clear();
            TxtPDCashPaid2.Clear();
            TxtPDCashPaid3.Clear();
            TxtPDD1.Clear();
            TxtPDD2.Clear();
            TxtPDD3.Clear();
            TxtPDNo1.Clear();
            TxtPDNo2.Clear();
            TxtPDNo3.Clear();
            TxtPDQ1.Clear();
            TxtPDQ2.Clear();
            TxtPDQ3.Clear();
            TxtTotal.Clear();
            TxtUserID.Clear();
            TxtPDUP1.Clear();
            TxtPDUP2.Clear();
            TxtPDUP3.Clear();
            TxtPDScholarship1.Clear();
            TxtPDScholarship2.Clear();
            TxtPDScholarship3.Clear();
        }
    }
}
