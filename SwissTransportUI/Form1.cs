using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SwissTransport;

namespace SwissTransportUI
{
    public partial class Form1 : Form
    {
        public static List<string> IdList = new List<string>();
        private readonly ButtonSearchConnections _buttonSearchConnections = new ButtonSearchConnections();
        private readonly ButtonSearchDepartures _buttonSearchDepartures = new ButtonSearchDepartures();
        private readonly Dest _dest = new Dest();
        private readonly Start _start = new Start();
        private Transport _transport = new Transport();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_search_connections_Click(object sender, EventArgs e)
        {
            lst_list.Items.Clear();
            var tempConnections = _buttonSearchConnections.SearchConnections(txt_start.Text, txt_dest.Text);

            foreach (var item in tempConnections) lst_list.Items.Add(item);
        }

        private void txt_start_TextChanged(object sender, EventArgs e)
        {
            box_start.Items.Clear();
            var tempStation = _start.SearchStart(txt_start.Text);

            foreach (var item in tempStation) box_start.Items.Add(item);

            if (box_start.Items.Count > 0)
                box_start.SelectedIndex = 0;
            else
                box_start.Text = null;
        }

        private void txt_dest_TextChanged(object sender, EventArgs e)
        {
            box_dest.Items.Clear();
            var tempStation = _dest.SearchDest(txt_dest.Text);

            foreach (var item in tempStation) box_dest.Items.Add(item);

            if (box_dest.Items.Count > 0)
                box_dest.SelectedIndex = 0;
            else
                box_dest.Text = null;
        }

        private void btn_search_departures_Click(object sender, EventArgs e)
        {
            lst_list.Items.Clear();
            var tempDepartures =
                _buttonSearchDepartures.SearchDepartures(txt_start.Text, IdList[box_start.SelectedIndex]);

            foreach (var item in tempDepartures) lst_list.Items.Add(item);
        }
    }
}