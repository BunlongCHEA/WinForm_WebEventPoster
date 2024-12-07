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
    public partial class ViewEvent : Form
    {
        public ViewEvent()
        {
            InitializeComponent();
        }
        private WebEventPosterEntities db = new WebEventPosterEntities();
        public AddEvent addEvent = new AddEvent();
        private void ViewEvent_Load(object sender, EventArgs e)
        {
            foreach(Event ev in db.Events)
            {
                dataGridView_ViewEvent.Rows.Add(ev.EventID, ev.EventName, ev.EventDate,
                    ev.EventTime, ev.EventLocation, ev.MaxTicket, ev.Price, ev.Descriptions, ev.PosterURL,
                    ev.AgeRestrict);
            }
        }

        private void dataGridView_ViewEvent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedCnt = dataGridView_ViewEvent.SelectedRows.Count;
            if (selectedCnt > 0)
            {
                int selectEventId = (int)dataGridView_ViewEvent.SelectedRows[0].Cells[0].Value;
                if (selectEventId != null)
                {
                    addEvent.FilterEventData(selectEventId);
                    this.Close();
                }
            }
        }
    }
}
