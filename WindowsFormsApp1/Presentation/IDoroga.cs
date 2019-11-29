using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;


namespace Presentation
{
   public interface IDoroga : IView
    {
        event Action AddVehicle;
        event Action StartIm;
        event Action StopIm;
        event Action GoBack;
    }
}
