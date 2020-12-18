using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using OZSK.Client.Annotations;

namespace OZSK.Client.ViewModel
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public abstract void Initialize();

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        public void SetProperty<T>(ref T storage, T value)
        {
            storage = value;
            OnPropertyChanged(nameof(storage));
        }
    }
}
