using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    [DataContract]
    public class HoSoKCB
    {
        [DataMember]
        public object xml1 { get; set; }
        [DataMember]
        public List<XML2> dsXml2 { get; set; }
        [DataMember]
        public List<XML3> dsXml3 { get; set; }
        [DataMember]
        public object dsXml4 { get; set; }
        [DataMember]
        public object dsXml5 { get; set; }
    }
}
