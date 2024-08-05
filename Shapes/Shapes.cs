using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRProj.Shapes
{
    public abstract class Shapes
    {
        protected Brush? FillColor { get; set; }
        protected Pen? BorderColor { get; set; }
        public abstract void CreateShape(Graphics graphics);

        public abstract bool DotInShape(Point point);
        public abstract void UpdateShape(int x, int y, int size1,  Brush fillColor, Pen borderColor, int size2=0);

    }
}
