using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace extampleTest.test
{
    
    public class StringCalculator
    {

        public object Add(string value)
        {
            if (value.Length == 0) return 0;
            if (value.Length == 1) return Int32.Parse(value);
            if (value.Length == 3) {
                var arr = value.Split(',');
                return int.Parse(arr[0]) + int.Parse(arr[1]); 
            }
            return value;
        }
         
    }
    
}
