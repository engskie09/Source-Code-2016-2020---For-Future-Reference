using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

class OvalPictureBox : PictureBox
{
    public Color ColorTop { get; set; }
    public Color ColorBottom { get; set; }

    protected override void OnPaint(PaintEventArgs e)
    {
        LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, 90F);
        Graphics g = e.Graphics;
        g.FillRectangle(lgb, this.ClientRectangle);
        base.OnPaint(e);

    }
    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        using (var gp = new GraphicsPath())
        {
            gp.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
            this.Region = new Region(gp);
        }
    }
}