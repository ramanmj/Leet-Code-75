using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet75.Array_Strings
{
    public class ReverseVowelOfAString
    {
        public string ReverseVowels(string s)
        {
            char[] st = s.ToCharArray();
            List<char> vowels = new List<char>();
            char[] check = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int index = 0;
            foreach (var alfa in st)
            {
                if (check.Contains(alfa))
                {
                    vowels.Add(alfa);
                }
            }
            char[] arrVowels = vowels.ToArray();
            Array.Reverse(arrVowels);
            vowels.ToArray();
            for (var i = 0; i < s.Length; i++)
            {
                if (check.Contains(st[i]))
                {
                    st[i] = arrVowels[index];
                    index++;
                }
            }
            string result = new string(st);
            return result;
        }
    }
}
