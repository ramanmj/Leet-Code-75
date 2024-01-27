using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet75.Array_Strings
{
    public class CanPlaceFlowers
    {
        public bool CanPlaceFlower(int[] flowerbed, int n)
        {
            var count = 0;
            for (var i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0)
                {
                    if (flowerbed.Length == 1)
                    {
                        return true;
                    }
                    if (i == 0)
                    {
                        if (flowerbed[i + 1] == 0)
                            count++;
                        i++;
                    }
                    else if (i == flowerbed.Length - 1)
                    {
                        if (flowerbed[i - 1] == 0)
                            count++;
                        i++;
                    }
                    else if (flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
                    {
                        i++;
                        count++;
                    }
                }
            }
            return (n <= count);
        }
    }

}
