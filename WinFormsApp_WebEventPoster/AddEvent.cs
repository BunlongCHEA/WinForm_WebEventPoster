using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_WebEventPoster
{
    public partial class AddEvent : Form
    {
        public AddEvent()
        {
            InitializeComponent();
        }
        private WebEventPosterEntities db = new WebEventPosterEntities();

        private void AddEvent_Load(object sender, EventArgs e)
        {
            //Set Event ID
            txtBox_EventID.Text = GetCountEvent().ToString();
            //Set Hour Time-Picker for EventTime
            for (int i = 0; i < 24; i++)
            {
                cb_EventTime_Hour.Items.Add(i.ToString("00"));
            }
            //Set Minute Time-Picker for EventTime
            for (int i = 0; i < 60; i++)
            {
                cb_EventTime_Minute.Items.Add(i.ToString("00"));
            }
            //Set Age Restriction
            for (int i = 5; i <= 100; i++)
            {
                cb_AgeRestict.Items.Add(i.ToString());
            }
        }

        public int GetCountEvent()
        {
            int value = 0;
            int maxValue = db.Events.Select(e => e.EventID).DefaultIfEmpty().Max();
            int countValue = db.Events.Count();
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
            txtBox_EventID.Text = GetCountEvent().ToString();
            txtBox_EventName.Text = "";
            dtPicker_EventDate.Text = "";
            cb_EventTime_Hour.SelectedIndex = -1;
            cb_EventTime_Minute.SelectedIndex = -1;
            //cb_EventTime_Hour.Text = "";
            //cb_EventTime_Minute.Text = "";
            txtBox_EventLocation.Text = "";
            txtBox_MaxTicket.Text = "";
            txtBox_Price.Text = "";
            txtBox_Description.Text = "";
            txtBox_PosterUrl.Text = "";
            cb_AgeRestict.SelectedIndex = -1;
            //cb_AgeRestict.Text = "";
        }
        public void FilterEventData(int eventId)
        {
            Event events = db.Events.Where(e => e.EventID == eventId).FirstOrDefault();
            if (events != null)
            {
                txtBox_EventID.Text = events.EventID.ToString();
                txtBox_EventName.Text = events.EventName;
                dtPicker_EventDate.Value = (DateTime)events.EventDate;

                string[] splitTime = events.EventTime.Split(':');
                cb_EventTime_Hour.Text = splitTime[0].ToString();
                cb_EventTime_Minute.Text = splitTime[1].ToString();

                txtBox_EventLocation.Text = events.EventLocation;
                txtBox_MaxTicket.Text = events.MaxTicket.ToString();
                txtBox_Price.Text = events.Price.ToString();
                txtBox_Description.Text = events.Descriptions;
                txtBox_PosterUrl.Text = events.PosterURL;
                cb_AgeRestict.Text = events.AgeRestrict;
            }
        }

        private void btn_DotViewCity_Click(object sender, EventArgs e)
        {
            ViewEvent viewEvent = new ViewEvent();
            viewEvent.addEvent = this;
            viewEvent.ShowDialog();
        }
        private void btn_AddCity_Click(object sender, EventArgs e)
        {
            Event events = new Event();
            events.EventID = GetCountEvent();
            events.EventName = txtBox_EventName.Text;
            events.EventDate = dtPicker_EventDate.Value;
            events.EventTime = cb_EventTime_Hour.Text + ":" + cb_EventTime_Minute.Text;
            events.EventLocation = txtBox_EventLocation.Text;
            events.MaxTicket = Convert.ToInt32(txtBox_MaxTicket.Text);
            events.Price = Convert.ToDecimal(txtBox_Price.Text);
            events.Descriptions = txtBox_Description.Text;
            events.PosterURL = txtBox_PosterUrl.Text;
            events.AgeRestrict = cb_AgeRestict.Text;
            db.Events.Add(events);
            db.SaveChanges();
            Clear();
            MessageBox.Show($"Add Event_ID {events.EventID.ToString()} to Table Successfully...");
        }
        private void btn_UpdateCity_Click(object sender, EventArgs e)
        {
            int eventId = Convert.ToInt32(txtBox_EventID.Text);
            Event events = db.Events.Where(ev => ev.EventID == eventId).FirstOrDefault();
            if (events != null)
            {
                events.EventName = txtBox_EventName.Text;
                events.EventDate = dtPicker_EventDate.Value;
                events.EventTime = cb_EventTime_Hour.Text + ":" + cb_EventTime_Minute.Text;
                events.EventLocation = txtBox_EventLocation.Text;
                events.MaxTicket = Convert.ToInt32(txtBox_MaxTicket.Text);
                events.Price = Convert.ToDecimal(txtBox_Price.Text);
                events.Descriptions = txtBox_Description.Text;
                events.PosterURL = txtBox_PosterUrl.Text;
                events.AgeRestrict = cb_AgeRestict.Text;
            }
            db.SaveChanges();
            Clear();
            MessageBox.Show($"Update Event_ID {eventId.ToString()} to Table Successfully...");
        }
        private void btn_DeleteCity_Click(object sender, EventArgs e)
        {
            int eventId = Convert.ToInt32(txtBox_EventID.Text);
            Event events = db.Events.Where(ev => ev.EventID == eventId).FirstOrDefault();
            if (events != null)
            {
                db.Events.Remove(events);
                db.SaveChanges();
                Clear();
                MessageBox.Show($"Delete Event_ID {eventId.ToString()} from Table Successfully...");
            }
        }
        private void btn_ClearCity_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
