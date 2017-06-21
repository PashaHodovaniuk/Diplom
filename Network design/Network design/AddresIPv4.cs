using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_design
{
    class AddresIPv4
    {
        int act1;
        int act2;
        int act3;
        int act4;
        public AddresIPv4(int act1, int act2, int act3, int act4)
        {
            this.act1 = act1;
            this.act2 = act2;
            this.act3 = act3;
            this.act4 = act4;
        }

        public void edit(int act1, int act2, int act3, int act4)
        {
            this.act1 = act1;
            this.act2 = act2;
            this.act3 = act3;
            this.act4 = act4;
        }
        public string toString()
        {
            return "";
        }
    }
}
