using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OZSK.Client.ViewModel;

namespace OZSK.Client.Model.Abstr
{
    public static class Extention
    {
        public static void SetBindingList(ComboBox comboBox, BaseViewModel viewModel, string listName, string selectedName, string displayMember = "Name")
        {
            comboBox.DataBindings.Add("DataSource", viewModel, listName, true,
                DataSourceUpdateMode.OnPropertyChanged);
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = "Id";
            comboBox.DataBindings.Add("SelectedItem", viewModel, selectedName, true,
                DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
