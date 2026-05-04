namespace BloodBankManagmentSystem.Presentation_Layer
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            imageList1 = new ImageList(components);
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            button2 = new Button();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colID1 = new DataGridViewTextBoxColumn();
            colID2 = new DataGridViewTextBoxColumn();
            colID3 = new DataGridViewTextBoxColumn();
            colID5 = new DataGridViewTextBoxColumn();
            label6 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1141, 122);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.DarkOrchid;
            label1.Location = new Point(138, 45);
            label1.Name = "label1";
            label1.Size = new Size(376, 46);
            label1.TabIndex = 0;
            label1.Text = "Donation / Blood Unit";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "blood-test.png");
            imageList1.Images.SetKeyName(1, "back.png");
            imageList1.Images.SetKeyName(2, "search.png");
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(0, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 313);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Donation Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 48);
            label2.Name = "label2";
            label2.Size = new Size(132, 28);
            label2.TabIndex = 0;
            label2.Text = "Donation ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 95);
            label3.Name = "label3";
            label3.Size = new Size(156, 28);
            label3.TabIndex = 1;
            label3.Text = "Donation Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 145);
            label4.Name = "label4";
            label4.Size = new Size(144, 28);
            label4.TabIndex = 2;
            label4.Text = "Quantity (ml):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 193);
            label5.Name = "label5";
            label5.Size = new Size(77, 28);
            label5.TabIndex = 3;
            label5.Text = "Donor:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 34);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 34);
            textBox2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(200, 102);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(172, 34);
            dateTimePicker1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(200, 193);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(172, 36);
            comboBox1.TabIndex = 7;
            // 
            // button2
            // 
            button2.BackColor = Color.YellowGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(99, 248);
            button2.Name = "button2";
            button2.Size = new Size(174, 37);
            button2.TabIndex = 9;
            button2.Text = "Add Donation";
            button2.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(407, 135);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(702, 306);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Blood Units List";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colID, colID1, colID2, colID3, colID5 });
            dataGridView1.GridColor = SystemColors.MenuText;
            dataGridView1.Location = new Point(6, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(680, 254);
            dataGridView1.TabIndex = 0;
            // 
            // colID
            // 
            colID.HeaderText = "Blood Unit ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colID1
            // 
            colID1.HeaderText = "Blood Type";
            colID1.MinimumWidth = 6;
            colID1.Name = "colID1";
            // 
            // colID2
            // 
            colID2.HeaderText = "Collection Date";
            colID2.MinimumWidth = 6;
            colID2.Name = "colID2";
            // 
            // colID3
            // 
            colID3.HeaderText = "Expiry Date";
            colID3.MinimumWidth = 6;
            colID3.Name = "colID3";
            // 
            // colID5
            // 
            colID5.HeaderText = "Donation ID";
            colID5.MinimumWidth = 6;
            colID5.Name = "colID5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(35, 482);
            label6.Name = "label6";
            label6.Size = new Size(162, 20);
            label6.TabIndex = 3;
            label6.Text = "Search by Blood Type:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "ALL", "A+", "AB+", "O+", "O-" });
            comboBox2.Location = new Point(212, 482);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageKey = "search.png";
            button1.ImageList = imageList1;
            button1.Location = new Point(392, 513);
            button1.Name = "button1";
            button1.Size = new Size(113, 29);
            button1.TabIndex = 5;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Black;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.ImageKey = "back.png";
            button3.ImageList = imageList1;
            button3.Location = new Point(943, 498);
            button3.Name = "button3";
            button3.Size = new Size(150, 29);
            button3.TabIndex = 6;
            button3.Text = "Back to Menu";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1141, 554);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ForeColor = Color.MediumSlateBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "Donation/Blood Unit";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private ImageList imageList1;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colID1;
        private DataGridViewTextBoxColumn colID2;
        private DataGridViewTextBoxColumn colID3;
        private DataGridViewTextBoxColumn colID5;
        private Label label6;
        private ComboBox comboBox2;
        private Button button1;
        private Button button3;
    }
}