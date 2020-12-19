using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OZSK.Client.Model;
using OZSK.Client.ServiceAgent;

namespace OZSK.Client.ViewModel.Main.Command
{
    public class LoadShippingNameCommand
    {
        private readonly BaseGetServiceAgent<BaseParams, ICollection<Model.ShippingName>> _serviceAgent;

        public LoadShippingNameCommand()
        {
            var path = "ShippingName";
            _serviceAgent = new BaseGetServiceAgent<BaseParams, ICollection<Model.ShippingName>>(path);
        }
        public async Task Execute(MainViewModel viewModel,object parameter)
        {
            if (!CanExecute(parameter))
                return;
            var result = await _serviceAgent.Execute(new BaseParams(), new CancellationToken());
            viewModel.ShippingNames = new ObservableCollection<ShippingName>(result.ToList());result.ToList();
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
    }
}
