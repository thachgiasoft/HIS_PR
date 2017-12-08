using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    [DataContract]
    public class ApiKey
    {
        [DataMember]
        public string access_token { get; set; }
        [DataMember]
        public string id_token
        {
            get;
            set;
        }

        [DataMember]
        public string token_type
        {
            get;
            set;
        }

        [DataMember]
        public string username
        {
            get;
            set;
        }

        [DataMember]
        public System.DateTime expires_in
        {
            get;
            set;
        }
    }


}
