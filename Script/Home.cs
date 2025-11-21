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
    public partial class Home : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-KOH7KUV\SQLEXPRESS;Initial Catalog=""ATMManagement System"";Integrated Security=True;Trust Server Certificate=True");

        public Home()
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

        private void btnBalnce_Click(object sender, EventArgs e)
        {
            CheckBalance objcheckBalance = new CheckBalance();
            objcheckBalance.Show();
            this.Hide();
        }

        private void btnChangePIN_Click(object sender, EventArgs e)
        {
            ChangePIN objChangePIN = new ChangePIN();
            objChangePIN.Show();
            this.Hide();
        }

        private void btnFastCash_Click(object sender, EventArgs e)
        {
            FastCash objFastCash = new FastCash();
            objFastCash.Show();
            this.Hide();
        }
       
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Deposit objDeposit = new Deposit();
            objDeposit.Show();
            this.Hide();
        }
        //To show account number on other form like on check balance form
        public static string AccountNumber;
        private void Home_Load(object sender, EventArgs e)
        {
            //to show account number which we enter at the time of loging
            lblAccountNumber.Text = "Account Number:" + Login.AccountNumber;
        }

        private void btnWithDraw_Click(object sender, EventArgs e)
        {
            WithDraw objWithdraw = new WithDraw();
            objWithdraw.Show();
            this.Hide();
        }

        private void btnMiniStatement_Click(object sender, EventArgs e)
        {
            MiniStatement objMiniStatement = new MiniStatement();
            objMiniStatement.Show();
            this.Hide();
        }
    }
}
