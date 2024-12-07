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
    public partial class TransactionMenu : Form
    {
        public TransactionMenu()
        {
            InitializeComponent();
        }
        private WebEventPosterEntities db = new WebEventPosterEntities();

        private void TransactionMenu_Load(object sender, EventArgs e)
        {
            //Add Transaction ID without input
            txtBox_TransId.Text = GetCountTrans().ToString();

            //Load All data to dataGridView_ViewTicket
            foreach (TicketTransaction tt in db.TicketTransactions)
            {
                dataGridView_ViewTicket.Rows.Add(tt.TransactionID, tt.Event.EventName,
                    tt.EventCategory.CategoryName, tt.Country.CountryName, tt.City.CityName,
                    tt.Client.FullName, tt.Qty, tt.Event.Price, tt.TotalPrice, tt.TransactionDate,
                    tt.TransUpdateDate);
            }

            //Combo Box for EventName
            cb_EventName.Items.Add("All");
            foreach (Event ev in db.Events)
            {
                cb_EventName.Items.Add(ev.EventName);
            }

            //Combo Box for EventCategory
            foreach (EventCategory ec in db.EventCategories)
            {
                cb_EventCategory.Items.Add(ec.CategoryName);
            }

            //Combo Box for EventCity
            foreach (City ct in db.Cities)
            {
                cb_EventCity.Items.Add(ct.CityName);
            }

            //Combo Box for EventCountry
            foreach(Country co in db.Countries)
            {
                cb_EventCountry.Items.Add(co.CountryName);
            }

            //Combo Box for ClientName
            foreach (Client cc in db.Clients)
            {
                cb_ClientName.Items.Add(cc.FullName);
            }
        }

        public int GetCountTrans()
        {
            int value = 0;
            int maxValue = db.TicketTransactions.Select(tt => tt.TransactionID).DefaultIfEmpty().Max();
            int countValue = db.TicketTransactions.Count();
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

        private void dataGridView_ViewTicket_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedCnt = dataGridView_ViewTicket.SelectedRows.Count;
            if (selectedCnt > 0)
            {
                int selectEventId = (int)dataGridView_ViewTicket.SelectedRows[0].Cells[0].Value;
                if (selectEventId != null)
                {
                    FilterTicketData(selectEventId);
                }
            }
        }
        public void FilterTicketData(int transId)
        {
            TicketTransaction transaction = db.TicketTransactions.Where(tt => tt.TransactionID == transId).FirstOrDefault();
            if (transaction != null)
            {
                txtBox_TransId.Text = transaction.TransactionID.ToString();
                cb_EventName.Text = transaction.Event.EventName;
                cb_EventCategory.Text = transaction.EventCategory.CategoryName;
                cb_EventCity.Text = transaction.City.CityName;
                cb_EventCountry.Text = transaction.Country.CountryName;
                cb_ClientName.Text = transaction.Client.FullName;
                txtBox_Qty.Text = transaction.Qty.ToString();
                txtBox_Price.Text = transaction.Event.Price.ToString();
                txtBox_TotalPrice.Text = transaction.TotalPrice.ToString();
            }
        }

        private void cb_EventName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_EventName.SelectedItem != null)
            {
                string selectedEventName = cb_EventName.SelectedItem.ToString();
                //MessageBox.Show("selectedEventName" + selectedEventName);

                if (selectedEventName == "All")
                {
                    //View all rows to DataGrid TicketTransaction
                    dataGridView_ViewTicket.Rows.Clear();
                    foreach (TicketTransaction tt in db.TicketTransactions)
                    {
                        dataGridView_ViewTicket.Rows.Add(tt.TransactionID, tt.Event.EventName,
                            tt.EventCategory.CategoryName, tt.Country.CountryName, tt.City.CityName,
                            tt.Client.FullName, tt.Qty, tt.Event.Price, tt.TotalPrice,
                            tt.TransactionDate, tt.TransUpdateDate);
                    }
                }
                else
                {
                    //View rows only certain EventName to DataGrid TicketTransaction
                    dataGridView_ViewTicket.Rows.Clear();
                    int selectedEventId = db.Events.Where(ev => ev.EventName == selectedEventName).Select(ev => ev.EventID).FirstOrDefault();
                    var ticketTransaction = db.TicketTransactions.Where(tt => tt.EventID == selectedEventId).ToList();
                    foreach (var tt in ticketTransaction)
                    {
                        dataGridView_ViewTicket.Rows.Add(tt.TransactionID, tt.Event.EventName,
                            tt.EventCategory.CategoryName, tt.Country.CountryName, tt.City.CityName,
                            tt.Client.FullName, tt.Qty, tt.Event.Price, tt.TotalPrice,
                            tt.TransactionDate, tt.TransUpdateDate);
                    }

                    //Display max ticket from each EventName
                    txtBox_MaxTicket.Text = db.Events.Where(ev => ev.EventName == selectedEventName).Select(ev => ev.MaxTicket).FirstOrDefault().ToString();

                    //Calculate Ticket Left for allow purchase 
                    txtBox_TicketLeft.Text = TotalTicketLeft().ToString();

                    //Display ticket price for each EventName
                    txtBox_Price.Text = db.Events.Where(ev => ev.EventName == selectedEventName).Select(ev => ev.Price).FirstOrDefault().ToString();
                }
            }
        }
        public int TotalTicketLeft()
        {
            string selectedEventName = cb_EventName.SelectedItem.ToString();
            int selectedEventId = db.Events.Where(ev => ev.EventName == selectedEventName).Select(ev => ev.EventID).FirstOrDefault();
            var ticketTransaction = db.TicketTransactions.Where(tt => tt.EventID == selectedEventId).ToList();

            int maxTicket = (int)db.Events.Where(ev => ev.EventName == selectedEventName).Select(ev => ev.MaxTicket).FirstOrDefault();
            int purchaseTicket = 0;

            foreach (var tt in ticketTransaction)
            {
                purchaseTicket += (int)tt.Qty;
            }
            int totalTicketleft = maxTicket - purchaseTicket;
            return totalTicketleft;
            //MessageBox.Show("total Ticketleft: " + totalTicketleft);
        }

        private void cb_ClientName_TextChanged(object sender, EventArgs e)
        {
            string searchTextLower = cb_ClientName.Text.ToLower(); //Convert to lower in case-sensitive
            cb_ClientName.Items.Clear(); //Clear existing of written word from user
            //Query the database to get all FullName
            var clientNames = db.Clients.Select(c => c.FullName).ToList();
            //Add client names matching the entered text
            foreach (string cn in clientNames)
            {
                if (cn.ToLower().Contains(searchTextLower))
                {
                    cb_ClientName.Items.Add(cn);
                }
            }
            cb_ClientName.DroppedDown = true; // Show dropdown list
        }

        private void txtBox_Qty_TextChanged(object sender, EventArgs e)
        {
            txtBox_TotalPrice.Text = GetTotalPrice().ToString();
        }
        public double GetTotalPrice()
        {
            double totalSumAmount = 0;

            if (!string.IsNullOrEmpty(txtBox_Qty.Text) && !string.IsNullOrEmpty(txtBox_Price.Text))
            {
                int qty = Convert.ToInt32(txtBox_Qty.Text);
                double price = Convert.ToDouble(txtBox_Price.Text);
                totalSumAmount = qty * price;
            }

            return totalSumAmount;
        }

        public void Clear()
        {
            txtBox_TransId.Text = GetCountTrans().ToString();
            cb_EventName.SelectedIndex = -1;
            cb_EventCategory.SelectedIndex = -1;
            cb_EventCity.SelectedIndex = -1;
            cb_EventCountry.SelectedIndex = -1;
            cb_ClientName.SelectedIndex = -1;
            txtBox_MaxTicket.Text = "";
            txtBox_TicketLeft.Text = "";
            txtBox_Qty.Text = "";
            txtBox_Price.Text = "";
            txtBox_TotalPrice.Text = "";
            dataGridView_ViewTicket.Rows.Clear();
        }

        private void btn_AddTrans_Click(object sender, EventArgs e)
        {
            TicketTransaction tt = new TicketTransaction();
            tt.TransactionID = Convert.ToInt32(txtBox_TransId.Text);
            tt.EventID = db.Events.Where(ev => ev.EventName == cb_EventName.Text)
                .Select(ev => ev.EventID).FirstOrDefault();
            tt.EventCategoryID = db.EventCategories.Where(ec => ec.CategoryName == cb_EventCategory.Text)
                .Select(ec => ec.EventCategoryID).FirstOrDefault();
            tt.CountryID = db.Countries.Where(co => co.CountryName == cb_EventCountry.Text)
                .Select(co => co.CountryID).FirstOrDefault();
            tt.CityID = db.Cities.Where(ct => ct.CityName == cb_EventCity.Text)
                .Select(ct => ct.CityID).FirstOrDefault();
            tt.ClientID = db.Clients.Where(cl => cl.FullName == cb_ClientName.Text)
                .Select(cl => cl.ClientID).FirstOrDefault();
            tt.Qty = Convert.ToInt32(txtBox_Qty.Text);
            tt.TotalPrice = Convert.ToDecimal(txtBox_TotalPrice.Text);
            tt.TransactionDate = DateTime.Now;
            tt.TransUpdateDate = DateTime.Now;
            db.TicketTransactions.Add(tt);
            db.SaveChanges();
            Clear();
            MessageBox.Show($"Add Transaction_ID {tt.TransactionID.ToString()} to Table Successfully...");
        }

        private void btn_UpdateTrans_Click(object sender, EventArgs e)
        {
            int transId = Convert.ToInt32(txtBox_TransId.Text);
            TicketTransaction tt = db.TicketTransactions.Where(tts => tts.TransactionID == transId).FirstOrDefault();
            if (tt != null)
            {
                tt.EventID = db.Events.Where(ev => ev.EventName == cb_EventName.Text)
                    .Select(ev => ev.EventID).FirstOrDefault();
                tt.EventCategoryID = db.EventCategories.Where(ec => ec.CategoryName == cb_EventCategory.Text)
                    .Select(ec => ec.EventCategoryID).FirstOrDefault();
                tt.CountryID = db.Countries.Where(co => co.CountryName == cb_EventCountry.Text)
                    .Select(co => co.CountryID).FirstOrDefault();
                tt.CityID = db.Cities.Where(ct => ct.CityName == cb_EventCity.Text)
                    .Select(ct => ct.CityID).FirstOrDefault();
                tt.ClientID = db.Clients.Where(cl => cl.FullName == cb_ClientName.Text)
                    .Select(cl => cl.ClientID).FirstOrDefault();
                tt.Qty = Convert.ToInt32(txtBox_Qty.Text);
                tt.TotalPrice = Convert.ToDecimal(txtBox_TotalPrice.Text);
                tt.TransUpdateDate = DateTime.Now;
            }
            db.SaveChanges();
            Clear();
            MessageBox.Show($"Update Transaction_ID {transId.ToString()} to Table Successfully...");
        }

        private void btn_DeleteTrans_Click(object sender, EventArgs e)
        {
            int transId = Convert.ToInt32(txtBox_TransId.Text);
            TicketTransaction tt = db.TicketTransactions.Where(tts => tts.TransactionID == transId).FirstOrDefault();
            if (tt != null)
            {
                db.TicketTransactions.Remove(tt);
                db.SaveChanges();
                Clear();
                MessageBox.Show($"Delete Transaction_ID {transId.ToString()} from Table Successfully...");
            }
        }

        private void btn_ClearTrans_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
