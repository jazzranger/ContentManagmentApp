using ContentManagmentApp.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContentManagmentApp.Forms
{
    public partial class DocumentDetails : MaterialForm
    {
        string doc;
        public DocumentDetails()
        {
            InitializeComponent();
            doc = Globals.selectedDoc;
        }
    }
}
