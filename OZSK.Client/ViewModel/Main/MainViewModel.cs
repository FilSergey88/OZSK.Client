using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OZSK.Client.Annotations;
using OZSK.Client.Model;
using OZSK.Client.ViewModel;
using OZSK.Client.ViewModel.Auto.Command;
using OZSK.Client.ViewModel.Main.Command;

namespace OZSK.Client.ViewModel.Main
{
    public class MainViewModel : BaseViewModel
    {
        private readonly LoadCipherListCommand _loadCipherListCommand;
        private readonly LoadShippingNameCommand _loadShippingNameCommand;
        private readonly LoadCarriersCommand _loadCarriersCommand;
        private readonly LoadAutoByCarrierIdCommand _loadAutoByCarrierIdCommand;

        public MainViewModel()
        {
            _loadAutoByCarrierIdCommand = new LoadAutoByCarrierIdCommand();
            _loadCipherListCommand = new LoadCipherListCommand();
            _loadShippingNameCommand = new LoadShippingNameCommand();
            _loadCarriersCommand = new LoadCarriersCommand();
        }

        private string _consigneeName;

        public string ConsigneeName
        {
            get => _consigneeName;
            set => SetProperty(ref _consigneeName, value);
        }

        public override void Initialize()
        {
            Task.Run(async () =>
            {
                await _loadCipherListCommand.Execute(this, null);
                await _loadShippingNameCommand.Execute(this, null);
                await _loadCarriersCommand.Execute(this, null);
            });
        }

        public void OnPropertyChangedCipher(Cipherlist cipherlist)
        {
            Consignee = cipherlist.Consignee;
            Cipher = cipherlist;
        }

        #region Cipher
        private Cipherlist _cipher;

        public Cipherlist Cipher
        {
            get => _cipher;
            set => SetProperty(ref _cipher, value);
        }

        private ObservableCollection<Cipherlist> _cipherlists;

        public ObservableCollection<Cipherlist> Cipherlists
        {
            get => _cipherlists;
            set => SetProperty(ref _cipherlists, value);
        }
        #endregion

        #region ShippingName
        private ObservableCollection<ShippingName> _shippingNames;

        public ObservableCollection<ShippingName> ShippingNames
        {
            get => _shippingNames;
            set => SetProperty(ref _shippingNames, value);
        }

        private ShippingName _shippingName;

        public ShippingName ShippingName
        {
            get => _shippingName;
            set => SetProperty(ref _shippingName, value);
        }
        #endregion

        private Consignee _consignee;

        public Consignee Consignee
        {
            get => _consignee;
            set
            {
                SetProperty(ref _consignee, value);
                ConsigneeName = value?.Name;
            }
        }

        #region Carrier
        private Model.Carrier _carrier;

        public Model.Carrier Carrier
        {
            get => _carrier;
            set => SetProperty(ref _carrier, value);
        }

        private ObservableCollection<Model.Carrier> _carriers;

        public ObservableCollection<Model.Carrier> CarrierList
        {
            get => _carriers;
            set => SetProperty(ref _carriers, value);
        }
        #endregion

        #region Auto
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

        public void LoadAuto()
        {
            if (Carrier != null)
            {
                Autos = new ObservableCollection<Model.Abstr.Auto>
                (CarrierList?.FirstOrDefault(q => q.Id == Carrier.Id)
                    ?.Autos?
                    .ToList()!);
                if (!Autos.Any())
                {
                    Drivers = new ObservableCollection<Model.Driver>();
                }
            }
        }

        public void LoadDriver()
        {
            if (Auto != null)
            {
                Drivers = new ObservableCollection<Model.Driver>
                (Autos?.FirstOrDefault(q => q.Id == Auto.Id)
                    ?.Drivers?
                    .ToList()!);

            }
        }
    }
}