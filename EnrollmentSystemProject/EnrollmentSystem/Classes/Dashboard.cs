using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentSystemProject.EnrollmentSystem.Classes
{
    internal class Dashboard
    {
        public static int GetTotalStudentByStatus(string Program)
        {
            int TotalStudents = 0;
            using (SqlConnection con = new SqlConnection(AddConnection.GetConnection()))
            {
                using (SqlCommand cmd = new SqlCommand("proTotalStudent", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Program", Program);
                    try
                    {
                        con.Open();
                        using (SqlDataReader data = cmd.ExecuteReader())
                        {
                            if (data.Read())
                            {
                                TotalStudents = data.GetInt32(data.GetOrdinal("TotalStudents"));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error retrieving total students: " + ex.Message);
                    }
                }
            }
            return TotalStudents;
        }

        public static int StudentByGender(string Gender)
        {
            int TotalStudents = 0;
            using (SqlConnection con = new SqlConnection(AddConnection.GetConnection()))
            {
                using (SqlCommand cmd = new SqlCommand("proStudentByStatus", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    try
                    {
                        con.Open();
                        using (SqlDataReader data = cmd.ExecuteReader())
                        {
                            if (data.Read())
                            {
                                TotalStudents = data.GetInt32(data.GetOrdinal("TotalStudents"));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error retrieving total students: " + ex.Message);
                    }
                }
            }
            return TotalStudents;
        }
        public static int TopByMajor(string Major)
        {
            int TopMajor = 0;
            using (SqlConnection con = new SqlConnection(AddConnection.GetConnection()))
            {
                using (SqlCommand cmd = new SqlCommand("proTopBymajor", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Major", Major);
                    try
                    {
                        con.Open();
                        using (SqlDataReader data = cmd.ExecuteReader())
                        {
                            if (data.Read())
                            {
                                TopMajor = data.GetInt32(data.GetOrdinal("TopMajor"));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error retrieving total students: " + ex.Message);
                    }
                }
            }
            return TopMajor;
        }
    }
}

