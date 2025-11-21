using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ATM_Management_System
{
    public partial class CheckBalance : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-KOH7KUV\SQLEXPRESS;Initial Catalog=""ATMManagement System"";Integrated Security=True;Trust Server Certificate=True");

        public CheckBalance()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Main objMain = new Main();
            objMain.Show();
            this.Close();
        }
        
        private void CheckBalance_Load(object sender, EventArgs e)
        {
            lblAccountNumber.Text =  Login.AccountNumber;
            //method to check balance
            checkBalance();
        }
        private void checkBalance()
        {
            
            sqlcon.Open();
            SqlDataAdapter sqlSDA = new SqlDataAdapter("Select userBalance From SiginUpInfo Where userAccountNumber='"+lblAccountNumber.Text+"' ",sqlcon);
            DataTable dt = new DataTable();
            sqlSDA.Fill(dt);
            lblUserBalance.Text = dt.Rows[0][0].ToString();
            sqlcon.Close();
        }
    }
}
