using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OZSK.Client.Model;
using OZSK.Client.ServiceAgent;

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
        public async Task Execute(object parameter)
        {
            if (!CanExecute(parameter))
                return;
            var result = await _serviceAgent.Execute(new BaseParams(), new CancellationToken());
            Autos = result.ToList();
        }
        public List<Model.Abstr.Auto> Autos { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }
    }
}
