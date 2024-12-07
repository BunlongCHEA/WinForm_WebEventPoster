namespace WinFormsApp_WebEventPoster
{
    partial class ViewClient
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
            this.dataGridView_ViewClient = new System.Windows.Forms.DataGridView();
            this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ViewClient)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ViewClient
            // 
            this.dataGridView_ViewClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientID,
            this.FullName,
            this.Email,
            this.BirthDate});
            this.dataGridView_ViewClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ViewClient.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ViewClient.Name = "dataGridView_ViewClient";
            this.dataGridView_ViewClient.ReadOnly = true;
            this.dataGridView_ViewClient.RowHeadersWidth = 51;
            this.dataGridView_ViewClient.RowTemplate.Height = 24;
            this.dataGridView_ViewClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ViewClient.Size = new System.Drawing.Size(1137, 533);
            this.dataGridView_ViewClient.TabIndex = 0;
            this.dataGridView_ViewClient.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_ViewClient_MouseDoubleClick);
            // 
            // ClientID
            // 
            this.ClientID.HeaderText = "Client ID";
            this.ClientID.MinimumWidth = 6;
            this.ClientID.Name = "ClientID";
            this.ClientID.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "Birth Date";
            this.BirthDate.MinimumWidth = 6;
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            // 
            // ViewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 533);
            this.Controls.Add(this.dataGridView_ViewClient);
            this.Name = "ViewClient";
            this.Text = "ViewClient";
            this.Load += new System.EventHandler(this.ViewClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ViewClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ViewClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
    }
}