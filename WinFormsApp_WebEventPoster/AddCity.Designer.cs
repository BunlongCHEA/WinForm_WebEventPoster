namespace WinFormsApp_WebEventPoster
{
    partial class AddCity
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
            this.txtBox_CityId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_DotViewCity = new System.Windows.Forms.Button();
            this.btn_DeleteCity = new System.Windows.Forms.Button();
            this.btn_UpdateCity = new System.Windows.Forms.Button();
            this.btn_AddCity = new System.Windows.Forms.Button();
            this.txtBox_CityName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_CountryName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_ClearCity
            // 
            this.btn_ClearCity.Location = new System.Drawing.Point(445, 208);
            this.btn_ClearCity.Name = "btn_ClearCity";
            this.btn_ClearCity.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearCity.TabIndex = 25;
            this.btn_ClearCity.Text = "Clear";
            this.btn_ClearCity.UseVisualStyleBackColor = true;
            this.btn_ClearCity.Click += new System.EventHandler(this.btn_ClearClient_Click);
            // 
            // txtBox_CityId
            // 
            this.txtBox_CityId.Location = new System.Drawing.Point(183, 55);
            this.txtBox_CityId.Name = "txtBox_CityId";
            this.txtBox_CityId.ReadOnly = true;
            this.txtBox_CityId.Size = new System.Drawing.Size(326, 22);
            this.txtBox_CityId.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "City ID :";
            // 
            // btn_DotViewCity
            // 
            this.btn_DotViewCity.Location = new System.Drawing.Point(524, 55);
            this.btn_DotViewCity.Name = "btn_DotViewCity";
            this.btn_DotViewCity.Size = new System.Drawing.Size(39, 23);
            this.btn_DotViewCity.TabIndex = 22;
            this.btn_DotViewCity.Text = "...";
            this.btn_DotViewCity.UseVisualStyleBackColor = true;
            this.btn_DotViewCity.Click += new System.EventHandler(this.btn_DotViewCity_Click);
            // 
            // btn_DeleteCity
            // 
            this.btn_DeleteCity.Location = new System.Drawing.Point(327, 208);
            this.btn_DeleteCity.Name = "btn_DeleteCity";
            this.btn_DeleteCity.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteCity.TabIndex = 21;
            this.btn_DeleteCity.Text = "Delete";
            this.btn_DeleteCity.UseVisualStyleBackColor = true;
            this.btn_DeleteCity.Click += new System.EventHandler(this.btn_DeleteClient_Click);
            // 
            // btn_UpdateCity
            // 
            this.btn_UpdateCity.Location = new System.Drawing.Point(213, 208);
            this.btn_UpdateCity.Name = "btn_UpdateCity";
            this.btn_UpdateCity.Size = new System.Drawing.Size(75, 23);
            this.btn_UpdateCity.TabIndex = 20;
            this.btn_UpdateCity.Text = "Update";
            this.btn_UpdateCity.UseVisualStyleBackColor = true;
            this.btn_UpdateCity.Click += new System.EventHandler(this.btn_UpdateClient_Click);
            // 
            // btn_AddCity
            // 
            this.btn_AddCity.Location = new System.Drawing.Point(105, 208);
            this.btn_AddCity.Name = "btn_AddCity";
            this.btn_AddCity.Size = new System.Drawing.Size(75, 23);
            this.btn_AddCity.TabIndex = 19;
            this.btn_AddCity.Text = "Add";
            this.btn_AddCity.UseVisualStyleBackColor = true;
            this.btn_AddCity.Click += new System.EventHandler(this.btn_AddClient_Click);
            // 
            // txtBox_CityName
            // 
            this.txtBox_CityName.Location = new System.Drawing.Point(183, 104);
            this.txtBox_CityName.Name = "txtBox_CityName";
            this.txtBox_CityName.Size = new System.Drawing.Size(326, 22);
            this.txtBox_CityName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Country Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "City Name :";
            // 
            // cb_CountryName
            // 
            this.cb_CountryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CountryName.FormattingEnabled = true;
            this.cb_CountryName.Location = new System.Drawing.Point(183, 151);
            this.cb_CountryName.Name = "cb_CountryName";
            this.cb_CountryName.Size = new System.Drawing.Size(326, 24);
            this.cb_CountryName.TabIndex = 26;
            // 
            // AddCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 284);
            this.Controls.Add(this.cb_CountryName);
            this.Controls.Add(this.btn_ClearCity);
            this.Controls.Add(this.txtBox_CityId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_DotViewCity);
            this.Controls.Add(this.btn_DeleteCity);
            this.Controls.Add(this.btn_UpdateCity);
            this.Controls.Add(this.btn_AddCity);
            this.Controls.Add(this.txtBox_CityName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCity";
            this.Text = "AddCity";
            this.Load += new System.EventHandler(this.AddCity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ClearCity;
        private System.Windows.Forms.TextBox txtBox_CityId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_DotViewCity;
        private System.Windows.Forms.Button btn_DeleteCity;
        private System.Windows.Forms.Button btn_UpdateCity;
        private System.Windows.Forms.Button btn_AddCity;
        private System.Windows.Forms.TextBox txtBox_CityName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_CountryName;
    }
}