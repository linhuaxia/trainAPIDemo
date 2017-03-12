using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YC.APIClient
{
    public class BaseAPIClient
    {
        public BaseAPIClient()
        {
            APIAccessToken = string.Empty;
        }

        public string APIAccessToken { get; set; }
    }
}
