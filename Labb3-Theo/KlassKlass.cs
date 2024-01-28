using Labb3_Theo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Theo
{
    internal class KlassKlass
    {
        public static void Run()
        {
            using SampleDbContext context = new SampleDbContext();
            var klasser = context.Klasses.Where(p => p.Klassnamn != null).OrderBy(p => p.Klassnamn);
            foreach (Klass item in klasser)
            {
                Console.WriteLine($"Klass: {item.Klassnamn}");
            }
            Console.WriteLine("Vilken klass vill du titta på?");
            var klasschoice = Console.ReadLine();
            var valdKlass = context.Klasses.FirstOrDefault(p => p.Klassnamn == klasschoice);
            if (valdKlass != null)
            {
                var KlassSok = context.Students.Where(p => p.KlassId == valdKlass.KlassId);
                foreach (Student student in KlassSok)
                {
                    Console.WriteLine($"Namn : {student.Namn}");
                }
            }
            else
            {
                Console.WriteLine("Ogiltig klassval. Inga studenter visas.");
            }
            Console.ReadKey();
        
            
        }
    }
}
