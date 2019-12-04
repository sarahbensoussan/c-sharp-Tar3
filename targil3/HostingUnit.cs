using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil3
{
    public class HostingUnit
    {
        public string UnitName;
        public int Rooms;
        public bool IsSwimmingPool;
        public List<DateTime> AllOrders { get; set; }
        public List<string> Uris { get; set; }

    }
}
