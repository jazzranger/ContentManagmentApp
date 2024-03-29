﻿namespace ContentManagmentApp.Forms
{
    partial class DocumentDetails
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
            this.RefuseButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ValidateButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DetailsView = new MaterialSkin.Controls.MaterialListView();
            this.Property = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // RefuseButton
            // 
            this.RefuseButton.AutoSize = true;
            this.RefuseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RefuseButton.Depth = 0;
            this.RefuseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefuseButton.Icon = null;
            this.RefuseButton.Location = new System.Drawing.Point(641, 157);
            this.RefuseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RefuseButton.Name = "RefuseButton";
            this.RefuseButton.Primary = true;
            this.RefuseButton.Size = new System.Drawing.Size(70, 36);
            this.RefuseButton.TabIndex = 8;
            this.RefuseButton.Text = "Refuse";
            this.RefuseButton.UseVisualStyleBackColor = true;
            this.RefuseButton.Click += new System.EventHandler(this.RefuseButton_Click);
            // 
            // ValidateButton
            // 
            this.ValidateButton.AutoSize = true;
            this.ValidateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ValidateButton.Depth = 0;
            this.ValidateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ValidateButton.Icon = null;
            this.ValidateButton.Location = new System.Drawing.Point(641, 101);
            this.ValidateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ValidateButton.Name = "ValidateButton";
            this.ValidateButton.Primary = true;
            this.ValidateButton.Size = new System.Drawing.Size(84, 36);
            this.ValidateButton.TabIndex = 7;
            this.ValidateButton.Text = "Validate";
            this.ValidateButton.UseVisualStyleBackColor = true;
            this.ValidateButton.Click += new System.EventHandler(this.ValidateButton_Click);
            // 
            // DetailsView
            // 
            this.DetailsView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetailsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Property,
            this.Value});
            this.DetailsView.Depth = 0;
            this.DetailsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.DetailsView.FullRowSelect = true;
            this.DetailsView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.DetailsView.HideSelection = false;
            this.DetailsView.Location = new System.Drawing.Point(42, 76);
            this.DetailsView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DetailsView.MouseState = MaterialSkin.MouseState.OUT;
            this.DetailsView.Name = "DetailsView";
            this.DetailsView.OwnerDraw = true;
            this.DetailsView.Size = new System.Drawing.Size(410, 401);
            this.DetailsView.TabIndex = 9;
            this.DetailsView.UseCompatibleStateImageBehavior = false;
            this.DetailsView.View = System.Windows.Forms.View.Details;
            // 
            // Property
            // 
            this.Property.Text = "Property";
            this.Property.Width = 200;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 200;
            // 
            // DocumentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.DetailsView);
            this.Controls.Add(this.RefuseButton);
            this.Controls.Add(this.ValidateButton);
            this.Name = "DocumentDetails";
            this.Text = "DocumentDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton RefuseButton;
        private MaterialSkin.Controls.MaterialRaisedButton ValidateButton;
        private MaterialSkin.Controls.MaterialListView DetailsView;
        private System.Windows.Forms.ColumnHeader Property;
        private System.Windows.Forms.ColumnHeader Value;
    }
}