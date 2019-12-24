using System;

namespace ContentManagmentApp.Forms
{
    partial class DocumentsManagment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DocList = new MaterialSkin.Controls.MaterialListView();
            this.DocumentId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DocumentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DetailsButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // DocList
            // 
            this.DocList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DocumentId,
            this.DocumentName});
            this.DocList.Depth = 0;
            this.DocList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.DocList.ForeColor = System.Drawing.SystemColors.MenuText;
            this.DocList.FullRowSelect = true;
            this.DocList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.DocList.HideSelection = false;
            this.DocList.Location = new System.Drawing.Point(12, 80);
            this.DocList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DocList.MouseState = MaterialSkin.MouseState.OUT;
            this.DocList.Name = "DocList";
            this.DocList.OwnerDraw = true;
            this.DocList.Size = new System.Drawing.Size(553, 297);
            this.DocList.TabIndex = 3;
            this.DocList.UseCompatibleStateImageBehavior = false;
            this.DocList.View = System.Windows.Forms.View.Details;
            this.DocList.SelectedIndexChanged += new System.EventHandler(this.DocList_SelectedIndexChanged);
            // 
            // DocumentId
            // 
            this.DocumentId.Text = "Document Id";
            this.DocumentId.Width = 150;
            // 
            // DocumentName
            // 
            this.DocumentName.Text = "Document Name";
            this.DocumentName.Width = 200;
            // 
            // DetailsButton
            // 
            this.DetailsButton.AutoSize = true;
            this.DetailsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DetailsButton.Depth = 0;
            this.DetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailsButton.Icon = null;
            this.DetailsButton.Location = new System.Drawing.Point(571, 124);
            this.DetailsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Primary = true;
            this.DetailsButton.Size = new System.Drawing.Size(75, 36);
            this.DetailsButton.TabIndex = 4;
            this.DetailsButton.Text = "Details";
            this.DetailsButton.UseVisualStyleBackColor = true;
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // DocumentsManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.DocList);
            this.Name = "DocumentsManagment";
            this.Text = "DocumentsManagment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialListView DocList;
        private System.Windows.Forms.ColumnHeader DocumentId;
        private System.Windows.Forms.ColumnHeader DocumentName;
        private MaterialSkin.Controls.MaterialRaisedButton DetailsButton;
    }
}