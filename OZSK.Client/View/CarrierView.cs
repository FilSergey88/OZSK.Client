using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OZSK.Client.Model;
using OZSK.Client.ViewModel.Carrier;

namespace OZSK.Client
{
    public partial class CarrierView : Form
    {
        private readonly CarrierViewModel _viewModel;
        public CarrierView(bool isAdd)
        {
            _viewModel = new CarrierViewModel(isAdd);

            InitializeComponent();
            comboBoxCarriers.Enabled = !isAdd;
            _viewModel.Initialize();
            bindingSourceViewModel.DataSource = _viewModel;


            comboBoxCarriers.DataBindings.Add("DataSource", _viewModel, "CarrierList", true,
                DataSourceUpdateMode.OnPropertyChanged);
            comboBoxCarriers.DisplayMember = "Name";
            comboBoxCarriers.ValueMember = "Id";
            comboBoxCarriers.DataBindings.Add("SelectedItem", _viewModel, "Carrier", true,
                DataSourceUpdateMode.OnPropertyChanged);
            if (!isAdd)
            {
                while (!(_viewModel.CarrierList?.Any() ?? false))
                {
                    this.Refresh();
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            _viewModel.Save();
        }

        private void comboBoxCarriers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox cBox && cBox.SelectedItem is Carrier carrier)
            {
                _viewModel.Carrier = carrier;
                _viewModel.Name = carrier.Name;
                _viewModel.Address = carrier.Address;
                _viewModel.Inn = carrier.INN;
                _viewModel.Phone= carrier.Contact;
                _viewModel.Seo = carrier.SEO;
            }
        }
    }
}
