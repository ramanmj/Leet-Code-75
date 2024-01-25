using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet75.Array_Strings
{
    public class MergeStringAlternately
    {
        public string MergeAlternately(string word1, string word2)
        {
            var longer = (word1.Length > word2.Length) ? word1 : word2;
            var merged = "";
            for (var i = 0; i < longer.Length; i++)
            {
                if (i < word1.Length)
                {
                    merged += word1[i];
                }
                if (i < word2.Length)
                {
                    merged += word2[i];
                }
            }
            return merged;
        }
    }

}

