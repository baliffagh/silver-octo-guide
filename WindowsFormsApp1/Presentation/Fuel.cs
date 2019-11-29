using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;


namespace Presentation
{
    public class Fuel
    {
        string nameOfFuel;

        public void read_name_of_fuel(string strName)
        {
            nameOfFuel = strName;
        }
    }
}
