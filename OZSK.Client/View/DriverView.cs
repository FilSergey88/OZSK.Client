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
        public DriverView(bool isAdd)
        {
            _viewModel = new DriverViewModel(isAdd);
            InitializeComponent();
            comboBoxDrivers.Enabled = !isAdd;
            _viewModel.Initialize();
            bindingSourceViewModel.DataSource = _viewModel;

            Extention.SetBindingList(comboBoxDrivers, _viewModel, "Drivers", "Driver");
            Extention.SetBindingList(comboBoxAutos, _viewModel, "Autos", "Auto", "FullName");

            while (!(_viewModel.Autos?.Any() ?? false) && (isAdd || !(_viewModel.Drivers?.Any() ?? false)))
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
            if (!(sender is ComboBox cBox) || !(cBox.SelectedItem is Driver driver)) return;
            _viewModel.Driver = driver;
            _viewModel.Fio= driver.Name;
            _viewModel.Number = driver.Number;
            _viewModel.Auto= _viewModel.Autos.FirstOrDefault(q => q.Id == driver.AutoId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _viewModel.Delete();
        }

        private void comboBoxAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(sender is ComboBox cBox) || !(cBox.SelectedItem is Auto auto)) return;
            _viewModel.Auto = auto;
        }
    }
}
