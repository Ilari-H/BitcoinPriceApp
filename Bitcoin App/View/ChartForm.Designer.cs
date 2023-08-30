namespace T3._1.View
{
    partial class ChartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartForm));
            label5 = new Label();
            btnDraw = new Button();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, -1);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 1;
            // 
            // btnDraw
            // 
            btnDraw.Location = new Point(11, 4);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(64, 23);
            btnDraw.TabIndex = 2;
            btnDraw.Text = "Draw";
            btnDraw.UseVisualStyleBackColor = true;
            btnDraw.Click += btnDraw_Click;
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(127, 4);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(78, 23);
            dtpFrom.TabIndex = 3;
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(246, 4);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(78, 23);
            dtpTo.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(83, 8);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "From:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(218, 8);
            label7.Name = "label7";
            label7.Size = new Size(22, 15);
            label7.TabIndex = 6;
            label7.Text = "To:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnDraw);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dtpFrom);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dtpTo);
            panel1.Location = new Point(-8, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 30);
            panel1.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(423, 8);
            label8.Name = "label8";
            label8.Size = new Size(245, 15);
            label8.TabIndex = 8;
            label8.Text = "Reopen if not loading or showin incorrect time";
            // 
            // ChartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 431);
            Controls.Add(panel1);
            Controls.Add(label5);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ChartForm";
            Text = "Bitcoin Chart";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lTo;
        private Label lFrom;
        private Label label5;
        private Button btnDraw;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Label label8;
    }
}