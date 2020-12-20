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
        private readonly AutoViewModel _viewModel;

        public AutoView(bool isAdd)
        {
            _viewModel = new AutoViewModel(isAdd);


            InitializeComponent();
            comboBoxAuto.Enabled = button1.Enabled = !isAdd;
            _viewModel.Initialize();
            bindingSourceViewModel.DataSource = _viewModel;

            Extention.SetBindingList(comboBoxCarriers, _viewModel, "CarrierList", "Carrier");
            Extention.SetBindingList(comboBoxAuto, _viewModel, "Autos", "Auto", "FullName");

            while (!(_viewModel.CarrierList?.Any() ?? false) && (isAdd || !(_viewModel.Autos?.Any() ?? false)))
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
            if (!(sender is ComboBox cBox) || !(cBox.SelectedItem is Auto auto)) return;
            _viewModel.Auto = auto;
            _viewModel.STS = auto.STS;
            _viewModel.Number = auto.Number;
            _viewModel.PTS = auto.PTS;
            _viewModel.Carrier = _viewModel.CarrierList.FirstOrDefault(q => q.Id == auto.CarrierId);
            _viewModel.Model = auto.Brand;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _viewModel.Delete();
        }

        private void comboBoxCarriers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox cBox && cBox.SelectedItem is Carrier carrier)
                _viewModel.Carrier= carrier;
        }
    }
}