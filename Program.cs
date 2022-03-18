using System;

namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.Write("E N T E R   T H E   S I Z E   O F   Y O U R   P A S S W O R D :   ");
            int size = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            char[] characterArray = new char[size];
            for (int i = 0; i < size; i++)
                characterArray[i] = (char)random.Next(97, 123);
            string randomPassword = new string(characterArray);
            Console.WriteLine("Y O U R   P A S S W O R D   I S :   " + randomPassword);
        }
    }
}
