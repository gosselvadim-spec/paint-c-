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
            white = new Button();
            red = new Button();
            green = new Button();
            yerllow = new Button();
            blue = new Button();
            pink = new Button();
            black = new Button();
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
            flowLayoutPanel1.Controls.Add(white);
            flowLayoutPanel1.Controls.Add(red);
            flowLayoutPanel1.Controls.Add(green);
            flowLayoutPanel1.Controls.Add(yerllow);
            flowLayoutPanel1.Controls.Add(blue);
            flowLayoutPanel1.Controls.Add(pink);
            flowLayoutPanel1.Controls.Add(black);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(618, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(182, 118);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // white
            // 
            white.BackColor = Color.White;
            white.FlatStyle = FlatStyle.Flat;
            white.Location = new Point(3, 3);
            white.Name = "white";
            white.Size = new Size(30, 30);
            white.TabIndex = 0;
            white.UseVisualStyleBackColor = false;
            // 
            // red
            // 
            red.BackColor = Color.Red;
            red.FlatStyle = FlatStyle.Flat;
            red.Location = new Point(39, 3);
            red.Name = "red";
            red.Size = new Size(30, 30);
            red.TabIndex = 1;
            red.UseVisualStyleBackColor = false;
            // 
            // green
            // 
            green.BackColor = Color.Lime;
            green.FlatStyle = FlatStyle.Flat;
            green.Location = new Point(75, 3);
            green.Name = "green";
            green.Size = new Size(30, 30);
            green.TabIndex = 2;
            green.UseVisualStyleBackColor = false;
            // 
            // yerllow
            // 
            yerllow.BackColor = Color.Yellow;
            yerllow.FlatStyle = FlatStyle.Flat;
            yerllow.Location = new Point(111, 3);
            yerllow.Name = "yerllow";
            yerllow.Size = new Size(30, 30);
            yerllow.TabIndex = 3;
            yerllow.UseVisualStyleBackColor = false;
            // 
            // blue
            // 
            blue.BackColor = Color.FromArgb(0, 0, 192);
            blue.FlatStyle = FlatStyle.Flat;
            blue.Location = new Point(147, 3);
            blue.Name = "blue";
            blue.Size = new Size(30, 30);
            blue.TabIndex = 4;
            blue.UseVisualStyleBackColor = false;
            // 
            // pink
            // 
            pink.BackColor = Color.FromArgb(192, 0, 192);
            pink.FlatStyle = FlatStyle.Flat;
            pink.Location = new Point(3, 39);
            pink.Name = "pink";
            pink.Size = new Size(30, 30);
            pink.TabIndex = 5;
            pink.UseVisualStyleBackColor = false;
            // 
            // black
            // 
            black.BackColor = Color.Black;
            black.FlatStyle = FlatStyle.Flat;
            black.Location = new Point(39, 39);
            black.Name = "black";
            black.Size = new Size(30, 30);
            black.TabIndex = 6;
            black.UseVisualStyleBackColor = false;
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
        private Button white;
        private Button red;
        private Button green;
        private Button yerllow;
        private Button blue;
        private Button pink;
        private Button black;
        private RadioButton karandash;
        private RadioButton line;
        private RadioButton tringle;
        private RadioButton elips;
        private TrackBar trackBar1;
        private Label label1;
    }
}
