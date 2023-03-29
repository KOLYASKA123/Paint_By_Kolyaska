using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_By_Kolyaska
{
    /// <summary>
    /// Этот класс используется, чтобы убрать уродские закругления у панели инструментов.
    /// </summary>
    public class ToolBarNotRounded : System.Windows.Forms.ToolStripProfessionalRenderer
    {
        public ToolBarNotRounded()
        {
            RoundedEdges = false;
        }
    }
}
