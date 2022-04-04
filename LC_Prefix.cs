using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Practice
{
    public class LC_Prefix
    {
       public static string LongestCommonPrefix(string[] st)
        {
            if(st == null || st.Length<=0)
            {
                return "";
            }
            var res=st[0];
            int j = st.Length;

            foreach (string s in st)
            {
                int i = 0;
                while (i < j && i < st.Length && res[i] == s[i])
                {
                    i++;
                }
                j = Math.Min(i, j);
            }
            return res.Substring(0, j);
        }
    }
}
