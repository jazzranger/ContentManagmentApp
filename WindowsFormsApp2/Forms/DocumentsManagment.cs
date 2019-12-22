using ContentManagmentApp.Models;
using MaterialSkin;
using MaterialSkin.Controls;
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



namespace ContentManagmentApp.Forms
{
    public partial class DocumentsManagment : MaterialForm
    {
        public DocumentsManagment()
        {
            InitializeComponent();

            ApiOperations ops = new ApiOperations();
            User user = Globals.LoggedInUser;
            var lettres = ops.GetList();

            for (int i = 0; i < lettres.Count; i++)
            {
                ListViewItem item = new ListViewItem(lettres[i].ObjectID.ToString());
                item.SubItems.Add("Text");
                DocList.Items.Add(item);               
            }
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            if(DocList.SelectedItems.Count > 0)
            {
                Globals.selectedDoc = DocList.SelectedItems[0].Text;
                DocumentDetails documentDetails = new DocumentDetails();
                documentDetails.Show();
            }         
        }

        private void DocList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {

        }

        private void RefuseButton_Click(object sender, EventArgs e)
        {

        }
    }
}
