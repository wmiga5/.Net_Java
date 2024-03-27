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
            string call = "https://openexchangerates.org/api/latest.json?app_id=c07df9e7b4f74d9aa2f6e7313f00eb10";
            string response = await client.GetStringAsync(call);

            rate_data myDeserializedClass = JsonSerializer.Deserialize<rate_data>(response);

            //foreach (string Input in myDeserializedClass.rates.ToString().Split('\n'))
            // {
            //    listBox2.Items.Add(Input);
            // }




            if (myDeserializedClass.rates.PLN != currency_Exchange.Currencies.Where(p => p.Tag == "PLN").OrderByDescending(p => p.timestamp_number).Select(p => p.Exchange).FirstOrDefault())
            {
                currency_Exchange.Currencies.Add(new Currency()
                {
                    Tag = "PLN",
                    Exchange = myDeserializedClass.rates.PLN,
                    timestamp_number = myDeserializedClass.timestamp
                });

            }
            if (myDeserializedClass.rates.EUR != currency_Exchange.Currencies.Where(p => p.Tag == "EUR").OrderByDescending(p => p.timestamp_number).Select(p => p.Exchange).FirstOrDefault())
            {
                currency_Exchange.Currencies.Add(new Currency()
                {
                    Tag = "EUR",
                    Exchange = (float)myDeserializedClass.rates.EUR,
                    timestamp_number = myDeserializedClass.timestamp
                });
            }
            if (myDeserializedClass.rates.JPY != currency_Exchange.Currencies.Where(p => p.Tag == "JPY").OrderByDescending(p => p.timestamp_number).Select(p => p.Exchange).FirstOrDefault())
            {
                currency_Exchange.Currencies.Add(new Currency()
                {
                    Tag = "JPY",
                    Exchange = (float)myDeserializedClass.rates.JPY,
                    timestamp_number = myDeserializedClass.timestamp
                });
            }
            if (myDeserializedClass.rates.GBP != currency_Exchange.Currencies.Where(p => p.Tag == "GBP").OrderByDescending(p => p.timestamp_number).Select(p => p.Exchange).FirstOrDefault())
            {
                currency_Exchange.Currencies.Add(new Currency()
                {
                    Tag = "GBP",
                    Exchange = (float)myDeserializedClass.rates.GBP,
                    timestamp_number = myDeserializedClass.timestamp
                });
            }


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

        private void PLN_CHART_Click(object sender, EventArgs e)
        {
            Chart_Form chartForm = new Chart_Form(currency_Exchange.Currencies.Where(p => p.Tag == "PLN").ToList());


            chartForm.ShowDialog();

        }

        private void List_box_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Chart_Form chartForm = new Chart_Form(currency_Exchange.Currencies.Where(p => p.Tag == "EUR").ToList());


            chartForm.ShowDialog();
        }

        private void GBP_CHART_Click(object sender, EventArgs e)
        {
            Chart_Form chartForm = new Chart_Form(currency_Exchange.Currencies.Where(p => p.Tag == "GBP").ToList());


            chartForm.ShowDialog();
        }

        private void JPY_CHART_Click(object sender, EventArgs e)
        {
            Chart_Form chartForm = new Chart_Form(currency_Exchange.Currencies.Where(p => p.Tag == "JPY").ToList());


            chartForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            PLN_CURRENT.Text = Math.Round(currency_Exchange.Currencies.Where(p => p.Tag == "PLN").OrderByDescending(p => p.timestamp_number).Select(p => p.Exchange).First(), 3).ToString();
            EUR_CURRENT.Text = Math.Round(currency_Exchange.Currencies.Where(p => p.Tag == "EUR").OrderByDescending(p => p.timestamp_number).Select(p => p.Exchange).First(), 3).ToString();
            GBP_CURRENT.Text = Math.Round(currency_Exchange.Currencies.Where(p => p.Tag == "GBP").OrderByDescending(p => p.timestamp_number).Select(p => p.Exchange).First(), 3).ToString();
            JPY_CURRENT.Text = Math.Round(currency_Exchange.Currencies.Where(p => p.Tag == "JPY").OrderByDescending(p => p.timestamp_number).Select(p => p.Exchange).First(), 3).ToString();


        }

        private void PLN_CURRENT_Click(object sender, EventArgs e)
        {

        }

        private void PLN_list_Click(object sender, EventArgs e)
        {
            chosen_list.DataSource = currency_Exchange.Currencies.Where(p => p.Tag == "PLN").ToList();
        }

        private void EUR_List_Click(object sender, EventArgs e)
        {
            chosen_list.DataSource = currency_Exchange.Currencies.Where(p => p.Tag == "EUR").ToList();
        }

        private void GBP_List_Click(object sender, EventArgs e)
        {
            chosen_list.DataSource = currency_Exchange.Currencies.Where(p => p.Tag == "GBP").ToList();
        }

        private void JPY_List_Click(object sender, EventArgs e)
        {
            chosen_list.DataSource = currency_Exchange.Currencies.Where(p => p.Tag == "JPY").ToList();
        }
    }

}
