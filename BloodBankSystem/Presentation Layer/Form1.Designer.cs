namespace BloodBankSystem.Presentation_Layer

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            imageList1 = new ImageList(components);
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageIndex = 0;
            button1.ImageList = imageList1;
            button1.Location = new Point(239, 147);
            button1.Name = "button1";
            button1.Size = new Size(317, 55);
            button1.TabIndex = 0;
            button1.Text = "Donor Management";
            button1.UseVisualStyleBackColor = false;
            button1.UseWaitCursor = true;
            button1.TextChanged += button1_Click;
            button1.Click += button1_Click_1;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "user.png");
            imageList1.Images.SetKeyName(1, "blood.png");
            imageList1.Images.SetKeyName(2, "blood-test.png");
            imageList1.Images.SetKeyName(3, "hospital.png");
            imageList1.Images.SetKeyName(4, "logout.png");
            imageList1.Images.SetKeyName(5, "logout (1).png");
            imageList1.Images.SetKeyName(6, "exit (1).png");
            // 
            // button2
            // 
            button2.BackColor = Color.LightGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.ImageKey = "blood-test.png";
            button2.ImageList = imageList1;
            button2.Location = new Point(239, 208);
            button2.Name = "button2";
            button2.Size = new Size(317, 57);
            button2.TabIndex = 1;
            button2.Text = "Donation / Blood Unit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleGoldenrod;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.ImageKey = "hospital.png";
            button3.ImageList = imageList1;
            button3.Location = new Point(239, 271);
            button3.Name = "button3";
            button3.Size = new Size(317, 52);
            button3.TabIndex = 2;
            button3.Text = "Hospital Requests";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.LightCoral;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.ImageKey = "blood.png";
            button4.ImageList = imageList1;
            button4.Location = new Point(239, 329);
            button4.Name = "button4";
            button4.Size = new Size(317, 58);
            button4.TabIndex = 3;
            button4.Text = "Inventory (Blood Units)";
            button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox1.ForeColor = SystemColors.HotTrack;
            textBox1.Location = new Point(328, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 32);
            textBox1.TabIndex = 6;
            textBox1.Text = "Main Menu";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.AppWorkspace;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.ImageIndex = 5;
            button5.ImageList = imageList1;
            button5.Location = new Point(239, 393);
            button5.Name = "button5";
            button5.Size = new Size(317, 56);
            button5.TabIndex = 7;
            button5.Text = "Exit";
            button5.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 551);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Blood Bank Management System";
            Click += Form1_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button button5;
    }
}
