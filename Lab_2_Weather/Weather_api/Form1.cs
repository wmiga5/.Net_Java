using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_api
{
    public partial class List_box : Form
    {
        private HttpClient client;
        public List_box()
        {
            InitializeComponent();
            client = new HttpClient();
        }

        private void textBoxResponse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private async void Download_Click(object sender, EventArgs e)
        {
            string call = "https://openexchangerates.org/api/latest.json?app_id=a98ceda401564003a614eb50f6612207";
            string response = await client.GetStringAsync(call);
            listBox2.Items.Add(response);
        }

    }
}
