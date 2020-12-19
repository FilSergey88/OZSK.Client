using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OZSK.Client.Model;
using OZSK.Client.Model.Abstr;
using OZSK.Client.ViewModel.Auto.Command;
using OZSK.Client.ViewModel.Main;

namespace OZSK.Client
{
    public partial class MainView : Form
    {
        private MainViewModel _viewModel;

        public MainView()
        {
            _viewModel = new MainViewModel();

            InitializeComponent();

            _viewModel.Initialize();

            bindingSourceViewModel.DataSource = _viewModel;
            ComboBoxCipherList.DataBindings.Add("DataSource", _viewModel, "Cipherlists", true,
                DataSourceUpdateMode.OnPropertyChanged);
            ComboBoxCipherList.DisplayMember = "Name";
            ComboBoxCipherList.ValueMember = "Id";
            ComboBoxCipherList.DataBindings.Add("SelectedItem", _viewModel, "Cipher", true,
                DataSourceUpdateMode.OnPropertyChanged);

            comboBoxNameShipping.DataBindings.Add("DataSource", _viewModel, nameof(_viewModel.ShippingNames), true,
                DataSourceUpdateMode.OnPropertyChanged);
            comboBoxNameShipping.DisplayMember = "Name";
            comboBoxNameShipping.ValueMember = "Id";
            comboBoxNameShipping.DataBindings.Add("SelectedItem", _viewModel, nameof(_viewModel.ShippingName), true,
                DataSourceUpdateMode.OnPropertyChanged);

            comboBoxCarriers.DataBindings.Add("DataSource", _viewModel, "CarrierList", true,
                DataSourceUpdateMode.OnPropertyChanged);
            comboBoxCarriers.DisplayMember = "Name";
            comboBoxCarriers.ValueMember = "Id";
            comboBoxCarriers.DataBindings.Add("SelectedItem", _viewModel, "Carrier", true,
                DataSourceUpdateMode.OnPropertyChanged);

            comboBoxAutos.DataBindings.Add("DataSource", _viewModel, "Autos", true,
                DataSourceUpdateMode.OnPropertyChanged);
            comboBoxAutos.DisplayMember = "FullName";
            comboBoxAutos.ValueMember = "Id";
            comboBoxAutos.DataBindings.Add("SelectedItem", _viewModel, "Auto", true,
                DataSourceUpdateMode.OnPropertyChanged);

            comboBoxDrivers.DataBindings.Add("DataSource", _viewModel, "Drivers", true,
                DataSourceUpdateMode.OnPropertyChanged);
            comboBoxDrivers.DisplayMember = "Name";
            comboBoxDrivers.ValueMember = "Id";
            comboBoxDrivers.DataBindings.Add("SelectedItem", _viewModel, "Driver", true,
                DataSourceUpdateMode.OnPropertyChanged);

            while (!(_viewModel.ShippingNames?.Any() ?? false) && 
                   !(_viewModel.Cipherlists?.Any() ?? false) &&
                   !(_viewModel.CarrierList?.Any() ?? false))
            {
                this.Refresh();
            }
        }

        
        

        private bool isChanged = true;

        private void ComboBoxCipherList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (isChanged)
                if (sender is ComboBox cBox && cBox.SelectedItem is Cipherlist cipher)
                {
                    isChanged = false;
                    _viewModel.OnPropertyChangedCipher(cipher);
                    cBox.SelectedItem = cipher;
                    isChanged = true;
                }
        }

        private void comboBoxCarriers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxCarriers.SelectedItem is  Carrier carrier)
            {
                _viewModel.Carrier = carrier;
                _viewModel.LoadAuto();

            }
        }

        private void comboBoxAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAutos.SelectedItem is Auto auto)
            {
                _viewModel.Auto = auto;
                _viewModel.LoadDriver();
            }
        }
    }
}