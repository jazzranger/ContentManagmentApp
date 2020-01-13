using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContentManagmentApp.Forms;
using ContentManagmentApp.Models;
using MaterialSkin.Controls;

namespace ContentManagmentApp.Forms
{
    public partial class LoginPage : MaterialForm
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            ApiOperations ops = new ApiOperations();

            var username = materialSingleLineTextField1.Text;
            var password = materialSingleLineTextField2.Text;

            User user = ops.Auth(username, password);
            if (user == null)
            {
                MessageBox.Show("Invalid username or password");
                return;
            }
            else
            {
                Globals.LoggedInUser = user;
                MessageBox.Show("Login successful");

                this.Hide();
                DocumentsManagment documentsManagment = new DocumentsManagment();
                documentsManagment.Show();
            }           
        }
    }
}
