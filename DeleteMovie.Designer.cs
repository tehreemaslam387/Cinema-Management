namespace Cinema_Management
{
    partial class DeleteMovie
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
        private void DeleteMovie_Load(object sender, EventArgs e)
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
            label1 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewCheckBoxColumn();
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
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(224, 24);
            label1.Name = "label1";
            label1.Size = new Size(359, 46);
            label1.TabIndex = 0;
            label1.Text = "DELETE MOVIE FORM";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.Brown;
            button1.Location = new Point(468, 358);
            button1.Name = "button1";
            button1.Size = new Size(115, 32);
            button1.TabIndex = 3;
            button1.Text = "Delete Movie ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Brown;
            dataGridViewCellStyle2.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.Brown;
            dataGridView1.Location = new Point(12, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Brown;
            dataGridViewCellStyle3.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Size = new Size(776, 264);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "delete";
            Column1.Name = "Column1";
            Column1.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.Black;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.Brown;
            button2.Location = new Point(468, 396);
            button2.Name = "button2";
            button2.Size = new Size(115, 30);
            button2.TabIndex = 5;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // DeleteMovie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = Properties.Resources.login_and_signup;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "DeleteMovie";
            Text = "DeleteMovie";
            WindowState = FormWindowState.Maximized;
            Load += DeleteMovie_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private DataGridViewCheckBoxColumn Column1;
    }
}