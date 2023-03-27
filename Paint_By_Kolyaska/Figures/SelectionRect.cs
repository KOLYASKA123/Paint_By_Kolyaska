using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_By_Kolyaska
{
    public class SelectionRect : Rect
    {
        public SelectionRect(int x1, int y1, int x2, int y2, Color outlineColor, Color fillColor, int outlineWidth, bool fillFlag) :
            base(x1, y1, x2, y2, outlineColor, fillColor, outlineWidth, fillFlag) { }
    }
}
