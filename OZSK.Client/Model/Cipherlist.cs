using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OZSK.Client.Model
{
    public class Cipherlist
    {
        public int Id { get; set; }
        public int ConsigneeId { get; set; }
        public string Name { get; set; }
        public byte[] Ts { get; set; }
        public Consignee Consignee { get; set; }

    }
}
