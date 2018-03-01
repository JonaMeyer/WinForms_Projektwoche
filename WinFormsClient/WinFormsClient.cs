using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace WinFormsClient
{
    public partial class WinFormsClient : Form
    {
        AsyncTcpClient Client = new AsyncTcpClient();
        public WinFormsClient()
        {
            InitializeComponent();
        }

        private void WinFormsClient_Load(object sender, EventArgs e)
        {

        }

        private void cmdVerbinden_Click(object sender, EventArgs e)
        {
            string IpAdresse;
            IpAdresse = txtIpAdresse.Text;
            if (IpAdresse != "0.0.0.0")
            {
                IPAddress adresse = IPAddress.Parse(IpAdresse);
                Client.Connect(adresse, 22);
                if (Client.IsConnected == true)
                {
                    pbVerbindung.BackColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("Server konnte über die IP nicht erreicht werden!");
                }
            }
            else
            {
                MessageBox.Show("Bitte IP eingeben!");
            }
        }
    }
}
