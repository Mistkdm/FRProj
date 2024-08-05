using System.Drawing;

namespace FRProj.Shapes
{
    internal class Circle : Shapes
    {
        public int Radius { get; set; }
        private Point Location { get; set; }
        public Circle(int radius, Point location)
        {
            Radius = radius;
            Location = location;
        }

        public Circle(int x, int y, int radius, Brush fillColor, Pen borderColor)
        {
            Location = new Point(x, y);
            Radius = radius;
            FillColor = fillColor;
            BorderColor = borderColor;

        } 
        public override void CreateShape(Graphics graphics)
        {
            graphics.FillEllipse(FillColor, Location.X - Radius, Location.Y - Radius, Radius * 2, Radius * 2);
            graphics.DrawEllipse(BorderColor, Location.X - Radius, Location.Y - Radius, Radius * 2, Radius * 2);
        }
        public override bool DotInShape(Point point)
        {
            bool InShape = false;
            double distance = Math.Sqrt(Math.Pow(point.X - Location.X, 2) + Math.Pow(point.Y - Location.Y, 2));
            if (distance <= Radius && Radius != 0)
            {
                MessageBox.Show("Точка находится внутри круга");
                InShape = true;
            }
            return InShape;
        }
        public override void UpdateShape(int x, int y, int radius, Brush fillColor, Pen borderColor, int unusedSize = 0)
        {
            this.Location = new Point(x, y);
            this.Radius = radius;
            this.FillColor = fillColor; 
            this.BorderColor = borderColor;
        }
    }
}
