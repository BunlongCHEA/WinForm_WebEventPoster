namespace WinFormsApp_WebEventPoster
{
    partial class AddClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_FullName = new System.Windows.Forms.TextBox();
            this.txtBox_Email = new System.Windows.Forms.TextBox();
            this.btn_AddClient = new System.Windows.Forms.Button();
            this.btn_UpdateClient = new System.Windows.Forms.Button();
            this.btn_DeleteClient = new System.Windows.Forms.Button();
            this.btn_DotViewClient = new System.Windows.Forms.Button();
            this.dtPicker_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtBox_ClientId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ClearClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birth Date :";
            // 
            // txtBox_FullName
            // 
            this.txtBox_FullName.Location = new System.Drawing.Point(187, 101);
            this.txtBox_FullName.Name = "txtBox_FullName";
            this.txtBox_FullName.Size = new System.Drawing.Size(326, 22);
            this.txtBox_FullName.TabIndex = 3;
            // 
            // txtBox_Email
            // 
            this.txtBox_Email.Location = new System.Drawing.Point(187, 148);
            this.txtBox_Email.Name = "txtBox_Email";
            this.txtBox_Email.Size = new System.Drawing.Size(326, 22);
            this.txtBox_Email.TabIndex = 4;
            // 
            // btn_AddClient
            // 
            this.btn_AddClient.Location = new System.Drawing.Point(108, 263);
            this.btn_AddClient.Name = "btn_AddClient";
            this.btn_AddClient.Size = new System.Drawing.Size(75, 23);
            this.btn_AddClient.TabIndex = 6;
            this.btn_AddClient.Text = "Add";
            this.btn_AddClient.UseVisualStyleBackColor = true;
            this.btn_AddClient.Click += new System.EventHandler(this.btn_AddClient_Click);
            // 
            // btn_UpdateClient
            // 
            this.btn_UpdateClient.Location = new System.Drawing.Point(216, 263);
            this.btn_UpdateClient.Name = "btn_UpdateClient";
            this.btn_UpdateClient.Size = new System.Drawing.Size(75, 23);
            this.btn_UpdateClient.TabIndex = 7;
            this.btn_UpdateClient.Text = "Update";
            this.btn_UpdateClient.UseVisualStyleBackColor = true;
            this.btn_UpdateClient.Click += new System.EventHandler(this.btn_UpdateClient_Click);
            // 
            // btn_DeleteClient
            // 
            this.btn_DeleteClient.Location = new System.Drawing.Point(330, 263);
            this.btn_DeleteClient.Name = "btn_DeleteClient";
            this.btn_DeleteClient.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteClient.TabIndex = 8;
            this.btn_DeleteClient.Text = "Delete";
            this.btn_DeleteClient.UseVisualStyleBackColor = true;
            this.btn_DeleteClient.Click += new System.EventHandler(this.btn_DeleteClient_Click);
            // 
            // btn_DotViewClient
            // 
            this.btn_DotViewClient.Location = new System.Drawing.Point(528, 52);
            this.btn_DotViewClient.Name = "btn_DotViewClient";
            this.btn_DotViewClient.Size = new System.Drawing.Size(39, 23);
            this.btn_DotViewClient.TabIndex = 10;
            this.btn_DotViewClient.Text = "...";
            this.btn_DotViewClient.UseVisualStyleBackColor = true;
            this.btn_DotViewClient.Click += new System.EventHandler(this.btn_DotViewClient_Click);
            // 
            // dtPicker_BirthDate
            // 
            this.dtPicker_BirthDate.Location = new System.Drawing.Point(187, 195);
            this.dtPicker_BirthDate.Name = "dtPicker_BirthDate";
            this.dtPicker_BirthDate.Size = new System.Drawing.Size(326, 22);
            this.dtPicker_BirthDate.TabIndex = 11;
            this.dtPicker_BirthDate.Value = new System.DateTime(2024, 3, 22, 16, 41, 4, 0);
            // 
            // txtBox_ClientId
            // 
            this.txtBox_ClientId.Location = new System.Drawing.Point(187, 52);
            this.txtBox_ClientId.Name = "txtBox_ClientId";
            this.txtBox_ClientId.ReadOnly = true;
            this.txtBox_ClientId.Size = new System.Drawing.Size(326, 22);
            this.txtBox_ClientId.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Client ID :";
            // 
            // btn_ClearClient
            // 
            this.btn_ClearClient.Location = new System.Drawing.Point(448, 263);
            this.btn_ClearClient.Name = "btn_ClearClient";
            this.btn_ClearClient.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearClient.TabIndex = 14;
            this.btn_ClearClient.Text = "Clear";
            this.btn_ClearClient.UseVisualStyleBackColor = true;
            this.btn_ClearClient.Click += new System.EventHandler(this.btn_ClearClient_Click);
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 324);
            this.Controls.Add(this.btn_ClearClient);
            this.Controls.Add(this.txtBox_ClientId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtPicker_BirthDate);
            this.Controls.Add(this.btn_DotViewClient);
            this.Controls.Add(this.btn_DeleteClient);
            this.Controls.Add(this.btn_UpdateClient);
            this.Controls.Add(this.btn_AddClient);
            this.Controls.Add(this.txtBox_Email);
            this.Controls.Add(this.txtBox_FullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddClient";
            this.Text = "AddClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_FullName;
        private System.Windows.Forms.TextBox txtBox_Email;
        private System.Windows.Forms.Button btn_AddClient;
        private System.Windows.Forms.Button btn_UpdateClient;
        private System.Windows.Forms.Button btn_DeleteClient;
        private System.Windows.Forms.Button btn_DotViewClient;
        private System.Windows.Forms.DateTimePicker dtPicker_BirthDate;
        private System.Windows.Forms.TextBox txtBox_ClientId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ClearClient;
    }
}