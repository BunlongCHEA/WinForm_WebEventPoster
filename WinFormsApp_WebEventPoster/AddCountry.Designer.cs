namespace WinFormsApp_WebEventPoster
{
    partial class AddCountry
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
            this.btn_ClearCountry = new System.Windows.Forms.Button();
            this.txtBox_CountryId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_DotViewCountry = new System.Windows.Forms.Button();
            this.btn_DeleteCountry = new System.Windows.Forms.Button();
            this.btn_UpdateCountry = new System.Windows.Forms.Button();
            this.btn_AddCountry = new System.Windows.Forms.Button();
            this.txtBox_CountryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ClearCountry
            // 
            this.btn_ClearCountry.Location = new System.Drawing.Point(469, 184);
            this.btn_ClearCountry.Name = "btn_ClearCountry";
            this.btn_ClearCountry.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearCountry.TabIndex = 23;
            this.btn_ClearCountry.Text = "Clear";
            this.btn_ClearCountry.UseVisualStyleBackColor = true;
            this.btn_ClearCountry.Click += new System.EventHandler(this.btn_ClearCountry_Click);
            // 
            // txtBox_CountryId
            // 
            this.txtBox_CountryId.Location = new System.Drawing.Point(206, 63);
            this.txtBox_CountryId.Name = "txtBox_CountryId";
            this.txtBox_CountryId.ReadOnly = true;
            this.txtBox_CountryId.Size = new System.Drawing.Size(326, 22);
            this.txtBox_CountryId.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Country ID :";
            // 
            // btn_DotViewCountry
            // 
            this.btn_DotViewCountry.Location = new System.Drawing.Point(547, 63);
            this.btn_DotViewCountry.Name = "btn_DotViewCountry";
            this.btn_DotViewCountry.Size = new System.Drawing.Size(39, 23);
            this.btn_DotViewCountry.TabIndex = 20;
            this.btn_DotViewCountry.Text = "...";
            this.btn_DotViewCountry.UseVisualStyleBackColor = true;
            this.btn_DotViewCountry.Click += new System.EventHandler(this.btn_DotViewCountry_Click);
            // 
            // btn_DeleteCountry
            // 
            this.btn_DeleteCountry.Location = new System.Drawing.Point(351, 184);
            this.btn_DeleteCountry.Name = "btn_DeleteCountry";
            this.btn_DeleteCountry.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteCountry.TabIndex = 19;
            this.btn_DeleteCountry.Text = "Delete";
            this.btn_DeleteCountry.UseVisualStyleBackColor = true;
            this.btn_DeleteCountry.Click += new System.EventHandler(this.btn_DeleteCountry_Click);
            // 
            // btn_UpdateCountry
            // 
            this.btn_UpdateCountry.Location = new System.Drawing.Point(237, 184);
            this.btn_UpdateCountry.Name = "btn_UpdateCountry";
            this.btn_UpdateCountry.Size = new System.Drawing.Size(75, 23);
            this.btn_UpdateCountry.TabIndex = 18;
            this.btn_UpdateCountry.Text = "Update";
            this.btn_UpdateCountry.UseVisualStyleBackColor = true;
            this.btn_UpdateCountry.Click += new System.EventHandler(this.btn_UpdateCountry_Click);
            // 
            // btn_AddCountry
            // 
            this.btn_AddCountry.Location = new System.Drawing.Point(129, 184);
            this.btn_AddCountry.Name = "btn_AddCountry";
            this.btn_AddCountry.Size = new System.Drawing.Size(75, 23);
            this.btn_AddCountry.TabIndex = 17;
            this.btn_AddCountry.Text = "Add";
            this.btn_AddCountry.UseVisualStyleBackColor = true;
            this.btn_AddCountry.Click += new System.EventHandler(this.btn_AddCountry_Click);
            // 
            // txtBox_CountryName
            // 
            this.txtBox_CountryName.Location = new System.Drawing.Point(206, 112);
            this.txtBox_CountryName.Name = "txtBox_CountryName";
            this.txtBox_CountryName.Size = new System.Drawing.Size(326, 22);
            this.txtBox_CountryName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Country Name :";
            // 
            // AddCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 245);
            this.Controls.Add(this.btn_ClearCountry);
            this.Controls.Add(this.txtBox_CountryId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_DotViewCountry);
            this.Controls.Add(this.btn_DeleteCountry);
            this.Controls.Add(this.btn_UpdateCountry);
            this.Controls.Add(this.btn_AddCountry);
            this.Controls.Add(this.txtBox_CountryName);
            this.Controls.Add(this.label1);
            this.Name = "AddCountry";
            this.Text = "AddCountry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ClearCountry;
        private System.Windows.Forms.TextBox txtBox_CountryId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_DotViewCountry;
        private System.Windows.Forms.Button btn_DeleteCountry;
        private System.Windows.Forms.Button btn_UpdateCountry;
        private System.Windows.Forms.Button btn_AddCountry;
        private System.Windows.Forms.TextBox txtBox_CountryName;
        private System.Windows.Forms.Label label1;
    }
}