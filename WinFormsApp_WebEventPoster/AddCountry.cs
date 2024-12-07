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
    public partial class AddCountry : Form
    {
        public AddCountry()
        {
            InitializeComponent();
            txtBox_CountryId.Text = GetCountCountry().ToString();
        }

        private WebEventPosterEntities db = new WebEventPosterEntities();
        public int GetCountCountry()
        {
            int value = 0;
            int countValue = db.Countries.Count();
            int maxValue = db.Countries.Select(c => c.CountryID).DefaultIfEmpty().Max();
            if (countValue <= maxValue)
            {
                value = maxValue + 1;
            }
            else
            {
                value = countValue + 1;
            }
            //MessageBox.Show("maxValue" + maxValue);
            //MessageBox.Show("countValue" + countValue);
            return value;
        }
        public void Clear()
        {
            txtBox_CountryId.Text = GetCountCountry().ToString();
            txtBox_CountryName.Text = "";
        }
        public void FilterCountryData(int countryId) 
        {
            Country country = db.Countries.Where(c => c.CountryID == countryId).FirstOrDefault();
            if (country != null)
            {
                txtBox_CountryId.Text = Convert.ToString(country.CountryID);
                txtBox_CountryName.Text = country.CountryName;
            }
        }

        private void btn_DotViewCountry_Click(object sender, EventArgs e)
        {
            ViewCountry viewCountry = new ViewCountry();
            viewCountry.addCountry = this;
            viewCountry.ShowDialog();
        }

        private void btn_AddCountry_Click(object sender, EventArgs e)
        {
            Country country = new Country();
            country.CountryID = Convert.ToInt32(txtBox_CountryId.Text);
            country.CountryName = txtBox_CountryName.Text;
            db.Countries.Add(country);
            db.SaveChanges();
            Clear();
            MessageBox.Show($"Add Country_ID {country.CountryID.ToString()} to Table Successfully...");
        }

        private void btn_UpdateCountry_Click(object sender, EventArgs e)
        {
            int countryId = Convert.ToInt32(txtBox_CountryId.Text);
            Country country = db.Countries.Where(cy => cy.CountryID == countryId).FirstOrDefault();
            if (country != null)
            {
                country.CountryName = txtBox_CountryName.Text;
            }
            db.SaveChanges();
            Clear();
            MessageBox.Show($"Update Country_ID {countryId.ToString()} to Table Successfully...");
        }

        private void btn_DeleteCountry_Click(object sender, EventArgs e)
        {
            int countryId = Convert.ToInt32(txtBox_CountryId.Text);
            Country country = db.Countries.Where(cy => cy.CountryID == countryId).FirstOrDefault();
            if (country != null)
            {
                db.Countries.Remove(country);
                db.SaveChanges();
                Clear();
                MessageBox.Show($"Delete Country_ID {countryId.ToString()} from Table Successfully...");
            }
        }

        private void btn_ClearCountry_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
