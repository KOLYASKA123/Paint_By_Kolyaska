using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_By_Kolyaska
{
    [Serializable()]
    public class Curve : Figure
    {
        public Curve(int x1, int y1, int x2, int y2, Color outlineColor, Color fillColor, int outlineWidth, bool fillFlag) :
            base(x1, y1, x2, y2, outlineColor, fillColor, outlineWidth, fillFlag)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.outlineColor = outlineColor;
            this.fillColor = fillColor;
            this.outlineWidth = outlineWidth;
            this.fillFlag = fillFlag;
            this.points.Add(new Point(x1, y1));
            this.points.Add(new Point(x2, y2));
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new(outlineColor, outlineWidth)
            {
                DashCap = System.Drawing.Drawing2D.DashCap.Round
            };
            figureBox = Rectangle.FromLTRB(
                points.MinBy(x => x.X).X,
                points.MinBy(y => y.Y).Y,
                points.MaxBy(x => x.X).X,
                points.MaxBy(y => y.Y).Y);
            g.DrawCurve(pen, points.ToArray());
        }

        public override void DrawDash(Graphics g)
        {
            Pen pen = new(outlineColor, outlineWidth)
            {
                DashCap = System.Drawing.Drawing2D.DashCap.Round,
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dash
            };
            figureBox = Rectangle.FromLTRB(
                points.MinBy(x => x.X).X,
                points.MinBy(y => y.Y).Y,
                points.MaxBy(x => x.X).X,
                points.MaxBy(y => y.Y).Y);
            g.DrawCurve(pen, points.ToArray<Point>());
        }

        public override bool CheckBorder(Size size)
        {
            return ChC(size);
        }

        public override bool CheckBorder(Size size, int dx, int dy)
        {
            return ChC(size, dx, dy);
        }

        public override void Move(Graphics g, int dx, int dy)
        {
            List<Point> newLst = new List<Point>();
            for (int i = 0; i < points.Count; i++)
            {
                newLst.Add(new Point(points[i].X + dx, points[i].Y + dy));
            }
            Pen pen = new(outlineColor, outlineWidth)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dash
            };
            g.DrawCurve(pen, newLst.ToArray<Point>());
        }

        public override void MoveConfirm(int dx, int dy)
        {
            OffsetListOfPoints(dx, dy);
        }
    }
}
