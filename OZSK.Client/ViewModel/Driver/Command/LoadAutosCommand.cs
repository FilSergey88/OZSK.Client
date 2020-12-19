using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OZSK.Client.Model;
using OZSK.Client.ServiceAgent;
using OZSK.Client.ViewModel.Auto;

namespace OZSK.Client.ViewModel.Driver.Command
{
    public class LoadAutosCommand
    {
        private readonly BaseGetServiceAgent<BaseParams, ICollection<Model.Abstr.Auto>> _serviceAgent;

        public LoadAutosCommand()
        {
            var path = "Auto";
            _serviceAgent = new BaseGetServiceAgent<BaseParams, ICollection<Model.Abstr.Auto>>(path);
        }
        public async Task Execute(DriverViewModel viewModel,object parameter)
        {
            if (!CanExecute(parameter))
                return;
            var result = await _serviceAgent.Execute(new BaseParams(), new CancellationToken());
            viewModel.Autos = new ObservableCollection<Model.Abstr.Auto>(result.ToList());result.ToList();
        }
        public async Task Execute(AutoViewModel viewModel, object parameter)
        {
            if (!CanExecute(parameter))
                return;
            var result = await _serviceAgent.Execute(new BaseParams(), new CancellationToken());
            viewModel.Autos = new ObservableCollection<Model.Abstr.Auto>(result.ToList()); result.ToList();
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
    }
}
