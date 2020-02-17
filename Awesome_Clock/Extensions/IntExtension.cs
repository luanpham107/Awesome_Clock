using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Awesome_Clock.Extensions
{
    public static class IntExtension
    {
        public static int ToHourInt(this int hour)
        {
            var h = hour;
            if (h > 12)
            {
                h -= 12;
            }
            return h;
        }
    }
}
