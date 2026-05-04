namespace BloodBankManagmentSystem.Presentation_Layer
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            imageList1 = new ImageList(components);
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox2 = new GroupBox();
            label9 = new Label();
            textBox6 = new TextBox();
            dataGridView1 = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colID1 = new DataGridViewTextBoxColumn();
            colID2 = new DataGridViewTextBoxColumn();
            colID3 = new DataGridViewTextBoxColumn();
            colID4 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "user.png");
            imageList1.Images.SetKeyName(1, "blood-test.png");
            imageList1.Images.SetKeyName(2, "back.png");
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            textBox1.Location = new Point(111, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(663, 52);
            textBox1.TabIndex = 0;
            textBox1.Text = "Donor Management";
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(41, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1086, 100);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user1;
            pictureBox2.Location = new Point(27, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(111, 18);
            label1.Name = "label1";
            label1.Size = new Size(343, 46);
            label1.TabIndex = 0;
            label1.Text = "Donor Management";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(0, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 394);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Donor Information";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(186, 338);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(175, 34);
            textBox5.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(186, 287);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(175, 34);
            textBox4.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "A+", "B-", "O+", "AB+", "O-" });
            comboBox2.Location = new Point(186, 236);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(175, 36);
            comboBox2.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(186, 181);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(175, 34);
            dateTimePicker1.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(186, 139);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(175, 36);
            comboBox1.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(186, 95);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(175, 34);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(186, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 34);
            textBox2.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 327);
            label8.Name = "label8";
            label8.Size = new Size(92, 28);
            label8.TabIndex = 6;
            label8.Text = "Address:";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 278);
            label7.Name = "label7";
            label7.Size = new Size(160, 28);
            label7.TabIndex = 5;
            label7.Text = "Phone Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 236);
            label6.Name = "label6";
            label6.Size = new Size(123, 28);
            label6.TabIndex = 4;
            label6.Text = "Blood Type:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 188);
            label5.Name = "label5";
            label5.Size = new Size(142, 28);
            label5.TabIndex = 3;
            label5.Text = "Date of Birth:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 139);
            label4.Name = "label4";
            label4.Size = new Size(86, 28);
            label4.TabIndex = 2;
            label4.Text = "Gender:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 95);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 1;
            label3.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 46);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 0;
            label2.Text = "Donor ID:";
            label2.Click += label2_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label9);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(402, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(660, 389);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Donors List";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 56);
            label9.Name = "label9";
            label9.Size = new Size(80, 28);
            label9.TabIndex = 0;
            label9.Text = "Search:";
            label9.Click += label9_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(119, 50);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(359, 34);
            textBox6.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colID, colID1, colID2, colID3, colID4 });
            dataGridView1.Location = new Point(23, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(631, 254);
            dataGridView1.TabIndex = 2;
            // 
            // colID
            // 
            colID.HeaderText = "Donor ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colID1
            // 
            colID1.HeaderText = "Name";
            colID1.MinimumWidth = 6;
            colID1.Name = "colID1";
            colID1.ReadOnly = true;
            // 
            // colID2
            // 
            colID2.HeaderText = "Gender";
            colID2.MinimumWidth = 6;
            colID2.Name = "colID2";
            colID2.ReadOnly = true;
            // 
            // colID3
            // 
            colID3.HeaderText = "Blood Type";
            colID3.MinimumWidth = 6;
            colID3.Name = "colID3";
            colID3.ReadOnly = true;
            // 
            // colID4
            // 
            colID4.HeaderText = "Phone Number";
            colID4.MinimumWidth = 6;
            colID4.Name = "colID4";
            colID4.ReadOnly = true;
            // 
            // button1
            // 
            button1.BackColor = Color.LawnGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(33, 524);
            button1.Name = "button1";
            button1.Size = new Size(94, 33);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(145, 524);
            button2.Name = "button2";
            button2.Size = new Size(94, 35);
            button2.TabIndex = 6;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.Location = new Point(257, 524);
            button3.Name = "button3";
            button3.Size = new Size(94, 35);
            button3.TabIndex = 7;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.AppWorkspace;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.Location = new Point(372, 524);
            button4.Name = "button4";
            button4.Size = new Size(94, 35);
            button4.TabIndex = 8;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlDark;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button5.ImageKey = "back.png";
            button5.ImageList = imageList1;
            button5.Location = new Point(915, 530);
            button5.Name = "button5";
            button5.Size = new Size(141, 29);
            button5.TabIndex = 9;
            button5.Text = "Back to menu";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 570);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Donor Management";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imageList1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label1;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox5;
        private TextBox textBox4;
        private GroupBox groupBox2;
        private TextBox textBox6;
        private Label label9;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colID1;
        private DataGridViewTextBoxColumn colID2;
        private DataGridViewTextBoxColumn colID3;
        private DataGridViewTextBoxColumn colID4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}