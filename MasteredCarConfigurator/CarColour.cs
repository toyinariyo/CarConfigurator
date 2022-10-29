using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasteredCarConfigurator
{
    public class CarColour
    {
        public string Colour { get; set; }
        public string Image { get; set; }
        public override string ToString()
        {
            return this.Colour;
        }
    }
}
