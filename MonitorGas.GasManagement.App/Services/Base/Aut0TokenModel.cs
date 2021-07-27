using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.App.Services.Base
{

    public class Profile
    {
        public string given_name { get; set; }
        public string family_name { get; set; }
        public string nickname { get; set; }
        public string name { get; set; }
        public string picture { get; set; }
        public string locale { get; set; }
        public DateTime updated_at { get; set; }
        public string sub { get; set; }
    }

    public class Aut0TokenModel
    {
        public string id_token { get; set; }
        public string access_token { get; set; }
        public string token_type { get; set; }
        public string scope { get; set; }
        public Profile profile { get; set; }
        public int expires_at { get; set; }
    }


}
