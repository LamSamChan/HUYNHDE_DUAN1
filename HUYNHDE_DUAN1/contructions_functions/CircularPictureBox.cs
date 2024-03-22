using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HUYNHDE_DUAN1.contructions_functions
{
    public class CircularPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            GraphicsPath g = new GraphicsPath();
            g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(g);
        }
    }
}