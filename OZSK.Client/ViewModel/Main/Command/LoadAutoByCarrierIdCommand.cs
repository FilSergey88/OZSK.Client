using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OZSK.Client.ServiceAgent;
using OZSK.Client.ViewModel.Driver;

namespace OZSK.Client.ViewModel.Main.Command
{
    public class LoadAutoByCarrierIdCommand
    {
        private readonly LoadAutoByIdServiceAgent _serviceAgent;

        public LoadAutoByCarrierIdCommand()
        {
            var path = "Auto/ByCarrierId";
            _serviceAgent = new LoadAutoByIdServiceAgent(path);
        }
        public async Task Execute(MainViewModel viewModel, object parameter)
        {
            if (!CanExecute(viewModel))
                return;
            var result = await _serviceAgent.Execute(viewModel.Carrier.Id, new CancellationToken());
            viewModel.Autos = new ObservableCollection<Model.Abstr.Auto>(result.ToList()); result.ToList();
        }
        public bool CanExecute(object parameter)
        {
            return parameter is MainViewModel viewModel && viewModel.Carrier != null;
        }
    }
}

