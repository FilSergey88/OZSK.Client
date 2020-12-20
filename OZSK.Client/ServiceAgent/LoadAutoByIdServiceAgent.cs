using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using OZSK.Client.Model;
using OZSK.Client.Model.Abstr;

namespace OZSK.Client.ServiceAgent
{
    public class LoadAutoByIdServiceAgent : BaseGetServiceAgent<int, ICollection<Auto>>

    {
        public LoadAutoByIdServiceAgent(string path) : base(path)
        {
        }

        protected override string BuildUrl(string baseUrl, int param)
        {
            return baseUrl + "/" + param;
        }

        protected override NameValueCollection BuildUrlParams(int param)
        {
            return HttpUtility.ParseQueryString(string.Empty);
        }
    }
}