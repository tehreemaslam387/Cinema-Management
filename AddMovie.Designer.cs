using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace Cinema_Management
{
    partial class AddMovie
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
        private void AddMovie_Load(object sender, EventArgs e)
        {

        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMovie));
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(91, 23);
            label1.Name = "label1";
            label1.Size = new Size(297, 46);
            label1.TabIndex = 0;
            label1.Text = "Add Movies Form";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.Black;
            textBox1.ForeColor = Color.Brown;
            textBox1.Location = new Point(172, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BackColor = Color.Black;
            textBox2.ForeColor = Color.Brown;
            textBox2.Location = new Point(172, 137);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.BackColor = Color.Black;
            textBox3.ForeColor = Color.Brown;
            textBox3.Location = new Point(172, 167);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(190, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.BackColor = Color.Black;
            textBox4.ForeColor = Color.Brown;
            textBox4.Location = new Point(172, 195);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(190, 23);
            textBox4.TabIndex = 4;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.Brown;
            button1.Location = new Point(257, 265);
            button1.Name = "button1";
            button1.Size = new Size(105, 33);
            button1.TabIndex = 5;
            button1.Text = "Add Movie ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(71, 112);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 6;
            label2.Text = " Enter Title   :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(61, 141);
            label3.Name = "label3";
            label3.Size = new Size(104, 19);
            label3.TabIndex = 7;
            label3.Text = "Enter Genre    :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(29, 167);
            label4.Name = "label4";
            label4.Size = new Size(137, 19);
            label4.TabIndex = 8;
            label4.Text = "Enter Release Date :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.Brown;
            label5.Location = new Point(57, 195);
            label5.Name = "label5";
            label5.Size = new Size(109, 19);
            label5.TabIndex = 9;
            label5.Text = "Enter Timings  :";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = Color.Brown;
            label6.Location = new Point(45, 224);
            label6.Name = "label6";
            label6.Size = new Size(121, 19);
            label6.TabIndex = 10;
            label6.Text = "Price Per Ticket  :";
            label6.Click += label6_Click;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.BackColor = Color.Black;
            textBox5.ForeColor = Color.Brown;
            textBox5.Location = new Point(172, 224);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(190, 23);
            textBox5.TabIndex = 11;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.Black;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.Brown;
            button2.Location = new Point(412, 327);
            button2.Name = "button2";
            button2.Size = new Size(105, 29);
            button2.TabIndex = 12;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AddMovie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.Gray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "AddMovie";
            Text = "AddMovie";
            WindowState = FormWindowState.Maximized;
            Load += AddMovie_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private Button button2;
    }
}