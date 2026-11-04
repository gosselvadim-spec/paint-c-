namespace _22LAB
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
            pictureBox1 = new PictureBox();
            Save = new Button();
            Clear = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            karandash = new RadioButton();
            line = new RadioButton();
            tringle = new RadioButton();
            elips = new RadioButton();
            trackBar1 = new TrackBar();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(618, 450);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Save
            // 
            Save.Location = new Point(624, 400);
            Save.Name = "Save";
            Save.Size = new Size(164, 29);
            Save.TabIndex = 1;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += button1_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(624, 365);
            Clear.Name = "Clear";
            Clear.Size = new Size(164, 29);
            Clear.TabIndex = 2;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Controls.Add(button8);
            flowLayoutPanel1.Controls.Add(button9);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(618, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(182, 118);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(30, 30);
            button3.TabIndex = 0;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(39, 3);
            button4.Name = "button4";
            button4.Size = new Size(30, 30);
            button4.TabIndex = 1;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Lime;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(75, 3);
            button5.Name = "button5";
            button5.Size = new Size(30, 30);
            button5.TabIndex = 2;
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Yellow;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(111, 3);
            button6.Name = "button6";
            button6.Size = new Size(30, 30);
            button6.TabIndex = 3;
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(0, 0, 192);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(147, 3);
            button7.Name = "button7";
            button7.Size = new Size(30, 30);
            button7.TabIndex = 4;
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(192, 0, 192);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(3, 39);
            button8.Name = "button8";
            button8.Size = new Size(30, 30);
            button8.TabIndex = 5;
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.Black;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(39, 39);
            button9.Name = "button9";
            button9.Size = new Size(30, 30);
            button9.TabIndex = 6;
            button9.UseVisualStyleBackColor = false;
            // 
            // karandash
            // 
            karandash.AutoSize = true;
            karandash.Location = new Point(621, 124);
            karandash.Name = "karandash";
            karandash.Size = new Size(97, 24);
            karandash.TabIndex = 7;
            karandash.TabStop = true;
            karandash.Text = "karandash";
            karandash.UseVisualStyleBackColor = true;
            // 
            // line
            // 
            line.AutoSize = true;
            line.Location = new Point(621, 154);
            line.Name = "line";
            line.Size = new Size(54, 24);
            line.TabIndex = 8;
            line.TabStop = true;
            line.Text = "line";
            line.UseVisualStyleBackColor = true;
            line.CheckedChanged += line_CheckedChanged;
            // 
            // tringle
            // 
            tringle.AutoSize = true;
            tringle.Location = new Point(621, 184);
            tringle.Name = "tringle";
            tringle.Size = new Size(73, 24);
            tringle.TabIndex = 9;
            tringle.TabStop = true;
            tringle.Text = "tringle";
            tringle.UseVisualStyleBackColor = true;
            // 
            // elips
            // 
            elips.AutoSize = true;
            elips.Location = new Point(621, 214);
            elips.Name = "elips";
            elips.Size = new Size(61, 24);
            elips.TabIndex = 10;
            elips.TabStop = true;
            elips.Text = "elips";
            elips.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(646, 287);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(130, 56);
            trackBar1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(668, 252);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 12;
            label1.Text = "Thickness ";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(elips);
            Controls.Add(tringle);
            Controls.Add(line);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(Clear);
            Controls.Add(Save);
            Controls.Add(pictureBox1);
            Controls.Add(karandash);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Save;
        private Button Clear;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private RadioButton karandash;
        private RadioButton line;
        private RadioButton tringle;
        private RadioButton elips;
        private TrackBar trackBar1;
        private Label label1;
    }
}
