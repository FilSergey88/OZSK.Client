using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OZSK.Client.Model;
using OZSK.Client.Model.Abstr;
using OZSK.Client.ServiceAgent;

namespace OZSK.Client.ViewModel.Auto.Command
{
    public class SaveAutoCommand
    {
        private readonly BasePostServiceAgent<Model.Auto, object> _serviceAgent;

        public SaveAutoCommand()
        {
            var path = "Auto/CreateOrUpdate";
            _serviceAgent = new BasePostServiceAgent<Model.Auto, object>(path);
        }
        public async Task Execute(object parameter)
        {
            if (!CanExecute(parameter))
                return;
            await _serviceAgent.Execute((Model.Auto)parameter, new CancellationToken());
        }
        public bool CanExecute(object parameter)
        {
            return (parameter is Model.Auto);
        }
    }
}