using Labb3_Theo.Models;

namespace Labb3_Theo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) { 
                Console.Clear();
            using SampleDbContext context = new SampleDbContext();

            Console.WriteLine("[1] Visa alla elever");
            Console.WriteLine("[2] Lägg till Personal");
            Console.WriteLine("[3] Visa klasser");
            var Mainmenu = Console.ReadLine();
                switch (Mainmenu)
                {
                    case "1":
                        {
                            Elever.Run();
                            
                        }
                        break;

                        case "2":
                        {
                            PersonalKlass.Run();
                        }
                        break;
                    
                    case "3":
                        {
                            KlassKlass.Run();
                        }
                        break;
                }
                
            }
        }
    }
}
