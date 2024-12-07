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
    public partial class AddEventCategory : Form
    {
        public AddEventCategory()
        {
            InitializeComponent();
            txtBox_EventCateId.Text = GetCountEventCategory().ToString();
        }
        private WebEventPosterEntities db = new WebEventPosterEntities();

        public int GetCountEventCategory()
        {
            int value = 0;
            int maxValue = db.EventCategories.Select(ec => ec.EventCategoryID).DefaultIfEmpty().Max();
            int countValue = db.EventCategories.Count();
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
            txtBox_EventCateId.Text = GetCountEventCategory().ToString();
            txtBox_EventCateName.Text = "";
        }
        public void FilterEventCategoryData(int categoryID)
        {
            EventCategory eventCategory = db.EventCategories.Where(ec => ec.EventCategoryID == categoryID).FirstOrDefault();
            if (eventCategory != null)
            {
                txtBox_EventCateId.Text = eventCategory.EventCategoryID.ToString();
                txtBox_EventCateName.Text = eventCategory.CategoryName.ToString(); 
            }
        }

        private void btn_DotViewEventCate_Click(object sender, EventArgs e)
        {
            ViewEventCategory viewEventCategory = new ViewEventCategory();
            viewEventCategory.eventCategory = this;
            viewEventCategory.ShowDialog();
        }
        private void btn_AddCity_Click(object sender, EventArgs e)
        {
            EventCategory eventCategory = new EventCategory();
            eventCategory.EventCategoryID = GetCountEventCategory();
            eventCategory.CategoryName = txtBox_EventCateName.Text;
            db.EventCategories.Add(eventCategory);
            db.SaveChanges();
            Clear();
            MessageBox.Show($"Add EventCategory_ID {eventCategory.EventCategoryID.ToString()} to Table Successfully...");
        }
        private void btn_UpdateCity_Click(object sender, EventArgs e)
        {
            int eventCateID = Convert.ToInt32(txtBox_EventCateId.Text);
            EventCategory eventCategory = db.EventCategories.Where(ec => ec.EventCategoryID == eventCateID).FirstOrDefault();
            if (eventCategory != null)
            {
                eventCategory.CategoryName = txtBox_EventCateName.Text;
            }
            db.SaveChanges();
            Clear();
            MessageBox.Show($"Update EventCategory_ID {eventCateID.ToString()} to Table Successfully...");
        }
        private void btn_DeleteCity_Click(object sender, EventArgs e)
        {
            int eventCateID = Convert.ToInt32(txtBox_EventCateId.Text);
            EventCategory eventCategory = db.EventCategories.Where(ec => ec.EventCategoryID == eventCateID).FirstOrDefault();
            if (eventCategory != null)
            {
                db.EventCategories.Remove(eventCategory);
                db.SaveChanges();
                Clear();
                MessageBox.Show($"Delete EventCategory_ID {eventCateID.ToString()} from Table Successfully...");
            }
        }
        private void btn_ClearCity_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
