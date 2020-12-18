using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OZSK.Client.ServiceAgent
{
    public class BaseParams
    {
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static BaseParams Empty { get; } = new BaseParams();
    }
}
