using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace poiskslov
{
    class Program
    {
        static void Main()
        {
            string path = @"B:/ViMir.txt";
            string line;
           
            StreamReader sr = new StreamReader(path, Encoding.GetEncoding(1251));
            while ((line = sr.ReadLine()) != null)
            {

                string[] str = line.Split(new char[] { ' ', ',', '.', '-', '!', '?', '"', '[', ']', ';' , ':'}, StringSplitOptions.RemoveEmptyEntries) ;
               
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i].Length < 2)
                        continue;
                }

                /*    int repeat = 0;
                    for (int j = i; j < str.Length; j++)
                    {
                        if (str[i] == str[j])
                            repeat++;
                    }
                    Console.WriteLine(str[i]+repeat);
                }
                Console.WriteLine(str + repeat);
                */

                //Console.WriteLine("Новая строка");

                var dict = new Dictionary<string, int>();

                foreach (var value in str)
                {
                    if (dict.ContainsKey(value))
                        dict[value]++;
                    else
                        dict[value] = 1;
                }
                foreach(var pair in dict)
                    Console.WriteLine("Слово {0} встречается {1} раз(а)", pair.Key, pair.Value);

            }
       
            Console.ReadLine();
        }
    }
}
