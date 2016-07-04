using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Element
{
    public class Button : Elements
    {

        public string Id { get; set; }

        public Button() { }
        public Button(String id) { this.Id = id; }



    }
}
