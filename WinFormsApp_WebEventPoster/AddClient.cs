using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_WebEventPoster
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
            txtBox_ClientId.Text = GetCountClient().ToString();
        }
        private WebEventPosterEntities db = new WebEventPosterEntities();

        public int GetCountClient()
        {
            int value = 0;
            int maxValue = db.Clients.Select(c => c.ClientID).DefaultIfEmpty().Max();
            int countValue = db.Clients.Count();
            if (countValue <= maxValue)
            {
                value = maxValue + 1;
            }
            else
            {
                value = countValue + 1;
            }
            return value;
        }
        public void Clear()
        {
            txtBox_ClientId.Text = GetCountClient().ToString();
            txtBox_FullName.Text = "";
            txtBox_Email.Text = "";
            dtPicker_BirthDate.Value = DateTime.Now;
        }
        public void FilterClientData(int clientId)
        {
            Client client = db.Clients.Where(c => c.ClientID == clientId).FirstOrDefault();
            if (client != null)
            {
                txtBox_ClientId.Text = Convert.ToString(client.ClientID);
                txtBox_FullName.Text = client.FullName;
                txtBox_Email.Text = client.Email;
                dtPicker_BirthDate.Value = (DateTime)client.BirthDate;
            }
        }
        private void btn_DotViewClient_Click(object sender, EventArgs e)
        {
            ViewClient viewClient = new ViewClient();
            viewClient.addClient = this;
            viewClient.ShowDialog();
        }

        private void btn_AddClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.ClientID = GetCountClient();
            client.FullName = txtBox_FullName.Text;
            client.Email = txtBox_Email.Text;
            client.BirthDate = dtPicker_BirthDate.Value;
            db.Clients.Add(client);
            db.SaveChanges();
            Clear();
            MessageBox.Show($"Add Client_ID {client.ClientID.ToString()} to Table Successfully...");
        }

        private void btn_UpdateClient_Click(object sender, EventArgs e)
        {
            int clientId = int.Parse(txtBox_ClientId.Text);
            Client client = db.Clients.Where(c => c.ClientID == clientId).FirstOrDefault();
            if (client != null)
            {
                client.FullName = txtBox_FullName.Text;
                client.Email= txtBox_Email.Text;
                client.BirthDate = dtPicker_BirthDate.Value;
            }
            db.SaveChanges();
            Clear();
            MessageBox.Show($"Update Client_ID {clientId.ToString()} to Table Successfully...");
        }

        private void btn_DeleteClient_Click(object sender, EventArgs e)
        {
            int clientId = int.Parse(txtBox_ClientId.Text);
            Client client = db.Clients.Where(c => c.ClientID == clientId).FirstOrDefault();
            if (client != null)
            {
                db.Clients.Remove(client);
                db.SaveChanges();
                Clear();
                MessageBox.Show($"Delete Client_ID {clientId.ToString()} from Table Successfully...");
            }
        }

        private void btn_ClearClient_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
