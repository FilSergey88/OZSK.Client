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
    public class LoadCipherListCommand
    {
        private readonly BaseGetServiceAgent<BaseParams, ICollection<Model.Cipherlist>> _serviceAgent;

        public LoadCipherListCommand()
        {
            var path = "CipherList";
            _serviceAgent = new BaseGetServiceAgent<BaseParams, ICollection<Model.Cipherlist>>(path);
        }
        public async Task Execute(MainViewModel viewModel,object parameter)
        {
            if (!CanExecute(parameter))
                return;
            var result = await _serviceAgent.Execute(new BaseParams(), new CancellationToken());
            viewModel.Cipherlists = new ObservableCollection<Cipherlist>(result.ToList());result.ToList();
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
    }
}
