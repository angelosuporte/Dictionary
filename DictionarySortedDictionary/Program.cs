using System;
using System.Collections.Generic;

namespace DictionarySortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99712234";

            cookies.Remove("phone");
      
            Console.WriteLine("Usuário: " + cookies["user"]);
            Console.WriteLine("Email:   " + cookies["email"]);
            if (cookies.ContainsKey("phone"))
            {
                Console.WriteLine("Phone:   " + cookies["phone"]);
            }
            else
            {
                Console.WriteLine("A chave 'phone' não existe");
            }

            Console.WriteLine("Size: " + cookies.Count);
 

            Console.WriteLine("Imprimir todos os cookies: ");
            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + item.Value);
            }
            Console.ReadKey();
        }
    }
}
