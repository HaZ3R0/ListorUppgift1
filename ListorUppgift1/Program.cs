using System;
using System.Collections.Generic;
namespace ListorUppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namnen = new List<string>();
            Console.WriteLine("Skriv in ett namn");
            string namn = Console.ReadLine();
            namnen.Add(namn);
            while(namn!= "")
            {
                Console.WriteLine("Skriv in ett namn till. Om du känner dig klar klicka bara enter");
                namn = Console.ReadLine();
                namnen.Add(namn);
            }

            Console.WriteLine("Här är namnen du skrev in");
            namnen.Reverse();

            foreach (string namn1 in namnen)
            {
                Console.WriteLine(namn1);
            }
        }
    }
}