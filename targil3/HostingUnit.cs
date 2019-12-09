using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil3
{
    public class HostingUnit
    {

        public List<DateTime> AllOrders { get; set; }
        public List<string> Uris { get; set; }
        public string UnitName { get; set; }
        public int Rooms { get; set; }
        public bool IsSwimmingPool { get; set; }
    }
}