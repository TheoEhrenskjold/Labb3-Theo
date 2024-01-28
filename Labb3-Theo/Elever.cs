using Labb3_Theo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Theo
{
    internal class Elever
    {
        public static void Run() 
        {
            using SampleDbContext context = new SampleDbContext();
            Console.WriteLine("[1]Sortera på Förnamn");
            Console.WriteLine("[2]Sortera på Student ID");

            var SubMenu = Console.ReadLine();
            if (SubMenu == "1")
            {
                var Students = context.Students.Where(p => p.Namn != null).OrderBy(p => p.Namn);

                foreach (Student p in Students)
                {
                    Console.WriteLine($"ID : {p.StudentId}");
                    Console.WriteLine($"Name : {p.Namn}");
                    Console.WriteLine(new string('-', 20));
                }
                Console.WriteLine("Vill du se dom sorterade stigande också? ja/nej");
                var stigandechoice = Console.ReadLine();
                if (stigandechoice == "ja")
                {
                    var StudentsDES = context.Students.Where(p => p.Namn != null).OrderByDescending(p => p.Namn);

                    foreach (Student p in StudentsDES)
                    {
                        Console.WriteLine($"ID : {p.StudentId}");
                        Console.WriteLine($"Name : {p.Namn}");
                        Console.WriteLine(new string('-', 20));
                    }
                    Console.WriteLine("Tryck enter för att fortsätta!");
                    Console.ReadKey();
                }
                Console.WriteLine("Tryck enter för att fortsätta!");
                Console.ReadKey();
            }
            if (SubMenu == "2")
            {
                var Students = context.Students.Where(p => p.Namn != null).OrderBy(p => p.StudentId);

                foreach (Student p in Students)
                {
                    Console.WriteLine($"ID : {p.StudentId}");
                    Console.WriteLine($"Name : {p.Namn}");
                    Console.WriteLine(new string('-', 20));
                }
                Console.WriteLine("Vill du se dom sorterade stigande också? ja/nej");
                var stigandechoice = Console.ReadLine();
                if (stigandechoice == "ja")
                {
                    var StudentsDES = context.Students.Where(p => p.Namn != null).OrderByDescending(p => p.StudentId);

                    foreach (Student p in StudentsDES)
                    {
                        Console.WriteLine($"ID : {p.StudentId}");
                        Console.WriteLine($"Name : {p.Namn}");
                        Console.WriteLine(new string('-', 20));
                    }
                    Console.WriteLine("Tryck enter för att fortsätta!");
                    Console.ReadKey();
                }
            }
        }
    }
}
