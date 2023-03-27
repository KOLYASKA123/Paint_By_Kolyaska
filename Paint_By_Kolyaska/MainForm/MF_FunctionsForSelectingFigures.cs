using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_By_Kolyaska
{
    public partial class MF : Form
    {
        private void chooseLine()
        {
            if (!menuLine.Checked)
            {
                menuCurva.Checked = false;
                menuRect.Checked = false;
                menuEllipse.Checked = false;
                menuText.Checked = false;
                menuFillFlag.Enabled = false;
                menuFillColor.Enabled = false;
                menuLine.Checked = true;
                toolBarLine.Checked = true;
                toolBarText.Checked = false;
                toolBarCurva.Checked = false;
                toolBarRect.Checked = false;
                toolBarEllipse.Checked = false;
                toolBarFillColor.Enabled = false;
                toolBarFillFlag.Enabled = false;
                fillColorStatusText.Visible = false;
                fillColorVal.Visible = false;
                fontSizeStatusText.Visible = false;
                fontSizeVal.Visible = false;
                fontStatusText.Visible = false;
                menuFont.Enabled = false;
                toolBarFont.Enabled = false;
                menuPenSize.Enabled = true;
                toolBarPenSize.Enabled = true;
                penSizeStatusText.Visible = true;
                penSizeVal.Visible = true;
                fontVal.Visible = false;
                figType = FigType.Line;
            }
        }

        private void chooseCurva()
        {
            if (!menuCurva.Checked)
            {
                menuLine.Checked = false;
                menuRect.Checked = false;
                menuEllipse.Checked = false;
                menuText.Checked = false;
                menuFillFlag.Enabled = false;
                menuFillColor.Enabled = false;
                menuCurva.Checked = true;
                toolBarCurva.Checked = true;
                toolBarLine.Checked = false;
                toolBarRect.Checked = false;
                toolBarEllipse.Checked = false;
                toolBarText.Checked = false;
                toolBarFillColor.Enabled = false;
                toolBarFillFlag.Enabled = false;
                fillColorStatusText.Visible = false;
                fillColorVal.Visible = false;
                fontSizeStatusText.Visible = false;
                fontSizeVal.Visible = false;
                fontStatusText.Visible = false;
                menuFont.Enabled = false;
                toolBarFont.Enabled = false;
                menuPenSize.Enabled = true;
                toolBarPenSize.Enabled = true;
                penSizeStatusText.Visible = true;
                penSizeVal.Visible = true;
                fontVal.Visible = false;
                figType = FigType.Curve;
            }
        }

        private void chooseRect()
        {
            if (!menuRect.Checked)
            {
                menuLine.Checked = false;
                menuCurva.Checked = false;
                menuEllipse.Checked = false;
                menuText.Checked = false;
                menuFillFlag.Enabled = true;
                if (menuFillFlag.Checked)
                {
                    menuFillColor.Enabled = true;
                    toolBarFillColor.Enabled = true;
                }
                menuRect.Checked = true;
                toolBarRect.Checked = true;
                toolBarText.Checked = false;
                toolBarLine.Checked = false;
                toolBarCurva.Checked = false;
                toolBarEllipse.Checked = false;
                toolBarFillFlag.Enabled = true;
                fillColorStatusText.Visible = true;
                fillColorVal.Visible = true;
                fontSizeStatusText.Visible = false;
                fontSizeVal.Visible = false;
                fontStatusText.Visible = false;
                menuFont.Enabled = false;
                toolBarFont.Enabled = false;
                menuPenSize.Enabled = true;
                toolBarPenSize.Enabled = true;
                penSizeStatusText.Visible = true;
                penSizeVal.Visible = true;
                fontVal.Visible = false;
                figType = FigType.Rect;
            }
        }

        private void chooseEllipse()
        {
            if (!menuEllipse.Checked)
            {
                menuLine.Checked = false;
                menuCurva.Checked = false;
                menuRect.Checked = false;
                menuText.Checked = false;
                menuFillFlag.Enabled = true;
                if (menuFillFlag.Checked)
                {
                    menuFillColor.Enabled = true;
                    toolBarFillColor.Enabled = true;
                }
                menuEllipse.Checked = true;
                toolBarEllipse.Checked = true;
                toolBarText.Checked = false;
                toolBarRect.Checked = false;
                toolBarLine.Checked = false;
                toolBarCurva.Checked = false;
                toolBarFillFlag.Enabled = true;
                fillColorStatusText.Visible = true;
                fillColorVal.Visible = true;
                fontSizeStatusText.Visible = false;
                fontSizeVal.Visible = false;
                fontStatusText.Visible = false;
                menuFont.Enabled = false;
                toolBarFont.Enabled = false;
                menuPenSize.Enabled = true;
                toolBarPenSize.Enabled = true;
                penSizeStatusText.Visible = true;
                penSizeVal.Visible = true;
                fontVal.Visible = false;
                figType = FigType.Ellipse;
            }
        }

        private void chooseText()
        {
            if (!menuText.Checked)
            {
                menuLine.Checked = false;
                menuCurva.Checked = false;
                menuRect.Checked = false;
                menuEllipse.Checked = false;
                if (menuFillFlag.Checked)
                {
                    menuFillColor.Enabled = true;
                    toolBarFillColor.Enabled = true;
                }
                menuText.Checked = true;
                toolBarText.Checked = true;
                toolBarLine.Checked = false;
                toolBarCurva.Checked = false;
                toolBarRect.Checked = false;
                toolBarEllipse.Checked = false;
                toolBarFillFlag.Enabled = true;
                fillColorStatusText.Visible = true;
                fillColorVal.Visible = true;
                fontSizeStatusText.Visible = true;
                fontSizeVal.Visible = true;
                fontStatusText.Visible = true;
                menuFont.Enabled = true;
                toolBarFont.Enabled = true;
                menuPenSize.Enabled = false;
                toolBarPenSize.Enabled = false;
                penSizeStatusText.Visible = false;
                penSizeVal.Visible = false;
                fontVal.Visible = true;
                figType = FigType.Text;
            }
        }
    }
}
