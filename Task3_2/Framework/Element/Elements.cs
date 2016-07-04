using Framework.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class Elements : Iloggable
    {
        public string Element { get; set; }

        public void Log()
        {
            throw new NotImplementedException();
        }


        public void Click(Button but) { }

        public void SetText() { }


        public override string ToString()

        {
            return "Element: " + Element;
        }


    }
}
