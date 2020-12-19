using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OZSK.Client.Model;
using OZSK.Client.Model.Abstr;
using OZSK.Client.ViewModel.Driver;

namespace OZSK.Client
{
    public partial class DriverView : Form
    {
        private readonly DriverViewModel _viewModel;
        public DriverView(bool IsAdd)
        {
            _viewModel = new DriverViewModel(IsAdd);
            InitializeComponent();


            comboBoxDrivers.Enabled = !IsAdd;
            comboBoxDrivers.DataBindings.Add("DataSource", _viewModel, "Drivers", true,
                DataSourceUpdateMode.OnPropertyChanged);
            comboBoxDrivers.DisplayMember = "Name";
            comboBoxDrivers.ValueMember = "Id";
            comboBoxDrivers.DataBindings.Add("SelectedItem", _viewModel, "Driver", true,
                DataSourceUpdateMode.OnPropertyChanged);
            _viewModel.Initialize();
            bindingSourceViewModel.DataSource = _viewModel;
            comboBoxAutos.DataBindings.Add("DataSource", _viewModel, "Autos", true,
                DataSourceUpdateMode.OnPropertyChanged);
            comboBoxAutos.DisplayMember = "FullName";
            comboBoxAutos.ValueMember = "Id";
            comboBoxAutos.DataBindings.Add("SelectedItem", _viewModel, "Auto", true,
                DataSourceUpdateMode.OnPropertyChanged);
            while (!(_viewModel.Autos?.Any() ?? false) && (IsAdd || !(_viewModel.Drivers?.Any() ?? false)))
            {
                this.Refresh();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            _viewModel.Save();

        }

        private void comboBoxDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox cBox && cBox.SelectedItem is Driver driver)
            {
                _viewModel.Driver = driver;
                _viewModel.FIO= driver.Name;
                _viewModel.Number = driver.Number;
                _viewModel.Auto= _viewModel.Autos.FirstOrDefault(q => q.Id == driver.AutoId);

            }
        }
    }
}
