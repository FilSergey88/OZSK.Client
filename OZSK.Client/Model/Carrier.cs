using System;
using System.Collections.Generic;
using System.Text;
using OZSK.Client.Model.Abstr;

namespace OZSK.Client.Model
{
    public class Carrier : IHasEntityState
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string SEO { get; set; }
        public string INN { get; set; }
        public string Address { get; set; }
        public IEnumerable<Auto> Autos { get; set; }
        public EntityState EntityState { get; set; }
        public byte[] Ts { get; set; }
    }
}
