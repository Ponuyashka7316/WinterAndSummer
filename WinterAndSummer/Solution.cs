using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterAndSummer
{
    class Solution
    {
        public int WinterAndSummer(int[] T)
        {
            for (int i = 1; i < T.Length - 1; ++i)
            {
                bool flag = true;
                var subArray1 = T.SubArray(0, i);
                var subArray2 = T.SubArray(i, T.Length - i);
                if (subArray1.Length == 0 || subArray2.Length == 0)
                    flag = false;
                for (int j = 0; j < subArray1.Length; j++)
                {
                    for (int k = 0; k < subArray2.Length; k++)
                    {
                        if (subArray1[j] > subArray2[k])
                            flag = false;
                    }
                }
                if (flag)
                    return i;
            }
            return T.Length;
        }
    }

}
