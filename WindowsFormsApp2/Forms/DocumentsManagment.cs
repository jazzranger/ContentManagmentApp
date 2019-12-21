using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WpfApp2.Models;
using WpfApp2.Operations;

namespace WindowsFormsApp2.Forms
{
    public partial class DocumentsManagment : Form
    {
        public DocumentsManagment()
        {
            InitializeComponent();
            ApiOperations ops = new ApiOperations();
            User user = Globals.LoggedInUser;
            //var lettres = ops.GetBox(user).Result;
            var lettres = ops.GetList();

        }
    }
}
