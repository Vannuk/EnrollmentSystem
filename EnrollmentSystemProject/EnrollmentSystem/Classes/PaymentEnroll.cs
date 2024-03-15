using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EnrollmentSystemProject.EnrollmentSystem.Classes
{
    public class PaymentEnroll : Enrollment
    {
        public string InvoiceNo { get; set; }
        public string TeamName { get; set; }
        public string Batch { get; set; }
        public int ItemNo1 { get; set; }
        public int ItemNo2 { get; set; }
        public int ItemNo3 { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public int Qty1 { get; set; }
        public int Qty2 { get; set; }
        public int Qty3 { get; set; }
        public DateTime PaymentDate { get; set; }
        public float UnitPrice1 { get; set; }
        public float UnitPrice2 { get; set; }
        public float UnitPrice3 { get; set; }
        public float Scholarship1 { get; set; }
        public float Scholarship2 { get; set; }
        public float Scholarship3 { get; set; }
        public float AmountDuo1 { get; set; }
        public float AmountDuo2 { get; set; }
        public float AmountDuo3 { get; set; }
        public float CashPaid1 { get; set; }
        public float CashPaid2 { get; set; }
        public float CashPaid3 { get; set; }
        public float Total { get; set; }
        public bool SearchStudentInformation()
        {
            //Delcare
            bool check; // = false;
            SqlConnection con;
            SqlCommand cmd;

            //Input
            using (con = new SqlConnection(AddConnection.GetConnection()))
            {
                cmd = new SqlCommand(@"Select * From[dbo].[Students] where StudentID = @StudentID;", con);
                cmd.Parameters.AddWithValue("@StudentID", StudID);

                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                //Process
                SqlDataReader SqlDr = cmd.ExecuteReader();
                SqlDr.Read();

                if (SqlDr.HasRows)
                {
                    //Output
                    FullNameEN = SqlDr.GetValue(4).ToString();
                    Program = SqlDr.GetValue(13).ToString();
                    StudyTime = SqlDr.GetValue(14).ToString();
                    check = true;
                }
                else
                {
                    check = false;
                }
                return check;
            }
        }
        
        public bool InsertPaymentStudent()
        {
            bool check = false;
            SqlCommand cmd;
            SqlConnection con;
            using (con = new SqlConnection(AddConnection.GetConnection()))
            {
                cmd = new SqlCommand("Insert Into PAYMENTS" +
              "(InvoiceNo,TeamName,StuID,FULLNAME, SHIFTS, PROGRAMS, Batch, PaymentDate, ItemNo1,ItemNo2,ItemNo3,Description1,Description2,Description3,Qty1,Qty2,Qty3,UnitPrice1,UnitPrice2,UnitPrice3,Scholarship1,Scholarship2,Scholarship3,AmountDuo1,AmountDuo2,AmountDuo3,CashPaid1,CashPaid2,CashPaid3,Total,UserID)" +
              "values(@InvoiceNo, @TeamName, @StuID, @FULLNAME, @SHIFTS,@PROGRAMS, @Batch, @PaymentDate, @ItemNo1, @ItemNo2 ,@ItemNo3, @Description1, @Description2, @Description3, @Qty1, @Qty2, @Qty3, @UnitPrice1, @UnitPrice2, @UnitPrice3, @Scholarship1, @Scholarship2, @Scholarship3, @AmountDuo1, @AmountDuo2, @AmountDuo3, @CashPaid1, @CashPaid2, @CashPaid3 ,@Total,@UserID);", con);
                cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNo);
                cmd.Parameters.AddWithValue("@TeamName", TeamName);
                cmd.Parameters.AddWithValue("@StuID", StudID);
                cmd.Parameters.AddWithValue("@FULLNAME", FullNameEN);
                cmd.Parameters.AddWithValue("@SHIFTS", StudyTime);
                cmd.Parameters.AddWithValue("@PROGRAMS", Program);
                cmd.Parameters.AddWithValue("@Batch", Batch);
                cmd.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                cmd.Parameters.AddWithValue("@ItemNo1", ItemNo1);
                cmd.Parameters.AddWithValue("@ItemNo2", ItemNo2);
                cmd.Parameters.AddWithValue("@ItemNo3", ItemNo3);
                cmd.Parameters.AddWithValue("@Description1", Description1);
                cmd.Parameters.AddWithValue("@Description2", Description2);
                cmd.Parameters.AddWithValue("@Description3", Description3);
                cmd.Parameters.AddWithValue("@Qty1", Qty1);
                cmd.Parameters.AddWithValue("@Qty2", Qty2);
                cmd.Parameters.AddWithValue("@Qty3", Qty3);
                cmd.Parameters.AddWithValue("@UnitPrice1", UnitPrice1);
                cmd.Parameters.AddWithValue("@UnitPrice2", UnitPrice2);
                cmd.Parameters.AddWithValue("@UnitPrice3", UnitPrice3);
                cmd.Parameters.AddWithValue("@Scholarship1", Scholarship1);
                cmd.Parameters.AddWithValue("@Scholarship2", Scholarship2);
                cmd.Parameters.AddWithValue("@Scholarship3", Scholarship3);
                cmd.Parameters.AddWithValue("@AmountDuo1", AmountDuo1);
                cmd.Parameters.AddWithValue("@AmountDuo2", AmountDuo2);
                cmd.Parameters.AddWithValue("@AmountDuo3", AmountDuo3);
                cmd.Parameters.AddWithValue("@CashPaid1", CashPaid1);
                cmd.Parameters.AddWithValue("@CashPaid2", CashPaid2);
                cmd.Parameters.AddWithValue("@CashPaid3", CashPaid3);
                cmd.Parameters.AddWithValue("@Total", Total);
                cmd.Parameters.AddWithValue("@UserID", UserID);


                if (con.State != System.Data.ConnectionState.Open)
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        System.Console.WriteLine("It is done!");
                        check = true;
                    }
                    catch (Exception)
                    {
                        System.Console.WriteLine("Error Insert");
                        check = false;
                    }
                //Output
                return check;
            }
        }
    }
}
