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
        public override void DotInShape(Point point)
        {
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
