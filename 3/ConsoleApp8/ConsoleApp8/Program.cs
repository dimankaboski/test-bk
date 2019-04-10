using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToUpper();
            Console.WriteLine(text);
            string[] words = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            var dict = new Dictionary<string, int>();
            var maxcount = 0;
            string maxword = "";
            foreach (string word in words)
            {
                if(dict.ContainsKey(word))
                {
                    if(++dict[word] > maxcount)
                    {
                        maxcount = dict[word];
                        maxword = word;
                    }
                }
                else
                {
                    dict.Add(word, 1);
                }
            }
            Console.WriteLine(maxword + '-' + maxcount);
        }
    }
}
