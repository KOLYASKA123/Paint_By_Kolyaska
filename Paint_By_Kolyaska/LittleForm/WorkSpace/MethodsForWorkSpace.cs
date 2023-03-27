using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_By_Kolyaska
{
    public partial class WorkSpace
    {
        /// <summary>
        /// Вызывается в случае перетаскивания фигур. Если при перетаскивании хотя бы одна фигура вышла за границы рабочей области, то выделенные фигуры вернутся в то место, где были выделены.
        /// </summary>
        /// <param name="list">Список выделенных фигур.</param>
        /// <param name="dx">Предполагаемое смещение по оси X.</param>
        /// <param name="dy">Предполагаемое смещение по оси Y.</param>
        /// <returns>true, если ни одна фигура не вышла за границы рабочей области, иначе false.</returns>
        private bool FigsCheckBorder(List<Figure> list, int dx, int dy)
        {
            foreach (Figure f in list)
            {
                if (!f.CheckBorder(Size, dx, dy))
                {
                    return false;
                }
            }
            return true;
        }

        private void InitializeChoosedFigure(MouseEventArgs e)
        {
            mainForm.paintFlag = true;
            mainForm.cursorMovedFlag = false;
            if (!mainForm.selectionFlag)
            {
                switch (mainForm.figType)
                {
                    case FigType.Line:
                        mainForm.fig = new Line(e.X, e.Y, e.X, e.Y, mainForm.optionOutlineColor, mainForm.optionFillColor, mainForm.optionOutlineWidth, mainForm.optionFillFlag);
                        break;
                    case FigType.Curve:
                        mainForm.fig = new Curve(e.X, e.Y, e.X, e.Y, mainForm.optionOutlineColor, mainForm.optionFillColor, mainForm.optionOutlineWidth, mainForm.optionFillFlag);
                        mainForm.fig.points.Add(new Point(e.X, e.Y));
                        break;
                    case FigType.Rect:
                        mainForm.fig = new Rect(e.X, e.Y, e.X, e.Y, mainForm.optionOutlineColor, mainForm.optionFillColor, mainForm.optionOutlineWidth, mainForm.optionFillFlag);
                        break;
                    case FigType.Ellipse:
                        mainForm.fig = new Ellipse(e.X, e.Y, e.X, e.Y, mainForm.optionOutlineColor, mainForm.optionFillColor, mainForm.optionOutlineWidth, mainForm.optionFillFlag);
                        break;
                    case FigType.Text:
                        mainForm.fig = new Text(e.X, e.Y, e.X, e.Y, mainForm.optionOutlineColor, mainForm.optionFillColor, mainForm.optionOutlineWidth, mainForm.optionFillFlag, mainForm.optionFont, "");
                        textBox1.Visible = false;
                        break;
                }
            }
            else
            {
                mainForm.fig = new SelectionRect(e.X, e.Y, e.X, e.Y, Color.Black, Color.White, 1, false);
                foreach (Figure f in dashLst)
                {
                    if (f.IsSelected(mainForm.fig.figureBox))
                    {
                        mainForm.dragFlag = true;
                    }
                }
            }
        }

        private void RedrawOldCanvas()
        {
            dblBuff.Render(g);
            dblBuff.Graphics.FillRectangle(new SolidBrush(Color.White), DisplayRectangle);
            foreach (Figure f in lst) f.Draw(dblBuff.Graphics);
        }

        private void RedrawContourOfNewFig(MouseEventArgs e)
        {
            foreach (Figure d in dashLst) d.DrawDash(dblBuff.Graphics);
            mainForm.fig.x2 = e.X;
            mainForm.fig.y2 = e.Y;
            if (mainForm.figType == FigType.Curve)
                mainForm.fig.points.Add(new Point(e.X, e.Y));
            mainForm.fig.DrawDash(dblBuff.Graphics);
        }

        private void DashMoveSelectedFigs(MouseEventArgs e)
        {
            foreach (Figure f in dashLst) f.Move(dblBuff.Graphics, e.X - prevX, e.Y - prevY);
        }

        private void UnselectDashListFigs()
        {
            foreach (Figure f in dashLst)
            {
                lst.Add(f);
            }
            dashLst.Clear();
        }

        private void RedrawOperations(MouseEventArgs e)
        {
            mainForm.changeLabelWorkSpaceCoordVal(e);
            if (mainForm.paintFlag)
            {
                RedrawOldCanvas();
                if (!mainForm.dragFlag)
                {
                    RedrawContourOfNewFig(e);
                }
                else
                {
                    DashMoveSelectedFigs(e);
                }
                mainForm.cursorMovedFlag = true;
                if (dashLst.Count > 0 && !mainForm.dragFlag)
                {
                    UnselectDashListFigs();
                }
            }
        }

        private void MoveSelectedFigs(MouseEventArgs e)
        {
            foreach (Figure f in dashLst)
            {
                f.MoveConfirm(e.X - prevX, e.Y - prevY);
            }
        }

        private void ShowTextBox()
        {
            textBox1.Clear();
            textBox1.Location = new Point(
                Math.Min(mainForm.fig.x1, mainForm.fig.x2),
                Math.Min(mainForm.fig.y1, mainForm.fig.y2));
            textBox1.ForeColor = mainForm.optionOutlineColor;
            textBox1.Font = mainForm.optionFont;
            textBox1.Size = new Size(
                Math.Max(mainForm.fig.x1, mainForm.fig.x2) -
                Math.Min(mainForm.fig.x1, mainForm.fig.x2),
                Math.Max(mainForm.fig.y1, mainForm.fig.y2) -
                Math.Min(mainForm.fig.y1, mainForm.fig.y2));
            textBox1.Visible = true;
            textBox1.Focus();
        }

        private void DrawAndAddNewFigInList()
        {
            mainForm.fig.Draw(dblBuff.Graphics);
            lst.Add(mainForm.fig);
        }

        private void TrackChanges()
        {
            if (!((LF)ParentForm).saveFlag)
            {
                if (thisForm.openedFlag)
                    mainForm.menuSaveFile.Enabled = true;
                thisForm.saveFlag = true;
            }
        }

        private void ConfirmActions(MouseEventArgs e)
        {
            if (mainForm.fig.CheckBorder(Size))
            {
                if (mainForm.selectionFlag)
                {
                    if (mainForm.dragFlag)
                    {
                        mainForm.dragFlag = false;

                        if (FigsCheckBorder(dashLst, e.X - prevX, e.Y - prevY))
                        {
                            MoveSelectedFigs(e);
                        }
                    }
                }
                else
                {
                    if (mainForm.figType == FigType.Text)
                    {
                        ShowTextBox();
                    }
                    else
                    {
                        DrawAndAddNewFigInList();
                        TrackChanges();
                    }
                }
            }
            else dblBuff.Render(g);
            mainForm.paintFlag = false;
            Invalidate();
        }
    }
}