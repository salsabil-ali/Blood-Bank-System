
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace BloodBankManagmentSystem.Presentation_Layer
{
    partial class Form5
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            button3 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(373, 38);
            label1.TabIndex = 0;
            label1.Text = "\U0001fa78 Inventory (Blood Units)";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 152);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filters";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(6, 33);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 0;
            label2.Text = "Blood Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(6, 64);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 1;
            label3.Text = "Status:";
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(97, 23);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 25);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(97, 54);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 25);
            comboBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.LightGray;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(6, 96);
            button1.Name = "button1";
            button1.Size = new Size(102, 34);
            button1.TabIndex = 4;
            button1.Text = "🔍Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.Silver;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(114, 96);
            button2.Name = "button2";
            button2.Size = new Size(104, 34);
            button2.TabIndex = 5;
            button2.Text = "Show All";
            button2.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 218);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(832, 358);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Blood Units Inventory";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = Color.Gainsboro;
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.LightGray;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridView2.ColumnHeadersHeight = 28;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column6, dataGridViewTextBoxColumn4, Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Window;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle15.SelectionForeColor = Color.White;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle15;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.Silver;
            dataGridView2.Location = new Point(6, 24);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dataGridView2.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView2.RowTemplate.Height = 26;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(820, 328);
            dataGridView2.TabIndex = 4;
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
            // Column1
            // 
            Column1.HeaderText = "Collection Date";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Expiry Date";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Donation ID";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Status";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.DimGray;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(701, 582);
            button3.Name = "button3";
            button3.Size = new Size(137, 47);
            button3.TabIndex = 3;
            button3.Text = "⬅️ Back to Menu";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(276, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(118, 89);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(414, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(118, 89);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(553, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(118, 89);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(720, 71);
            panel4.Name = "panel4";
            panel4.Size = new Size(118, 89);
            panel4.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 11);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 0;
            label4.Text = "Total Units";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.ForestGreen;
            label5.Location = new Point(19, 11);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 1;
            label5.Text = "Available";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(33, 11);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 2;
            label6.Text = "Used";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.BlueViolet;
            label7.Location = new Point(27, 11);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 3;
            label7.Text = "Expired";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(47, 47);
            label8.Name = "label8";
            label8.Size = new Size(18, 20);
            label8.TabIndex = 1;
            label8.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.ForestGreen;
            label9.Location = new Point(46, 47);
            label9.Name = "label9";
            label9.Size = new Size(18, 20);
            label9.TabIndex = 2;
            label9.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Maroon;
            label10.Location = new Point(46, 43);
            label10.Name = "label10";
            label10.Size = new Size(18, 20);
            label10.TabIndex = 3;
            label10.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.BlueViolet;
            label11.Location = new Point(48, 43);
            label11.Name = "label11";
            label11.Size = new Size(18, 20);
            label11.TabIndex = 4;
            label11.Text = "0";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 641);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "\U0001fa78 Inventory (Blood Units)";
            Load += Form5_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}