namespace Cinema_Management
{
    partial class SignupForm
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(277, 120);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 0;
            label1.Text = "Username ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(277, 145);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = SystemColors.InfoText;
            textBox1.ForeColor = SystemColors.Info;
            textBox1.Location = new Point(385, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BackColor = SystemColors.MenuText;
            textBox2.ForeColor = SystemColors.Info;
            textBox2.Location = new Point(385, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(277, 185);
            button1.Name = "button1";
            button1.Size = new Size(211, 39);
            button1.TabIndex = 4;
            button1.Text = "SignUp";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login_and_signup;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignupForm";
            Text = "SignupForm";
            WindowState = FormWindowState.Maximized;
            Load += SignupForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}