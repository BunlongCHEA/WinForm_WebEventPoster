using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_WebEventPoster
{
    public partial class ViewCountry : Form
    {
        public ViewCountry()
        {
            InitializeComponent();
        }
        private WebEventPosterEntities db = new WebEventPosterEntities();
        public AddCountry addCountry = new AddCountry();

        private void ViewCountry_Load(object sender, EventArgs e)
        {
            foreach (Country cy in db.Countries)
            {
                dataGridView_ViewCountry.Rows.Add(cy.CountryID, cy.CountryName);
            }
        }

        private void dataGridView_ViewCountry_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedCnt = dataGridView_ViewCountry.SelectedRows.Count;
            if (selectedCnt > 0)
            {
                int selectCountryId = (int)dataGridView_ViewCountry.SelectedRows[0].Cells[0].Value;
                if (selectCountryId != null)
                {
                    addCountry.FilterCountryData(selectCountryId);
                    this.Close();
                }
            }
        }
    }
}
