using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickVenta.forndesign
{
    public static class radiusform
    {
        public static void GetRadius(this Form frm)
        {
            Rectangle bounds = new Rectangle(0, 0, frm.Width, frm.Height);
            int radius = 20; // Radio de redondeo
            GraphicsPath path = new GraphicsPath();

            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            frm.Region = new Region(path);
        }
    }
}
