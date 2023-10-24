using System;
using System.Drawing;
using System.Windows.Forms;

public class TransparentLabel : Label
{
    public TransparentLabel()
    {
        // Set the control to be transparent and not capture mouse events.
        SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        SetStyle(ControlStyles.Opaque, false);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Adjust the TextRenderer for proper text rendering.
        TextRenderer.DrawText(e.Graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor, Color.Transparent, TextFormatFlags.Left);
    }
}
