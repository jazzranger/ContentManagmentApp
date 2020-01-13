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
        ApiOperations ops;

        public DocumentDetails()
        {
            InitializeComponent();
            var doc = Globals.selectedDoc;
            ops = new ApiOperations();
            User user = Globals.LoggedInUser;
            var result = ops.GetDoc(user, doc.ObjectID).Result;

            ListViewItem item = new ListViewItem("FileName");
            item.SubItems.Add(result.FileName);
            DetailsView.Items.Add(item);

            for (int i = 0; i < doc.Fields.Count; i++)
            {
                ListViewItem val = new ListViewItem(doc.Fields[i].Title);
                val.SubItems.Add(doc.Fields[i].Value);
                DetailsView.Items.Add(val);
            }
        }

        private void RefuseButton_Click(object sender, EventArgs e)
        {
            if(ops.Refuse().Result)
                MessageBox.Show("Document is refuse");
            else
                MessageBox.Show("Document is not refuse");
        }

        private void ValidateButton_Click(object sender, EventArgs e)
        {
            if (ops.Validate().Result)
                MessageBox.Show("Document is validate");
            else
                MessageBox.Show("Document is not validate");
        }
    }
}
