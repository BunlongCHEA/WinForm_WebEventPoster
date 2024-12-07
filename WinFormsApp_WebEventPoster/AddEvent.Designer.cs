namespace WinFormsApp_WebEventPoster
{
    partial class AddEvent
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
            this.btn_ClearCity = new System.Windows.Forms.Button();
            this.txtBox_EventID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_DotViewCity = new System.Windows.Forms.Button();
            this.btn_DeleteCity = new System.Windows.Forms.Button();
            this.btn_UpdateCity = new System.Windows.Forms.Button();
            this.btn_AddCity = new System.Windows.Forms.Button();
            this.txtBox_EventName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPicker_EventDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_EventTime_Hour = new System.Windows.Forms.ComboBox();
            this.cb_EventTime_Minute = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBox_Description = new System.Windows.Forms.TextBox();
            this.txtBox_PosterUrl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBox_EventLocation = new System.Windows.Forms.TextBox();
            this.cb_AgeRestict = new System.Windows.Forms.ComboBox();
            this.txtBox_Price = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBox_MaxTicket = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ClearCity
            // 
            this.btn_ClearCity.Location = new System.Drawing.Point(537, 576);
            this.btn_ClearCity.Name = "btn_ClearCity";
            this.btn_ClearCity.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearCity.TabIndex = 36;
            this.btn_ClearCity.Text = "Clear";
            this.btn_ClearCity.UseVisualStyleBackColor = true;
            this.btn_ClearCity.Click += new System.EventHandler(this.btn_ClearCity_Click);
            // 
            // txtBox_EventID
            // 
            this.txtBox_EventID.Location = new System.Drawing.Point(277, 25);
            this.txtBox_EventID.Name = "txtBox_EventID";
            this.txtBox_EventID.ReadOnly = true;
            this.txtBox_EventID.Size = new System.Drawing.Size(326, 22);
            this.txtBox_EventID.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Event ID :";
            // 
            // btn_DotViewCity
            // 
            this.btn_DotViewCity.Location = new System.Drawing.Point(618, 25);
            this.btn_DotViewCity.Name = "btn_DotViewCity";
            this.btn_DotViewCity.Size = new System.Drawing.Size(39, 23);
            this.btn_DotViewCity.TabIndex = 33;
            this.btn_DotViewCity.Text = "...";
            this.btn_DotViewCity.UseVisualStyleBackColor = true;
            this.btn_DotViewCity.Click += new System.EventHandler(this.btn_DotViewCity_Click);
            // 
            // btn_DeleteCity
            // 
            this.btn_DeleteCity.Location = new System.Drawing.Point(419, 576);
            this.btn_DeleteCity.Name = "btn_DeleteCity";
            this.btn_DeleteCity.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteCity.TabIndex = 32;
            this.btn_DeleteCity.Text = "Delete";
            this.btn_DeleteCity.UseVisualStyleBackColor = true;
            this.btn_DeleteCity.Click += new System.EventHandler(this.btn_DeleteCity_Click);
            // 
            // btn_UpdateCity
            // 
            this.btn_UpdateCity.Location = new System.Drawing.Point(305, 576);
            this.btn_UpdateCity.Name = "btn_UpdateCity";
            this.btn_UpdateCity.Size = new System.Drawing.Size(75, 23);
            this.btn_UpdateCity.TabIndex = 31;
            this.btn_UpdateCity.Text = "Update";
            this.btn_UpdateCity.UseVisualStyleBackColor = true;
            this.btn_UpdateCity.Click += new System.EventHandler(this.btn_UpdateCity_Click);
            // 
            // btn_AddCity
            // 
            this.btn_AddCity.Location = new System.Drawing.Point(197, 576);
            this.btn_AddCity.Name = "btn_AddCity";
            this.btn_AddCity.Size = new System.Drawing.Size(75, 23);
            this.btn_AddCity.TabIndex = 30;
            this.btn_AddCity.Text = "Add";
            this.btn_AddCity.UseVisualStyleBackColor = true;
            this.btn_AddCity.Click += new System.EventHandler(this.btn_AddCity_Click);
            // 
            // txtBox_EventName
            // 
            this.txtBox_EventName.Location = new System.Drawing.Point(277, 74);
            this.txtBox_EventName.Name = "txtBox_EventName";
            this.txtBox_EventName.Size = new System.Drawing.Size(326, 22);
            this.txtBox_EventName.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Event Location :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Event Name :";
            // 
            // dtPicker_EventDate
            // 
            this.dtPicker_EventDate.Location = new System.Drawing.Point(277, 126);
            this.dtPicker_EventDate.Name = "dtPicker_EventDate";
            this.dtPicker_EventDate.Size = new System.Drawing.Size(326, 22);
            this.dtPicker_EventDate.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Event Date :";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Event Time :";
            // 
            // cb_EventTime_Hour
            // 
            this.cb_EventTime_Hour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_EventTime_Hour.FormattingEnabled = true;
            this.cb_EventTime_Hour.Location = new System.Drawing.Point(277, 181);
            this.cb_EventTime_Hour.Name = "cb_EventTime_Hour";
            this.cb_EventTime_Hour.Size = new System.Drawing.Size(76, 24);
            this.cb_EventTime_Hour.TabIndex = 42;
            // 
            // cb_EventTime_Minute
            // 
            this.cb_EventTime_Minute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_EventTime_Minute.FormattingEnabled = true;
            this.cb_EventTime_Minute.Location = new System.Drawing.Point(409, 181);
            this.cb_EventTime_Minute.Name = "cb_EventTime_Minute";
            this.cb_EventTime_Minute.Size = new System.Drawing.Size(76, 24);
            this.cb_EventTime_Minute.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 184);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = ":";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 403);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "Description :";
            // 
            // txtBox_Description
            // 
            this.txtBox_Description.Location = new System.Drawing.Point(275, 403);
            this.txtBox_Description.Name = "txtBox_Description";
            this.txtBox_Description.Size = new System.Drawing.Size(326, 22);
            this.txtBox_Description.TabIndex = 46;
            // 
            // txtBox_PosterUrl
            // 
            this.txtBox_PosterUrl.Location = new System.Drawing.Point(275, 459);
            this.txtBox_PosterUrl.Name = "txtBox_PosterUrl";
            this.txtBox_PosterUrl.Size = new System.Drawing.Size(326, 22);
            this.txtBox_PosterUrl.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 459);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "Poster URL :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 517);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 49;
            this.label9.Text = "Age Restriction :";
            // 
            // txtBox_EventLocation
            // 
            this.txtBox_EventLocation.Location = new System.Drawing.Point(277, 234);
            this.txtBox_EventLocation.Name = "txtBox_EventLocation";
            this.txtBox_EventLocation.Size = new System.Drawing.Size(326, 22);
            this.txtBox_EventLocation.TabIndex = 51;
            // 
            // cb_AgeRestict
            // 
            this.cb_AgeRestict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_AgeRestict.FormattingEnabled = true;
            this.cb_AgeRestict.Location = new System.Drawing.Point(275, 514);
            this.cb_AgeRestict.Name = "cb_AgeRestict";
            this.cb_AgeRestict.Size = new System.Drawing.Size(326, 24);
            this.cb_AgeRestict.TabIndex = 52;
            // 
            // txtBox_Price
            // 
            this.txtBox_Price.Location = new System.Drawing.Point(277, 346);
            this.txtBox_Price.Name = "txtBox_Price";
            this.txtBox_Price.Size = new System.Drawing.Size(326, 22);
            this.txtBox_Price.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(150, 346);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 16);
            this.label10.TabIndex = 55;
            this.label10.Text = "Price Per Ticket :";
            // 
            // txtBox_MaxTicket
            // 
            this.txtBox_MaxTicket.Location = new System.Drawing.Point(277, 290);
            this.txtBox_MaxTicket.Name = "txtBox_MaxTicket";
            this.txtBox_MaxTicket.Size = new System.Drawing.Size(326, 22);
            this.txtBox_MaxTicket.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(150, 290);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 53;
            this.label11.Text = "Max Ticket :";
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 621);
            this.Controls.Add(this.txtBox_Price);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBox_MaxTicket);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cb_AgeRestict);
            this.Controls.Add(this.txtBox_EventLocation);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBox_PosterUrl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBox_Description);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_EventTime_Minute);
            this.Controls.Add(this.cb_EventTime_Hour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtPicker_EventDate);
            this.Controls.Add(this.btn_ClearCity);
            this.Controls.Add(this.txtBox_EventID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_DotViewCity);
            this.Controls.Add(this.btn_DeleteCity);
            this.Controls.Add(this.btn_UpdateCity);
            this.Controls.Add(this.btn_AddCity);
            this.Controls.Add(this.txtBox_EventName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEvent";
            this.Text = "AddEvent";
            this.Load += new System.EventHandler(this.AddEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ClearCity;
        private System.Windows.Forms.TextBox txtBox_EventID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_DotViewCity;
        private System.Windows.Forms.Button btn_DeleteCity;
        private System.Windows.Forms.Button btn_UpdateCity;
        private System.Windows.Forms.Button btn_AddCity;
        private System.Windows.Forms.TextBox txtBox_EventName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPicker_EventDate;
        private System.Windows.Forms.Label label3;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_EventTime_Hour;
        private System.Windows.Forms.ComboBox cb_EventTime_Minute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBox_Description;
        private System.Windows.Forms.TextBox txtBox_PosterUrl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBox_EventLocation;
        private System.Windows.Forms.ComboBox cb_AgeRestict;
        private System.Windows.Forms.TextBox txtBox_Price;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBox_MaxTicket;
        private System.Windows.Forms.Label label11;
    }
}