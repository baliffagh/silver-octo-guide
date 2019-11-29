using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presentation
{
     public class MainPresenter
    {
        private readonly IKernel _kernel;
        private IMain _view;
        // тут сервис
        public MainPresenter(IKernel kernel, IMain view /*,service*/)
        {
            _kernel = kernel;

            /*_service = service;*/
            _view = view;
            _view.AddFuel += AddFuel;
            _view.ChooseNeedFuel += ChooseNeedFuel;
            _view.Ready += Ready;
        }

        private void AddFuel(string fuel)
        {
            /*_service.AddFuel(fuel);*/
        }

        private void ChooseNeedFuel(string fuel)
        {
            /*_service.ChooseNeedFuel(fuel);*/
        }

        private void Ready()
        {
            _kernel.Get<DorogaPresenter>().Run();
            _view.Close();
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
