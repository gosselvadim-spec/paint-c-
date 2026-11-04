using System;
using System.Drawing;

namespace _22LAB
{
    public abstract class BaseTool
    {
        public Color color { get; set; } = Color.Black;
        public float Thickness { get; set; } = 2f;

        public abstract void DrawPreview(Graphics g, Point start, Point end);
        public abstract void DrawFinal(Graphics g, Point start, Point end);
    }

    public class Karandash : BaseTool
    {
        public override void DrawPreview(Graphics g, Point start, Point end) { }
        public override void DrawFinal(Graphics g, Point start, Point end)
        {
            using (Pen pen = new Pen(color, Thickness))
            {
                g.DrawLine(pen, start, end);
            }
        }
    }

    public class Line : BaseTool
    {
        public override void DrawPreview(Graphics g, Point start, Point end)
        {
            using (Pen pen = new Pen(color, Thickness))
            {
                g.DrawLine(pen, start, end);
            }
        }
        public override void DrawFinal(Graphics g, Point start, Point end) => DrawPreview(g, start, end);
    }


    public class Tringle : BaseTool
    {
        public override void DrawPreview(Graphics g, Point start, Point end)
        {
            using (Pen pen = new Pen(color, Thickness))
            {
                int x = Math.Min(start.X, end.X);
                int y = Math.Min(start.Y, end.Y);
                int w = Math.Abs(start.X - end.X);
                int h = Math.Abs(start.Y - end.Y);
                g.DrawRectangle(pen, x, y, w, h);
            }
        }
        public override void DrawFinal(Graphics g, Point start, Point end) => DrawPreview(g, start, end);
    }

    public class Ellips : BaseTool
    {
        public override void DrawPreview(Graphics g, Point start, Point end)
        {
            using (Pen pen = new Pen(color, Thickness))
            {
                int x = Math.Min(start.X, end.X);
                int y = Math.Min(start.Y, end.Y);
                int w = Math.Abs(start.X - end.X);
                int h = Math.Abs(start.Y - end.Y);
                g.DrawEllipse(pen, x, y, w, h);
            }
        }
        public override void DrawFinal(Graphics g, Point start, Point end) => DrawPreview(g, start, end);
    }
}