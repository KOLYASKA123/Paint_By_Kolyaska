using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Paint_By_Kolyaska
{
    [Serializable()]
    public class SaveData
    {
        public Size size;
        public List<Figure> listOfFigures;

        public SaveData(Size size, List<Figure> listOfFigures)
        {
            this.size = size;
            this.listOfFigures = listOfFigures;
        }
    }
}
