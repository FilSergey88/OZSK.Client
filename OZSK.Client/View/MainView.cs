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
            dateTimePickerDate.Value = DateTime.Now.Date;
            bindingSourceViewModel.DataSource = _viewModel;

            Extention.SetBindingList(comboBoxDrivers, _viewModel, "Drivers", "Driver");
            Extention.SetBindingList(comboBoxAutos, _viewModel, "Autos", "Auto", "FullName");
            Extention.SetBindingList(comboBoxCarriers, _viewModel, "CarrierList", "Carrier");
            Extention.SetBindingList(ComboBoxCipherList, _viewModel, "Cipherlists", "Cipher");
            Extention.SetBindingList(comboBoxNameShipping, _viewModel, nameof(_viewModel.ShippingNames), nameof(_viewModel.ShippingName));

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
                    _viewModel.Consignee = cipher.Consignee;
                    _viewModel.Cipher = cipher;
                    cBox.SelectedItem = cipher;
                    isChanged = true;
                }
        }

        private void comboBoxCarriers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(comboBoxCarriers.SelectedItem is Carrier carrier)) return;
            _viewModel.Carrier = carrier;
            _viewModel.LoadAuto();
        }

        private void comboBoxAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(comboBoxAutos.SelectedItem is Auto auto)) return;
            _viewModel.Auto = auto;
            _viewModel.LoadDriver();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = !_viewModel.LoadInTN();
        }

        private void comboBoxDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDrivers.SelectedItem is Driver driver)
            {
                _viewModel.Driver= driver;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = !_viewModel.LoadInOV();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainView_FormClosed(object sender, FormClosedEventArgs e)
        {
            _viewModel.SaveNumbers();
        }

        private void comboBoxNameShipping_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox cBox && cBox.SelectedItem is ShippingName shippingName)
            {
                _viewModel.ShippingName = shippingName;
            }
        }
    }
}