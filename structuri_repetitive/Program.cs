using System;

namespace structuri_repetitive;

class ex1
{
    static void Main(string[] args)
    {

        int number;

        TextPrintUsers();

        number = int.Parse(Console.ReadLine());

        Perechii(number);

    }
    static void TextPrintUsers()
    {

        Console.WriteLine("Type the number ");


    }

    static void Perechii(int number)
    {
        int x = 0;

        while (x < number / 2)
        {
            x++;

            int y = number - x;

            if (y < x)
            {

                Console.WriteLine(x + " " + y);

            }



        }

    }


}
Se citesc numere pana la aparitia lui 0 .Sa se determine cate dintre ele erau pare.


using System;

namespace STRUCTURI_REPETITIVE;

class ex1
{
    static void Main(string[] args)
    {
        int number;

        TextPrintUsers();

        number = int.Parse(Console.ReadLine());


        Even_numbers(number);
    }
    static void TextPrintUsers()
    {
        Console.WriteLine("Type the number ");
    }
    static void Even_numbers(int number) // 
    {
        int NrPare = 0;            // reprezentand counter ul de numere pare  


        while (number != 0) // numarul este diferit de 0 
        {

            if (number % 2 == 0) // 4 este divizibil 
                                 // numarul este divizibil cu 2 atunci in se incrementeaza in counter cu o valoare 
            {
                NrPare++; // NtPare =  1;

            }

            number = int.Parse(Console.ReadLine());
            // number = 6
            /* se citeste alt numar de la tastatura deoarece cerinta specifica  ,, se citesc numere de la 
            tastatura pana la aparitia numarului 0 */
        }
        Console.WriteLine(NrPare);  //1 
        // se retine valoare counter ului si se schimba la fiecare intrare in bucla 
    }


}

Se citesc numere pana la aparitia lui 0 .Sa se determine cate dintre ele erau impare.

using System;

namespace structuri_repetitive;


class ex2
{
    static void Main(string[] args)
    {
        int number;

        TextPrintUsers();

        number = int.Parse(Console.ReadLine());


        NrImpare(number);


    }
    static void TextPrintUsers()
    {

        Console.WriteLine("Type the number ");
    }
    static void NrImpare(int number)
    {
        int NrImpare = 0; // counter

        while (number != 0)
        {
            if (number % 2 == 1)
            {

                NrImpare++;

            }
            number = int.Parse(Console.ReadLine()); // se citesc numere verificandu daca respecta conditia din bucla pana la aparitia lui 0  dupa sunt afisate cate numere impare au fost tastate de catre utilizator 


        }


        Console.WriteLine(NrImpare + " sunt numere impare tastate de catre utilizator");


    }



    Se citesc numere pana la aparitia lui 0 .Sa se determine cate dintre ele erau pare si sa se faca suma numerelor pare;



using System;
using System.Security.Cryptography.X509Certificates;

namespace structuri_repetitive;

class ex2_aum
    {
        static void Main(string[] args)
        {
            int number;

            number = int.Parse(Console.ReadLine());

            Sum(number);

        }
        static void TextPrintUsers()
        {

            Console.WriteLine("Type the number");

        }

        static void Sum(int number)
        {
            int NrPare = 0;
            int sum = 0;


            while (number != 0)
            {


                if (number % 2 == 0)
                {
                    NrPare++;

                    sum = sum + number;


                }

                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(NrPare + " acestea sunt numerele pare tastate de catre utilizator ");

            Console.WriteLine(sum + " este suma numerelor pare ");




        }



    }



    Se dă un număr natural n.Afișați în ordine crescătoare primele n numere naturale nenule.


using System;

namespace structuri_repetitive;


class ordine_crescatoare
{
    static void Main(string[] args)
    {
        int number;

        TextPrintUsers();

        number = int.Parse(Console.ReadLine());

        ascending_number(number);

    }
    static void TextPrintUsers()
    {

        Console.WriteLine(" Type the number ");

    }
    static void ascending_number(int number)
    {

        int increment = 0;

        while (increment < number)
        {
            if (number != 0)
            {
                increment++;


            }
            Console.WriteLine(increment);
        }

    }

}

Se dă un număr natural n.Afișați în ordine descrescătoare primele n numere naturale nenule.



using System;


namespace structuri_repetitive;

class descending_order
{
    static void Main(string[] args)
    {
        int number = 0;

        TextPrintUsers();

        number = int.Parse(Console.ReadLine());

        Descending_Order(number);

    }
    static void TextPrintUsers()
    {

        Console.WriteLine(" Type the numbers");

    }
    static void Descending_Order(int number)
    {

        for (int increment = number; increment <= number && increment != 0; increment--)
        {

            Console.WriteLine(increment);

        }





    }

}



































