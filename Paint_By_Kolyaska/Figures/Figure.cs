using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Security.Policy;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.Xml;

namespace Paint_By_Kolyaska
{
    [Serializable()]
    public abstract class Figure
    {
        public int x1, y1, x2, y2;
        public Color outlineColor;
        public Color fillColor;
        public int outlineWidth;
        public bool fillFlag;
        public List<Point> points = new();

        protected Font font;
        protected string? text;

        public Rectangle figureBox;

        protected void OffsetTwoPoints(int dx, int dy)
        {
            x1 += dx;
            y1 += dy;
            x2 += dx;
            y2 += dy;
        }

        protected void OffsetListOfPoints(int dx, int dy)
        {
            for (int i = 0; i < points.Count; i++) 
                points[i] = new Point(points[i].X + dx, points[i].Y + dy);
        }

        public Figure(int x1, int y1, int x2, int y2, Color outlineColor, Color fillColor, int outlineWidth, bool fillFlag)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.figureBox = Rectangle.FromLTRB(x1, y1, x2, y2);
            this.outlineColor = outlineColor;
            this.fillColor = fillColor;
            this.outlineWidth = outlineWidth;
            this.fillFlag = fillFlag;
        }

        public bool IsSelected(Rectangle fb)
        {
            return figureBox.IntersectsWith(fb);
        }

        public void SetText(string newText)
        {
            text = newText;
        }

        public Figure(int x1, int y1, int x2, int y2, Color outlineColor, Color fillColor, int outlineWidth, bool fillFlag, Font font, string text)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.figureBox = Rectangle.FromLTRB(x1, y1, x2, y2);
            this.outlineColor = outlineColor;
            this.fillColor = fillColor;
            this.outlineWidth = outlineWidth;
            this.fillFlag = fillFlag;
            this.font = font;
            this.text = text;
        }

        /// <summary>
        /// Выполняет финальную отрисовку фигуры.
        /// </summary>
        /// <param name="g">Какой-то объект, необходимый для рисования графических примитивов.</param>
        public abstract void Draw(Graphics g);

        /// <summary>
        /// Вообще сейчас этот метод нужен, чтобы перекрывать старые промежуточные контуры
        /// фигуры, но потом его, по идее, можно будет заменить двойной буферизацией.
        /// </summary>
        /// <param name="g">Какой-то объект, необходимый для рисования графических примитивов.</param>
        public abstract void DrawDash(Graphics g);

        /// <summary>
        /// Отрисовывает фигуру с заданным смещением.
        /// </summary>
        /// <param name="g">Какой-то объект, необходимый для рисования графических примитивов.</param>
        /// <param name="dx">Смещение по оси X.</param>
        /// <param name="dy">Смещение по оси Y.</param>
        public abstract void Move(Graphics g, int dx, int dy);

        public abstract void MoveConfirm(int dx, int dy);

        /// <summary>
        /// Проверяет перед финальной отрисовкой, выходит ли рисуемая фигура за пределы рабочей области.
        /// Если фигура выходит за границу, то фигура не рисуется и не добавляется в массив фигур рабочей области.
        /// </summary>
        /// <param name="size">Размер рабочей области.</param>
        /// <returns>Флаг проверки того, лежит ли фигура в пределах рабочей области</returns>
        protected bool ChB(Size size)
        {
            if (
                x1 >= 0 && x1 <= size.Width &&
                y1 >= 0 && y1 <= size.Height &&
                x2 >= 0 && x2 <= size.Width &&
                y2 >= 0 && y2 <= size.Height
                )
            {
                return true;
            }
            return false;
        }

        protected bool ChB(Size size, int dx, int dy)
        {
            if (
                x1 + dx >= 0 && x1 + dx <= size.Width &&
                y1 + dy >= 0 && y1 + dy <= size.Height &&
                x2 + dx >= 0 && x2 + dx <= size.Width &&
                y2 + dy >= 0 && y2 + dy <= size.Height
                )
            {
                return true;
            }
            return false;
        }

        protected bool ChC(Size size)
        {
            foreach (Point p in points)
            {
                if (p.X < 0 || p.X > size.Width || p.Y < 0 || p.Y > size.Height)
                {
                    return false;
                }
            }
            return true;
        }

        protected bool ChC(Size size, int dx, int dy)
        {
            foreach (Point p in points)
            {
                if ((p.X + dx) < 0 || (p.X + dx) > size.Width || (p.Y + dy) < 0 || (p.Y + dy) > size.Height)
                {
                    return false;
                }
            }
            return true;
        }

        public abstract bool CheckBorder(Size size);
        public abstract bool CheckBorder(Size size, int dx, int dy);
    }
}