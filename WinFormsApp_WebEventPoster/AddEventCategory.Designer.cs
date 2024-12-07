namespace WinFormsApp_WebEventPoster
{
    partial class AddEventCategory
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
            this.btn_ClearEventCate = new System.Windows.Forms.Button();
            this.txtBox_EventCateId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_DotViewEventCate = new System.Windows.Forms.Button();
            this.btn_DeleteEventCate = new System.Windows.Forms.Button();
            this.btn_UpdateEventCate = new System.Windows.Forms.Button();
            this.btn_AddEventCate = new System.Windows.Forms.Button();
            this.txtBox_EventCateName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ClearEventCate
            // 
            this.btn_ClearEventCate.Location = new System.Drawing.Point(439, 164);
            this.btn_ClearEventCate.Name = "btn_ClearEventCate";
            this.btn_ClearEventCate.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearEventCate.TabIndex = 34;
            this.btn_ClearEventCate.Text = "Clear";
            this.btn_ClearEventCate.UseVisualStyleBackColor = true;
            this.btn_ClearEventCate.Click += new System.EventHandler(this.btn_ClearCity_Click);
            // 
            // txtBox_EventCateId
            // 
            this.txtBox_EventCateId.Location = new System.Drawing.Point(207, 49);
            this.txtBox_EventCateId.Name = "txtBox_EventCateId";
            this.txtBox_EventCateId.ReadOnly = true;
            this.txtBox_EventCateId.Size = new System.Drawing.Size(326, 22);
            this.txtBox_EventCateId.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Event Category ID :";
            // 
            // btn_DotViewEventCate
            // 
            this.btn_DotViewEventCate.Location = new System.Drawing.Point(548, 49);
            this.btn_DotViewEventCate.Name = "btn_DotViewEventCate";
            this.btn_DotViewEventCate.Size = new System.Drawing.Size(39, 23);
            this.btn_DotViewEventCate.TabIndex = 31;
            this.btn_DotViewEventCate.Text = "...";
            this.btn_DotViewEventCate.UseVisualStyleBackColor = true;
            this.btn_DotViewEventCate.Click += new System.EventHandler(this.btn_DotViewEventCate_Click);
            // 
            // btn_DeleteEventCate
            // 
            this.btn_DeleteEventCate.Location = new System.Drawing.Point(321, 164);
            this.btn_DeleteEventCate.Name = "btn_DeleteEventCate";
            this.btn_DeleteEventCate.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteEventCate.TabIndex = 30;
            this.btn_DeleteEventCate.Text = "Delete";
            this.btn_DeleteEventCate.UseVisualStyleBackColor = true;
            this.btn_DeleteEventCate.Click += new System.EventHandler(this.btn_DeleteCity_Click);
            // 
            // btn_UpdateEventCate
            // 
            this.btn_UpdateEventCate.Location = new System.Drawing.Point(207, 164);
            this.btn_UpdateEventCate.Name = "btn_UpdateEventCate";
            this.btn_UpdateEventCate.Size = new System.Drawing.Size(75, 23);
            this.btn_UpdateEventCate.TabIndex = 29;
            this.btn_UpdateEventCate.Text = "Update";
            this.btn_UpdateEventCate.UseVisualStyleBackColor = true;
            this.btn_UpdateEventCate.Click += new System.EventHandler(this.btn_UpdateCity_Click);
            // 
            // btn_AddEventCate
            // 
            this.btn_AddEventCate.Location = new System.Drawing.Point(99, 164);
            this.btn_AddEventCate.Name = "btn_AddEventCate";
            this.btn_AddEventCate.Size = new System.Drawing.Size(75, 23);
            this.btn_AddEventCate.TabIndex = 28;
            this.btn_AddEventCate.Text = "Add";
            this.btn_AddEventCate.UseVisualStyleBackColor = true;
            this.btn_AddEventCate.Click += new System.EventHandler(this.btn_AddCity_Click);
            // 
            // txtBox_EventCateName
            // 
            this.txtBox_EventCateName.Location = new System.Drawing.Point(207, 98);
            this.txtBox_EventCateName.Name = "txtBox_EventCateName";
            this.txtBox_EventCateName.Size = new System.Drawing.Size(326, 22);
            this.txtBox_EventCateName.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Event Category Name :";
            // 
            // AddEventCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 233);
            this.Controls.Add(this.btn_ClearEventCate);
            this.Controls.Add(this.txtBox_EventCateId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_DotViewEventCate);
            this.Controls.Add(this.btn_DeleteEventCate);
            this.Controls.Add(this.btn_UpdateEventCate);
            this.Controls.Add(this.btn_AddEventCate);
            this.Controls.Add(this.txtBox_EventCateName);
            this.Controls.Add(this.label1);
            this.Name = "AddEventCategory";
            this.Text = "AddEventCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ClearEventCate;
        private System.Windows.Forms.TextBox txtBox_EventCateId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_DotViewEventCate;
        private System.Windows.Forms.Button btn_DeleteEventCate;
        private System.Windows.Forms.Button btn_UpdateEventCate;
        private System.Windows.Forms.Button btn_AddEventCate;
        private System.Windows.Forms.TextBox txtBox_EventCateName;
        private System.Windows.Forms.Label label1;
    }
}