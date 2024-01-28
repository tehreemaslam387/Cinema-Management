namespace Cinema_Management
{
    partial class Movies
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
        private void Movies_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.BackColor = Color.Black;
            headerStyle.ForeColor = Color.Brown;
            dataGridView1.ColumnHeadersDefaultCellStyle = headerStyle;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Brown;
            dataGridViewCellStyle1.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Brown;
            dataGridViewCellStyle2.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.Brown;
            dataGridView1.Location = new Point(12, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Brown;
            dataGridViewCellStyle3.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Size = new Size(770, 238);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(296, 9);
            label1.Name = "label1";
            label1.Size = new Size(206, 46);
            label1.TabIndex = 1;
            label1.Text = "Movies List ";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.Brown;
            button1.Location = new Point(568, 327);
            button1.Name = "button1";
            button1.Size = new Size(89, 33);
            button1.TabIndex = 2;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Movies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BackgroundImage = Properties.Resources.login_and_signup;
            ClientSize = new Size(794, 372);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Movies";
            Text = "Movies";
            WindowState = FormWindowState.Maximized;
            Load += Movies_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
    }
}