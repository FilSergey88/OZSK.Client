using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OZSK.Client.Annotations;
using OZSK.Client.Model;
using OZSK.Client.ViewModel.Auto;

namespace OZSK.Client
{
    public partial class AutoView : Form
    {
        private AutoViewModel _viewModel;

        public AutoView()
        {
            _viewModel = new AutoViewModel();


            InitializeComponent();
            _viewModel.Initialize();
            bindingSourceViewModel.DataSource = _viewModel;
            comboBoxCarriers.DataBindings.Add("DataSource", _viewModel, "CarrierList", true,
                DataSourceUpdateMode.OnPropertyChanged);
            comboBoxCarriers.DisplayMember = "Name";
            comboBoxCarriers.ValueMember = "Id";
            comboBoxCarriers.DataBindings.Add("SelectedItem", _viewModel, "Carrier", true,
                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _viewModel.Save();
        }
    }
}