using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Weather_api
{
    public partial class Chart_Form : Form
    {
        private List<Currency> ploted_data;
        public Chart_Form(List<Currency> get_data)
        {
            ploted_data = get_data;
            InitializeComponent();
        }

        private void Chart_Form_Load(object sender, EventArgs e)
        {
            Series series = new Series(ploted_data[0].Tag);

           
            series.ChartType = SeriesChartType.Point;

           
            foreach(Currency currency in ploted_data) 
            {
              
                
                DataPoint point= new DataPoint();
                point.SetValueXY(currency.ConvertTimestampToDateTime(), currency.Exchange);

                point.MarkerSize = 10;

              
                point.Label = currency.Exchange.ToString(); 
                point.LabelForeColor = Color.Black; 

                series.Points.Add(point);
            }
           

            
            chart1.Series.Add(series);



            chart1.ChartAreas[0].AxisX.Title = "Oś X";
            chart1.ChartAreas[0].AxisY.Title = "Oś Y";
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";

            chart1.ChartAreas[0].AxisY.Interval = 0.05; 
          

            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Hours;
            chart1.ChartAreas[0].AxisX.Interval = 1; 

            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            chart1.ChartAreas[0].AxisY.Minimum = Math.Round(ploted_data.OrderBy(c=>c.Exchange).Select(p=>p.Exchange).FirstOrDefault(),3)-0.2;
            chart1.ChartAreas[0].AxisY.Maximum = Math.Round(ploted_data.OrderBy(c => c.Exchange).Select(p => p.Exchange).LastOrDefault(), 3) + 0.2;


        }


            private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
