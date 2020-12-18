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
    public class SaveDriverCommand
    {
        private readonly BasePostServiceAgent<Model.Driver, object> _serviceAgent;

        public SaveDriverCommand()
        {
            var path = "Driver/CreateOrUpdate";
            _serviceAgent = new BasePostServiceAgent<Model.Driver, object>(path);
        }
        public async Task Execute(object parameter)
        {
            if (!CanExecute(parameter))
                return;
            await _serviceAgent.Execute((Model.Driver)parameter, new CancellationToken());
        }
        public bool CanExecute(object parameter)
        {
            return (parameter is Model.Driver);
        }
    }
}