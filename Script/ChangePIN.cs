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

namespace ATM_Management_System
{
    public partial class ChangePIN : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-KOH7KUV\SQLEXPRESS;Initial Catalog=""ATMManagement System"";Integrated Security=True;Trust Server Certificate=True");

        public ChangePIN()
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
            this.Hide();
        }


        private void btnChange_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPIN.Text.Trim()))
            {
                MessageBox.Show("Please Enter New PIN");
            }
            string userAccount = Login.AccountNumber;
            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand("UPDATE SiginUpInfo SET userPIN = '"+txtNewPIN.Text+"' WHERE userAccountNumber = @UserAccount", sqlcon);
            sqlcmd.Parameters.AddWithValue("@NewAmount", Convert.ToDecimal(txtNewPIN.Text));
            sqlcmd.Parameters.AddWithValue("@UserAccount", userAccount);
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("PIN Change Successfully");
        }
    }
}
