﻿
namespace SecretStorage.src.forms
{
    /// <summary>
    /// Admin windows form
    /// </summary>
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.Disconnect = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.SqlTextBox = new System.Windows.Forms.TextBox();
            this.SqlLabel = new System.Windows.Forms.Label();
            this.SqlButton = new System.Windows.Forms.Button();
            this.UserListView = new System.Windows.Forms.ListView();
            this.IdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PasswordColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UsersLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.BtnAddImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Disconnect
            // 
            this.Disconnect.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disconnect.Location = new System.Drawing.Point(847, 12);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(125, 30);
            this.Disconnect.TabIndex = 0;
            this.Disconnect.Text = "Se déconnecter";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(10, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(238, 42);
            this.Title.TabIndex = 2;
            this.Title.Text = "Administrateur";
            // 
            // SqlTextBox
            // 
            this.SqlTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SqlTextBox.Location = new System.Drawing.Point(422, 313);
            this.SqlTextBox.Multiline = true;
            this.SqlTextBox.Name = "SqlTextBox";
            this.SqlTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SqlTextBox.Size = new System.Drawing.Size(550, 200);
            this.SqlTextBox.TabIndex = 3;
            // 
            // SqlLabel
            // 
            this.SqlLabel.AutoSize = true;
            this.SqlLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SqlLabel.Location = new System.Drawing.Point(622, 284);
            this.SqlLabel.Name = "SqlLabel";
            this.SqlLabel.Size = new System.Drawing.Size(149, 26);
            this.SqlLabel.TabIndex = 4;
            this.SqlLabel.Text = "Commande SQL";
            // 
            // SqlButton
            // 
            this.SqlButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SqlButton.Location = new System.Drawing.Point(847, 519);
            this.SqlButton.Name = "SqlButton";
            this.SqlButton.Size = new System.Drawing.Size(125, 30);
            this.SqlButton.TabIndex = 5;
            this.SqlButton.Text = "Exécuter";
            this.SqlButton.UseVisualStyleBackColor = true;
            this.SqlButton.Click += new System.EventHandler(this.SqlButton_Click);
            // 
            // UserListView
            // 
            this.UserListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColumn,
            this.NameColumn,
            this.PasswordColumn});
            this.UserListView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserListView.HideSelection = false;
            this.UserListView.Location = new System.Drawing.Point(17, 313);
            this.UserListView.Name = "UserListView";
            this.UserListView.Size = new System.Drawing.Size(384, 200);
            this.UserListView.TabIndex = 6;
            this.UserListView.UseCompatibleStateImageBehavior = false;
            // 
            // IdColumn
            // 
            this.IdColumn.Text = "Id";
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Nom";
            // 
            // PasswordColumn
            // 
            this.PasswordColumn.Text = "Mot de passe";
            // 
            // UsersLabel
            // 
            this.UsersLabel.AutoSize = true;
            this.UsersLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersLabel.Location = new System.Drawing.Point(151, 284);
            this.UsersLabel.Name = "UsersLabel";
            this.UsersLabel.Size = new System.Drawing.Size(110, 26);
            this.UsersLabel.TabIndex = 7;
            this.UsersLabel.Text = "Utilisateurs";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(151, 53);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(70, 26);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Nom : ";
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Image = global::SecretStorage.Properties.Resources.user;
            this.ProfilePicture.InitialImage = null;
            this.ProfilePicture.Location = new System.Drawing.Point(17, 53);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(128, 128);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePicture.TabIndex = 9;
            this.ProfilePicture.TabStop = false;
            // 
            // BtnAddImage
            // 
            this.BtnAddImage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddImage.Location = new System.Drawing.Point(17, 188);
            this.BtnAddImage.Name = "BtnAddImage";
            this.BtnAddImage.Size = new System.Drawing.Size(125, 30);
            this.BtnAddImage.TabIndex = 10;
            this.BtnAddImage.Text = "Photo de profil";
            this.BtnAddImage.UseVisualStyleBackColor = true;
            this.BtnAddImage.Click += new System.EventHandler(this.BtnAddImage_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.BtnAddImage);
            this.Controls.Add(this.ProfilePicture);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.UsersLabel);
            this.Controls.Add(this.UserListView);
            this.Controls.Add(this.SqlButton);
            this.Controls.Add(this.SqlLabel);
            this.Controls.Add(this.SqlTextBox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Disconnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox SqlTextBox;
        private System.Windows.Forms.Label SqlLabel;
        private System.Windows.Forms.Button SqlButton;
        private System.Windows.Forms.ListView UserListView;
        private System.Windows.Forms.Label UsersLabel;
        private System.Windows.Forms.ColumnHeader IdColumn;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader PasswordColumn;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox ProfilePicture;
        private System.Windows.Forms.Button BtnAddImage;
    }
}