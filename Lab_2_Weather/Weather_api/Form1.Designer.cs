namespace Weather_api
{
    partial class List_box
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Download = new System.Windows.Forms.Button();
            listBox2 = new System.Windows.Forms.ListBox();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // Download
            // 
            Download.Location = new System.Drawing.Point(336, 131);
            Download.Name = "Download";
            Download.Size = new System.Drawing.Size(75, 23);
            Download.TabIndex = 0;
            Download.Text = "Download";
            Download.UseVisualStyleBackColor = true;
            Download.Click += Download_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new System.Drawing.Point(509, 78);
            listBox2.Name = "listBox2";
            listBox2.Size = new System.Drawing.Size(416, 289);
            listBox2.TabIndex = 1;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(347, 233);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Erase";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // List_box
            // 
            ClientSize = new System.Drawing.Size(981, 438);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(Download);
            Name = "List_box";
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.ListBox textBoxResponse;
        private System.Windows.Forms.Button Download_btn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
    }
}

