using System;
using System.Collections.Generic;
using System.Text;

namespace _22LAB
{
    public class Holst
    {
        public Bitmap Bitmap { get; private set; }    
        private Graphics graphics;                
        private PictureBox pictureBox;             
        private bool Drawing = false;
        private Point startPoint;

        public BaseTool CurrentTool { get; set; }
        public Color CurrentColor { get; set; } = Color.Black;
        public float CurrentThickness { get; set; } = 2f;

        public Holst(PictureBox box)
        {
            pictureBox = box;
            Bitmap = new Bitmap(box.Width, box.Height);
            graphics = Graphics.FromImage(Bitmap);
            graphics.Clear(Color.White);
            pictureBox.Image = Bitmap;
        }

        public void MouseDown(Point location)
        {
            if (CurrentTool != null)
            {
                Drawing = true;
                startPoint = location;
                CurrentTool.color = CurrentColor;
                CurrentTool.Thickness = CurrentThickness;
            }
        }

        public void MouseMove(Point location)
        {
            if (Drawing && CurrentTool != null)
            {
                if (CurrentTool is Karandash)
                {
                    CurrentTool.DrawFinal(graphics, startPoint, location);
                    startPoint = location;
                    pictureBox.Image = Bitmap;
                }
                else
                {
                    Bitmap tempBmp = new Bitmap(Bitmap);
                    using (Graphics tempG = Graphics.FromImage(tempBmp))
                    {
                        CurrentTool.DrawPreview(tempG, startPoint, location);
                    }
                    pictureBox.Image = tempBmp;
                }
            }
        }

        public void MouseUp(Point location)
        {
            if (Drawing && CurrentTool != null)
            {
                Drawing = false;
                if (!(CurrentTool is Karandash))
                {
                    CurrentTool.DrawFinal(graphics, startPoint, location);
                }
                pictureBox.Image = Bitmap;
            }
        }

        public void Clear()
        {
            graphics.Clear(Color.White);
            pictureBox.Image = Bitmap;
        }

        public void Save(string filePath)
        {
            Bitmap.Save(filePath);
        }
    }
}
