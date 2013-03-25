using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mr_Exercise1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int intUitkomst = 0;

            Console.WriteLine("Welkom bij versie v0.3" + Environment.NewLine);
            Console.WriteLine("Kies uit de volgende berekening:" + Environment.NewLine
                    + "1. Optellen" + Environment.NewLine
                    + "2. Aftrekken" + Environment.NewLine
                    + "3. Delen" + Environment.NewLine
                    + "4. Vermenigvuldigen");

            string strBewerking = Console.ReadLine().ToLower();

            Console.WriteLine("Voer een getal in:");
            string strInput1 = Console.ReadLine();
            int intNumber1 = int.Parse(strInput1);

            Console.WriteLine("Voer een getal in:");
            string strInput2 = Console.ReadLine();
            int intNumber2 = int.Parse(strInput2);

            if (strBewerking == "optellen" || strBewerking == "+" || strBewerking == "1")
            {
                intUitkomst = intNumber1 + intNumber2;
            }
            else
            {
                if (strBewerking == "aftrekken" || strBewerking == "-" || strBewerking == "2")
                {
                    intUitkomst = intNumber1 - intNumber2;
                }
                else
                {
                    if (strBewerking == "delen" || strBewerking == "/" || strBewerking == "3")
                    {
                        intUitkomst = intNumber1 / intNumber2;
                    }
                    else
                    {
                        if (strBewerking == "vermenigvuldig" || strBewerking == "*" || strBewerking == "4")
                        {
                            intUitkomst = intNumber1 * intNumber2;
                        }
                        else
                        {
                            Console.WriteLine("ERROR");
                        }
                    }
                }
            }

            Console.WriteLine("Voer nog een getal in:");
            strInput2 = Console.ReadLine();
            intNumber2 = int.Parse(strInput2);


            while (intNumber2 != 0)
            {
                if (strBewerking == "optellen" || strBewerking == "+" || strBewerking == "1")
                {
                    intUitkomst = intUitkomst + intNumber2;
                }
                else
                {
                    if (strBewerking == "aftrekken" || strBewerking == "-" || strBewerking == "2")
                    {
                        intUitkomst = intUitkomst - intNumber2;
                    }
                    else
                    {
                        if (strBewerking == "delen" || strBewerking == "/" || strBewerking == "3")
                        {
                            intUitkomst = intUitkomst / intNumber2;
                        }
                        else
                        {
                            if (strBewerking == "vermenigvuldig" || strBewerking == "*" || strBewerking == "4")
                            {
                                intUitkomst = intUitkomst * intNumber2;
                            }
                            else
                            {
                                Console.WriteLine("ERROR");
                            }
                        }
                    }
                }
                Console.WriteLine("Voer nog een getal in:");
                strInput2 = Console.ReadLine();
                intNumber2 = int.Parse(strInput2);
            }
            Console.WriteLine("De uitkomst is " + intUitkomst);
            Console.ReadLine();

        }
    }
}
