﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OZSK.Client.Model.Abstr;
using OZSK.Client.ViewModel.Auto.Command;
using OZSK.Client.ViewModel.Carrier.Command;

namespace OZSK.Client.ViewModel.Carrier
{
    public class CarrierViewModel : BaseViewModel, IHasCarrierList

    {
        private readonly SaveCarrierCommand _saveCarrierCommand;
        private readonly LoadCarriersCommand _loadCarriersCommand;
        private readonly bool _isAdd;
        public CarrierViewModel(bool isAdd)
        {
            _isAdd = isAdd;
            _loadCarriersCommand = new LoadCarriersCommand();
            _saveCarrierCommand = new SaveCarrierCommand();
        }

        #region params
        private string _name, _address, _seo, _phone, _inn;
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
        #endregion
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

        public override void Initialize()
        {
            if (!_isAdd)
                Task.Run(async () => await _loadCarriersCommand.Execute(this, null));
        }

        public async void Save()
        {
            var newCarrier = new Model.Carrier
            {
                Address = Address,
                Contact = Phone,
                Name = Name,
                SEO = Seo,
                EntityState = _isAdd ? EntityState.Added : EntityState.Edited,
                INN = Inn
            };
            if (!_isAdd)
            {
                newCarrier.Ts = Carrier.Ts;
                newCarrier.Id = Carrier.Id;
            }
            await _saveCarrierCommand.Execute(newCarrier);
        }

        public async void Delete()
        {
            var driver = new Model.Carrier
            {
                EntityState = EntityState.Deleted,
                Ts = Carrier.Ts,
                Id = Carrier.Id
            };

            await _saveCarrierCommand.Execute(driver);
        }
    }
}
