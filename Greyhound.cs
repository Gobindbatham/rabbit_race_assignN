using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rabbit_race_assign
{
   public class Greyhound
    {
        int limit = 750;
        public int setLimit() {
            return limit;
        }

        public int genNo() {
            Random rd = new Random();
            return rd.Next(1,50);
        }

    }
}
