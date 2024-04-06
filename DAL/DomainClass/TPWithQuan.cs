using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DomainClass
{
    public class TPWithQuan
    {
        public int Stt { get; set; }
        public Guid? Guidid { get; set; }
        public string Matp { get; set; } = null!;
        public string Tentp { get; set; } = null!;
        public string Maquan { get; set; } = null!;
        public string Tenquan { get; set; } = null!;
    }
}
