using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.ComponentModel;

namespace Utilidades
{
    [DefaultEvent("Click")]
    public partial class BotonPersonalizado : UserControl
    {
        int wh = 20; float ang = 45;
        Color color = Color.MidnightBlue, color1 = Color.Red;
        Timer t = new Timer();
        string txt = "Ingresar";

        public BotonPersonalizado()
        {
            DoubleBuffered = true;
            t.Interval = 30;
            t.Start();
            t.Tick += (n, e) => { Angle = Angle % 360 + 1; };
            ForeColor = Color.White;
        }

        public float Angle
        {
            get { return ang; }
            set { ang = value; Invalidate(); }
        }
        public int BorderRadius
        {
            get { return wh; }

            set { wh = value; Invalidate(); }

        }

        public Color Color1
        {
            get { return color; }
            set { color = value; Invalidate(); }
        }
        public Color Color2
        {
            get { return color1; }
            set { color1 = value; Invalidate(); }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(new Rectangle(0, 0, wh, wh), 180, 90);
            path.AddArc(new Rectangle(Width-wh, 0, wh, wh), -90, 90);
            path.AddArc(new Rectangle(Width - wh, Height-wh, wh, wh), 0, 90);
            path.AddArc(new Rectangle(0, Height-wh, wh, wh), 90, 90);

            e.Graphics.FillPath(new LinearGradientBrush(ClientRectangle,color,color1, ang), path);
            e.Graphics.DrawString(txt, Font, new SolidBrush(ForeColor), ClientRectangle, new StringFormat(){ LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });

            base.OnPaint(e);
        }


    }
}
