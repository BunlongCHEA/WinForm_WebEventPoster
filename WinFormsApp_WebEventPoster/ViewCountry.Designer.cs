namespace WinFormsApp_WebEventPoster
{
    partial class ViewCountry
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
            this.dataGridView_ViewCountry = new System.Windows.Forms.DataGridView();
            this.CountryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ViewCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ViewCountry
            // 
            this.dataGridView_ViewCountry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ViewCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ViewCountry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CountryID,
            this.CountryName});
            this.dataGridView_ViewCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ViewCountry.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ViewCountry.Name = "dataGridView_ViewCountry";
            this.dataGridView_ViewCountry.ReadOnly = true;
            this.dataGridView_ViewCountry.RowHeadersWidth = 51;
            this.dataGridView_ViewCountry.RowTemplate.Height = 24;
            this.dataGridView_ViewCountry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ViewCountry.Size = new System.Drawing.Size(800, 450);
            this.dataGridView_ViewCountry.TabIndex = 0;
            this.dataGridView_ViewCountry.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_ViewCountry_MouseDoubleClick);
            // 
            // CountryID
            // 
            this.CountryID.HeaderText = "Country ID";
            this.CountryID.MinimumWidth = 6;
            this.CountryID.Name = "CountryID";
            this.CountryID.ReadOnly = true;
            // 
            // CountryName
            // 
            this.CountryName.HeaderText = "Country Name";
            this.CountryName.MinimumWidth = 6;
            this.CountryName.Name = "CountryName";
            this.CountryName.ReadOnly = true;
            // 
            // ViewCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_ViewCountry);
            this.Name = "ViewCountry";
            this.Text = "ViewCountry";
            this.Load += new System.EventHandler(this.ViewCountry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ViewCountry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ViewCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryName;
    }
}