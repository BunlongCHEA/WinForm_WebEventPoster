namespace WinFormsApp_WebEventPoster
{
    partial class ViewEventCategory
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
            this.dataGridView_ViewEventCate = new System.Windows.Forms.DataGridView();
            this.EventCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ViewEventCate)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ViewEventCate
            // 
            this.dataGridView_ViewEventCate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ViewEventCate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ViewEventCate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventCategoryID,
            this.CategoryName});
            this.dataGridView_ViewEventCate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ViewEventCate.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ViewEventCate.Name = "dataGridView_ViewEventCate";
            this.dataGridView_ViewEventCate.ReadOnly = true;
            this.dataGridView_ViewEventCate.RowHeadersWidth = 51;
            this.dataGridView_ViewEventCate.RowTemplate.Height = 24;
            this.dataGridView_ViewEventCate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ViewEventCate.Size = new System.Drawing.Size(800, 450);
            this.dataGridView_ViewEventCate.TabIndex = 0;
            this.dataGridView_ViewEventCate.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_ViewEventCate_MouseDoubleClick);
            // 
            // EventCategoryID
            // 
            this.EventCategoryID.HeaderText = "Event Category ID";
            this.EventCategoryID.MinimumWidth = 6;
            this.EventCategoryID.Name = "EventCategoryID";
            this.EventCategoryID.ReadOnly = true;
            // 
            // CategoryName
            // 
            this.CategoryName.HeaderText = "Category Name";
            this.CategoryName.MinimumWidth = 6;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // ViewEventCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_ViewEventCate);
            this.Name = "ViewEventCategory";
            this.Text = "ViewEventCategory";
            this.Load += new System.EventHandler(this.ViewEventCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ViewEventCate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ViewEventCate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
    }
}