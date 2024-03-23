using System.Text.Json;
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

        private Currency_Exchange currency_Exchange;
        public List_box()
        {
            InitializeComponent();
            client = new HttpClient();
            currency_Exchange = new Currency_Exchange();
        }

        private void textBoxResponse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private async void Download_Click(object sender, EventArgs e)
        {
            string call = "https://openexchangerates.org/api/latest.json?app_id=a98ceda401564003a614eb50f6612207";
            string response = await client.GetStringAsync(call);

            rate_data myDeserializedClass = JsonSerializer.Deserialize<rate_data>(response);

            //foreach (string Input in myDeserializedClass.rates.ToString().Split('\n'))
            // {
            //    listBox2.Items.Add(Input);
            // }


            currency_Exchange.Currencies.Add(new Currency() { Tag = "PLN", Exchange = (float)myDeserializedClass.rates.PLN });
            currency_Exchange.SaveChanges();

            listBox2.DataSource = currency_Exchange.Currencies.ToList<Currency>();



        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            currency_Exchange.RemoveRange(currency_Exchange.Currencies);
            currency_Exchange.SaveChanges();
            listBox2.DataSource = currency_Exchange.Currencies.ToList<Currency>();
        }
    }
}
