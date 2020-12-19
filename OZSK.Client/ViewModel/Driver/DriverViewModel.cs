using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private readonly LoadDriverCommand _loadDriverCommand;
        private bool _isAdd;
        public DriverViewModel(bool isAdd)
        {
            _loadAutosCommand = new LoadAutosCommand();
            _saveDriverCommand = new SaveDriverCommand();
            _loadDriverCommand = new LoadDriverCommand();
            _isAdd = isAdd;
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

        private ObservableCollection<Model.Abstr.Auto> _autos;

        public ObservableCollection<Model.Abstr.Auto> Autos
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
            Task.Run(async () =>
            {
                await _loadAutosCommand.Execute(this, null);
                if (!_isAdd)
                    await _loadDriverCommand.Execute(this, null);
            });
        }
        #region Driver
        private ObservableCollection<Model.Driver> _drivers;

        public ObservableCollection<Model.Driver> Drivers
        {
            get => _drivers;
            set => SetProperty(ref _drivers, value);
        }

        private Model.Driver _driver;

        public Model.Driver Driver
        {
            get => _driver;
            set => SetProperty(ref _driver, value);
        }
        #endregion

        public async void Save()
        {
            var newDriver = new Model.Driver()
            {
                Number = Number,
                Name = FIO,
                EntityState = _isAdd ? EntityState.Added : EntityState.Edited,
                AutoId = Auto?.Id ?? 0
            };
            if (!_isAdd)
            {
                newDriver.Ts = Driver.Ts;
                newDriver.Id = Driver.Id;
            }
            await _saveDriverCommand.Execute(newDriver);
        }
    }
}
