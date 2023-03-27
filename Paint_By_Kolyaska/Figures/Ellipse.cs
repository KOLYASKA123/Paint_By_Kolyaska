using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_By_Kolyaska
{
    public class Ellipse : Figure
    {
        public Ellipse(int x1, int y1, int x2, int y2, Color outlineColor, Color fillColor, int outlineWidth, bool fillFlag) :
            base(x1, y1, x2, y2, outlineColor, fillColor, outlineWidth, fillFlag)
        { }

        /// <summary>
        /// Выполняет финальную отрисовку эллипса.
        /// </summary>
        /// <param name="g">Какой-то объект, необходимый для рисования графических примитивов.</param>
        public override void Draw(Graphics g)
        {
            Pen pen = new(outlineColor, outlineWidth);
            figureBox = Rectangle.FromLTRB(Math.Min(x1, x2), Math.Min(y1, y2), Math.Max(x1, x2), Math.Max(y1, y2));
            if (fillFlag) g.FillEllipse(new SolidBrush(fillColor), figureBox);
            g.DrawEllipse(pen, figureBox);
        }

        /// <summary>
        /// Выполняет промежуточную отрисоку контура эллипса.
        /// </summary>
        /// <param name="g">Какой-то объект, необходимый для рисования графических примитивов.</param>
        public override void DrawDash(Graphics g)
        {
            Pen pen = new(outlineColor, outlineWidth)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dash
            };
            figureBox = Rectangle.FromLTRB(Math.Min(x1, x2), Math.Min(y1, y2), Math.Max(x1, x2), Math.Max(y1, y2));
            if (fillFlag) g.FillEllipse(new SolidBrush(fillColor), figureBox);
            g.DrawEllipse(pen, figureBox);
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
            if (fillFlag) g.FillEllipse(new SolidBrush(fillColor),
                figureBox.X + dx, figureBox.Y + dy, figureBox.Width, figureBox.Height);
            g.DrawEllipse(pen, figureBox.X + dx, figureBox.Y + dy, figureBox.Width, figureBox.Height);
        }

        public override void MoveConfirm(int dx, int dy)
        {
            OffsetTwoPoints(dx, dy);
        }
    }
}
