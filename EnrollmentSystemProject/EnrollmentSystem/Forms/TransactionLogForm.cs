using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DocumentFormat.OpenXml.Office2019.Presentation;
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
    public partial class TransactionLogForm : Form
    {
        List<TransactionLog> transList = new List<TransactionLog>();
        public TransactionLogForm()
        {
            InitializeComponent();
        }

        private void TransactionLogForm_Load(object sender, EventArgs e)
        {
            TransactionLog transaction = new TransactionLog();
            List<TransactionLog> lsData = transaction.GetTransactionLogs();

            foreach(TransactionLog tran in lsData)
            {
                dgv_TransactionLog.Rows.Add(
                    tran.TranID,
                    tran.UserID,
                    tran.TranDate,
                    tran.Action,
                    tran.Table,
                    tran.Objective
                    );
            }
        }
    }
}
