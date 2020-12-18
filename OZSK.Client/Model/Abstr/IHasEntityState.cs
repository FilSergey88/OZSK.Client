using System;
using System.Collections.Generic;
using System.Text;

namespace OZSK.Client.Model.Abstr
{
    public interface IHasEntityState
    {
        EntityState EntityState { get; set; }
    }

    public enum EntityState
    {
        None,
        Edited,
        Deleted,
        Added
    }
}
