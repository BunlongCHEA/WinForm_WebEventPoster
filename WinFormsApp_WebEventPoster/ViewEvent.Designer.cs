namespace WinFormsApp_WebEventPoster
{
    partial class ViewEvent
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
            this.dataGridView_ViewEvent = new System.Windows.Forms.DataGridView();
            this.EventID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descriptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosterURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeRestrict = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ViewEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ViewEvent
            // 
            this.dataGridView_ViewEvent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ViewEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ViewEvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventID,
            this.EventName,
            this.EventDate,
            this.EventTime,
            this.EventLocation,
            this.MaxTicket,
            this.Price,
            this.Descriptions,
            this.PosterURL,
            this.AgeRestrict});
            this.dataGridView_ViewEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ViewEvent.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ViewEvent.Name = "dataGridView_ViewEvent";
            this.dataGridView_ViewEvent.ReadOnly = true;
            this.dataGridView_ViewEvent.RowHeadersWidth = 51;
            this.dataGridView_ViewEvent.RowTemplate.Height = 24;
            this.dataGridView_ViewEvent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ViewEvent.Size = new System.Drawing.Size(1112, 450);
            this.dataGridView_ViewEvent.TabIndex = 0;
            this.dataGridView_ViewEvent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_ViewEvent_MouseDoubleClick);
            // 
            // EventID
            // 
            this.EventID.HeaderText = "Event ID";
            this.EventID.MinimumWidth = 6;
            this.EventID.Name = "EventID";
            this.EventID.ReadOnly = true;
            // 
            // EventName
            // 
            this.EventName.HeaderText = "Event Name";
            this.EventName.MinimumWidth = 6;
            this.EventName.Name = "EventName";
            this.EventName.ReadOnly = true;
            // 
            // EventDate
            // 
            this.EventDate.HeaderText = "Event Date";
            this.EventDate.MinimumWidth = 6;
            this.EventDate.Name = "EventDate";
            this.EventDate.ReadOnly = true;
            // 
            // EventTime
            // 
            this.EventTime.HeaderText = "Event Time";
            this.EventTime.MinimumWidth = 6;
            this.EventTime.Name = "EventTime";
            this.EventTime.ReadOnly = true;
            // 
            // EventLocation
            // 
            this.EventLocation.HeaderText = "Event Location";
            this.EventLocation.MinimumWidth = 6;
            this.EventLocation.Name = "EventLocation";
            this.EventLocation.ReadOnly = true;
            // 
            // MaxTicket
            // 
            this.MaxTicket.HeaderText = "Max Ticket";
            this.MaxTicket.MinimumWidth = 6;
            this.MaxTicket.Name = "MaxTicket";
            this.MaxTicket.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Descriptions
            // 
            this.Descriptions.HeaderText = "Descriptions";
            this.Descriptions.MinimumWidth = 6;
            this.Descriptions.Name = "Descriptions";
            this.Descriptions.ReadOnly = true;
            // 
            // PosterURL
            // 
            this.PosterURL.HeaderText = "Poster URL";
            this.PosterURL.MinimumWidth = 6;
            this.PosterURL.Name = "PosterURL";
            this.PosterURL.ReadOnly = true;
            // 
            // AgeRestrict
            // 
            this.AgeRestrict.HeaderText = "Age Restrict";
            this.AgeRestrict.MinimumWidth = 6;
            this.AgeRestrict.Name = "AgeRestrict";
            this.AgeRestrict.ReadOnly = true;
            // 
            // ViewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 450);
            this.Controls.Add(this.dataGridView_ViewEvent);
            this.Name = "ViewEvent";
            this.Text = "ViewEvent";
            this.Load += new System.EventHandler(this.ViewEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ViewEvent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ViewEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descriptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosterURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeRestrict;
    }
}