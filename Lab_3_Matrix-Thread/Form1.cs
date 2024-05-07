
using System.Text;

namespace Matrix_Thread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        private void Seed_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Generate_button_Click(object sender, EventArgs e)
        {

            Matrix matrix_one = new Matrix(int.Parse(Seed_Input.Text), int.Parse(Size_Input.Text));
            Matrix matrix_two = new Matrix(int.Parse(Seed_Input.Text) + 2, int.Parse(Size_Input.Text));
            foreach (List<double> row in matrix_one.Values)
            {
                StringBuilder rowString = new StringBuilder();
                foreach (double val in row)
                {
                    rowString.Append(val).Append(" ");
                }
                Matrix_1.Items.Add(rowString.ToString().TrimEnd()); // Dodajemy pojedynczy wiersz do ListBox
            }

            foreach (List<double> row in matrix_two.Values)
            {
                StringBuilder rowString = new StringBuilder();
                foreach (double val in row)
                {
                    rowString.Append(val).Append(" ");
                }
                Matrix_2.Items.Add(rowString.ToString().TrimEnd()); // Dodajemy pojedynczy wiersz do ListBox
            }
            Multiplex multiplex = new Multiplex(matrix_one, matrix_two);
            double time1 = 0;
            double time2 = 0;
            for (int i = 1;i<8;i++) 
            {
                for(int j = 0;j<1;j++) 
                {
                    time1 = 0;
                    time2 = 0;
                    multiplex.Count_matrix(i, label1);
                    multiplex.Count_matrix_simple(i, label3);
                    time1 += double.Parse(label1.Text);
                    time2 += double.Parse(label3.Text);
                }
                Wyniki_LB.Items.Add("W¹tki: "+i+"| Thread: "+time1+"| Pararel: "+time2);
            }

          

            Matrix help1 =multiplex.result;
            Matrix help2= multiplex.result_simple;
            label2.Text = multiplex.get_counter().ToString();
           
            foreach (List<double> row in help1.Values)
            {
                StringBuilder rowString = new StringBuilder();
                foreach (double val in row)
                {
                    rowString.Append(val).Append(" ");
                }
                Matrix_Result.Items.Add(rowString.ToString().TrimEnd()); // Dodajemy pojedynczy wiersz do ListBox
            }



        }
        private void Count_Click(object sender, EventArgs e)
        {
            Matrix_1.Items.Clear();
            Matrix_2.Items.Clear();
            Matrix_Result.Items.Clear();
            Wyniki_LB.Items.Clear();
            label2.Text="";
        }
    }
}
