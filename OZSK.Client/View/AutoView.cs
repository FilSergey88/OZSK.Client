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
    public partial class AutoView : Form, INotifyPropertyChanged
    {
        private AutoViewModel _viewModel;
        public AutoView()
        {
            _viewModel = new AutoViewModel();

            
            InitializeComponent();
            _viewModel.Initialize();
            bindingSourceViewModel.DataSource = _viewModel;
            var bSource = new BindingSource {DataSource = _viewModel.CarrierList};
            comboBoxCarriers.DataSource = bSource;
            comboBoxCarriers.DisplayMember = "Name";
            comboBoxCarriers.ValueMember = "Id";
            comboBoxCarriers.SelectedItem = nameof(_viewModel.SelectedCarrier);

        }



        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            _viewModel.Save((Carrier)comboBoxCarriers.SelectedItem);
        }
    }
}
