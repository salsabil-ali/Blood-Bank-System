using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace BloodBankManagmentSystem.Presentation_Layer
{
    partial class Form4 
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            textBox3 = new TextBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            dataGridView2 = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.DimGray;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(808, 469);
            button1.Name = "button1";
            button1.Size = new Size(137, 47);
            button1.TabIndex = 0;
            button1.Text = "⬅️ Back to Menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(22, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 306);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Request Information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button5
            // 
            button5.BackColor = Color.LightGray;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.Gray;
            button5.FlatAppearance.BorderSize = 2;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(296, 255);
            button5.Name = "button5";
            button5.Size = new Size(77, 34);
            button5.TabIndex = 13;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightCoral;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.Brown;
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(204, 255);
            button4.Name = "button4";
            button4.Size = new Size(75, 34);
            button4.TabIndex = 12;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.SteelBlue;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(103, 255);
            button3.Name = "button3";
            button3.Size = new Size(84, 34);
            button3.TabIndex = 11;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGreen;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.Green;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(6, 255);
            button2.Name = "button2";
            button2.Size = new Size(79, 34);
            button2.TabIndex = 10;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(137, 170);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(236, 25);
            comboBox2.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(137, 214);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 25);
            textBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(137, 124);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(236, 25);
            comboBox1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(137, 83);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(236, 25);
            dateTimePicker1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 25);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(6, 214);
            label5.Name = "label5";
            label5.Size = new Size(125, 17);
            label5.TabIndex = 4;
            label5.Text = "Quantity Requested:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(6, 170);
            label4.Name = "label4";
            label4.Size = new Size(76, 17);
            label4.TabIndex = 3;
            label4.Text = "Blood Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(6, 127);
            label3.Name = "label3";
            label3.Size = new Size(59, 17);
            label3.TabIndex = 2;
            label3.Text = "Hospital:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(6, 83);
            label2.Name = "label2";
            label2.Size = new Size(89, 17);
            label2.TabIndex = 1;
            label2.Text = "Request Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(74, 17);
            label1.TabIndex = 0;
            label1.Text = "Request ID:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(415, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(529, 212);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Requests List";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 28;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Silver;
            dataGridView1.Location = new Point(20, 59);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(503, 136);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.FillWeight = 83.94914F;
            Column1.HeaderText = "Request ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 90;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column2.FillWeight = 347.11908F;
            Column2.HeaderText = "Request Date";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column3.FillWeight = 40.0495529F;
            Column3.HeaderText = "Hospital";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column4.FillWeight = 12.6903543F;
            Column4.HeaderText = "Blood Type";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 90;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column5.FillWeight = 16.1918411F;
            Column5.HeaderText = "Quantity";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 70;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(111, 21);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(408, 25);
            textBox3.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(16, 29);
            label6.Name = "label6";
            label6.Size = new Size(50, 17);
            label6.TabIndex = 1;
            label6.Text = "Search:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView2);
            groupBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(416, 278);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(529, 176);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Requests Details (Allocated Units)";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.Gainsboro;
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.LightGray;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView2.ColumnHeadersHeight = 28;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column6, dataGridViewTextBoxColumn4, Column7 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.Silver;
            dataGridView2.Location = new Point(15, 24);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dataGridView2.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView2.RowTemplate.Height = 26;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(503, 136);
            dataGridView2.TabIndex = 3;
            // 
            // Column6
            // 
            Column6.HeaderText = "Blood Unit ID";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn4.FillWeight = 12.6903543F;
            dataGridViewTextBoxColumn4.HeaderText = "Blood Type";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 90;
            // 
            // Column7
            // 
            Column7.HeaderText = "Quantity Allocated";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            label7.ForeColor = Color.Sienna;
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(289, 38);
            label7.TabIndex = 5;
            label7.Text = "🏥Hospital Requests";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 536);
            Controls.Add(label7);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "🏥Hospital Requests";
            Load += Form4_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private GroupBox groupBox2;
        private TextBox textBox3;
        private Label label6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private GroupBox groupBox3;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Column7;
        private Label label7;
    }
}
