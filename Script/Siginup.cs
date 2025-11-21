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
    public partial class Siginup : Form
    {
        /// <summary>
        DBAccess objDBAccess = new DBAccess();
        /// </summary>
        
        public Siginup()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Siginup_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main objMain = new Main();
            objMain.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtAccoNo.Text.Trim()))
            {
                MessageBox.Show("Please Enter AccoNo");
            } 
            
            else if (string.IsNullOrEmpty(txtPIN.Text.Trim()))
            {
                MessageBox.Show("Please Enter PIN");
            } 
            else if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Please Enter Name");
            } 
            else if (string.IsNullOrEmpty(txtFatherName.Text.Trim()))
            {
                MessageBox.Show("Please Enter Father name");
            } 
            else if (string.IsNullOrEmpty(txtAddress.Text.Trim()))
            {
                MessageBox.Show("Please Enter Address");
            }
            else if (string.IsNullOrEmpty(txtPhoneNo.Text.Trim()))
            {
                MessageBox.Show("Please Enter PhoneNo");
            }
            else if (string.IsNullOrEmpty(txtBalance.Text.Trim()))
            {
                MessageBox.Show("Please Enter Balance");
            } 
            else if (string.IsNullOrEmpty(cmbEducation.Text.Trim()))
            {
                MessageBox.Show("Please Enter Education");
            } 
            else if (string.IsNullOrEmpty(cmbOccupation.Text.Trim()))
            {
                MessageBox.Show("Please Enter Occupation");
            } 
            else if (string.IsNullOrEmpty(dtpDOB.Text.Trim()))
            {
                MessageBox.Show("Please Enter DOB");
            }
            

            DBConnection();
        }
        private void DBConnection()
        {
            //to connect data and save data at database
            string userAccountNumber = txtAccoNo.Text.Trim();
            string userPIN = txtPIN.Text.Trim();
            string userName = txtName.Text.Trim();
            string userFatherNamne = txtFatherName.Text.Trim();
            string userAddress = txtAddress.Text.Trim();
            int userPhoneNumber = Convert.ToInt32(txtPhoneNo.Text.Trim());
           // int userPhoneNumber = Convert.ToInt32(txtPhoneNo.Text.Trim());
           // int userPhoneNumber = (int)Convert.ToInt64(txtPhoneNo.Text.Trim());

            int userBalance = Convert.ToInt32(txtBalance.Text.Trim());
            string userEducation = cmbEducation.Text.Trim();
            string userOccupation = cmbOccupation.Text.Trim();
            string userDOB = dtpDOB.Text.Trim();
            
            SqlCommand insetrCommand = new SqlCommand("insert into SiginUpInfo(userAccountNumber,userPIN,userName,userFatherName,userAddress,userPhoneNumber,userBalance,userEducation,userOccupation,userDOB)Values(@userAccountNumber,@userPIN,@userName,@userFatherNamne,@userAddress,@userPhoneNumber,@userBalance,@userEducation,@userOccupation,@userDOB)");
            insetrCommand.Parameters.AddWithValue("@userAccountNumber", userAccountNumber);
            insetrCommand.Parameters.AddWithValue("@userPIN", userPIN);
            insetrCommand.Parameters.AddWithValue("@userName", userName);
            insetrCommand.Parameters.AddWithValue("@userFatherNamne", userFatherNamne);
            insetrCommand.Parameters.AddWithValue("@userAddress", userAddress);
            insetrCommand.Parameters.AddWithValue("@userPhoneNumber", userPhoneNumber);
            insetrCommand.Parameters.AddWithValue("@userEducation", userEducation);
            insetrCommand.Parameters.AddWithValue("@userBalance", userBalance);
            insetrCommand.Parameters.AddWithValue("@userOccupation", userOccupation);
            insetrCommand.Parameters.AddWithValue("@userDOB", userDOB);
            int row = objDBAccess.executeQuery(insetrCommand);
            if (row == 1)
            {
                MessageBox.Show("User Data Add Successfully");

            }
            else
            {
                MessageBox.Show("Please Try Again");
            }


        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            //to add on mouce over function when mouce over the button color will change
            btnSave.BackColor=Color.Green;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            //to add on mouce leave function when mouce over the button color will change
            btnSave.BackColor = Color.DarkSlateGray;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            Main objMain = new Main();
            objMain.Show();
            this.Hide();
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            //to add on mouce over function when mouce over the button color will change
            btnLogout.BackColor = Color.Red;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            //to add on mouce leave function when mouce over the button color will change
            btnLogout.BackColor = Color.DarkSlateGray;
        }
    }
}
