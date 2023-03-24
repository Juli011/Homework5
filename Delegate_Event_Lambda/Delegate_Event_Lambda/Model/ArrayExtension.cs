using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event_Lambda.Model
{
    internal static class ArrayExtension
    {
        public static double Root(this int number)
        {
              return Math.Sqrt(number);
        }
    }
}
