using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OZSK.Client.Model;
using OZSK.Client.Model.Abstr;
using OZSK.Client.ServiceAgent;

namespace OZSK.Client.ViewModel.Auto.Command
{
    public class LoadCarriersCommand
    {
        private readonly BaseGetServiceAgent<BaseParams, ICollection<Carrier>> _serviceAgent;

        public LoadCarriersCommand()
        {
            var path = "Carrier";
            _serviceAgent = new BaseGetServiceAgent<BaseParams, ICollection<Carrier>>(path);
        }
        public async Task Execute(object parameter)
        {
            if (!CanExecute(parameter))
                return;
            var result =  await _serviceAgent.Execute(new BaseParams(), new CancellationToken());
            Carriers = result.ToList();
        }
        public List<Carrier> Carriers { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }
    }
}
