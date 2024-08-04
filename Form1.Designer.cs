namespace FRProj
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LocationX = new System.Windows.Forms.TextBox();
            this.LocationY = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.Radius = new System.Windows.Forms.TextBox();
            this.TriangleSide = new System.Windows.Forms.TextBox();
            this.Width = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.TextBox();
            this.LabelRadius = new System.Windows.Forms.Label();
            this.LabelWidthAndHeight = new System.Windows.Forms.Label();
            this.LabelTriangleSide = new System.Windows.Forms.Label();
            this.ComboFillColor = new System.Windows.Forms.ComboBox();
            this.ComboBorderColor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Круг";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Прямоугольник";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(254, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Треугольник";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LocationX
            // 
            this.LocationX.Location = new System.Drawing.Point(394, 12);
            this.LocationX.Name = "LocationX";
            this.LocationX.Size = new System.Drawing.Size(100, 23);
            this.LocationX.TabIndex = 3;
            // 
            // LocationY
            // 
            this.LocationY.Location = new System.Drawing.Point(522, 12);
            this.LocationY.Name = "LocationY";
            this.LocationY.Size = new System.Drawing.Size(100, 23);
            this.LocationY.TabIndex = 4;
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(374, 15);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(14, 15);
            this.X.TabIndex = 6;
            this.X.Text = "X";
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Location = new System.Drawing.Point(502, 15);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(14, 15);
            this.Y.TabIndex = 7;
            this.Y.Text = "Y";
            // 
            // Radius
            // 
            this.Radius.Location = new System.Drawing.Point(31, 41);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(100, 23);
            this.Radius.TabIndex = 8;
            // 
            // TriangleSide
            // 
            this.TriangleSide.Location = new System.Drawing.Point(254, 41);
            this.TriangleSide.Name = "TriangleSide";
            this.TriangleSide.Size = new System.Drawing.Size(100, 23);
            this.TriangleSide.TabIndex = 9;
            // 
            // Width
            // 
            this.Width.Location = new System.Drawing.Point(137, 41);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(111, 23);
            this.Width.TabIndex = 10;
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(137, 70);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(111, 23);
            this.Height.TabIndex = 11;
            // 
            // LabelRadius
            // 
            this.LabelRadius.AutoSize = true;
            this.LabelRadius.Location = new System.Drawing.Point(59, 70);
            this.LabelRadius.Name = "LabelRadius";
            this.LabelRadius.Size = new System.Drawing.Size(45, 15);
            this.LabelRadius.TabIndex = 12;
            this.LabelRadius.Text = "Радиус";
            // 
            // LabelWidthAndHeight
            // 
            this.LabelWidthAndHeight.AutoSize = true;
            this.LabelWidthAndHeight.Location = new System.Drawing.Point(144, 96);
            this.LabelWidthAndHeight.Name = "LabelWidthAndHeight";
            this.LabelWidthAndHeight.Size = new System.Drawing.Size(104, 15);
            this.LabelWidthAndHeight.TabIndex = 13;
            this.LabelWidthAndHeight.Text = "Ширина и высота";
            // 
            // LabelTriangleSide
            // 
            this.LabelTriangleSide.AutoSize = true;
            this.LabelTriangleSide.Location = new System.Drawing.Point(281, 67);
            this.LabelTriangleSide.Name = "LabelTriangleSide";
            this.LabelTriangleSide.Size = new System.Drawing.Size(42, 15);
            this.LabelTriangleSide.TabIndex = 14;
            this.LabelTriangleSide.Text = "Длина";
            // 
            // ComboFillColor
            // 
            this.ComboFillColor.FormattingEnabled = true;
            this.ComboFillColor.Items.AddRange(new object[] {
            "ActiveBorder",
            "ActiveCaption",
            "ActiveCaptionText",
            "AppWorkspace",
            "Control",
            "ControlDark",
            "ControlDarkDark",
            "ControlLight",
            "ControlLightLight",
            "ControlText",
            "Desktop",
            "GrayText",
            "Highlight",
            "HighlightText",
            "HotTrack",
            "InactiveBorder",
            "InactiveCaption",
            "InactiveCaptionText",
            "Info",
            "InfoText",
            "Menu",
            "MenuText",
            "ScrollBar",
            "Window",
            "WindowFrame",
            "WindowText",
            "Transparent",
            "AliceBlue",
            "AntiqueWhite",
            "Aqua",
            "Aquamarine",
            "Azure",
            "Beige",
            "Bisque",
            "Black",
            "BlanchedAlmond",
            "Blue",
            "BlueViolet",
            "Brown",
            "BurlyWood",
            "CadetBlue",
            "Chartreuse",
            "Chocolate",
            "Coral",
            "CornflowerBlue",
            "Cornsilk",
            "Crimson",
            "Cyan",
            "DarkBlue",
            "DarkCyan",
            "DarkGoldenrod",
            "DarkGray",
            "DarkGreen",
            "DarkKhaki",
            "DarkMagenta",
            "DarkOliveGreen",
            "DarkOrange",
            "DarkOrchid",
            "DarkRed",
            "DarkSalmon",
            "DarkSeaGreen",
            "DarkSlateBlue",
            "DarkSlateGray",
            "DarkTurquoise",
            "DarkViolet",
            "DeepPink",
            "DeepSkyBlue",
            "DimGray",
            "DodgerBlue",
            "Firebrick",
            "FloralWhite",
            "ForestGreen",
            "Fuchsia",
            "Gainsboro",
            "GhostWhite",
            "Gold",
            "Goldenrod",
            "Gray",
            "Green",
            "GreenYellow",
            "Honeydew",
            "HotPink",
            "IndianRed",
            "Indigo",
            "Ivory",
            "Khaki",
            "Lavender",
            "LavenderBlush",
            "LawnGreen",
            "LemonChiffon",
            "LightBlue",
            "LightCoral",
            "LightCyan",
            "LightGoldenrodYellow",
            "LightGray",
            "LightGreen",
            "LightPink",
            "LightSalmon",
            "LightSeaGreen",
            "LightSkyBlue",
            "LightSlateGray",
            "LightSteelBlue",
            "LightYellow",
            "Lime",
            "LimeGreen",
            "Linen",
            "Magenta",
            "Maroon",
            "MediumAquamarine",
            "MediumBlue",
            "MediumOrchid",
            "MediumPurple",
            "MediumSeaGreen",
            "MediumSlateBlue",
            "MediumSpringGreen",
            "MediumTurquoise",
            "MediumVioletRed",
            "MidnightBlue",
            "MintCream",
            "MistyRose",
            "Moccasin",
            "NavajoWhite",
            "Navy",
            "OldLace",
            "Olive",
            "OliveDrab",
            "Orange",
            "OrangeRed",
            "Orchid",
            "PaleGoldenrod",
            "PaleGreen",
            "PaleTurquoise",
            "PaleVioletRed",
            "PapayaWhip",
            "PeachPuff",
            "Peru",
            "Pink",
            "Plum",
            "PowderBlue",
            "Purple",
            "Red",
            "RosyBrown",
            "RoyalBlue",
            "SaddleBrown",
            "Salmon",
            "SandyBrown",
            "SeaGreen",
            "SeaShell",
            "Sienna",
            "Silver",
            "SkyBlue",
            "SlateBlue",
            "SlateGray",
            "Snow",
            "SpringGreen",
            "SteelBlue",
            "Tan",
            "Teal",
            "Thistle",
            "Tomato",
            "Turquoise",
            "Violet",
            "Wheat",
            "White",
            "WhiteSmoke",
            "Yellow",
            "YellowGreen",
            "ButtonFace",
            "ButtonHighlight",
            "ButtonShadow",
            "GradientActiveCaption",
            "GradientInactiveCaption",
            "MenuBar",
            "MenuHighlight",
            "RebeccaPurple"});
            this.ComboFillColor.Location = new System.Drawing.Point(394, 41);
            this.ComboFillColor.Name = "ComboFillColor";
            this.ComboFillColor.Size = new System.Drawing.Size(100, 23);
            this.ComboFillColor.TabIndex = 16;
            // 
            // ComboBorderColor
            // 
            this.ComboBorderColor.FormattingEnabled = true;
            this.ComboBorderColor.Items.AddRange(new object[] {
            "ActiveBorder",
            "ActiveCaption",
            "ActiveCaptionText",
            "AppWorkspace",
            "Control",
            "ControlDark",
            "ControlDarkDark",
            "ControlLight",
            "ControlLightLight",
            "ControlText",
            "Desktop",
            "GrayText",
            "Highlight",
            "HighlightText",
            "HotTrack",
            "InactiveBorder",
            "InactiveCaption",
            "InactiveCaptionText",
            "Info",
            "InfoText",
            "Menu",
            "MenuText",
            "ScrollBar",
            "Window",
            "WindowFrame",
            "WindowText",
            "Transparent",
            "AliceBlue",
            "AntiqueWhite",
            "Aqua",
            "Aquamarine",
            "Azure",
            "Beige",
            "Bisque",
            "Black",
            "BlanchedAlmond",
            "Blue",
            "BlueViolet",
            "Brown",
            "BurlyWood",
            "CadetBlue",
            "Chartreuse",
            "Chocolate",
            "Coral",
            "CornflowerBlue",
            "Cornsilk",
            "Crimson",
            "Cyan",
            "DarkBlue",
            "DarkCyan",
            "DarkGoldenrod",
            "DarkGray",
            "DarkGreen",
            "DarkKhaki",
            "DarkMagenta",
            "DarkOliveGreen",
            "DarkOrange",
            "DarkOrchid",
            "DarkRed",
            "DarkSalmon",
            "DarkSeaGreen",
            "DarkSlateBlue",
            "DarkSlateGray",
            "DarkTurquoise",
            "DarkViolet",
            "DeepPink",
            "DeepSkyBlue",
            "DimGray",
            "DodgerBlue",
            "Firebrick",
            "FloralWhite",
            "ForestGreen",
            "Fuchsia",
            "Gainsboro",
            "GhostWhite",
            "Gold",
            "Goldenrod",
            "Gray",
            "Green",
            "GreenYellow",
            "Honeydew",
            "HotPink",
            "IndianRed",
            "Indigo",
            "Ivory",
            "Khaki",
            "Lavender",
            "LavenderBlush",
            "LawnGreen",
            "LemonChiffon",
            "LightBlue",
            "LightCoral",
            "LightCyan",
            "LightGoldenrodYellow",
            "LightGray",
            "LightGreen",
            "LightPink",
            "LightSalmon",
            "LightSeaGreen",
            "LightSkyBlue",
            "LightSlateGray",
            "LightSteelBlue",
            "LightYellow",
            "Lime",
            "LimeGreen",
            "Linen",
            "Magenta",
            "Maroon",
            "MediumAquamarine",
            "MediumBlue",
            "MediumOrchid",
            "MediumPurple",
            "MediumSeaGreen",
            "MediumSlateBlue",
            "MediumSpringGreen",
            "MediumTurquoise",
            "MediumVioletRed",
            "MidnightBlue",
            "MintCream",
            "MistyRose",
            "Moccasin",
            "NavajoWhite",
            "Navy",
            "OldLace",
            "Olive",
            "OliveDrab",
            "Orange",
            "OrangeRed",
            "Orchid",
            "PaleGoldenrod",
            "PaleGreen",
            "PaleTurquoise",
            "PaleVioletRed",
            "PapayaWhip",
            "PeachPuff",
            "Peru",
            "Pink",
            "Plum",
            "PowderBlue",
            "Purple",
            "Red",
            "RosyBrown",
            "RoyalBlue",
            "SaddleBrown",
            "Salmon",
            "SandyBrown",
            "SeaGreen",
            "SeaShell",
            "Sienna",
            "Silver",
            "SkyBlue",
            "SlateBlue",
            "SlateGray",
            "Snow",
            "SpringGreen",
            "SteelBlue",
            "Tan",
            "Teal",
            "Thistle",
            "Tomato",
            "Turquoise",
            "Violet",
            "Wheat",
            "White",
            "WhiteSmoke",
            "Yellow",
            "YellowGreen",
            "ButtonFace",
            "ButtonHighlight",
            "ButtonShadow",
            "GradientActiveCaption",
            "GradientInactiveCaption",
            "MenuBar",
            "MenuHighlight",
            "RebeccaPurple"});
            this.ComboBorderColor.Location = new System.Drawing.Point(522, 41);
            this.ComboBorderColor.Name = "ComboBorderColor";
            this.ComboBorderColor.Size = new System.Drawing.Size(100, 23);
            this.ComboBorderColor.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComboBorderColor);
            this.Controls.Add(this.ComboFillColor);
            this.Controls.Add(this.LabelTriangleSide);
            this.Controls.Add(this.LabelWidthAndHeight);
            this.Controls.Add(this.LabelRadius);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.TriangleSide);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.LocationY);
            this.Controls.Add(this.LocationX);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Shapes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox LocationX;
        private TextBox LocationY;
        private Label X;
        private Label Y;
        private TextBox Radius;
        private TextBox TriangleSide;
        private TextBox Width;
        private TextBox Height;
        private Label LabelRadius;
        private Label LabelTriangleSide;
        private Label LabelWidthAndHeight;
        private ComboBox ComboFillColor;
        private ComboBox ComboBorderColor;
    }
}