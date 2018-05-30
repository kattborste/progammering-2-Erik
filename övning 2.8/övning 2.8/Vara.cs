using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._8
{
    class Vara
    {
        protected string namn;

        public Vara(string namn)
        {
            this.namn = namn;
        }

        public string Namn()
        {
            return namn;
        }
        public virtual double beräknaPris()
        {
            return 0;
        }
    }
}
