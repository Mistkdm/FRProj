using FRProj.Shapes;
using System.Drawing.Text;

namespace FRProj
{
    public partial class Form1 : Form
    {
        private List<Shapes.Shapes> shapes;
        private Brush FillColor;
        private Pen BorderColor;
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
            shapes = new List<Shapes.Shapes>();
            LocationX.KeyPress += new KeyPressEventHandler(OnlyNumbers);
            LocationY.KeyPress += new KeyPressEventHandler(OnlyNumbers);
            Radius.KeyPress += new KeyPressEventHandler(OnlyNumbers);
            Width.KeyPress += new KeyPressEventHandler(OnlyNumbers);
            Height.KeyPress += new KeyPressEventHandler(OnlyNumbers);
            TriangleSide.KeyPress += new KeyPressEventHandler(OnlyNumbers);
            ComboFillColor.Text = "Black";
            ComboBorderColor.Text = "Black";
            SetColor(ref FillColor!, ref BorderColor!);
            Circle circle = new Circle(0, 0, 0, FillColor, BorderColor);
            shapes.Add(circle);
            FRProj.Shapes.Rectangle rectangle = new FRProj.Shapes.Rectangle(0, 0, 0, 0, FillColor, BorderColor);
            shapes.Add(rectangle);
            EquTriangle equTriangle = new EquTriangle(0, 0, 0, FillColor, BorderColor);
            shapes.Add(equTriangle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetColor(ref FillColor, ref BorderColor);
            if (IsTextBoxFill(LocationX, LocationY, Radius)) 
            {
                shapes[0].UpdateShape(Int32.Parse(LocationX.Text), Int32.Parse(LocationY.Text), Int32.Parse(Radius.Text), FillColor, BorderColor);
                this.Invalidate();
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SetColor(ref FillColor, ref BorderColor);
            if (IsTextBoxFill(LocationX, LocationY, Width, Height))
            {
                shapes[1].UpdateShape(Int32.Parse(LocationX.Text), Int32.Parse(LocationY.Text), Int32.Parse(Width.Text), FillColor, BorderColor, Int32.Parse(Height.Text));
                this.Invalidate();
            }
          
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SetColor(ref FillColor, ref BorderColor);
            if (IsTextBoxFill(LocationX, LocationY, TriangleSide))
            {
                shapes[2].UpdateShape(Int32.Parse(LocationX.Text), Int32.Parse(LocationY.Text), Int32.Parse(TriangleSide.Text), FillColor, BorderColor);

                this.Invalidate();
            }
        }
        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
        private bool IsTextBoxFill(params TextBox[] textBox)
        {
            bool isFill = true;
            foreach (var item in textBox )
            {
                if (item.Text == "")
                {
                    isFill = false;
                }
            }
            return isFill;
        }
        private void SetColor(ref Brush brushColor, ref Pen penColor)
        {
            Color fillColor = Color.FromName(ComboFillColor.SelectedItem.ToString()!);
            Color borderColor = Color.FromName(ComboBorderColor.SelectedItem.ToString()!);
            brushColor = new SolidBrush(fillColor);
            penColor = new Pen(borderColor);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (shapes.Count > 0)
            {
                foreach(var shape in shapes)
                {
                    shape.CreateShape(e.Graphics);
                }
            }
        }


    }
}