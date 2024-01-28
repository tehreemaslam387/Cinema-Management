namespace Cinema_Management
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 50F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(-140, 9);
            label1.Name = "label1";
            label1.Size = new Size(1052, 89);
            label1.TabIndex = 0;
            label1.Text = "CINEMA MANAGEMENT SYSTEM";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(329, 98);
            label2.Name = "label2";
            label2.Size = new Size(96, 37);
            label2.TabIndex = 1;
            label2.Text = "MENU";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Firebrick;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(316, 141);
            button1.Name = "button1";
            button1.Size = new Size(129, 35);
            button1.TabIndex = 2;
            button1.Text = "Movies List";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.Firebrick;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.Location = new Point(316, 182);
            button2.Name = "button2";
            button2.Size = new Size(129, 35);
            button2.TabIndex = 3;
            button2.Text = "Add Movie";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.Firebrick;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.Location = new Point(316, 223);
            button3.Name = "button3";
            button3.Size = new Size(129, 36);
            button3.TabIndex = 4;
            button3.Text = "Delete Movie";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.Firebrick;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button4.Location = new Point(316, 265);
            button4.Name = "button4";
            button4.Size = new Size(129, 35);
            button4.TabIndex = 5;
            button4.Text = "Book Now";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.BackColor = Color.Firebrick;
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button5.Location = new Point(316, 306);
            button5.Name = "button5";
            button5.Size = new Size(129, 37);
            button5.TabIndex = 6;
            button5.Text = "About Us";
            button5.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = Properties.Resources.menu;
            ClientSize = new Size(801, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cinema Management System";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
