using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OZSK.Client.Annotations;
using OZSK.Client.Model;
using OZSK.Client.Model.Abstr;
using OZSK.Client.ViewModel.Auto.Command;

namespace OZSK.Client.ViewModel.Auto
{
    public class AutoViewModel : INotifyPropertyChanged
    {
        private readonly LoadCarriersCommand _loadCarriersCommand;
        private readonly SaveAutoCommand _saveCarrierCommand;
        private string _model;
        private string _number;
        private string _sts;
        private string _pts;
        private Carrier _carrier;

        public AutoViewModel()
        {
            _loadCarriersCommand = new LoadCarriersCommand();
            _saveCarrierCommand = new SaveAutoCommand();
        }

        public string Model
        {
            get => _model;
            set
            {
                _model = value;
                OnPropertyChanged(nameof(Model));
            }
        }

        public string Number
        {
            get => _number;
            set
            {
                _number = value;
                OnPropertyChanged(nameof(Number));
            }
        }

        public string STS
        {
            get => _sts;
            set
            {
                _sts = value;
                OnPropertyChanged(nameof(STS));
            }
        }

        public string PTS
        {
            get => _pts;
            set
            {
                _pts = value;
                OnPropertyChanged(nameof(PTS));
            }
        }

        public Carrier SelectedCarrier
        {
            get => _carrier;
            set
            {
                _carrier = value;
                OnPropertyChanged(nameof(SelectedCarrier));
            }
        }

        private BindingList<Carrier> _carriers;

        public BindingList<Carrier> CarrierList
        {
            get => _carriers;
            set
            {
                _carriers = value;
                OnPropertyChanged(nameof(CarrierList));
            }
        }

        public async void Save(Carrier selectedCarrier)
        {
            var newAuto = new Model.Abstr.Auto
            {
                Number = Number,
                Brand = Model,
                PTS = PTS,
                STS = STS,
                EntityState = EntityState.Added,
                CarrierId = selectedCarrier?.Id ?? 0
            };
            await _saveCarrierCommand.Execute(newAuto);
        }

        public void Initialize()
        {
            Task.Run(async () => await _loadCarriersCommand.Execute(null)).ContinueWith(q =>
            {
                CarrierList = new BindingList<Carrier>(_loadCarriersCommand.Carriers);
            });
            Thread.Sleep(2000);
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}