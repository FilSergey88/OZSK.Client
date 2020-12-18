using System;
using System.Collections.Generic;
using System.Text;

namespace OZSK.Client.Model.Abstr
{
    public class Auto : IHasEntityState
    {
        public int Id { get; set; }
        public int CarrierId { get; set; }
        public string Brand { get; set; }
        public string Number { get; set; }
        public string PTS { get; set; }
        public string STS { get; set; }
        public IEnumerable<Driver> Drivers { get; set; }
        public EntityState EntityState { get; set; }
        public byte[] Ts { get; set; }

        public string FullName => $"{Brand} {Number}";
    }
}

