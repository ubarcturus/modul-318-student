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
        Transport Transport = new Transport();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Connections connections = Transport.GetConnections(txt_start.Text, txt_dest.Text);
            lst_list.Items.Clear();
            foreach (var item in connections.ConnectionList)
            {
                lst_list.Items.Add(item.Duration + item.From.Station.Name + item.To.Station.Name);
            }
        }

        private void txt_start_TextChanged(object sender, EventArgs e)
        {
            Stations stations = Transport.GetStations(txt_start.Text);
            box_start.Items.Clear();
            foreach (var item in stations.StationList)
            {
                if (item.Name != null)
                {
                    box_start.Items.Add(item.Name);
                }
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
            Stations stations = Transport.GetStations(txt_dest.Text);
            box_dest.Items.Clear();
            foreach (var item in stations.StationList)
            {
                if (item.Name != null)
                {
                    box_dest.Items.Add(item.Name);
                }
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
    }
}
