﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using OZSK.Client.ViewModel.Driver.Command;

namespace OZSK.Client.ViewModel.Auto
{
        
    public class AutoViewModel : BaseViewModel, IHasCarrierList, IHasAutos
    {
        private readonly LoadCarriersCommand _loadCarriersCommand;
        private readonly SaveAutoCommand _saveCarrierCommand;
        private readonly LoadAutosCommand _loadAutosCommand;
        private readonly bool _isAdd;

        public AutoViewModel(bool isAdd)
        {
            _loadCarriersCommand = new LoadCarriersCommand();
            _saveCarrierCommand = new SaveAutoCommand();
            _loadAutosCommand = new LoadAutosCommand();
            _isAdd = isAdd;
        }

        #region Params

        private string _model, _number, _sts, _pts;

        public string Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        public string Number
        {
            get => _number;
            set => SetProperty(ref _number, value);

        }

        public string STS
        {
            get => _sts;
            set => SetProperty(ref _sts, value);

        }

        public string PTS
        {
            get => _pts;
            set => SetProperty(ref _pts, value);

        }


        private ObservableCollection<Model.Carrier> _carriers;

        public ObservableCollection<Model.Carrier> CarrierList
        {
            get => _carriers;
            set => SetProperty(ref _carriers, value);

        }

        private Model.Carrier _carrier;

        public Model.Carrier Carrier
        {
            get => _carrier;
            set => SetProperty(ref _carrier, value);
        }

        #endregion

        #region Auto
        private ObservableCollection<Model.Auto> _autos;

        public ObservableCollection<Model.Auto> Autos
        {
            get => _autos;
            set => SetProperty(ref _autos, value);
        }

        private Model.Auto _auto;

        public Model.Auto Auto
        {
            get => _auto;
            set => SetProperty(ref _auto, value);
        }



        #endregion

        public async void Save()
        {
            var newAuto = new Model.Auto
            {
                Number = Number,
                Brand = Model,
                PTS = PTS,
                STS = STS,
                EntityState = _isAdd ? EntityState.Added : EntityState.Edited,
                CarrierId = Carrier?.Id ?? 0
            };
            if (!_isAdd)
            {
                newAuto.Ts = Auto.Ts;
                newAuto.Id = Auto.Id;
            }

            await _saveCarrierCommand.Execute(newAuto);
        }

        public override void Initialize()
        {
            Task.Run(async () =>
            {
                await _loadCarriersCommand.Execute(this, null);
                if (!_isAdd)
                    await _loadAutosCommand.Execute(this, null);
            });
        }

        public async void Delete()
        {
            var newAuto = new Model.Auto
            {
                EntityState = EntityState.Deleted,
                Ts = Auto.Ts,
                Id =  Auto.Id
            };
            

            await _saveCarrierCommand.Execute(newAuto);
        }
    }
}