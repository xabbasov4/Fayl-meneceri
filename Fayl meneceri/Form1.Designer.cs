using Microsoft.VisualBasic.Devices;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Fayl_meneceri
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            listBox1 = new ListBox();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            label2 = new Label();
            label3 = new Label();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(15, 16);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(92, 29);
            button1.TabIndex = 0;
            button1.Text = "qovluq seç";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(127, 16);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(92, 29);
            button2.TabIndex = 1;
            button2.Text = "aç";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(230, 16);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(100, 29);
            button3.TabIndex = 2;
            button3.Text = "yadda saxla";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(334, 16);
            button4.Margin = new Padding(2, 2, 2, 2);
            button4.Name = "button4";
            button4.Size = new Size(92, 29);
            button4.TabIndex = 3;
            button4.Text = "sil";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(430, 19);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(234, 27);
            textBox1.TabIndex = 4;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.InactiveCaption;
            richTextBox1.Location = new Point(230, 90);
            richTextBox1.Margin = new Padding(2, 2, 2, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new Size(435, 284);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(15, 90);
            listBox1.Margin = new Padding(2, 2, 2, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(201, 284);
            listBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(15, 381);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 7;
            label1.Text = "məlumat";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 9, 0);
            statusStrip1.Size = new Size(696, 26);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(151, 20);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(15, 68);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 9;
            label2.Text = "fayllar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(230, 68);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 10;
            label3.Text = "mətn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(696, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(statusStrip1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private ListBox listBox1;
        private Label label1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label label2;
        private Label label3;
    }
}