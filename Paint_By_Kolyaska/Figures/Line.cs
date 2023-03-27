using Paint_By_Kolyaska;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_By_Kolyaska
{
    [Serializable()]
    public class Line : Figure
    {
        public Line(int x1, int y1, int x2, int y2, Color outlineColor, Color fillColor, int outlineWidth, bool fillFlag) :
            base(x1, y1, x2, y2, outlineColor, fillColor, outlineWidth, fillFlag) { }

        public override void Draw(Graphics g)
        {
            Pen pen = new(outlineColor, outlineWidth)
            {
                DashCap = System.Drawing.Drawing2D.DashCap.Round
            };
            figureBox = Rectangle.FromLTRB(Math.Min(x1, x2), Math.Min(y1, y2), Math.Max(x1, x2), Math.Max(y1, y2));
            g.DrawLine(pen, x1, y1, x2, y2);
        }

        public override void DrawDash(Graphics g)
        {
            Pen pen = new(outlineColor, outlineWidth)
            {
                DashCap = System.Drawing.Drawing2D.DashCap.Round,
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dash
            };
            figureBox = Rectangle.FromLTRB(Math.Min(x1, x2), Math.Min(y1, y2), Math.Max(x1, x2), Math.Max(y1, y2));
            g.DrawLine(pen, x1, y1, x2, y2);
        }

        public override bool CheckBorder(Size size)
        {
            return ChB(size);
        }

        public override bool CheckBorder(Size size, int dx, int dy)
        {
            return ChB(size, dx, dy);
        }

        public override void Move(Graphics g, int dx, int dy)
        {
            Pen pen = new(outlineColor, outlineWidth)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dash
            };
            g.DrawLine(pen, x1 + dx, y1 + dy, x2 + dx, y2 + dy);
        }

        public override void MoveConfirm(int dx, int dy)
        {
            OffsetTwoPoints(dx, dy);
        }
    }
}
