namespace Pictures_editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Bitmap? img;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.ShowDialog();
            var file = openFileDialog.FileName;
            if (file != null)
            {
                img =new Bitmap(file);
                Bitmap img1 = new Bitmap(img);
                Bitmap img2 = new Bitmap(img);
                Bitmap img3 = new Bitmap(img);
                Bitmap img4 = new Bitmap(img);

                Action[] Tasks = new Action[4];
                Tasks[0] = new Action(() => {  Negative(img1); });
                Tasks[1] = new Action(() => {  Black_or_White(img2); });
                Tasks[2] = new Action(() => { Countur(img3); });
                Tasks[3] = new Action(() => { Threshold(img4,60); });

                Parallel.Invoke(Tasks);

                pictureBox1.Image = img;
                pictureBox2.Image = img1;
                pictureBox3.Image = img2;
                pictureBox4.Image = img3;
                pictureBox5.Image = img4;
             
            }

        }

        static void Negative(Bitmap image)
        {
          

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color Original_color = image.GetPixel(x, y);
                    Color New_color = Color.FromArgb(255 - Original_color.R, 255 - Original_color.G, 255 - Original_color.B);
                    image.SetPixel(x, y, New_color);
                }
            }

          
        }

        static void Black_or_White(Bitmap image)
        {
           

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color Original_color = image.GetPixel(x, y);
                    int Avreage_color = (Original_color.R + Original_color.G + Original_color.B) / 3;
                    Color New_color = Color.FromArgb(Avreage_color, Avreage_color, Avreage_color);
                    image.SetPixel(x, y, New_color);
                } 
            }
            
        }
            static void  Countur(Bitmap image)
            {
               

                for (int x = 1; x < image.Width - 1; x++)
                {
                    for (int y = 1; y < image.Height - 1; y++)
                    {
                        Color Original_color = image.GetPixel(x, y);
                        Color Next_color = Color.Black;

                        Color Right_color = image.GetPixel(x + 1, y);
                        Color Bot_color = image.GetPixel(x, y + 1);

                        int diffR = Math.Abs(Original_color.R - Right_color.R) + Math.Abs(Original_color.R - Bot_color.R);
                        int diffG = Math.Abs(Original_color.G - Right_color.G) + Math.Abs(Original_color.G - Bot_color.G);
                        int diffB = Math.Abs(Original_color.B - Right_color.B) + Math.Abs(Original_color.B - Bot_color.B);

                        int diffTotal = diffR + diffG + diffB;
                        if (diffTotal > 50)
                        {
                            Next_color = Color.White;
                        }

                    image.SetPixel(x, y, Next_color);
                    }
                }

              
            }


            static void Threshold(Bitmap image, int threshold)
            {
                
                for (int x = 0; x < image.Width; x++)
                {
                    for (int y = 0; y < image.Height; y++)
                    {
                        Color Original_color = image.GetPixel(x, y);
                        Color nextColor = Original_color.R > threshold ? Color.White : Color.Black;
                        image.SetPixel(x, y, nextColor);
                    }
                }

               
            }


          
        }


    }

