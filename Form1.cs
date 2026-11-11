using System;
using System.Drawing;
using System.Windows.Forms;

namespace _22LAB
{
    public partial class Form1 : Form
    {
        private Holst canvas;

        public Form1()
        {
            InitializeComponent();

            canvas = new Holst(pictureBox1);

            pictureBox1.MouseDown += (s, e) => { if (e.Button == MouseButtons.Left) canvas.MouseDown(e.Location); };
            pictureBox1.MouseMove += (s, e) => canvas.MouseMove(e.Location);
            pictureBox1.MouseUp += (s, e) => canvas.MouseUp(e.Location);

            Clear.Click += (s, e) => canvas.Clear();
            Save.Click += (s, e) => {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg";
                if (sfd.ShowDialog() == DialogResult.OK) canvas.Save(sfd.FileName);
            };

            karandash.CheckedChanged += (s, e) => { if (karandash.Checked) canvas.CurrentTool = new Karandash(); };
            line.CheckedChanged += (s, e) => { if (line.Checked) canvas.CurrentTool = new Line(); };
            tringle.CheckedChanged += (s, e) => { if (tringle.Checked) canvas.CurrentTool = new Tringle(); };
            elips.CheckedChanged += (s, e) => { if (elips.Checked) canvas.CurrentTool = new Ellips(); };

            
            trackBar1.Scroll += (s, e) => canvas.CurrentThickness = trackBar1.Value;

            
            white.Click += (s, e) => canvas.CurrentColor = Color.White;
            red.Click += (s, e) => canvas.CurrentColor = Color.Red;
            green.Click += (s, e) => canvas.CurrentColor = Color.Lime;
            yerllow.Click += (s, e) => canvas.CurrentColor = Color.Yellow;
            blue.Click += (s, e) => canvas.CurrentColor = Color.Blue;
            pink.Click += (s, e) => canvas.CurrentColor = Color.Pink;
            black.Click += (s, e) => canvas.CurrentColor = Color.Black;
        }
    }
}