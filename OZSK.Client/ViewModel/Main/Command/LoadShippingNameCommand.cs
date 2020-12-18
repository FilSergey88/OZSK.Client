using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
        public async Task Execute(object parameter)
        {
            if (!CanExecute(parameter))
                return;
            var result = await _serviceAgent.Execute(new BaseParams(), new CancellationToken());
            ShippingNames = result.ToList();
        }
        public List<Model.ShippingName> ShippingNames { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }
    }
}
