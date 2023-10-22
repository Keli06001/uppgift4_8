using System;

namespace uppgift4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in en string");
            string stri= Console.ReadLine();
            Console.WriteLine("Skriv in en string med exakt två tecken");
            string Kort= Console.ReadLine();

            string hittade = "";

            for (int i = 0; i < Kort.Length; i++)
            {
                char hitta = Kort[i];

                for (int j = 0; j < stri.Length; j++)
                {
                    char leta = stri[j];
                    if (hitta == leta)
                    {
                        hittade = hittade + hitta;
                        break;
                    }
                }
            }
            if (hittade == Kort)
            {
                Console.WriteLine("Bokstäverna finns");
            }
            else
            {
                Console.WriteLine("Bokstäverna finns inte");
            }
            Console.ReadKey();
        }
    }
}