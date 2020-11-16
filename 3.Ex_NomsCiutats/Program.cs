using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Ex_NomsCiutats
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos los strings vacíos

            string city1 = "";
            string city2 = "";
            string city3 = "";
            string city4 = " ";
            string city5 = " ";
            string city6 = " ";

            //Introducimos los datos por teclado tras la petición del programa, los guardamos en sus strings
            Console.WriteLine(" Escribe un nombre de ciudad española: ");
            city1=Console.ReadLine();
            Console.WriteLine(" Escribe un nombre de ciudad española: ");
            city2 = Console.ReadLine();
            Console.WriteLine(" Escribe un nombre de ciudad española: ");
            city3 = Console.ReadLine();
            Console.WriteLine(" Escribe un nombre de ciudad española: ");
            city4 = Console.ReadLine();
            Console.WriteLine(" Escribe un nombre de ciudad española: ");
            city5 = Console.ReadLine();
            Console.WriteLine(" Escribe un nombre de ciudad española: ");
            city6 = Console.ReadLine();

            string citys= "  " + city1 + "  " + city2 + "  " + city3 + "  " + city4 + "  " + city5 + "  " + city6; //Juntamos los strings para imprimirlos posteriormente en la sigiente orden
            Console.WriteLine("Los nombres de las ciudades son: " + "\n" + citys);
        }
    }
}
