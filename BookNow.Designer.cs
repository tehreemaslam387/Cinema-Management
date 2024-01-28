namespace Cinema_Management
{
    partial class BookNow
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
        private void BookNow_Load(object sender, EventArgs e)
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewCheckBoxColumn();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(149, -7);
            label1.Name = "label1";
            label1.Size = new Size(468, 46);
            label1.TabIndex = 0;
            label1.Text = "BOOK YOUR MOVIE NOW!!!";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Brown;
            dataGridViewCellStyle1.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Brown;
            dataGridViewCellStyle3.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.GridColor = Color.Brown;
            dataGridView1.Location = new Point(28, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.Brown;
            dataGridViewCellStyle4.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Size = new Size(703, 153);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.ForeColor = Color.Brown;
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.SelectionBackColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = Color.Brown;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Column1.DefaultCellStyle = dataGridViewCellStyle2;
            Column1.HeaderText = "Book Now";
            Column1.Name = "Column1";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(15, 253);
            label2.Name = "label2";
            label2.Size = new Size(183, 25);
            label2.TabIndex = 2;
            label2.Text = "Enter Your Name   :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(8, 282);
            label3.Name = "label3";
            label3.Size = new Size(190, 25);
            label3.TabIndex = 3;
            label3.Text = "Number Of Tickets :";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.Black;
            textBox1.ForeColor = Color.Brown;
            textBox1.Location = new Point(198, 256);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BackColor = Color.Black;
            textBox2.ForeColor = Color.Brown;
            textBox2.Location = new Point(198, 285);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(127, 23);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.Brown;
            button1.Location = new Point(494, 384);
            button1.Name = "button1";
            button1.Size = new Size(109, 31);
            button1.TabIndex = 6;
            button1.Text = "Book Now ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.Black;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.Brown;
            button2.Location = new Point(494, 421);
            button2.Name = "button2";
            button2.Size = new Size(109, 31);
            button2.TabIndex = 7;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // BookNow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = Properties.Resources.bookk;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "BookNow";
            Text = "BookNow";
            WindowState = FormWindowState.Maximized;
            Load += BookNow_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private DataGridViewCheckBoxColumn Column1;
    }
}