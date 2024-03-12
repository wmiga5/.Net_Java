using ConsoleApp1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Number_TB.Text, out int number))
            {
                if (number < 0)
                {
                    Number_TB.BackColor = Color.Red;
                }
                else
                {
                    Number_TB.BackColor = SystemColors.Window;
                }
            }
            else if (Number_TB.Text.Count() == 0)
            {
                Number_TB.BackColor = SystemColors.Window;
            }
            else
            {
                Number_TB.BackColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Backpack_size = 0;
            int Number = 0, Seed = 0;

            //  Console.WriteLine("WprowadŸ pojemnoœæ plecaka,ilosc elementow i seed:");
            Backpack_size = int.Parse(Capacity_TB.Text);
            Number = int.Parse(Number_TB.Text);
            Seed = int.Parse(Seed_TB.Text);
            Problem problem = new Problem(Number, Seed);

            Generated_problemLB.Items.Clear();
            Sorted_List_LB.Items.Clear();
            Result_LB.Items.Clear();
            //Console.WriteLine(problem);

            foreach (string Input in problem.ToString().Split('\n'))
            {
                Generated_problemLB.Items.Add(Input);
            }


            Result solved_problem = new(problem.Solve(Backpack_size));




            // Console.WriteLine(problem);
            foreach (string Input in problem.ToString().Split('\n'))
            {
                Sorted_List_LB.Items.Add(Input);
            }

            foreach (string Input in solved_problem.ToString().Split('\n'))
            {
                Result_LB.Items.Add(Input);
            }

            //Console.WriteLine(solved_problem);

        }



       

        private void Capacity_TB_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Capacity_TB.Text, out int number))
            {
                if (number < 0)
                {
                    Capacity_TB.BackColor = Color.Red;
                }
                else
                {
                    Capacity_TB.BackColor = SystemColors.Window;
                }
            }
            else if (Capacity_TB.Text.Count() == 0)
            {
                Capacity_TB.BackColor = SystemColors.Window;
            }
            else
            {
                Capacity_TB.BackColor = Color.Red;
            }
        }

        private void Seed_TB_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Seed_TB.Text, out int number))
            {
                if (number < 0)
                {
                    Seed_TB.BackColor = Color.Red;
                }
                else
                {
                    Seed_TB.BackColor = SystemColors.Window;
                }
            }
            else if (Seed_TB.Text.Count() == 0)
            {
                Seed_TB.BackColor = SystemColors.Window;
            }
            else
            {
                Seed_TB.BackColor = Color.Red;
            }
        }
    }
}
