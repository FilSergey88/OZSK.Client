using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OZSK.Client.Model.Abstr
{
    public interface IHasAutos
    {
        ObservableCollection<Model.Auto> Autos { get; set; }
    }
}
