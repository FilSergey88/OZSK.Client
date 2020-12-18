using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
        public async Task Execute(object parameter)
        {
            if (!CanExecute(parameter))
                return;
            var result = await _serviceAgent.Execute(new BaseParams(), new CancellationToken());
            Cipherlists = result.ToList();
        }
        public List<Model.Cipherlist> Cipherlists { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }
    }
}
