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
using System.Data;

namespace ATM_Management_System
{
    public partial class Login : Form
    {

        //DBAccess objDBAccess = new DBAccess();
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-KOH7KUV\SQLEXPRESS;Initial Catalog=""ATMManagement System"";Integrated Security=True;Trust Server Certificate=True");

        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Siginup objSiginup = new Siginup();
            objSiginup.Show();
            this.Hide();
        }
        //To show account number on other form like on home page
        public static string AccountNumber;
        private void btnLogin_Click(object sender, EventArgs e)
        {

            //valadation for login
            sqlcon.Open();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT count(*) FROM SiginUpInfo WHERE userAccountNumber = '" + txtAccNo.Text + "' AND userPIN = '" + txtPIN.Text + "'",sqlcon);
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);
            int count = Convert.ToInt32(dt.Rows[0][0]);

            if (count == 1)
            {
                AccountNumber = txtAccNo.Text;
                Home objHome = new Home();
                objHome.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Try Again");
            }

            sqlcon.Close();

        }
    }
}
