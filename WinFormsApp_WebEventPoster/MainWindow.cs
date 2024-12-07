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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.ShowDialog();
        }

        private void viewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewClient viewClient = new ViewClient();
            viewClient.ShowDialog();
        }

        private void addCountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCountry addCountry = new AddCountry();
            addCountry.ShowDialog();
        }

        private void viewCountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCountry viewCountry = new ViewCountry();
            viewCountry.ShowDialog();
        }

        private void addCityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCity addCity = new AddCity();
            addCity.ShowDialog();
        }

        private void viewCityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCity viewCity = new ViewCity();
            viewCity.ShowDialog();
        }

        private void addEventCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEventCategory addEventCategory = new AddEventCategory();
            addEventCategory.ShowDialog();
        }

        private void viewEventCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEventCategory viewEventCategory = new ViewEventCategory();
            viewEventCategory.ShowDialog();
        }

        private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEvent addEvent = new AddEvent();
            addEvent.ShowDialog();
        }

        private void viewEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEvent viewEvent = new ViewEvent();
            viewEvent.ShowDialog();
        }

        private void Ticket_Click(object sender, EventArgs e)
        {
            TransactionMenu transactionMenu = new TransactionMenu();
            transactionMenu.ShowDialog();
        }
    }
}
