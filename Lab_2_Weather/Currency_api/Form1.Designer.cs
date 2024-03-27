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
            PLN_CHART = new System.Windows.Forms.Button();
            EUR_CHART = new System.Windows.Forms.Button();
            GBP_CHART = new System.Windows.Forms.Button();
            JPY_CHART = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            PLN_CURRENT = new System.Windows.Forms.Label();
            EUR_CURRENT = new System.Windows.Forms.Label();
            GBP_CURRENT = new System.Windows.Forms.Label();
            JPY_CURRENT = new System.Windows.Forms.Label();
            chosen_list = new System.Windows.Forms.ListBox();
            PLN_list = new System.Windows.Forms.Button();
            EUR_List = new System.Windows.Forms.Button();
            GBP_List = new System.Windows.Forms.Button();
            JPY_List = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // Download
            // 
            Download.Location = new System.Drawing.Point(-1, -1);
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
            button1.Location = new System.Drawing.Point(-1, 415);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Erase";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // PLN_CHART
            // 
            PLN_CHART.Location = new System.Drawing.Point(162, 82);
            PLN_CHART.Name = "PLN_CHART";
            PLN_CHART.Size = new System.Drawing.Size(79, 23);
            PLN_CHART.TabIndex = 3;
            PLN_CHART.Text = "PLN_CHART";
            PLN_CHART.UseVisualStyleBackColor = true;
            PLN_CHART.Click += PLN_CHART_Click;
            // 
            // EUR_CHART
            // 
            EUR_CHART.Location = new System.Drawing.Point(247, 82);
            EUR_CHART.Name = "EUR_CHART";
            EUR_CHART.Size = new System.Drawing.Size(75, 23);
            EUR_CHART.TabIndex = 4;
            EUR_CHART.Text = "EUR_CHART";
            EUR_CHART.UseVisualStyleBackColor = true;
            EUR_CHART.Click += button2_Click;
            // 
            // GBP_CHART
            // 
            GBP_CHART.Location = new System.Drawing.Point(328, 82);
            GBP_CHART.Name = "GBP_CHART";
            GBP_CHART.Size = new System.Drawing.Size(75, 23);
            GBP_CHART.TabIndex = 5;
            GBP_CHART.Text = "GBP_CHART";
            GBP_CHART.UseVisualStyleBackColor = true;
            GBP_CHART.Click += GBP_CHART_Click;
            // 
            // JPY_CHART
            // 
            JPY_CHART.Location = new System.Drawing.Point(409, 82);
            JPY_CHART.Name = "JPY_CHART";
            JPY_CHART.Size = new System.Drawing.Size(75, 23);
            JPY_CHART.TabIndex = 6;
            JPY_CHART.Text = "JPY_CHART";
            JPY_CHART.UseVisualStyleBackColor = true;
            JPY_CHART.Click += JPY_CHART_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(110, 112);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(47, 15);
            label1.TabIndex = 7;
            label1.Text = "Current";
            label1.Click += label1_Click;
            // 
            // PLN_CURRENT
            // 
            PLN_CURRENT.AutoSize = true;
            PLN_CURRENT.Location = new System.Drawing.Point(183, 112);
            PLN_CURRENT.Name = "PLN_CURRENT";
            PLN_CURRENT.Size = new System.Drawing.Size(0, 15);
            PLN_CURRENT.TabIndex = 8;
            PLN_CURRENT.Click += PLN_CURRENT_Click;
            // 
            // EUR_CURRENT
            // 
            EUR_CURRENT.AutoSize = true;
            EUR_CURRENT.Location = new System.Drawing.Point(264, 112);
            EUR_CURRENT.Name = "EUR_CURRENT";
            EUR_CURRENT.Size = new System.Drawing.Size(0, 15);
            EUR_CURRENT.TabIndex = 9;
            // 
            // GBP_CURRENT
            // 
            GBP_CURRENT.AutoSize = true;
            GBP_CURRENT.Location = new System.Drawing.Point(344, 112);
            GBP_CURRENT.Name = "GBP_CURRENT";
            GBP_CURRENT.Size = new System.Drawing.Size(0, 15);
            GBP_CURRENT.TabIndex = 10;
            // 
            // JPY_CURRENT
            // 
            JPY_CURRENT.AutoSize = true;
            JPY_CURRENT.Location = new System.Drawing.Point(427, 112);
            JPY_CURRENT.Name = "JPY_CURRENT";
            JPY_CURRENT.Size = new System.Drawing.Size(0, 15);
            JPY_CURRENT.TabIndex = 11;
            // 
            // chosen_list
            // 
            chosen_list.FormattingEnabled = true;
            chosen_list.ItemHeight = 15;
            chosen_list.Location = new System.Drawing.Point(162, 168);
            chosen_list.Name = "chosen_list";
            chosen_list.Size = new System.Drawing.Size(322, 199);
            chosen_list.TabIndex = 12;
            // 
            // PLN_list
            // 
            PLN_list.Location = new System.Drawing.Point(166, 139);
            PLN_list.Name = "PLN_list";
            PLN_list.Size = new System.Drawing.Size(75, 23);
            PLN_list.TabIndex = 13;
            PLN_list.Text = "PLN";
            PLN_list.UseVisualStyleBackColor = true;
            PLN_list.Click += PLN_list_Click;
            // 
            // EUR_List
            // 
            EUR_List.Location = new System.Drawing.Point(247, 139);
            EUR_List.Name = "EUR_List";
            EUR_List.Size = new System.Drawing.Size(75, 23);
            EUR_List.TabIndex = 14;
            EUR_List.Text = "EUR";
            EUR_List.UseVisualStyleBackColor = true;
            EUR_List.Click += EUR_List_Click;
            // 
            // GBP_List
            // 
            GBP_List.Location = new System.Drawing.Point(328, 139);
            GBP_List.Name = "GBP_List";
            GBP_List.Size = new System.Drawing.Size(75, 23);
            GBP_List.TabIndex = 15;
            GBP_List.Text = "GBP";
            GBP_List.UseVisualStyleBackColor = true;
            GBP_List.Click += GBP_List_Click;
            // 
            // JPY_List
            // 
            JPY_List.Location = new System.Drawing.Point(409, 139);
            JPY_List.Name = "JPY_List";
            JPY_List.Size = new System.Drawing.Size(75, 23);
            JPY_List.TabIndex = 16;
            JPY_List.Text = "JPY";
            JPY_List.UseVisualStyleBackColor = true;
            JPY_List.Click += JPY_List_Click;
            // 
            // List_box
            // 
            ClientSize = new System.Drawing.Size(981, 554);
            Controls.Add(JPY_List);
            Controls.Add(GBP_List);
            Controls.Add(EUR_List);
            Controls.Add(PLN_list);
            Controls.Add(chosen_list);
            Controls.Add(JPY_CURRENT);
            Controls.Add(GBP_CURRENT);
            Controls.Add(EUR_CURRENT);
            Controls.Add(PLN_CURRENT);
            Controls.Add(label1);
            Controls.Add(JPY_CHART);
            Controls.Add(GBP_CHART);
            Controls.Add(EUR_CHART);
            Controls.Add(PLN_CHART);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(Download);
            Name = "List_box";
            Load += List_box_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.ListBox textBoxResponse;
        private System.Windows.Forms.Button Download_btn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PLN_CHART;
        private System.Windows.Forms.Button EUR_CHART;
        private System.Windows.Forms.Button GBP_CHART;
        private System.Windows.Forms.Button JPY_CHART;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PLN_CURRENT;
        private System.Windows.Forms.Label EUR_CURRENT;
        private System.Windows.Forms.Label GBP_CURRENT;
        private System.Windows.Forms.Label JPY_CURRENT;
        private System.Windows.Forms.ListBox chosen_list;
        private System.Windows.Forms.Button PLN_list;
        private System.Windows.Forms.Button EUR_List;
        private System.Windows.Forms.Button GBP_List;
        private System.Windows.Forms.Button JPY_List;
    }
}

