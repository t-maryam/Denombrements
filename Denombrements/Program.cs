using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        static void Main(string[] args)
        {
           int c;
           do 
           { 
                 Console.WriteLine("Entrer votre choix : 1 Permutation, 2 Arrangement, 3 Combinaison, 0 Quitter");
                 c = int.Parse(Console.ReadLine());
           } while (c != 0 && c != 1 && c != 2 && c != 3);

               
           switch (c)
           {
                case 0:
                    { 
                        Environment.Exit(0); 
                    }
                    break;
                case 1:
                    Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                    int n = int.Parse(Console.ReadLine()); // saisir le nombre
                                                           // calcul de r
                    long r = 1;
                    for (int k = 1; k <= n; k++)
                        r *= k;
                    Console.WriteLine(n + "! = " + r);
                    break;
                case 2:
                        Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        int total = int.Parse(Console.ReadLine()); // saisir le nombre
                        Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                        n = int.Parse(Console.ReadLine()); // saisir le nombre
                        // calcul de r
                        r = 1;
                        for (int k = (total - n + 1); k <= total; k++)
                        r = r * k;
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("A(" + total + "/" + n + ") = " + r);
                    break;
                case 3:
                        Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        total = int.Parse(Console.ReadLine()); // saisir le nombre
                        Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                        n = int.Parse(Console.ReadLine()); // saisir le nombre
                        // calcul de r1
                        long r1 = 1;
                        for (int k = (total - n + 1); k <= total; k++)
                            r1 *= k;
                        // calcul de r2
                        long r2 = 1;
                        for (int k = 1; k <= n; k++)
                            r2 *= k;
                        // calcul de r3
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("C(" + total + "/" + n + ") = " + (r1 / r2));
                    break;
           }
            Console.ReadLine();
        }
    }
}
