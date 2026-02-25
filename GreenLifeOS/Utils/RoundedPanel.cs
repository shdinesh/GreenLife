using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GreenLifeOS.Utils
{
    internal class RoundedPanel : Panel
    {
        private int borderRadius = 20;
        private int borderSize = 1;
        private Color borderColor = Color.LightGray;

        [Category("Custom")]
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; Invalidate(); }
        }

        [Category("Custom")]
        public int BorderSize
        {
            get => borderSize;
            set { borderSize = value; Invalidate(); }
        }

        [Category("Custom")]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var rectSurface = this.ClientRectangle;
            if (rectSurface.Width <= 0 || rectSurface.Height <= 0) return;

            int radius = borderRadius;
            int size = borderSize;

            using (var path = GetRoundedPath(rectSurface, radius))
            using (var pen = new Pen(borderColor, size))
            {
                this.Region = new Region(path);

                if (size > 0)
                {
                    var rectBorder = Rectangle.Inflate(rectSurface, -size, -size);
                    using (var pathBorder = GetRoundedPath(rectBorder, radius - size))
                    {
                        e.Graphics.DrawPath(pen, pathBorder);
                    }
                }
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            int r = radius * 2;
            var path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
            path.CloseFigure();
            return path;
        }
    }

}
