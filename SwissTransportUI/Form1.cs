using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace SwissTransportUI
{
    public partial class Form1 : Form
    {
        private Transport Transport = new Transport();
        private ButtonSearchConnections ButtonSearchConnections = new ButtonSearchConnections();
        private Start Start = new Start();
        private Dest Dest = new Dest();
        private ButtonSearchDepartures ButtonSearchDepartures = new ButtonSearchDepartures();
        public static List<string> IdList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_search_connections_Click(object sender, EventArgs e)
        {
            lst_list.Items.Clear();
            List<string> tempConnections = ButtonSearchConnections.SearchConnections(txt_start.Text, txt_dest.Text);

            foreach (var item in tempConnections)
            {
                lst_list.Items.Add(item);
            }
        }

        private void txt_start_TextChanged(object sender, EventArgs e)
        {
            box_start.Items.Clear();
            List<string> tempStation = Start.SearchStart(txt_start.Text);

            foreach (var item in tempStation)
            {
                box_start.Items.Add(item);
            }
            
            if (box_start.Items.Count > 0)
            {
                box_start.SelectedIndex = 0;
            }
            else
            {
                box_start.Text = null;
            }
        }

        private void txt_dest_TextChanged(object sender, EventArgs e)
        {
            box_dest.Items.Clear();
            List<string> tempStation = Dest.SearchDest(txt_dest.Text);

            foreach (var item in tempStation)
            {
                box_dest.Items.Add(item);
            }

            if (box_dest.Items.Count > 0)
            {
                box_dest.SelectedIndex = 0;
            }
            else
            {
                box_dest.Text = null;
            }
        }

        private void btn_search_departures_Click(object sender, EventArgs e)
        {
            lst_list.Items.Clear();
            List<string> tempDepartures = ButtonSearchDepartures.SearchDepartures(txt_start.Text, IdList[box_start.SelectedIndex]);

            foreach (var item in tempDepartures)
            {
                lst_list.Items.Add(item);
            }
        }
    }
}