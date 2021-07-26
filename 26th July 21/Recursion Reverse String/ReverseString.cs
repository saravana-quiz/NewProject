using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_String_Reversal
{
    class ReverseString
    {
        public void StringReversal(string sentance)
        {
            if (sentance.Length > 0)
            
                StringReversal(sentance.Substring(1, sentance.Length - 1));
          
            else
                return;
          
            Console.Write(sentance[0]);

        }
    }
}
