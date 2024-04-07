using System.Security.Cryptography.X509Certificates;
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
            
            var watch=System.Diagnostics.Stopwatch.StartNew();
            Matrix help = multiplex.Count_matrix(int.Parse(Thread_Input.Text));
            watch.Stop();
            label1.Text = watch.Elapsed.ToString();
            foreach (List<double> row in help.Values)
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

        }
    }
}
