using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_15.DictionaryAndSortedDictionary
{
    internal class DictionaryMain
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["User"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "998124241";
            cookies["phone"] = "53626246";

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");
            
            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no email key");
            }

            Console.WriteLine("Size: " + cookies.Count());

            Console.WriteLine("All Cookies:");
            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ", " + item.Value);
            }
        }
    }
}
