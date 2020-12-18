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
            var bSource = new BindingSource { DataSource = _viewModel.Autos };
            comboBoxAutos.DataSource = bSource;
            comboBoxAutos.DisplayMember = "FullName";
            comboBoxAutos.ValueMember = "Id";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            _viewModel.Save((Auto)comboBoxAutos.SelectedItem);

        }
    }
}
