using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class KQPhienLamViec
    {
        public KQPhienLamViec()
        {
            maKetQua = null;
            APIKey = new ApiKey();
        }
        public string maKetQua { get; set; }
        public ApiKey APIKey { get; set; }
    }
}
