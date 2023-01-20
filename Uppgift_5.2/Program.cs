using System;
namespace uppgift_5._2
{
    class program
    {
        static void Main(string[]args)
        {
            
                Console.WriteLine("Hur många heltal vill du skriva in?");
                int antal = int.Parse(Console.ReadLine());
                string[] heltal = new string[antal];

                for (int i = 0; i < antal; i++)
                {
                    Console.WriteLine("skirv in dina/ditt heltal");
                    heltal[i] = Console.ReadLine();
                }
                    Console.WriteLine("här är talen du skrev in");
                for(int i = 0; i < antal; i++)
                { 

                   
                   Console.Write($"Tal{i+1}: {heltal[i]} \n");
                }
        }
    }
}