using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;


namespace Presentation
{
    public interface IMain : IView
    {
        event Action<string> AddFuel;
        event Action<string> ChooseNeedFuel;
        event Action Ready;
    }
}
