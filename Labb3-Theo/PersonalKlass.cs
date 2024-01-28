using Labb3_Theo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Theo
{
    internal class PersonalKlass
    {

        public static void Run()
        {
            using SampleDbContext context = new SampleDbContext();
            Console.WriteLine("Vad heter den anställda?");
            var anställdnamn = Console.ReadLine();
            Console.WriteLine($"Vilken befattning har {anställdnamn}");
            var anställdbefattning = Console.ReadLine();
            Console.WriteLine($"Vilken ID {anställdnamn}");
            var anställdID = Convert.ToInt32(Console.ReadLine());
            //if (anställdbefattning == "lärare")
            //{
            //    Console.WriteLine("Vilket ämne ansvarar din lärare för?");
            //    var lärarämne = Console.ReadLine();
            //    Lärare lärare = new Lärare();
            //    {
            //        lärare.Namn = anställdnamn;
            //        lärare.Ämne = lärarämne;
            //    }
            //    context.Add(lärare);
            //    Personal personal = new Personal();
            //    {
            //        personal.Namn = anställdnamn;
            //        personal.Befattning = anställdbefattning;
            //    }
            //    context.Add(personal);
            //}

            //else
            //{
            //    Personal personal = new Personal();
            //    {
            //        personal.Namn = anställdnamn;
            //        personal.Befattning = anställdbefattning;
            //    }
            //    context.Add(personal);
            //}
            Personal personal = new Personal();
            {
                personal.PersonalId = anställdID;
                personal.Namn = anställdnamn;
                personal.Befattning = anställdbefattning;
            }
            context.Add(personal);
            context.SaveChanges();
            Console.WriteLine($"{anställdnamn} har lagts till i databasen.");
            Console.WriteLine("Tryck enter för att fortsätta");
            Console.ReadKey();
        }
    }
}
