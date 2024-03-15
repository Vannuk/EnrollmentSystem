using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentSystemProject.EnrollmentSystem.Classes
{
    internal class TransactionLog
    {
        public string TranID {  get; set; }
        public string UserID {  get; set; }
        public string UserName { get; set; }
        public DateTime TranDate {  get; set; }
        public string Action {  get; set; }
        public string Table {  get; set; }
        public string Objective {  get; set; }



        public List<TransactionLog> GetTransactionLogs()
        {
            SqlCommand cmd;
            List<TransactionLog> lasData = new List<TransactionLog>();

            using (SqlConnection con = new SqlConnection(AddConnection.GetConnection()))
            {
                cmd = new SqlCommand("sp_GetTansactionLog", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                try
                {
                    con.Open();
                    SqlDataReader data = cmd.ExecuteReader();

                    while (data.Read())
                    {
                        TransactionLog trans = new TransactionLog();
                        trans.TranID = data["TranID"].ToString();
                        trans.UserID = data["EmpID"].ToString();
                        trans.TranDate = Convert.ToDateTime(data["TranDate"].ToString());
                        trans.Action = data["Action"].ToString();
                        trans.Table = data["Table"].ToString();
                        trans.Objective = data["Object"].ToString();

                        lasData.Add(trans);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error retrieving data");
                }
            }

            // Output
            return lasData;
        }

    }
}
