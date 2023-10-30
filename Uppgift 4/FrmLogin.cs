using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_4
{
    public partial class FrmLogin : Form
    {

        public List<Admin> Admins;
        public bool IsLoginSuccessful;


        public FrmLogin(List<Admin>admins)
        {
            InitializeComponent();
            this.Admins = admins;
        }

        public bool SignIn()
        {
            string username = nameBox.Text.ToLower();
            string password = passwordBox.Text;

            foreach (var admin in Admins)
            {
                if (username == admin.Username.ToLower() && password == admin.Password)
                {
                    return true;
                }


            }
            return false;
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (SignIn())
            {
                IsLoginSuccessful = true;
                this.Close();
            }
            else
            {
                IsLoginSuccessful = false;
                MessageBox.Show("fel namn och eller lösenord.");
            }
        }
    }
}
