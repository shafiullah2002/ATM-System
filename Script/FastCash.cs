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
    public partial class FastCash : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-KOH7KUV\SQLEXPRESS;Initial Catalog=""ATMManagement System"";Integrated Security=True;Trust Server Certificate=True");

        public FastCash()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string userAccount = Login.AccountNumber;
       
        private void btnRS100_Click(object sender, EventArgs e)
        {

            int amountToCashOut = 100;

            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand("UPDATE SiginUpInfo SET userBalance = userBalance - @AmountToCashOut WHERE userAccountNumber = @UserAccount", sqlcon);
            sqlcmd.Parameters.AddWithValue("@AmountToCashOut", amountToCashOut);
            sqlcmd.Parameters.AddWithValue("@UserAccount", userAccount);
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            if (amountToCashOut >= 100)
            {
                MessageBox.Show("Cash Out Successfully");

            }
            else
            {

                MessageBox.Show("Insufficient Balance");

            }
            //For Mini Statement

            string Amount = "100";
            string TransactionType = "FastCash";
            sqlcon.Open();
            string AccountNumber = Login.AccountNumber;
            SqlCommand sqlCmd = new SqlCommand("INSERT INTO TransactionInfo (AccountNumber, Type, Amount, TransactionDate) VALUES (@AccountNumber, @TransactionType, @Amount, @TransactionDate)", sqlcon);

            sqlCmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            sqlCmd.Parameters.AddWithValue("@TransactionType", TransactionType);
            sqlCmd.Parameters.AddWithValue("@Amount", Amount);
            sqlCmd.Parameters.AddWithValue("@TransactionDate", DateTime.Today.Date);

            sqlCmd.ExecuteNonQuery();
            sqlcon.Close();


        }

        private void btnRS500_Click(object sender, EventArgs e)
        {

            int amountToCashOut = 500;
            if (amountToCashOut <= 500)
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("UPDATE SiginUpInfo SET userBalance = userBalance - @AmountToCashOut WHERE userAccountNumber = @UserAccount", sqlcon);
                sqlcmd.Parameters.AddWithValue("@AmountToCashOut", amountToCashOut);
                sqlcmd.Parameters.AddWithValue("@UserAccount", userAccount);
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("Cash Out Successfully");
            }
            else
            {
                MessageBox.Show("Insufficient Balance");

            }
            //For Mini Statement

            string Amount = "500";
            string TransactionType = "FastCash";
            sqlcon.Open();
            string AccountNumber = Login.AccountNumber;
            SqlCommand sqlCmd = new SqlCommand("INSERT INTO TransactionInfo (AccountNumber, Type, Amount, TransactionDate) VALUES (@AccountNumber, @TransactionType, @Amount, @TransactionDate)", sqlcon);

            sqlCmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            sqlCmd.Parameters.AddWithValue("@TransactionType", TransactionType);
            sqlCmd.Parameters.AddWithValue("@Amount", Amount);
            sqlCmd.Parameters.AddWithValue("@TransactionDate", DateTime.Today.Date);

            sqlCmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void btnRS1000_Click(object sender, EventArgs e)
        {

            int amountToCashOut = 1000;
            if (amountToCashOut <= 1000)
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("UPDATE SiginUpInfo SET userBalance = userBalance - @AmountToCashOut WHERE userAccountNumber = @UserAccount", sqlcon);
                sqlcmd.Parameters.AddWithValue("@AmountToCashOut", amountToCashOut);
                sqlcmd.Parameters.AddWithValue("@UserAccount", userAccount);
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("Cash Out Successfully");
            }
            else
            {
                MessageBox.Show("Insufficient Balance");

            }
            //For Mini Statement

            string Amount = "1000";
            string TransactionType = "FastCash";
            sqlcon.Open();
            string AccountNumber = Login.AccountNumber;
            SqlCommand sqlCmd = new SqlCommand("INSERT INTO TransactionInfo (AccountNumber, Type, Amount, TransactionDate) VALUES (@AccountNumber, @TransactionType, @Amount, @TransactionDate)", sqlcon);

            sqlCmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            sqlCmd.Parameters.AddWithValue("@TransactionType", TransactionType);
            sqlCmd.Parameters.AddWithValue("@Amount", Amount);
            sqlCmd.Parameters.AddWithValue("@TransactionDate", DateTime.Today.Date);

            sqlCmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void btnRS2000_Click(object sender, EventArgs e)
        {

            int amountToCashOut = 2000;
            if (amountToCashOut <= 2000)
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("UPDATE SiginUpInfo SET userBalance = userBalance - @AmountToCashOut WHERE userAccountNumber = @UserAccount", sqlcon);
                sqlcmd.Parameters.AddWithValue("@AmountToCashOut", amountToCashOut);
                sqlcmd.Parameters.AddWithValue("@UserAccount", userAccount);
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("Cash Out Successfully");
            }
            else
            {
                MessageBox.Show("Insufficient Balance");

            }
            //For Mini Statement

            string Amount = "2000";
            string TransactionType = "FastCash";
            sqlcon.Open();
            string AccountNumber = Login.AccountNumber;
            SqlCommand sqlCmd = new SqlCommand("INSERT INTO TransactionInfo (AccountNumber, Type, Amount, TransactionDate) VALUES (@AccountNumber, @TransactionType, @Amount, @TransactionDate)", sqlcon);

            sqlCmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            sqlCmd.Parameters.AddWithValue("@TransactionType", TransactionType);
            sqlCmd.Parameters.AddWithValue("@Amount", Amount);
            sqlCmd.Parameters.AddWithValue("@TransactionDate", DateTime.Today.Date);

            sqlCmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void btnRS5000_Click(object sender, EventArgs e)
        {

            int amountToCashOut = 5000;
            if (amountToCashOut <= 5000)
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("UPDATE SiginUpInfo SET userBalance = userBalance - @AmountToCashOut WHERE userAccountNumber = @UserAccount", sqlcon);
                sqlcmd.Parameters.AddWithValue("@AmountToCashOut", amountToCashOut);
                sqlcmd.Parameters.AddWithValue("@UserAccount", userAccount);
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("Cash Out Successfully");
            }
            else
            {
                MessageBox.Show("Insufficient Balance");

            }
            //For Mini Statement

            string Amount = "5000";
            string TransactionType = "FastCash";
            sqlcon.Open();
            string AccountNumber = Login.AccountNumber;
            SqlCommand sqlCmd = new SqlCommand("INSERT INTO TransactionInfo (AccountNumber, Type, Amount, TransactionDate) VALUES (@AccountNumber, @TransactionType, @Amount, @TransactionDate)", sqlcon);

            sqlCmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            sqlCmd.Parameters.AddWithValue("@TransactionType", TransactionType);
            sqlCmd.Parameters.AddWithValue("@Amount", Amount);
            sqlCmd.Parameters.AddWithValue("@TransactionDate", DateTime.Today.Date);

            sqlCmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void btnRS10000_Click(object sender, EventArgs e)
        {

            int amountToCashOut = 10000;
            if (amountToCashOut <= 10000)
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("UPDATE SiginUpInfo SET userBalance = userBalance - @AmountToCashOut WHERE userAccountNumber = @UserAccount", sqlcon);
                sqlcmd.Parameters.AddWithValue("@AmountToCashOut", amountToCashOut);
                sqlcmd.Parameters.AddWithValue("@UserAccount", userAccount);
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("Cash Out Successfully");
            }
            else
            {
                MessageBox.Show("Insufficient Balance");

            }
            //For Mini Statement

            string Amount = "10000";
            string TransactionType = "FastCash";
            sqlcon.Open();
            string AccountNumber = Login.AccountNumber;
            SqlCommand sqlCmd = new SqlCommand("INSERT INTO TransactionInfo (AccountNumber, Type, Amount, TransactionDate) VALUES (@AccountNumber, @TransactionType, @Amount, @TransactionDate)", sqlcon);

            sqlCmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            sqlCmd.Parameters.AddWithValue("@TransactionType", TransactionType);
            sqlCmd.Parameters.AddWithValue("@Amount", Amount);
            sqlCmd.Parameters.AddWithValue("@TransactionDate", DateTime.Today.Date);

            sqlCmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Main objMain = new Main();
            objMain.Show();
            this.Hide();
        }
    }
}
