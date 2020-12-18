using System;
using System.Collections.Generic;
using System.Text;

namespace OZSK.Client.Model
{
    public class Consignee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public byte[] Ts { get; set; }
    }
}
