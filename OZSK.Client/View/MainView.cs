using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OZSK.Client.ViewModel.Auto.Command;

namespace OZSK.Client
{
    public partial class MainView : Form
    {
        private MainViewModel _viewModel;

        public MainView()
        {
            _viewModel = new MainViewModel();

            InitializeComponent();
            bindingSourceViewModel.DataSource = _viewModel;
            var command = new LoadCarriersCommand();
            command.Execute(null);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _viewModel.AddAuto();

        }

        private void MainView_Load(object sender, EventArgs e)
        {
            _viewModel.Initialize();
            Thread.Sleep(3000);
        }
    }
}
