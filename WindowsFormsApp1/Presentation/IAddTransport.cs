using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presentation
{
   public interface IAddTransport : IView
    {
        event Action Done;
    }
}
