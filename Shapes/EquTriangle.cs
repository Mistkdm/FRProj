using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FRProj.Shapes
{
    internal class EquTriangle : Shapes
    {
        private Point[] Points { get; set; }
        public int SideLength { get; set; }
        public EquTriangle(int x, int y, int sideLenght, Brush brush, Pen pen)
        {
            SideLength = sideLenght;
            FillColor = brush;
            BorderColor = pen;
            CalculatePoints(x, y);
        }
        private void CalculatePoints(int x, int y)
        {
            Points = new Point[3];

            Points[0] = new Point(x, y);
            Points[1] = new Point(x + SideLength, y);
            Points[2] = new Point(x + SideLength/2, y - (int)(Math.Sqrt(3) * SideLength/2));
        }
        public override void CreateShape(Graphics graphics)
        {
            graphics.FillPolygon(FillColor, Points);
            graphics.DrawPolygon(BorderColor, Points);
        }
        public override bool DotInShape(Point point)
        {
            bool InShape = false;
            float dX = point.X - Points[2].X;
            float dY = point.Y - Points[2].Y;
            float dX21 = Points[2].X - Points[1].X;
            float dY12 = Points[1].Y - Points[2].Y;
            float D = dY12 * (Points[0].X - Points[2].X) + dX21 * (Points[0].Y - Points[2].Y);
            float s = dY12 * dX + dX21 * dY;
            float t = (Points[2].Y - Points[0].Y) * dX + (Points[0].X - Points[2].X) * dY;

            if ((D < 0) && s <= 0 && t <= 0 && s + t >= D & SideLength !=0)
            {
                MessageBox.Show("Точка находится внутри треугольника");
                InShape = true;
            }
            if(s >= 0 && t >= 0 && s + t <= D & SideLength != 0)
            {
                MessageBox.Show("Точка находится внутри треугольника");
                InShape = true;
            }
            return InShape;
        }
        public override void UpdateShape(int x, int y, int sideLength, Brush fillColor, Pen borderColor, int unusedSize = 0)
        {
            this.SideLength = sideLength;
            this.FillColor = fillColor;
            this.BorderColor = borderColor;
            CalculatePoints(x, y);
        }
    }
}
