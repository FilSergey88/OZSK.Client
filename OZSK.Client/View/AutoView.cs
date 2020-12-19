using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OZSK.Client.Annotations;
using OZSK.Client.Model;
using OZSK.Client.Model.Abstr;
using OZSK.Client.ViewModel.Auto;

namespace OZSK.Client
{
    public partial class AutoView : Form
    {
        private AutoViewModel _viewModel;

        public AutoView(bool IsAdd)
        {
            _viewModel = new AutoViewModel(IsAdd);


            InitializeComponent();
            comboBoxAuto.Enabled = !IsAdd;
            button1.Enabled = !IsAdd;
            _viewModel.Initialize();
            bindingSourceViewModel.DataSource = _viewModel;
            comboBoxCarriers.DataBindings.Add("DataSource", _viewModel, "CarrierList", true,
                DataSourceUpdateMode.OnPropertyChanged);
            comboBoxCarriers.DisplayMember = "Name";
            comboBoxCarriers.ValueMember = "Id";
            comboBoxCarriers.DataBindings.Add("SelectedItem", _viewModel, "Carrier", true,
                DataSourceUpdateMode.OnPropertyChanged);

            comboBoxAuto.DataBindings.Add("DataSource", _viewModel, "Autos", true,
                DataSourceUpdateMode.OnPropertyChanged);
            comboBoxAuto.DisplayMember = "FullName";
            comboBoxAuto.ValueMember = "Id";
            comboBoxAuto.DataBindings.Add("SelectedItem", _viewModel, "Auto", true,
                DataSourceUpdateMode.OnPropertyChanged);
            while (!(_viewModel.CarrierList?.Any() ?? false) && (IsAdd || !(_viewModel.Autos?.Any() ?? false)))
            {
                this.Refresh();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _viewModel.Save();
        }

        private void comboBoxAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox cBox && cBox.SelectedItem is Auto auto)
            {
                _viewModel.Auto = auto;
                _viewModel.STS = auto.STS;
                _viewModel.Number = auto.Number;
                _viewModel.PTS = auto.PTS;
                _viewModel.Carrier = _viewModel.CarrierList.FirstOrDefault(q => q.Id == auto.CarrierId);
                _viewModel.Model = auto.Brand;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _viewModel.Delete();
        }
    }
}