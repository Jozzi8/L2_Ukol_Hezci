//S double, aby šlo vložit desetinné číslo a interpolac string

using System;

namespace L2_Ukol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte první číslo:");
            string numOne = Console.ReadLine();
            double numOneDou = double.Parse(numOne);

            Console.WriteLine("Zadejte druhé číslo:");
            string numTwo = Console.ReadLine();
            double numTwoDou = double.Parse(numTwo);

            Console.WriteLine("Vlož matematickou operaci (+, -, *, /):");
            string oper = Console.ReadLine();

            double vysledek;

            if (oper == "+")
            {
                vysledek = numOneDou + numTwoDou;
            }

            else if (oper == "-")
            {
                vysledek = numOneDou - numTwoDou;
            }

            else if (oper == "*")
            {
                vysledek = numOneDou + numTwoDou;
            }

            else if (oper == "/")
            {
                if (numTwoDou == 0)
                {
                    Console.WriteLine("Nulou nelze dělit");
                }
                else
                {
                    vysledek = numOneDou / numTwoDou;
                }
            }
            else
            {
                Console.WriteLine("Povolené operace jsou pouze +, -, *, /");
            }

            Console.WriteLine("Výsledek: "+numOneDou+" "+oper+" "+numTwoDou+" = "+vysledek);
            //Console.WriteLine($"Výsledek: {numOneDou} {oper} {numTwoDou} = {vysledek}");
        }
    }
}