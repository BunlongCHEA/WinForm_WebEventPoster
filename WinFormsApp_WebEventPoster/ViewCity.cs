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
    public partial class ViewCity : Form
    {
        public ViewCity()
        {
            InitializeComponent();
        }
        private WebEventPosterEntities db = new WebEventPosterEntities();
        public AddCity addCity = null;

        private void ViewCity_Load(object sender, EventArgs e)
        {
            foreach (City ct in db.Cities)
            {
                dataGridView_ViewCity.Rows.Add(ct.CityID, ct.CityName, ct.Country.CountryName);
            }
        }

        private void dataGridView_ViewCity_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedCnt = dataGridView_ViewCity.SelectedRows.Count;
            //MessageBox.Show($"selectedCnt" + selectedCnt);
            if (selectedCnt > 0)
            {
                int selectCityId = (int)dataGridView_ViewCity.SelectedRows[0].Cells[0].Value;
                //MessageBox.Show($"selectCityId" + selectCityId);
                if (selectCityId != null)
                {
                    addCity.FilterCityData(selectCityId);
                    this.Close();
                }
            }
        }
    }
}
