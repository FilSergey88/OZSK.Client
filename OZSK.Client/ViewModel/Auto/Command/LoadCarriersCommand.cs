using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OZSK.Client.Model;
using OZSK.Client.Model.Abstr;
using OZSK.Client.ServiceAgent;
using OZSK.Client.ViewModel.Carrier;
using OZSK.Client.ViewModel.Main;

namespace OZSK.Client.ViewModel.Auto.Command
{
    public class LoadCarriersCommand
    {
        private readonly BaseGetServiceAgent<BaseParams, ICollection<Model.Carrier>> _serviceAgent;

        public LoadCarriersCommand()
        {
            var path = "Carrier";
            _serviceAgent = new BaseGetServiceAgent<BaseParams, ICollection<Model.Carrier>>(path);
        }
        public async Task Execute(IHasCarrierList viewModel,object parameter)
        {
            if (!CanExecute(parameter))
                return;
            var result =  await _serviceAgent.Execute(new BaseParams(), new CancellationToken());
            viewModel.CarrierList =  new ObservableCollection<Model.Carrier>(result.ToList());result.ToList();
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
    }
}
