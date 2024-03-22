using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HUYNHDE_DUAN1.contructions_functions
{
    internal class buttonRadius : Button
    {
        // fields
        private int borderSize = 0;

        private int borderRadius = 20;
        private Color borderColor = Color.Red;

        //properties
        /*   */

        [Category("RJ Code Advacne")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        /*   */

        [Category("RJ Code Advacne")]
        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        /*   */

        [Category("RJ Code Advacne")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        /*   */

        [Category("RJ Code Advacne")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        /*   */

        [Category("RJ Code Advacne")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        // contructor
        public buttonRadius()
        {
            this.FlatStyle = FlatStyle.Standard;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
        }

        //Methods
        private GraphicsPath GetfigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectSurface = new Rectangle(0, 0, this.Width, this.Height);
            Rectangle rectBorder = new Rectangle(1, 1, Convert.ToInt32(this.Width - 0.8F), this.Height - 1);

            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetfigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetfigurePath(rectBorder, borderRadius))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    //Button Surface
                    this.Region = new Region(pathSurface);
                    // draw surface border
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    //button border
                    if (borderSize >= 1)
                    {
                        //draw controller border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else // normal button
            {
                // button surface
                this.Region = new Region(rectSurface);
                // button border

                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    }
}