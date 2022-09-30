using System; 
namespace Uppgift_3._13
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur gammal är du?");
              int Ålder=int.Parse(Console.ReadLine());



            if (Ålder >= 16 && Ålder <= 19)
            {
                Console.WriteLine("Du får delta i tävlingen");
            }
            else

            {
                Console.WriteLine("Du får inte delta i tävlingen");
            }
                
            
        }
    }
}