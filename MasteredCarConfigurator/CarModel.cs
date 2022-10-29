using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasteredCarConfigurator
{
    public class CarModel
    {
        public string Model { get; set; }
        public string Image { get; set; }
        public override string ToString()
        {
            return this.Model;
        }
    }
}
