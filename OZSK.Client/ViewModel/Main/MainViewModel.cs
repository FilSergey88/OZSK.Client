using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using OZSK.Client.Annotations;
using OZSK.Client.ViewModel.Auto.Command;

namespace OZSK.Client
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private LoadCarriersCommand _loadCarriersCommand;

        public void Initialize()
        {
            _loadCarriersCommand = new LoadCarriersCommand();
            _loadCarriersCommand.Execute(null);
        }
        public void AddAuto()
        {
            using var form = new AutoView();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
