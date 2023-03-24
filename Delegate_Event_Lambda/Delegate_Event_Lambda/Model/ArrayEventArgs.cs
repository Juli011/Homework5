using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event_Lambda.Model
{
    internal class ArrayEventArgs
    {
        public int Number { get; set; }
       
        public ArrayEventArgs(int number)
        {
            this.Number = number;    
        }


    }
}
