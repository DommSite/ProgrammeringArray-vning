using System;

namespace stadsarray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stad = new string[3];
            stad[0] = "Växjö";
            stad[1] = "Vislanda";
            Console.WriteLine("Skriv in den bästa staden du vet om");
            stad[2] = Console.ReadLine();
            Console.WriteLine("Här är de 3 bästa sverige i ordningen trejde bäst, näst bäst och bäst");
            Console.WriteLine($"{stad[0]}, {stad[1]} och {stad[2]}");
        }
    }
}
