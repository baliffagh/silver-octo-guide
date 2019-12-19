using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presentation
{
   public class AddTransportPresenter
    {
        private readonly IKernel _kernel;
        private IAddTransport _view;
        // тут сервис
        public AddTransportPresenter(IKernel kernel, IAddTransport view /*,service*/)
        {
            _kernel = kernel;

            /*_service = service;*/
            _view = view;
            _view.Done += Done;
        }

        private void Done()
        {
           // _kernel.Get<AddTransportPresenter>().Run();
            _view.Close();
        }
        public void Run()
        {
            _view.Show();
        }
    }
}
