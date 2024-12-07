namespace WinFormsApp_WebEventPoster
{
    partial class ViewCity
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
            this.dataGridView_ViewCity = new System.Windows.Forms.DataGridView();
            this.CityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ViewCity)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ViewCity
            // 
            this.dataGridView_ViewCity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ViewCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ViewCity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CityID,
            this.CityName,
            this.CountryName});
            this.dataGridView_ViewCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ViewCity.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ViewCity.Name = "dataGridView_ViewCity";
            this.dataGridView_ViewCity.ReadOnly = true;
            this.dataGridView_ViewCity.RowHeadersWidth = 51;
            this.dataGridView_ViewCity.RowTemplate.Height = 24;
            this.dataGridView_ViewCity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ViewCity.Size = new System.Drawing.Size(800, 450);
            this.dataGridView_ViewCity.TabIndex = 0;
            this.dataGridView_ViewCity.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_ViewCity_MouseDoubleClick);
            // 
            // CityID
            // 
            this.CityID.HeaderText = "City ID";
            this.CityID.MinimumWidth = 6;
            this.CityID.Name = "CityID";
            this.CityID.ReadOnly = true;
            // 
            // CityName
            // 
            this.CityName.HeaderText = "City Name";
            this.CityName.MinimumWidth = 6;
            this.CityName.Name = "CityName";
            this.CityName.ReadOnly = true;
            // 
            // CountryName
            // 
            this.CountryName.HeaderText = "Country Name";
            this.CountryName.MinimumWidth = 6;
            this.CountryName.Name = "CountryName";
            this.CountryName.ReadOnly = true;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // ViewCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_ViewCity);
            this.Name = "ViewCity";
            this.Text = "ViewCity";
            this.Load += new System.EventHandler(this.ViewCity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ViewCity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ViewCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryName;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}