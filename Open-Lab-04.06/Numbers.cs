using System;
using System.Collections.Generic;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            List<int> a = new List<int>();
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        a.Add(numbers[i]) ;
                    }
                }
                return a.ToArray();
                
            }
           
        }
    }
}
