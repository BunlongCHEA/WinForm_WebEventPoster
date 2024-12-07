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
    public partial class ViewEventCategory : Form
    {
        public ViewEventCategory()
        {
            InitializeComponent();
        }
        private WebEventPosterEntities db = new WebEventPosterEntities();
        public AddEventCategory eventCategory = new AddEventCategory(); 

        private void ViewEventCategory_Load(object sender, EventArgs e)
        {
            foreach (EventCategory ec in db.EventCategories)
            {
                dataGridView_ViewEventCate.Rows.Add(ec.EventCategoryID, ec.CategoryName);
            }
        }

        private void dataGridView_ViewEventCate_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedCnt = dataGridView_ViewEventCate.SelectedRows.Count;
            //MessageBox.Show($"selectedCnt" + selectedCnt);
            if (selectedCnt > 0)
            {
                int selectEventCateId = (int)dataGridView_ViewEventCate.SelectedRows[0].Cells[0].Value;
                //MessageBox.Show($"selectCityId" + selectCityId);
                if (selectEventCateId != null)
                {
                    eventCategory.FilterEventCategoryData(selectEventCateId);
                    this.Close();
                }
            }
        }
    }
}
