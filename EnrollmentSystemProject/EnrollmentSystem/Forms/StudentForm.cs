using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnrollmentSystemProject.EnrollmentSystem.Classes;

namespace EnrollmentSystemProject.EnrollmentSystem.Forms
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eRU_CoreDataSet.Students' table. You can move, or remove it, as needed.

        }

        private void TxtSearchP_Enter(object sender, EventArgs e)
        {
            {
                if (TxtSearchP.Text == "Search Student Here")
                {
                    TxtSearchP.Text = "";
                    TxtSearchP.ForeColor = System.Drawing.Color.Black;
                }
            }
        }

        private void TxtSearchP_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtSearchP.Text))
            {
                TxtSearchP.Text = "";
                TxtSearchP.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void TxtSearchP_DoubleClick(object sender, EventArgs e)
        {
            string inputText = TxtSearchP.Text; // Get the input from the TextBox

            // Construct the SQL query
            string query = "SELECT StudentID, RegDate,FullNameKH,FullNameEng,Gender,DOB,ParentContact,Email,Address,PhoneNumber,Major,Program,StudyTime FROM Students WHERE Program = @Program";

            using (SqlConnection connection = new SqlConnection(AddConnection.GetConnection()))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the input parameter to the command
                    command.Parameters.AddWithValue("@Program", inputText);

                    // Open the database connection
                    connection.Open();

                    // Create a DataTable to hold the retrieved data
                    DataTable dataTable = new DataTable();

                    // Read the data from the database into the DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
        }
    }
}
