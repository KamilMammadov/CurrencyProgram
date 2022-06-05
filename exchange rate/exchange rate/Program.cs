using System;
using System.Linq;

namespace exchange_rate
{
    class Program
    {
        static void Main(string[] args)
        {
            string exit = "/exit";
            int error = 0;
            string[] currency = { "usd", "euro", "tl","funt","rubl" };
            double[] currencyRate = { 0.59, 0.55, 9.66, 0.47, 37.27 };


            while (true)
            {
                Console.WriteLine("########################################");
                for (int i = 0; i < currency.Length; i++)
                {
                    Console.WriteLine($" 1 Azn = {currencyRate[i]} {currency[i]} ");
                }
                Console.WriteLine("programi dayandirmaq ucun /exit ");
                
                Console.Write("Zehmet olmasa istediyiniz kursu yuxarida yazildigi kimi (usd,euro...) daxil edin : ");
                string requiredRate = Console.ReadLine();

                if (requiredRate == exit)
                {
                    Console.WriteLine("Bizi secdiyiniz ucun tesekkurler");
                    break;
                }

               
                Console.Write("Zehmet olmasa qiymeti daxil edin : ");
                double amount = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("");

                for (int i = 0; i < currency.Length; i++)
                {
                    if(requiredRate != currency[i]) //bura melumat sehv daxil edilmeyi ucun yazilib
                        {
                        error++;
                        }
                   else  if (requiredRate == currency[i])
                    {
                        Console.WriteLine($"mezennenin kodu : {requiredRate}");
                        Console.WriteLine($"{amount} Azn = {amount * currencyRate[i]} {requiredRate}");
                    } 

                }

                if (error==currency.Length)
                {
                    Console.WriteLine("Melumati duzgun daxil edin!");
                }
                
                Console.WriteLine("");
                Console.WriteLine("########################################"); 
            }


        }
    }
}
