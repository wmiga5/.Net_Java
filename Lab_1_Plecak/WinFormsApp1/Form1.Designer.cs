
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Generated_problemLB = new ListBox();
            Result_LB = new ListBox();
            Capacity_TB = new TextBox();
            Number_TB = new TextBox();
            Seed_TB = new TextBox();
            Run_btn = new Button();
            Sorted_List_LB = new ListBox();
            Capacity_LB = new Label();
            Number_LB = new Label();
            Seed_LB = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Generated_problemLB
            // 
            Generated_problemLB.FormattingEnabled = true;
            Generated_problemLB.ItemHeight = 15;
            Generated_problemLB.Location = new Point(680, 49);
            Generated_problemLB.MultiColumn = true;
            Generated_problemLB.Name = "Generated_problemLB";
            Generated_problemLB.Size = new Size(297, 424);
            Generated_problemLB.TabIndex = 0;
            Generated_problemLB.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Result_LB
            // 
            Result_LB.FormattingEnabled = true;
            Result_LB.ItemHeight = 15;
            Result_LB.Location = new Point(21, 259);
            Result_LB.Name = "Result_LB";
            Result_LB.Size = new Size(410, 214);
            Result_LB.TabIndex = 1;
            Result_LB.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // Capacity_TB
            // 
            Capacity_TB.Location = new Point(34, 49);
            Capacity_TB.Name = "Capacity_TB";
            Capacity_TB.Size = new Size(100, 23);
            Capacity_TB.TabIndex = 2;
            Capacity_TB.TextChanged += Capacity_TB_TextChanged;
            // 
            // Number_TB
            // 
            Number_TB.Location = new Point(156, 49);
            Number_TB.Name = "Number_TB";
            Number_TB.Size = new Size(100, 23);
            Number_TB.TabIndex = 3;
            Number_TB.TextChanged += textBox2_TextChanged;
            // 
            // Seed_TB
            // 
            Seed_TB.Location = new Point(280, 49);
            Seed_TB.Name = "Seed_TB";
            Seed_TB.Size = new Size(100, 23);
            Seed_TB.TabIndex = 4;
            // 
            // Run_btn
            // 
            Run_btn.Location = new Point(34, 207);
            Run_btn.Name = "Run_btn";
            Run_btn.Size = new Size(75, 23);
            Run_btn.TabIndex = 5;
            Run_btn.Text = "RUN\r\n";
            Run_btn.UseVisualStyleBackColor = true;
            Run_btn.Click += button1_Click;
            // 
            // Sorted_List_LB
            // 
            Sorted_List_LB.FormattingEnabled = true;
            Sorted_List_LB.ItemHeight = 15;
            Sorted_List_LB.Location = new Point(437, 49);
            Sorted_List_LB.Name = "Sorted_List_LB";
            Sorted_List_LB.Size = new Size(237, 424);
            Sorted_List_LB.TabIndex = 7;
            Sorted_List_LB.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // Capacity_LB
            // 
            Capacity_LB.AutoSize = true;
            Capacity_LB.Location = new Point(41, 24);
            Capacity_LB.Name = "Capacity_LB";
            Capacity_LB.Size = new Size(53, 15);
            Capacity_LB.TabIndex = 8;
            Capacity_LB.Text = "Capacity";
            Capacity_LB.Click += label1_Click;
            // 
            // Number_LB
            // 
            Number_LB.AutoSize = true;
            Number_LB.Location = new Point(163, 26);
            Number_LB.Name = "Number_LB";
            Number_LB.Size = new Size(51, 15);
            Number_LB.TabIndex = 9;
            Number_LB.Text = "Number";
            // 
            // Seed_LB
            // 
            Seed_LB.AutoSize = true;
            Seed_LB.Location = new Point(285, 24);
            Seed_LB.Name = "Seed_LB";
            Seed_LB.Size = new Size(32, 15);
            Seed_LB.TabIndex = 10;
            Seed_LB.Text = "Seed";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(438, 27);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 11;
            label1.Text = "Sorted";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(681, 27);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 12;
            label2.Text = "Problem";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(989, 499);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Seed_LB);
            Controls.Add(Number_LB);
            Controls.Add(Capacity_LB);
            Controls.Add(Sorted_List_LB);
            Controls.Add(Run_btn);
            Controls.Add(Seed_TB);
            Controls.Add(Number_TB);
            Controls.Add(Capacity_TB);
            Controls.Add(Result_LB);
            Controls.Add(Generated_problemLB);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private ListBox Generated_problemLB;
        private ListBox Result_LB;
        private TextBox Capacity_TB;
        private TextBox Number_TB;
        private TextBox Seed_TB;
        private Button Run_btn;
        private ListBox Sorted_List_LB;
        private Label Capacity_LB;
        private Label Number_LB;
        private Label Seed_LB;
        private Label label1;
        private Label label2;
    }
}
