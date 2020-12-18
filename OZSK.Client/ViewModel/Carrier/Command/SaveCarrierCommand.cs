using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OZSK.Client.ServiceAgent;

namespace OZSK.Client.ViewModel.Carrier.Command
{
    public class SaveCarrierCommand
    {
        private readonly BasePostServiceAgent<Model.Carrier, object> _serviceAgent;

        public SaveCarrierCommand()
        {
            var path = "Carrier/CreateOrUpdate";
            _serviceAgent = new BasePostServiceAgent<Model.Carrier, object>(path);
        }
        public async Task Execute(object parameter)
        {
            if (!CanExecute(parameter))
                return;
            await _serviceAgent.Execute((Model.Carrier)parameter, new CancellationToken());
        }
        public bool CanExecute(object parameter)
        {
            return parameter is Model.Carrier;
        }
    }
}