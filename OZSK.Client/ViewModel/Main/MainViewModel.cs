using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using OZSK.Client.Annotations;
using OZSK.Client.ViewModel;
using OZSK.Client.ViewModel.Auto.Command;

namespace OZSK.Client
{
    public class MainViewModel : BaseViewModel
    {

        public override void Initialize()
        {
        }
        public void AddAuto()
        {
            using var form = new AutoView();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                
            }
        }

        public void AddDriver()
        {
            using var form = new DriverView();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {

            }
        }

        public void AddCarrier()
        {
            using var form = new CarrierView();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {

            }
        }
    }
}
