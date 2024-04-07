namespace Matrix_Thread
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
            Matrix_1 = new ListBox();
            Matrix_2 = new ListBox();
            Matrix_Result = new ListBox();
            Seed_Input = new TextBox();
            Size_Input = new TextBox();
            Thread_Input = new TextBox();
            Generate_button = new Button();
            Count = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Matrix_1
            // 
            Matrix_1.FormattingEnabled = true;
            Matrix_1.ItemHeight = 15;
            Matrix_1.Location = new Point(3, 103);
            Matrix_1.Margin = new Padding(3, 2, 3, 2);
            Matrix_1.Name = "Matrix_1";
            Matrix_1.Size = new Size(381, 244);
            Matrix_1.TabIndex = 0;
            // 
            // Matrix_2
            // 
            Matrix_2.FormattingEnabled = true;
            Matrix_2.ItemHeight = 15;
            Matrix_2.Location = new Point(373, 103);
            Matrix_2.Margin = new Padding(3, 2, 3, 2);
            Matrix_2.Name = "Matrix_2";
            Matrix_2.Size = new Size(271, 244);
            Matrix_2.TabIndex = 1;
            // 
            // Matrix_Result
            // 
            Matrix_Result.FormattingEnabled = true;
            Matrix_Result.ItemHeight = 15;
            Matrix_Result.Location = new Point(657, 103);
            Matrix_Result.Margin = new Padding(3, 2, 3, 2);
            Matrix_Result.Name = "Matrix_Result";
            Matrix_Result.Size = new Size(271, 244);
            Matrix_Result.TabIndex = 2;
            // 
            // Seed_Input
            // 
            Seed_Input.Location = new Point(64, 41);
            Seed_Input.Margin = new Padding(3, 2, 3, 2);
            Seed_Input.Name = "Seed_Input";
            Seed_Input.Size = new Size(110, 23);
            Seed_Input.TabIndex = 3;
            Seed_Input.Text = "0";
            Seed_Input.TextChanged += Seed_Input_TextChanged;
            // 
            // Size_Input
            // 
            Size_Input.Location = new Point(205, 41);
            Size_Input.Margin = new Padding(3, 2, 3, 2);
            Size_Input.Name = "Size_Input";
            Size_Input.Size = new Size(110, 23);
            Size_Input.TabIndex = 4;
            // 
            // Thread_Input
            // 
            Thread_Input.Location = new Point(335, 41);
            Thread_Input.Margin = new Padding(3, 2, 3, 2);
            Thread_Input.Name = "Thread_Input";
            Thread_Input.Size = new Size(110, 23);
            Thread_Input.TabIndex = 5;
            // 
            // Generate_button
            // 
            Generate_button.Location = new Point(494, 41);
            Generate_button.Margin = new Padding(3, 2, 3, 2);
            Generate_button.Name = "Generate_button";
            Generate_button.Size = new Size(82, 22);
            Generate_button.TabIndex = 6;
            Generate_button.Text = "Generate";
            Generate_button.UseVisualStyleBackColor = true;
            Generate_button.Click += Generate_button_Click;
            // 
            // Count
            // 
            Count.Location = new Point(616, 40);
            Count.Name = "Count";
            Count.Size = new Size(75, 23);
            Count.TabIndex = 7;
            Count.Text = "button1";
            Count.UseVisualStyleBackColor = true;
            Count.Click += Count_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(797, 44);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1000, 60);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 9;
            label2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 392);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Count);
            Controls.Add(Generate_button);
            Controls.Add(Thread_Input);
            Controls.Add(Size_Input);
            Controls.Add(Seed_Input);
            Controls.Add(Matrix_Result);
            Controls.Add(Matrix_2);
            Controls.Add(Matrix_1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Matrix_1;
        private ListBox Matrix_2;
        private ListBox Matrix_Result;
        private TextBox Seed_Input;
        private TextBox Size_Input;
        private TextBox Thread_Input;
        private Button Generate_button;
        private Button Count;
        private Label label1;
        private Label label2;
    }
}
