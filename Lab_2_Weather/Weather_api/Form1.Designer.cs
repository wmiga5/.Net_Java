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
            this.Download = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Download
            // 
            this.Download.Location = new System.Drawing.Point(336, 131);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(75, 23);
            this.Download.TabIndex = 0;
            this.Download.Text = "button1";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(509, 78);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(416, 292);
            this.listBox2.TabIndex = 1;
            // 
            // List_box
            // 
            this.ClientSize = new System.Drawing.Size(981, 438);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.Download);
            this.Name = "List_box";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox textBoxResponse;
        private System.Windows.Forms.Button Download_btn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.ListBox listBox2;
    }
}

