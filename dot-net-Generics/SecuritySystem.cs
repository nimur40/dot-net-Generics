using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot_net_Generics
{
    public class SecuritySystem<Tuser> where Tuser:Iuser
    {
        private Tuser _user;
        public void Open()
        {

        }
    }
}
