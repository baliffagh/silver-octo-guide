using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presentation
{
   public class DorogaPresenter
    {
        private readonly IKernel _kernel;
        private IDoroga _view;
        // тут сервис
        public DorogaPresenter(IKernel kernel, IDoroga view /*,service*/)
        {
            _kernel = kernel;

            /*_service = service;*/
            _view = view;
            _view.AddVehicle += AddVehicle;
            _view.StartIm += StartIm;
            _view.StopIm += StopIm;
            _view.GoBack += GoBack;
        }

        private void GoBack()
        {
            _kernel.Get<MainPresenter>().Run();
        }
        public void Run()
        {
            _view.Show();
        }

        private void AddVehicle()
        {
            _kernel.Get<AddTransportPresenter>().Run();
        }

        private void StartIm()
        {
            /*_service.StartIm();*/
        }

        private void StopIm()
        {
            /*_service.StopIm();*/
            /*_view.StopIm();*/
        }
    }
}
