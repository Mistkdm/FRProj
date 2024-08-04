﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRProj.Shapes
{
    public class Rectangle : Shapes
    {
        public int Width { get; set; }
        public int Height { get; set; }
        private Point Location { get; set; }
        public Rectangle(int x, int y, int width, int height, Brush brush, Pen pen)
        {
            Location = new Point(x, y);
            Width = width;
            Height = height;
            FillColor = brush;
            BorderColor = pen;
        }
        public override void CreateShape(Graphics graphics)
        {
            graphics.FillRectangle(FillColor, Location.X, Location.Y, Width, Height);
            graphics.DrawRectangle(BorderColor, Location.X,Location.Y, Width, Height);
        }
        public override void DotInShape(Point point)
        {
        }
        public override void UpdateShape(int x, int y, int height, Brush fillColor, Pen borderColor, int width = 0)
        {
            this.Location = new Point(x, y);
            this.Height = height;
            this.Width = width;
            this.FillColor = fillColor;
            this.BorderColor = borderColor;
        }
    }
}
