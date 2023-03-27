using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_By_Kolyaska
{
    [Serializable()]
    public class Text : Figure
    {
        public Text(int x1, int y1, int x2, int y2, Color outlineColor, Color fillColor, int outlineWidth, bool fillFlag, Font font, string text) :
            base(x1, y1, x2, y2, outlineColor, fillColor, outlineWidth, fillFlag, font, text)
        { }

        public override bool CheckBorder(Size size)
        {
            return ChB(size);
        }

        public override bool CheckBorder(Size size, int dx, int dy)
        {
            return ChB(size, dx, dy);
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new(outlineColor, 1);
            figureBox = Rectangle.FromLTRB(Math.Min(x1, x2), Math.Min(y1, y2), Math.Max(x1, x2), Math.Max(y1, y2));
            if (fillFlag) g.FillRectangle(new SolidBrush(fillColor), figureBox);
            g.DrawRectangle(pen, figureBox);
            g.DrawString(text, font, new SolidBrush(outlineColor), figureBox);
        }

        public override void DrawDash(Graphics g)
        {
            Pen pen = new(outlineColor, 1)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dash
            };
            figureBox = Rectangle.FromLTRB(Math.Min(x1, x2), Math.Min(y1, y2), Math.Max(x1, x2), Math.Max(y1, y2));
            g.DrawString(text, font, new SolidBrush(outlineColor), figureBox);
            g.DrawRectangle(pen, figureBox);
        }

        public override void Move(Graphics g, int dx, int dy)
        {
            Pen pen = new(outlineColor, outlineWidth)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dash
            };
            g.DrawString(text, font, new SolidBrush(outlineColor), new Rectangle(figureBox.X + dx, figureBox.Y + dy, figureBox.Width, figureBox.Height));
            g.DrawRectangle(pen, figureBox.X + dx, figureBox.Y + dy, figureBox.Width, figureBox.Height);
        }

        public override void MoveConfirm(int dx, int dy)
        {
            OffsetTwoPoints(dx, dy);
        }
    }
}
