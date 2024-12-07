namespace WinFormsApp_WebEventPoster
{
    partial class TransactionMenu
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_ViewTicket = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBox_TotalPrice = new System.Windows.Forms.TextBox();
            this.cb_EventCity = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Price = new System.Windows.Forms.TextBox();
            this.txtBox_TransId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_ClientName = new System.Windows.Forms.ComboBox();
            this.cb_EventName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_EventCountry = new System.Windows.Forms.ComboBox();
            this.cb_EventCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_TicketLeft = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_AddTrans = new System.Windows.Forms.Button();
            this.txtBox_Qty = new System.Windows.Forms.TextBox();
            this.btn_UpdateTrans = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_DeleteTrans = new System.Windows.Forms.Button();
            this.btn_ClearTrans = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBox_MaxTicket = new System.Windows.Forms.TextBox();
            this.TransactID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransUpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ViewTicket)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_ViewTicket);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 366);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1453, 378);
            this.panel2.TabIndex = 60;
            // 
            // dataGridView_ViewTicket
            // 
            this.dataGridView_ViewTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ViewTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ViewTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactID,
            this.EventName,
            this.EventCategory,
            this.Country,
            this.City,
            this.ClientName,
            this.Quantity,
            this.Price,
            this.TotalPrice,
            this.TransDate,
            this.TransUpdateDate});
            this.dataGridView_ViewTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ViewTicket.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ViewTicket.Name = "dataGridView_ViewTicket";
            this.dataGridView_ViewTicket.ReadOnly = true;
            this.dataGridView_ViewTicket.RowHeadersWidth = 51;
            this.dataGridView_ViewTicket.RowTemplate.Height = 24;
            this.dataGridView_ViewTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ViewTicket.Size = new System.Drawing.Size(1453, 378);
            this.dataGridView_ViewTicket.TabIndex = 0;
            this.dataGridView_ViewTicket.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_ViewTicket_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtBox_MaxTicket);
            this.panel1.Controls.Add(this.txtBox_TotalPrice);
            this.panel1.Controls.Add(this.cb_EventCity);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBox_Price);
            this.panel1.Controls.Add(this.txtBox_TransId);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cb_ClientName);
            this.panel1.Controls.Add(this.cb_EventName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cb_EventCountry);
            this.panel1.Controls.Add(this.cb_EventCategory);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtBox_TicketLeft);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_AddTrans);
            this.panel1.Controls.Add(this.txtBox_Qty);
            this.panel1.Controls.Add(this.btn_UpdateTrans);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_DeleteTrans);
            this.panel1.Controls.Add(this.btn_ClearTrans);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1453, 360);
            this.panel1.TabIndex = 61;
            // 
            // txtBox_TotalPrice
            // 
            this.txtBox_TotalPrice.Location = new System.Drawing.Point(475, 300);
            this.txtBox_TotalPrice.Name = "txtBox_TotalPrice";
            this.txtBox_TotalPrice.ReadOnly = true;
            this.txtBox_TotalPrice.Size = new System.Drawing.Size(326, 22);
            this.txtBox_TotalPrice.TabIndex = 106;
            // 
            // cb_EventCity
            // 
            this.cb_EventCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_EventCity.FormattingEnabled = true;
            this.cb_EventCity.Location = new System.Drawing.Point(1010, 21);
            this.cb_EventCity.Name = "cb_EventCity";
            this.cb_EventCity.Size = new System.Drawing.Size(132, 24);
            this.cb_EventCity.TabIndex = 98;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(348, 300);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 105;
            this.label9.Text = "Total Price :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 83;
            this.label1.Text = "Trans ID :";
            // 
            // txtBox_Price
            // 
            this.txtBox_Price.Location = new System.Drawing.Point(475, 257);
            this.txtBox_Price.Name = "txtBox_Price";
            this.txtBox_Price.ReadOnly = true;
            this.txtBox_Price.Size = new System.Drawing.Size(326, 22);
            this.txtBox_Price.TabIndex = 104;
            // 
            // txtBox_TransId
            // 
            this.txtBox_TransId.Location = new System.Drawing.Point(82, 21);
            this.txtBox_TransId.Name = "txtBox_TransId";
            this.txtBox_TransId.ReadOnly = true;
            this.txtBox_TransId.Size = new System.Drawing.Size(122, 22);
            this.txtBox_TransId.TabIndex = 84;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(348, 257);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 103;
            this.label10.Text = "Price :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 85;
            this.label2.Text = "Event Name :";
            // 
            // cb_ClientName
            // 
            this.cb_ClientName.FormattingEnabled = true;
            this.cb_ClientName.Location = new System.Drawing.Point(475, 81);
            this.cb_ClientName.Name = "cb_ClientName";
            this.cb_ClientName.Size = new System.Drawing.Size(326, 24);
            this.cb_ClientName.Sorted = true;
            this.cb_ClientName.TabIndex = 102;
            this.cb_ClientName.TextChanged += new System.EventHandler(this.cb_ClientName_TextChanged);
            // 
            // cb_EventName
            // 
            this.cb_EventName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_EventName.FormattingEnabled = true;
            this.cb_EventName.Location = new System.Drawing.Point(351, 21);
            this.cb_EventName.Name = "cb_EventName";
            this.cb_EventName.Size = new System.Drawing.Size(205, 24);
            this.cb_EventName.TabIndex = 86;
            this.cb_EventName.SelectedIndexChanged += new System.EventHandler(this.cb_EventName_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 101;
            this.label8.Text = "Client Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 87;
            this.label3.Text = "Event Category :";
            // 
            // cb_EventCountry
            // 
            this.cb_EventCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_EventCountry.FormattingEnabled = true;
            this.cb_EventCountry.Location = new System.Drawing.Point(1311, 21);
            this.cb_EventCountry.Name = "cb_EventCountry";
            this.cb_EventCountry.Size = new System.Drawing.Size(130, 24);
            this.cb_EventCountry.TabIndex = 100;
            // 
            // cb_EventCategory
            // 
            this.cb_EventCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_EventCategory.FormattingEnabled = true;
            this.cb_EventCategory.Location = new System.Drawing.Point(727, 21);
            this.cb_EventCategory.Name = "cb_EventCategory";
            this.cb_EventCategory.Size = new System.Drawing.Size(140, 24);
            this.cb_EventCategory.TabIndex = 88;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1185, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 99;
            this.label6.Text = "Event At Country :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 89;
            this.label4.Text = "Ticket Left :";
            // 
            // txtBox_TicketLeft
            // 
            this.txtBox_TicketLeft.Location = new System.Drawing.Point(475, 168);
            this.txtBox_TicketLeft.Name = "txtBox_TicketLeft";
            this.txtBox_TicketLeft.ReadOnly = true;
            this.txtBox_TicketLeft.Size = new System.Drawing.Size(326, 22);
            this.txtBox_TicketLeft.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(903, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 97;
            this.label7.Text = "Event At City :";
            // 
            // btn_AddTrans
            // 
            this.btn_AddTrans.Location = new System.Drawing.Point(885, 85);
            this.btn_AddTrans.Name = "btn_AddTrans";
            this.btn_AddTrans.Size = new System.Drawing.Size(184, 53);
            this.btn_AddTrans.TabIndex = 91;
            this.btn_AddTrans.Text = "Add";
            this.btn_AddTrans.UseVisualStyleBackColor = true;
            this.btn_AddTrans.Click += new System.EventHandler(this.btn_AddTrans_Click);
            // 
            // txtBox_Qty
            // 
            this.txtBox_Qty.Location = new System.Drawing.Point(475, 214);
            this.txtBox_Qty.Name = "txtBox_Qty";
            this.txtBox_Qty.Size = new System.Drawing.Size(326, 22);
            this.txtBox_Qty.TabIndex = 96;
            this.txtBox_Qty.TextChanged += new System.EventHandler(this.txtBox_Qty_TextChanged);
            // 
            // btn_UpdateTrans
            // 
            this.btn_UpdateTrans.Location = new System.Drawing.Point(885, 143);
            this.btn_UpdateTrans.Name = "btn_UpdateTrans";
            this.btn_UpdateTrans.Size = new System.Drawing.Size(184, 53);
            this.btn_UpdateTrans.TabIndex = 92;
            this.btn_UpdateTrans.Text = "Update";
            this.btn_UpdateTrans.UseVisualStyleBackColor = true;
            this.btn_UpdateTrans.Click += new System.EventHandler(this.btn_UpdateTrans_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 95;
            this.label5.Text = "Quantity :";
            // 
            // btn_DeleteTrans
            // 
            this.btn_DeleteTrans.Location = new System.Drawing.Point(885, 201);
            this.btn_DeleteTrans.Name = "btn_DeleteTrans";
            this.btn_DeleteTrans.Size = new System.Drawing.Size(184, 53);
            this.btn_DeleteTrans.TabIndex = 93;
            this.btn_DeleteTrans.Text = "Delete";
            this.btn_DeleteTrans.UseVisualStyleBackColor = true;
            this.btn_DeleteTrans.Click += new System.EventHandler(this.btn_DeleteTrans_Click);
            // 
            // btn_ClearTrans
            // 
            this.btn_ClearTrans.Location = new System.Drawing.Point(885, 259);
            this.btn_ClearTrans.Name = "btn_ClearTrans";
            this.btn_ClearTrans.Size = new System.Drawing.Size(184, 53);
            this.btn_ClearTrans.TabIndex = 94;
            this.btn_ClearTrans.Text = "Clear";
            this.btn_ClearTrans.UseVisualStyleBackColor = true;
            this.btn_ClearTrans.Click += new System.EventHandler(this.btn_ClearTrans_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(348, 125);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 107;
            this.label11.Text = "Max Ticket :";
            // 
            // txtBox_MaxTicket
            // 
            this.txtBox_MaxTicket.Location = new System.Drawing.Point(475, 125);
            this.txtBox_MaxTicket.Name = "txtBox_MaxTicket";
            this.txtBox_MaxTicket.ReadOnly = true;
            this.txtBox_MaxTicket.Size = new System.Drawing.Size(326, 22);
            this.txtBox_MaxTicket.TabIndex = 108;
            // 
            // TransactID
            // 
            this.TransactID.HeaderText = "Transact ID";
            this.TransactID.MinimumWidth = 6;
            this.TransactID.Name = "TransactID";
            this.TransactID.ReadOnly = true;
            // 
            // EventName
            // 
            this.EventName.HeaderText = "Event Name";
            this.EventName.MinimumWidth = 6;
            this.EventName.Name = "EventName";
            this.EventName.ReadOnly = true;
            // 
            // EventCategory
            // 
            this.EventCategory.HeaderText = "Event Category";
            this.EventCategory.MinimumWidth = 6;
            this.EventCategory.Name = "EventCategory";
            this.EventCategory.ReadOnly = true;
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.MinimumWidth = 6;
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // ClientName
            // 
            this.ClientName.HeaderText = "Client Name";
            this.ClientName.MinimumWidth = 6;
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // TransDate
            // 
            this.TransDate.HeaderText = "Transaction Date";
            this.TransDate.MinimumWidth = 6;
            this.TransDate.Name = "TransDate";
            this.TransDate.ReadOnly = true;
            // 
            // TransUpdateDate
            // 
            this.TransUpdateDate.HeaderText = "Transaction Update Date";
            this.TransUpdateDate.MinimumWidth = 6;
            this.TransUpdateDate.Name = "TransUpdateDate";
            this.TransUpdateDate.ReadOnly = true;
            // 
            // TransactionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 744);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "TransactionMenu";
            this.Text = "Ticket Venue";
            this.Load += new System.EventHandler(this.TransactionMenu_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ViewTicket)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_ViewTicket;
        private System.Windows.Forms.TextBox txtBox_TotalPrice;
        private System.Windows.Forms.ComboBox cb_EventCity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Price;
        private System.Windows.Forms.TextBox txtBox_TransId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_ClientName;
        private System.Windows.Forms.ComboBox cb_EventName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_EventCountry;
        private System.Windows.Forms.ComboBox cb_EventCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_TicketLeft;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_AddTrans;
        private System.Windows.Forms.TextBox txtBox_Qty;
        private System.Windows.Forms.Button btn_UpdateTrans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_DeleteTrans;
        private System.Windows.Forms.Button btn_ClearTrans;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransUpdateDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBox_MaxTicket;
    }
}