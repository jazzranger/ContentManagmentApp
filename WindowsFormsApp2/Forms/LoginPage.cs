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
            DocumentsManagment documentsManagment = new DocumentsManagment();
            documentsManagment.Show();

            //ApiOperations ops = new ApiOperations();

            //User user = ops.Auth();
            //if (user == null)
            //{
            //    MessageBox.Show("Invalid username or password");
            //    return;
            //}

            //Globals.LoggedInUser = user;
            //MessageBox.Show("Login successful");
            //DocumentsManagment documentsManagment1 = new DocumentsManagment();
        }
    }
}
