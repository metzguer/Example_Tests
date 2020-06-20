using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace libraryTests
{
    public class LevenDistance
    {
        public int Compute(string one, string two) {

            int n = one.Length;
            int m = two.Length;

            int[,] d = new int[n + 1, m + 1];

            //step one
            if (n == 0) {
                return m;
            }

            if (m == 0) {
                return n;
            }

            //step two
            for (int i = 0; i <= n; d[i,0] = i++){ 
                
            }

            for (int i = 0; i <= m; d[i, 0] = i++)
            {

            }
            // step three
            for (int i=1; i<=n;i++) {
                //step four
                for (int j = 1; j <= m; j++)
                {
                    //step five
                    int cost = (two[j - 1] == one[i - 1]) ? 0 : 1;
                    //step six
                    d[i, j] = Math.Min(
                            Math.Min(d[i-1, j]+1, d[i,j-1]+1),
                            d[i-1,j-1]+cost
                        ); 
                }
            }

            return d[n,m];
        }
    }
}
