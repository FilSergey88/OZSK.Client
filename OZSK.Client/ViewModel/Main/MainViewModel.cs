using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public MainViewModel()
        {
            _loadCipherListCommand = new LoadCipherListCommand();
            _loadShippingNameCommand = new LoadShippingNameCommand();
        }

        private string _consigneeName;
        public string ConsigneeName
        {
            get => _consigneeName;
            set => SetProperty(ref _consigneeName, value);
        }
        public override void Initialize()
        {
            Task.Run(async () => await _loadCipherListCommand.Execute(null)).ContinueWith(q =>
            {
                Cipherlists = new List<Cipherlist>(_loadCipherListCommand.Cipherlists);
            });
            Thread.Sleep(2000);
            Task.Run(async () => await _loadShippingNameCommand.Execute(null)).ContinueWith(q =>
            {
                ShippingNames = new List<ShippingName>(_loadShippingNameCommand.ShippingNames);
            });
            Thread.Sleep(2000);
        }

        public void OnPropertyChangedCipher(Cipherlist cipherlist)
        {
            Consignee = cipherlist.Consignee;
            Cipherlist = cipherlist;
        }
        private Cipherlist _cipherlist;

        public Cipherlist Cipherlist
        {
            get => _cipherlist;
            set => SetProperty(ref _cipherlist, value);
        }
        private List<Cipherlist> _cipherlists;
        private List<ShippingName> _shippingNames;
        public List<Cipherlist> Cipherlists
        {
            get => _cipherlists;
            set => SetProperty(ref _cipherlists, value);

        }
        public List<ShippingName> ShippingNames
        {
            get => _shippingNames;
            set => SetProperty(ref _shippingNames, value);

        }
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
        public void AddAuto()
        {
            using var form = new AutoView();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                
            }
        }

        public void AddDriver()
        {
            using var form = new DriverView();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {

            }
        }

        public void AddCarrier()
        {
            using var form = new CarrierView();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {

            }
        }
    }
}
