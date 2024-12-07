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
    public partial class AddCity : Form
    {
        public AddCity()
        {
            InitializeComponent();
            txtBox_CityId.Text = GetCountCity().ToString();
        }
        private WebEventPosterEntities db = new WebEventPosterEntities();

        public int GetCountCity()
        {
            int value = 0;
            int maxValue = db.Cities.Select(c => c.CityID).DefaultIfEmpty().Max();
            int countValue = db.Cities.Count();
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
            txtBox_CityId.Text = GetCountCity().ToString();
            txtBox_CityName.Text = "";
            cb_CountryName.Text = "";
        }
        public void FilterCityData(int cityId)
        {
            City city = db.Cities.Where(ct => ct.CityID == cityId).FirstOrDefault();
            if (city != null)
            {
                txtBox_CityId.Text = city.CityID.ToString();
                txtBox_CityName.Text = city.CityName.ToString();
                cb_CountryName.Text = city.Country.CountryName.ToString();
            }
        }

        private void btn_DotViewCity_Click(object sender, EventArgs e)
        {
            ViewCity viewCity = new ViewCity();
            viewCity.addCity = this;
            viewCity.ShowDialog();
        }
        private void btn_AddClient_Click(object sender, EventArgs e)
        {
            City city = new City();
            city.CityID = GetCountCity();
            city.CityName = txtBox_CityName.Text;
            string countryName = cb_CountryName.Text;
            city.CountryID = db.Countries.Where(cys => cys.CountryName == cb_CountryName.Text)
                               .Select(cy => cy.CountryID).FirstOrDefault();
            db.Cities.Add(city);
            db.SaveChanges();
            Clear();
            MessageBox.Show($"Add City_ID {city.CityID.ToString()} to Table Successfully...");
        }

        private void btn_UpdateClient_Click(object sender, EventArgs e)
        {
            int cityID = Convert.ToInt32(txtBox_CityId.Text);
            City city = db.Cities.Where(ct => ct.CityID == cityID).FirstOrDefault();
            if (city != null)
            {
                city.CityName = txtBox_CityName.Text;
                city.CountryID = db.Countries.Where(cys => cys.CountryName == cb_CountryName.Text)
                                   .Select(cy => cy.CountryID).FirstOrDefault();
            }
            db.SaveChanges();
            Clear();
            MessageBox.Show($"Update City_ID {cityID.ToString()} to Table Successfully...");
        }

        private void btn_DeleteClient_Click(object sender, EventArgs e)
        {
            int cityID = Convert.ToInt32(txtBox_CityId.Text);
            City city = db.Cities.Where(ct => ct.CityID == cityID).FirstOrDefault();
            if (city != null)
            {
                db.Cities.Remove(city);
                db.SaveChanges();
                Clear();
                MessageBox.Show($"Delete City_ID {cityID.ToString()} from Table Successfully...");
            }
        }

        private void btn_ClearClient_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void AddCity_Load(object sender, EventArgs e)
        {
            Country country = new Country();
            foreach (Country c in db.Countries)
            {
                cb_CountryName.Items.Add(c.CountryName);
            }
        }
    }
}
