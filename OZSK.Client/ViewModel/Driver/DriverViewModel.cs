using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OZSK.Client.Annotations;
using OZSK.Client.Model.Abstr;
using OZSK.Client.ViewModel.Driver.Command;

namespace OZSK.Client.ViewModel.Driver
{
    public class DriverViewModel : BaseViewModel
    {
        private readonly LoadAutosCommand _loadAutosCommand;
        private readonly SaveDriverCommand _saveDriverCommand;
        
        public DriverViewModel()
        {
            _loadAutosCommand = new LoadAutosCommand();
            _saveDriverCommand = new SaveDriverCommand();
        }

        #region Params
        private string _number;
        private string _name;
        public string Number
        {
            get => _number;
            set => SetProperty(ref _number, value);
        }
        public string FIO
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        private List<Model.Abstr.Auto> _autos;

        public List<Model.Abstr.Auto> Autos
        {
            get => _autos;
            set => SetProperty(ref _autos, value);

        }

        private Model.Abstr.Auto _auto;
        public Model.Abstr.Auto Auto
        {
            get => _auto;
            set => SetProperty(ref _auto, value);
        }
        #endregion

        public override void Initialize()
        {
            Task.Run(async () => await _loadAutosCommand.Execute(this,null));
        }

        public async void Save()
        {
            var newAuto = new Model.Driver()
            {
                Number = Number,
                Name = FIO,
                EntityState = EntityState.Added,
                AutoId = Auto?.Id ?? 0
            };
            await _saveDriverCommand.Execute(newAuto);
        }
    }
}
