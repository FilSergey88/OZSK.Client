using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OZSK.Client.Model.Abstr;
using OZSK.Client.ViewModel.Carrier.Command;

namespace OZSK.Client.ViewModel.Carrier
{
    public class CarrierViewModel : BaseViewModel

    {
        private readonly SaveCarrierCommand _saveCarrierCommand;

        public CarrierViewModel()
        {
            _saveCarrierCommand = new SaveCarrierCommand();
        }

        private string _name;
        private string _address;
        private string _seo;
        private string _phone;
        private string _inn;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        public string Address
        {
            get => _address;
            set => SetProperty(ref _address, value);
        }
        public string Seo
        {
            get => _seo;
            set => SetProperty(ref _seo, value);
        }
        public string Inn
        {
            get => _inn;
            set => SetProperty(ref _inn, value);
        }
        public string Phone
        {
            get => _phone;
            set => SetProperty(ref _phone, value);
        }
        public override void Initialize()
        {
            
        }

        public async void Save()
        {
            var newCarrier = new Model.Carrier
            {
                Address = Address,
                Contact = Phone,
                Name = Name,
                SEO = Seo,
                EntityState = EntityState.Added
            };

            await _saveCarrierCommand.Execute(newCarrier);
        }
    }
}
