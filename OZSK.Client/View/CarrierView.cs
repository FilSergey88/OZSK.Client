using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OZSK.Client.ViewModel.Carrier;

namespace OZSK.Client
{
    public partial class CarrierView : Form
    {
        private readonly CarrierViewModel _viewModel;
        public CarrierView()
        {
            _viewModel = new CarrierViewModel();
            InitializeComponent();
            bindingSourceViewModel.DataSource = _viewModel;

        }

        private void Save_Click(object sender, EventArgs e)
        {
            _viewModel.Save();
        }
    }
}
