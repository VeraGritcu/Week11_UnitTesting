using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoatLatin
{
    public class Class1
    {
        public static string ConvertToGoatLatin(string input)
        {
            string[] arr = input.Split(' ');
            string result = null;
            string voc = "aeiou";
            string ending = "ma";
            for (int i = 0; i < arr.Length; i++)
            {
                ending += "a";
                var word = arr[i];

                if (voc.Contains(word[0]))
                {
                    result += word + ending + " ";
                }
                else
                {
                    var temp = word[0];
                    word = word.Substring(1, word.Length - 1) + temp; 
                    result += word + ending + " ";
                }
            }

            return result.Substring(0, result.Length-1);

        }
    }
}
