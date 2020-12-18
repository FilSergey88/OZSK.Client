using System;
using System.Collections.Generic;
using System.Text;
using OZSK.Client.Model.Abstr;

namespace OZSK.Client.Model
{
    public class Driver : IHasEntityState
    {
        public int Id { get; set; }
        public int AutoId { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public EntityState EntityState { get; set; }
        public byte[] Ts { get; set; }
    }
}
