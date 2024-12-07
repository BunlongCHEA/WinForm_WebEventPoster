namespace WinFormsApp_WebEventPoster
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCountryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCountryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEventCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEventCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.countryToolStripMenuItem,
            this.cityToolStripMenuItem,
            this.eventCategoryToolStripMenuItem,
            this.eventToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientToolStripMenuItem,
            this.viewClientToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.addClientToolStripMenuItem.Text = "Add Client";
            this.addClientToolStripMenuItem.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // viewClientToolStripMenuItem
            // 
            this.viewClientToolStripMenuItem.Name = "viewClientToolStripMenuItem";
            this.viewClientToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.viewClientToolStripMenuItem.Text = "View Client";
            this.viewClientToolStripMenuItem.Click += new System.EventHandler(this.viewClientToolStripMenuItem_Click);
            // 
            // countryToolStripMenuItem
            // 
            this.countryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCountryToolStripMenuItem,
            this.viewCountryToolStripMenuItem});
            this.countryToolStripMenuItem.Name = "countryToolStripMenuItem";
            this.countryToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.countryToolStripMenuItem.Text = "Country";
            // 
            // addCountryToolStripMenuItem
            // 
            this.addCountryToolStripMenuItem.Name = "addCountryToolStripMenuItem";
            this.addCountryToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.addCountryToolStripMenuItem.Text = "Add Country";
            this.addCountryToolStripMenuItem.Click += new System.EventHandler(this.addCountryToolStripMenuItem_Click);
            // 
            // viewCountryToolStripMenuItem
            // 
            this.viewCountryToolStripMenuItem.Name = "viewCountryToolStripMenuItem";
            this.viewCountryToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.viewCountryToolStripMenuItem.Text = "View Country";
            this.viewCountryToolStripMenuItem.Click += new System.EventHandler(this.viewCountryToolStripMenuItem_Click);
            // 
            // cityToolStripMenuItem
            // 
            this.cityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCityToolStripMenuItem,
            this.viewCityToolStripMenuItem});
            this.cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            this.cityToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.cityToolStripMenuItem.Text = "City";
            // 
            // addCityToolStripMenuItem
            // 
            this.addCityToolStripMenuItem.Name = "addCityToolStripMenuItem";
            this.addCityToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.addCityToolStripMenuItem.Text = "Add City";
            this.addCityToolStripMenuItem.Click += new System.EventHandler(this.addCityToolStripMenuItem_Click);
            // 
            // viewCityToolStripMenuItem
            // 
            this.viewCityToolStripMenuItem.Name = "viewCityToolStripMenuItem";
            this.viewCityToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.viewCityToolStripMenuItem.Text = "View City";
            this.viewCityToolStripMenuItem.Click += new System.EventHandler(this.viewCityToolStripMenuItem_Click);
            // 
            // eventCategoryToolStripMenuItem
            // 
            this.eventCategoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEventCategoryToolStripMenuItem,
            this.viewEventCategoryToolStripMenuItem});
            this.eventCategoryToolStripMenuItem.Name = "eventCategoryToolStripMenuItem";
            this.eventCategoryToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.eventCategoryToolStripMenuItem.Text = "Event Category";
            // 
            // addEventCategoryToolStripMenuItem
            // 
            this.addEventCategoryToolStripMenuItem.Name = "addEventCategoryToolStripMenuItem";
            this.addEventCategoryToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.addEventCategoryToolStripMenuItem.Text = "Add Event Category";
            this.addEventCategoryToolStripMenuItem.Click += new System.EventHandler(this.addEventCategoryToolStripMenuItem_Click);
            // 
            // viewEventCategoryToolStripMenuItem
            // 
            this.viewEventCategoryToolStripMenuItem.Name = "viewEventCategoryToolStripMenuItem";
            this.viewEventCategoryToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.viewEventCategoryToolStripMenuItem.Text = "View Event Category";
            this.viewEventCategoryToolStripMenuItem.Click += new System.EventHandler(this.viewEventCategoryToolStripMenuItem_Click);
            // 
            // eventToolStripMenuItem
            // 
            this.eventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEventToolStripMenuItem,
            this.viewEventToolStripMenuItem});
            this.eventToolStripMenuItem.Name = "eventToolStripMenuItem";
            this.eventToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.eventToolStripMenuItem.Text = "Event";
            // 
            // addEventToolStripMenuItem
            // 
            this.addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            this.addEventToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.addEventToolStripMenuItem.Text = "Add Event";
            this.addEventToolStripMenuItem.Click += new System.EventHandler(this.addEventToolStripMenuItem_Click);
            // 
            // viewEventToolStripMenuItem
            // 
            this.viewEventToolStripMenuItem.Name = "viewEventToolStripMenuItem";
            this.viewEventToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.viewEventToolStripMenuItem.Text = "View Event";
            this.viewEventToolStripMenuItem.Click += new System.EventHandler(this.viewEventToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(338, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome To The Events";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(251, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(338, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "Click To Purchase Event Ticket Here";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Ticket_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Web Event Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCountryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCountryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEventCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEventCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEventToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

