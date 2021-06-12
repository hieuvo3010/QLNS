using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS
{
    class Common
    {
        private static QLNSContext _Instance = new QLNSContext();

        public static QLNSContext Instance { get => _Instance; set => _Instance = value; }
    }
}
