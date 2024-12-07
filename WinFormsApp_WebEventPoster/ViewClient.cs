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
    public partial class ViewClient : Form
    {
        public ViewClient()
        {
            InitializeComponent();
        }
        private WebEventPosterEntities db = new WebEventPosterEntities();
        public AddClient addClient = null;

        private void ViewClient_Load(object sender, EventArgs e)
        {
            foreach (Client c in db.Clients)
            {
                dataGridView_ViewClient.Rows.Add(c.ClientID, c.FullName, c.Email, c.BirthDate.ToString().Substring(0,10).Replace('/','-'));
            }
        }

        private void dataGridView_ViewClient_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedCnt = dataGridView_ViewClient.SelectedRows.Count;
            if (selectedCnt > 0)
            {
                int selectClientId = (int)dataGridView_ViewClient.SelectedRows[0].Cells[0].Value;
                if (selectClientId != null)
                {
                    addClient.FilterClientData(selectClientId);
                    this.Close();
                }
            }
        }
    }
}
