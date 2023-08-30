namespace T3._1
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            UnixTimeLabel = new Label();
            panel1 = new Panel();
            cbBTC = new ComboBox();
            label11 = new Label();
            btnSearch = new Button();
            label4 = new Label();
            label3 = new Label();
            dtpEnd = new DateTimePicker();
            dtpStart = new DateTimePicker();
            label2 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            label13 = new Label();
            lFrom = new Label();
            lTo = new Label();
            llSeeChart = new LinkLabel();
            label8 = new Label();
            label9 = new Label();
            rtbConsole = new RichTextBox();
            lBTCSearch = new Label();
            label6 = new Label();
            panel3 = new Panel();
            lError = new Label();
            label12 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Current time: ";
            // 
            // UnixTimeLabel
            // 
            UnixTimeLabel.AutoSize = true;
            UnixTimeLabel.Location = new Point(76, 7);
            UnixTimeLabel.Name = "UnixTimeLabel";
            UnixTimeLabel.Size = new Size(29, 15);
            UnixTimeLabel.TabIndex = 1;
            UnixTimeLabel.Text = "N/A";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cbBTC);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dtpEnd);
            panel1.Controls.Add(dtpStart);
            panel1.Location = new Point(3, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(154, 161);
            panel1.TabIndex = 3;
            // 
            // cbBTC
            // 
            cbBTC.FormattingEnabled = true;
            cbBTC.Items.AddRange(new object[] { "Price", "Volume" });
            cbBTC.Location = new Point(41, 8);
            cbBTC.Name = "cbBTC";
            cbBTC.Size = new Size(98, 23);
            cbBTC.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(0, 11);
            label11.Name = "label11";
            label11.Size = new Size(26, 15);
            label11.TabIndex = 6;
            label11.Text = "BTC";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(26, 133);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += BtnSearch_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 81);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 3;
            label4.Text = "To";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 51);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 2;
            label3.Text = "From";
            // 
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(41, 77);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(97, 23);
            dtpEnd.TabIndex = 1;
            dtpEnd.Value = new DateTime(2023, 5, 15, 0, 0, 0, 0);
            // 
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(42, 48);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(97, 23);
            dtpStart.TabIndex = 0;
            dtpStart.Value = new DateTime(2023, 5, 15, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 26);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Search";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(191, 26);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 6;
            label5.Text = "Bitcoin";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label13);
            panel2.Controls.Add(lFrom);
            panel2.Controls.Add(lTo);
            panel2.Controls.Add(llSeeChart);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(rtbConsole);
            panel2.Controls.Add(lBTCSearch);
            panel2.Location = new Point(163, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(415, 321);
            panel2.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(103, 297);
            label13.Name = "label13";
            label13.Size = new Size(38, 15);
            label13.TabIndex = 8;
            label13.Text = "From:";
            // 
            // lFrom
            // 
            lFrom.AutoSize = true;
            lFrom.Location = new Point(147, 297);
            lFrom.Name = "lFrom";
            lFrom.Size = new Size(29, 15);
            lFrom.TabIndex = 5;
            lFrom.Text = "N/A";
            // 
            // lTo
            // 
            lTo.AutoSize = true;
            lTo.Location = new Point(264, 297);
            lTo.Name = "lTo";
            lTo.Size = new Size(29, 15);
            lTo.TabIndex = 4;
            lTo.Text = "N/A";
            // 
            // llSeeChart
            // 
            llSeeChart.AutoSize = true;
            llSeeChart.Location = new Point(18, 5);
            llSeeChart.Name = "llSeeChart";
            llSeeChart.Size = new Size(97, 15);
            llSeeChart.TabIndex = 6;
            llSeeChart.TabStop = true;
            llSeeChart.Text = "See in chart form";
            llSeeChart.LinkClicked += llSeeChart_LinkClicked;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 297);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 3;
            label8.Text = "Bitcoin";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(246, 297);
            label9.Name = "label9";
            label9.Size = new Size(22, 15);
            label9.TabIndex = 2;
            label9.Text = "To:";
            // 
            // rtbConsole
            // 
            rtbConsole.BackColor = Color.Black;
            rtbConsole.ForeColor = Color.White;
            rtbConsole.Location = new Point(18, 23);
            rtbConsole.Name = "rtbConsole";
            rtbConsole.ReadOnly = true;
            rtbConsole.Size = new Size(379, 271);
            rtbConsole.TabIndex = 0;
            rtbConsole.Text = "";
            // 
            // lBTCSearch
            // 
            lBTCSearch.AutoSize = true;
            lBTCSearch.Location = new Point(59, 297);
            lBTCSearch.Name = "lBTCSearch";
            lBTCSearch.Size = new Size(29, 15);
            lBTCSearch.TabIndex = 7;
            lBTCSearch.Text = "N/A";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 199);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 6;
            label6.Text = "Info";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lError);
            panel3.Controls.Add(label12);
            panel3.Location = new Point(3, 208);
            panel3.Name = "panel3";
            panel3.Size = new Size(154, 148);
            panel3.TabIndex = 5;
            // 
            // lError
            // 
            lError.AutoSize = true;
            lError.Location = new Point(12, 33);
            lError.Name = "lError";
            lError.Size = new Size(29, 15);
            lError.TabIndex = 8;
            lError.Text = "N/A";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(8, 18);
            label12.Name = "label12";
            label12.Size = new Size(40, 15);
            label12.TabIndex = 7;
            label12.Text = "Errors:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(582, 360);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(UnixTimeLabel);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Market app";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label UnixTimeLabel;
        private Panel panel1;
        private Label label2;
        private Button btnSearch;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpEnd;
        private DateTimePicker dtpStart;
        private Label label5;
        private Panel panel2;
        private Label lFrom;
        private Label lTo;
        private Label label8;
        private Label label9;
        private RichTextBox rtbConsole;
        private Label label6;
        private Panel panel3;
        private LinkLabel llSeeChart;
        private Label lError;
        private Label label12;
        private ComboBox cbBTC;
        private Label label11;
        private Label label13;
        private Label lBTCSearch;
    }
}