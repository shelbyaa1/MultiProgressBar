using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace MultiProgressBar.Controls
{
    [ToolboxItem(true)]
    [DesignTimeVisible(true)]
    [ToolboxBitmap(typeof(ProgressBar))]
    [Description("Different Styles of ProgressBar")]
    public sealed class MultiProgressBar : UserControl
    {
        #region [Enumerations]
        public enum TextMode
        {
            None,
            Value,
            Percentage
        }
        public enum BarType
        {
            Circle,
            Horizontal,
            Vertical
        }
        public enum Direction
        {
            Forward,
            Backward
        }
        #endregion

        #region [ Class Fields]
        private int _value = 25;
        private int _maximum = 100;
        private int _minimum = 0;
        private int _lineWidth = 20;
        private int _borderWidth = 5;
        private float per = 0f;

        private Color _colorBMPBackground = Color.Transparent;
        private Color _colorBarBackground = Color.Blue;
        private Color _colorBarBorder = Color.Green;
        private Color _colorBarGradient1 = Color.Red;
        private Color _colorBarGradient2 = Color.Orange;

        private LinearGradientMode _gradientDirection = LinearGradientMode.ForwardDiagonal;
        private LineCap _startShape = LineCap.Flat;
        private LineCap _endShape = LineCap.ArrowAnchor;
        private TextMode _textType = TextMode.Percentage;
        private BarType _barType = BarType.Circle;
        private Direction _direction = Direction.Forward;

        private EventHandler onValueChanged;

        #endregion

        #region [Class Properties]
        [Description("Progress Value"), Category("Settings")]
        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                if ((value > _minimum) && (value < _maximum))
                {
                    _value = value;
                }
                if (value >= _maximum)
                {
                    _value = _maximum;
                }
                if (value <= _minimum)
                {
                    _value = _minimum;
                }
                Invalidate();
            }
        }
        [Description("Minimum Value for Progress Bar"), Category("Settings")]
        public int Min_Val
        {
            get
            {
                return _minimum;
            }
            set
            {
                if (value <= _maximum)
                {
                    _minimum = value;
                }
                if (value > _maximum)
                {
                    _minimum = _maximum;
                }
                Invalidate();
            }
        }
        [Description("Max Value for Progress Bar"), Category("Settings")]
        public int Max_Val
        {
            get
            {
                return _maximum;
            }
            set
            {
                if (value >= _minimum)
                {
                    _maximum = value;
                }
                if (value < _minimum)
                {
                    _maximum = _minimum;
                }
                Invalidate();
            }
        }
        [Description("The direction of Progress Bar Forward or Backward"), Category("Settings")]
        public Direction Bar_Direction { get { return _direction; } set { _direction = value; Invalidate(); } }
        [Description("Type of bar to use Circle, Horizontal, or Vertical"), Category("Settings")]
        public BarType Bar_Type { get { return _barType; } set { _barType = value; Invalidate(); } }
        [Description("Text Formated as None, Value, or Percentage"), Category("Appearance")]
        public TextMode TextType { get { return _textType; } set { _textType = value; Invalidate(); } }
        [Description("Text value"), Category("Appearance")]
        public override string Text { get; set; }
        [Description("Background Color of the Custom Bar"), Category("Appearance")]
        public Color ColorBarBorder { get { return _colorBarBorder; } set { _colorBarBorder = value; Invalidate(); } }
        [Description("Border Color of the Progress Bar"), Category("Appearance")]
        public Color ColorBarBackground { get { return _colorBarBackground; } set { _colorBarBackground = value; Invalidate(); } }
        [Description("Color of  progress Bar"), Category("Appearance")]
        public Color ColorBMPBackground { get { return _colorBMPBackground; } set { _colorBMPBackground = value; Invalidate(); } }
        [Description("Used only on the Circle Progress Bar. It is the Color of the Square around the Bar."), Category("Appearance")]
        public Color ColorBarGradient1 { get { return _colorBarGradient1; } set { _colorBarGradient1 = value; Invalidate(); } }
        [Description("If this Color and LineColor2 are the same the Progress Bar is solid Color. If this Color and LineColor2 are different then there is a Gradient Effect"), Category("Appearance")]
        public Color ColorBarGradient2 { get { return _colorBarGradient2; } set { _colorBarGradient2 = value; Invalidate(); } }
        [Description("If this Color and LineColor1 are the same the Progress Bar is solid Color. If this Color and LineColor1 are different then there is a Gradient Effect"), Category("Appearance")]
        public int BorderWidth { get { return _borderWidth; } set { _borderWidth = value; Invalidate(); } }
        [Description("Progress Bar Border Thickness"), Category("Appearance")]
        public int LineWidth { get { return _lineWidth; } set { _lineWidth = value; Invalidate(); } }
        [Description("Gradient Direction"), Category("Appearance")]
        public LinearGradientMode GradientDirection { get { return _gradientDirection; } set { _gradientDirection = value; Invalidate(); } }
        [Description("Start Shape"), Category("Appearance"), DisplayName("Bar Shape End")]
        public LineCap BarShapeStart { get { return _startShape; } set { _startShape = value; Invalidate(); } }
        [Description("End Shape"), Category("Appearance"), DisplayName("Bar Shape Start")]
        public LineCap BarShapeEnd { get { return _endShape; } set { _endShape = value; Invalidate(); } }
        #endregion

        public MultiProgressBar()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.Opaque, true);

            Size = new Size(75, 75);
            Font = new Font(FontFamily.GenericSerif, 14, FontStyle.Regular);
            DoubleBuffered = true;

            TextType = TextMode.Percentage;
        }

        #region [Events]
        protected override void OnPaint(PaintEventArgs e)
        {

            switch (TextType)
            {
                case TextMode.None:
                    Text = string.Empty;
                    break;

                case TextMode.Value:
                    Text = _value.ToString();
                    break;

                case TextMode.Percentage:
                    Text = (100 * _value / _maximum).ToString() + " " + '%';
                    break;
            }

            SolidBrush brush_BMP_Color = new SolidBrush(ColorBMPBackground);
            SolidBrush brush_Bar_Color = new SolidBrush(ColorBarBackground);
            SolidBrush brush_Border_Color = new SolidBrush(ColorBarBorder);
            Brush lgb_BackGround = new LinearGradientBrush(ClientRectangle, ColorBarGradient1, ColorBarGradient2, GradientDirection);
            Pen borderPen = new Pen(brush_Border_Color, BorderWidth);

            if (Bar_Type == BarType.Circle) { Width = Height; }
            using (var bitmap = new Bitmap(Width, Height))
            {
                using (var graphics = System.Drawing.Graphics.FromImage(bitmap))
                {
                    graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    PaintTransparentBackground(this, e);

                    switch (Bar_Type)
                    {
                        case BarType.Circle:

                            MinimumSize = new Size(60, 60);
                            Size = new Size(Width, Height);
                            Pen foreGroundPen = new Pen(brush_Bar_Color, LineWidth);
                            e.Graphics.FillRectangle(brush_BMP_Color, ClientRectangle);
                            e.Graphics.DrawEllipse(foreGroundPen, 18, 18, Width - 36, Height - 36);

                            Pen c_linePen = new Pen(lgb_BackGround, LineWidth)
                            {
                                StartCap = BarShapeStart,
                                EndCap = BarShapeEnd
                            };

                            switch (Bar_Direction)
                            {
                                case Direction.Forward:
                                    e.Graphics.DrawArc(c_linePen, 18, 18, Width - 36, Height - 36, 270, (int)Math.Round((double)(360 * _value / _maximum)));
                                    break;
                                case Direction.Backward:
                                    e.Graphics.DrawArc(c_linePen, 18, 18, Width - 36, Height - 36, 270, -((int)Math.Round((double)(360 * _value / _maximum))));
                                    break;
                            }

                            e.Graphics.DrawRectangle(borderPen, 0, 0, Width, Height);

                            using (var fontColor = new SolidBrush(ForeColor))
                            {
                                var textSize = graphics.MeasureString(Text, Font);

                                e.Graphics.DrawString(Text, Font, fontColor,
                                    Convert.ToInt32(Width / 2 - textSize.Width / 2),
                                    Convert.ToInt32(Height / 2 - textSize.Height / 2));
                            }
                            graphics.DrawImage(bitmap, 0, 0);
                            break;

                        case BarType.Horizontal:
                            MinimumSize = new Size(50, 20);
                            Size = new Size(ClientSize.Width, ClientSize.Height);
                            e.Graphics.FillRectangle(brush_Bar_Color, ClientRectangle);

                            per = (float)Width / _maximum;
                            Pen h_linePen = new Pen(lgb_BackGround, (float)(Height * .5))
                            {
                                StartCap = BarShapeStart,
                                EndCap = BarShapeEnd
                            };

                            switch (Bar_Direction)
                            {
                                case Direction.Forward:
                                    e.Graphics.DrawLine(h_linePen, 0, Height / 2, _value * per, Height / 2);
                                    break;
                                case Direction.Backward:
                                    e.Graphics.DrawLine(h_linePen, Width, Height / 2, Width - (_value * per), Height / 2);
                                    break;
                            }

                            e.Graphics.DrawRectangle(borderPen, 0, 0, ClientSize.Width, ClientSize.Height);

                            using (var fontColor = new SolidBrush(ForeColor))
                            {
                                var textSize = e.Graphics.MeasureString(Text, Font);

                                e.Graphics.DrawString(Text, Font, fontColor,
                                    Convert.ToInt32(ClientSize.Width / 2 - textSize.Width / 2),
                                    Convert.ToInt32(ClientSize.Height / 2 - textSize.Height / 2));
                            }
                            graphics.DrawImage(bitmap, 0, 0);
                            break;

                        case BarType.Vertical:
                            MinimumSize = new Size(20, 50);
                            Size = new Size(Width, Height);
                            e.Graphics.FillRectangle(brush_Bar_Color, ClientRectangle);

                            per = (float)Height / _maximum;
                            Pen v_linePen = new Pen(lgb_BackGround, (float)(Width * .5))
                            {
                                StartCap = BarShapeStart,
                                EndCap = BarShapeEnd
                            };
                            switch (Bar_Direction)
                            {
                                case Direction.Forward:
                                    e.Graphics.DrawLine(v_linePen, Width / 2, Height, Width / 2, Height - (_value * per));
                                    break;
                                case Direction.Backward:
                                    e.Graphics.DrawLine(v_linePen, Width / 2, 0, Width / 2, (_value * per));
                                    break;
                            }

                            e.Graphics.DrawRectangle(borderPen, 0, 0, Width, Height);

                            using (var fontColor = new SolidBrush(ForeColor))
                            {
                                var textSize = e.Graphics.MeasureString(Text, Font);

                                e.Graphics.DrawString(Text, Font, fontColor,
                                    Convert.ToInt32(ClientSize.Width / 2 - textSize.Width / 2),
                                    Convert.ToInt32(ClientSize.Height / 2 - textSize.Height / 2));
                            }
                            graphics.DrawImage(bitmap, 0, 0);
                            break;
                    }
                }
            }
        }
        private static void PaintTransparentBackground(Control control, PaintEventArgs e)
        {
            if (control.Parent == null || !Application.RenderWithVisualStyles)
                return;

            ButtonRenderer.DrawParentBackground(e.Graphics, control.ClientRectangle, control);
        }
        #endregion
    }
}
