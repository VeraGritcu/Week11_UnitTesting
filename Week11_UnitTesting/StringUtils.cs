using System;
using System.Collections.Generic;

namespace Week11_UnitTesting
{
    public class StringUtils
    {
        public static string ReverseString(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException("Oups, your string is either empty or null");
            }
            char[] array = str.ToCharArray();
            int r = array.Length - 1, l = 0;

            while (l < r)
            {
                if (!char.IsLetter(array[l]))
                    l++;
                else if (!char.IsLetter(str[r]))
                    r--;

                else
                {
                    char tmp = array[l];
                    array[l] = array[r];
                    array[r] = tmp;
                    l++;
                    r--;
                }
            }
            string reversed = null;
            foreach (var item in array)
            {
                reversed += item.ToString();
            }

            return reversed;
        }
    }
}
