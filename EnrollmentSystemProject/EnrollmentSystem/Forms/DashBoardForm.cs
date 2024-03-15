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
using System.Windows.Forms.DataVisualization.Charting;

namespace EnrollmentSystemProject.EnrollmentSystem.Forms
{
    public partial class DashBoardForm : Form
    {
        public DashBoardForm()
        {
            InitializeComponent();
            PieChartByProgram();
            piechartCountStudentByStatus();
            barchartCountStudentsByGrade();
        }
        private void PieChartByProgram()
        {
            int Bachelor = Dashboard.GetTotalStudentByStatus("Bachelor");
            int Associate = Dashboard.GetTotalStudentByStatus("Associate");
            int Master = Dashboard.GetTotalStudentByStatus("Master");

            Series series = piechartProgram.Series["S1"];
            series.Points.AddXY(Bachelor + "Bachelor", Bachelor);
            series.Points.AddXY(Associate + "Associate", Associate);
            series.Points.AddXY(Master + "Master", Master);

            //Set Color
            series.Points[0].Color = System.Drawing.Color.FromArgb(0, 82, 46);
            series.Points[1].Color = System.Drawing.Color.FromArgb(116, 160, 140);

            //InvisiblePieLabel
            series["PieLabelStyle"] = "Disabled";
        }
        private void piechartCountStudentByStatus()
        {
            int Female = Dashboard.StudentByGender("Female");
            int Male = Dashboard.StudentByGender("Male");

            Series series = piechartStudentByStatus.Series["S2"];
            series.Points.AddXY(Female + "Males", Female);
            series.Points.AddXY(Male + "Females", Male);

            //Adjust Doughnut Size
            //series["DoughnutRadius"] = "40";

            //[ SET COLOR ]
            series.Points[0].Color = System.Drawing.Color.FromArgb(116, 160, 140);
            series.Points[1].Color = System.Drawing.Color.FromArgb(0, 82, 46);

            //InvisiblePieLabel
            series["PieLabelStyle"] = "Disabled";
        }

        private void barchartCountStudentsByGrade()
        {
            int FB = Dashboard.TopByMajor("Finance and Banking");
            int Acc = Dashboard.TopByMajor("Accounting");
            int CSE = Dashboard.TopByMajor("Computer Science and Engineering");
            int ENG = Dashboard.TopByMajor("English");
            int IB = Dashboard.TopByMajor("Internation Business");
            int BTI = Dashboard.TopByMajor("BusinessIT");
            int Fintech = Dashboard.TopByMajor("Fintech");
            int MM = Dashboard.TopByMajor("Management");
            //int ETI = Dashboard.TopByMajor("English for Translation and Interpreting");
            //int EBC = Dashboard.TopByMajor("English for Business Communication");
            //int BE = Dashboard.TopByMajor("Business Econimic");
            //int SML = Dashboard.TopByMajor("Supply Chain Management and Logistics");
            //int TEFL = Dashboard.TopByMajor("Teaching English as a Foreign Language");
            //int RMI = Dashboard.TopByMajor("Risk Management and Insurance");
            //int BEM = Dashboard.TopByMajor("Business and Enterprise Management");
            //int Law = Dashboard.TopByMajor("Law");
            //int Marking = Dashboard.TopByMajor("Marking");

            Series series = barTopmajor.Series["S3"];

            // Create a DataTable with columns Number and Grade
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Number", typeof(string));
            dataTable.Columns.Add("Major", typeof(int));
            barTopmajor.DataSource = dataTable;

            dataTable.Rows.Add("Finance and Banking", FB);
            dataTable.Rows.Add("Accounting", Acc);
            dataTable.Rows.Add("Computer Science and Engineering", CSE);
            dataTable.Rows.Add("English", ENG);
            dataTable.Rows.Add("Internation Business", IB);
            dataTable.Rows.Add("BusinessIT", BTI);
            dataTable.Rows.Add("Fintech", Fintech);
            dataTable.Rows.Add("Management", MM);
            //dataTable.Rows.Add("English for Translation and Interpreting", ETI);
            //dataTable.Rows.Add("English for Business Communication", EBC);
            //dataTable.Rows.Add("Business Econimic", BE);
            //dataTable.Rows.Add("Supply Chain Management and Logistics", SML);
            //dataTable.Rows.Add("Teaching English as a Foreign Language", TEFL);
            //dataTable.Rows.Add("Risk Management and Insurance", RMI);
            //dataTable.Rows.Add("Business and Enterprise Management", BEM);
            //dataTable.Rows.Add("Law", Law);
            //dataTable.Rows.Add("Marking", Marking);

            series["PixelPointWidth"] = "20"; //[ SET COLUMN WITH TO 30 PIXELS ]
            series.IsVisibleInLegend = false;

            series.XValueMember = "Number"; // Column name for X values
            series.YValueMembers = "Major"; // Column name for Y values

            //[ SET COLOR FOR EACH DATA POINT]
            //[ ADD POINTS OT THE SEIES ]
            series.Points.Clear();
            series.Points.AddXY("Finance and Banking", FB);
            series.Points.AddXY("Accounting", Acc);
            series.Points.AddXY("Computer Science and Engineering", CSE);
            series.Points.AddXY("English", ENG);
            series.Points.AddXY("Internation Business", IB);
            series.Points.AddXY("BusinessIT", BTI);
            series.Points.AddXY("Fintech", Fintech);
            series.Points.AddXY("Management", MM);
            //series.Points.AddXY("English for Translation and Interpreting", ETI);
            //series.Points.AddXY("English for Business Communication", EBC);
            //series.Points.AddXY("Business Econimic", BE);
            //series.Points.AddXY("Supply Chain Management and Logistics", SML);
            //series.Points.AddXY("Risk Management and Insurance", RMI);
            //series.Points.AddXY("Business and Enterprise Management", BEM);
            //series.Points.AddXY("Law", Law);
            //series.Points.AddXY("Marking", Marking);
        }
    }
}
