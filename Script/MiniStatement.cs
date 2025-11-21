using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM_Management_System
{
    public partial class MiniStatement : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-KOH7KUV\SQLEXPRESS;Initial Catalog=""ATMManagement System"";Integrated Security=True;Trust Server Certificate=True");

        public MiniStatement()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string AccNumber = Login.AccountNumber;
       
      
        private void dgvMiniStatement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadMiniStatement();
        }
        private void loadMiniStatement()
        {
            dgvMiniStatement.Rows.Clear(); // clear old data

           
            sqlcon.Open();
            string Query = "Select * from TransactionInfo";
            SqlCommand sqlcmd = new SqlCommand(Query, sqlcon);
           
            var reader = sqlcmd.ExecuteReader();
          

            while (reader.Read())
            {
                dgvMiniStatement.Rows.Add(reader["TransactionID"], reader["AccountNumber"], reader["Type"], reader["Amount"], reader["TransactionDate"]);
            }
          


        }

        private void MiniStatement_Load(object sender, EventArgs e)
        {
            loadMiniStatement();
        }
    }
}
