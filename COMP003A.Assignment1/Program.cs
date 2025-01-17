/*
*Author: [Zaid Rojas]
*Course: [COMP-003A-L01]
*Faculty: Jonathan Cruz
*Purpose: This application demonstrates the basic structures of a .NET console application.
*Test
*/

namespace COMP003A.Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string UserName = Console.ReadLine();

            Console.WriteLine($"Hello {UserName}! My name is Zaid Rojas.");
            Console.WriteLine("\n\nHere are 10 things about me:");
            Console.WriteLine("1. I have a dog.\n2. I have another dog (two in total)\n3. I have participated in six game jams\n4. The first videogame I remember playing is Super Mario Bros on a neighbor's NES." +
                "\n5. Blue is my favorite color genre (favorite blue at the moment is Cobalt)\n6. Mario and Luigi Bowser's Inside Story is my favorite game of all time" +
                "\n7. My comfort food is chilaquiles\n8. Breakfast is my favorite food\n9. I have a soft spot for love songs with ukulele" +
                "\n10. I punctured between my pointer and middle finger opening a package with a knife one year ago.");
        }
    }
}
