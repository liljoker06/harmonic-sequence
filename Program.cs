using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github_harmonic_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int chose;
            bool ok;
            int nbrTerms;
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine(" 1 - harmonic sequence 1/n ");
                Console.WriteLine(" 0 - end  ");
                Console.WriteLine("--------------------------------------------------- ");
                do
                {
                    Console.WriteLine("you chose ?");
                    string stChoix = Console.ReadLine();
                    ok = int.TryParse(stChoix, out chose);
                }
                while (!ok);
                if ( chose == 0) break;

                switch (chose)
                {
                    case 1:
                        while (true)
                        {
                            do
                            {
                                Console.Write("suite 1/n :combien de termes ?");
                                ok = int.TryParse(Console.ReadLine(), out nbrTerms);
                            }
                            while (!ok);
                            if (nbrTerms <= 0) break;
                            for (int i = 1; i <= nbrTerms; i++)
                            {
                                Console.WriteLine("t [" + i + "]=" + 1.0 / i);

                            }
                        }
                        break;
                }
            }
        }
    }
}
