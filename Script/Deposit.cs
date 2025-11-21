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
    public partial class Deposit : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-KOH7KUV\SQLEXPRESS;Initial Catalog=""ATMManagement System"";Integrated Security=True;Trust Server Certificate=True");

        public Deposit()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrEmpty(txtAmount.Text.Trim()))
            {
                MessageBox.Show("Please Enter Amount");

            }
            string userAccount = Login.AccountNumber;
            sqlcon.Open();
            //to add balance 

            SqlCommand sqlcmd = new SqlCommand("UPDATE SiginUpInfo SET userBalance = userBalance + @NewAmount WHERE userAccountNumber = @UserAccount", sqlcon);
            sqlcmd.Parameters.AddWithValue("@NewAmount", Convert.ToDecimal(txtAmount.Text));
            sqlcmd.Parameters.AddWithValue("@UserAccount", userAccount);

            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("Amount Add Successfuly");
            addTransaction();

        }
        private void addTransaction()
        {
          
            string TransactionType = "Deposit";
            sqlcon.Open();
            string AccountNumber = Login.AccountNumber;
            SqlCommand sqlcmd = new SqlCommand("INSERT INTO TransactionInfo (AccountNumber, Type, Amount, TransactionDate) VALUES (@AccountNumber, @TransactionType, @Amount, @TransactionDate)", sqlcon);

            sqlcmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            sqlcmd.Parameters.AddWithValue("@TransactionType", TransactionType);
            sqlcmd.Parameters.AddWithValue("@Amount", txtAmount.Text);
            sqlcmd.Parameters.AddWithValue("@TransactionDate", DateTime.Today.Date);

            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();




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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void ldlAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
