using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public DriverView()
        {
            _viewModel = new DriverViewModel();


            InitializeComponent();
            _viewModel.Initialize();
            bindingSourceViewModel.DataSource = _viewModel;
            comboBoxAutos.DataBindings.Add("DataSource", _viewModel, "Autos", true,
                DataSourceUpdateMode.OnPropertyChanged);
            comboBoxAutos.DisplayMember = "FullName";
            comboBoxAutos.ValueMember = "Id";
            comboBoxAutos.DataBindings.Add("SelectedItem", _viewModel, "Auto", true,
                DataSourceUpdateMode.OnPropertyChanged);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            _viewModel.Save();

        }
    }
}
