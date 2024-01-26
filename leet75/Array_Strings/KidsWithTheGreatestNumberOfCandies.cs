using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet75.Array_Strings
{
    public class KidsWithTheGreatestNumberOfCandies
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            List<bool> total = new List<bool>();
            int maxCandies = candies.Max();

            foreach (var candie in candies)
            {
                total.Add((candie + extraCandies) >= maxCandies);
            }
            return total;
        }
    }

}
