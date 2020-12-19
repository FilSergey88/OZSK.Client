using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OZSK.Client.ServiceAgent;
using OZSK.Client.ViewModel.Auto;

namespace OZSK.Client.ViewModel.Driver.Command
{
    class LoadDriverCommand
    {
        private readonly BaseGetServiceAgent<BaseParams, ICollection<Model.Driver>> _serviceAgent;

        public LoadDriverCommand()
        {
            var path = "Driver";
            _serviceAgent = new BaseGetServiceAgent<BaseParams, ICollection<Model.Driver>>(path);
        }
        public async Task Execute(DriverViewModel viewModel, object parameter)
        {
            if (!CanExecute(parameter))
                return;
            var result = await _serviceAgent.Execute(new BaseParams(), new CancellationToken());
            viewModel.Drivers = new ObservableCollection<Model.Driver>(result.ToList()); result.ToList();
        }
        
        public bool CanExecute(object parameter)
        {
            return true;
        }
    }
}
