using FootApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootApp
{
    class Program
    {
        static void Main(string[] args)
        {

            FootballContext ctx = new FootballContext();



            var aarena = new Arena();
            Console.WriteLine("Enter an Arnea name");
            var name = Console.ReadLine();
            aarena.Name = name;
            Console.WriteLine("Enter an Arnea address name");
            var address = Console.ReadLine();
            aarena.Address = address;


            ctx.Arenas.Add(aarena);

            var ateam = new Team();
            Console.WriteLine("Enter an Team name");

            var teamname = Console.ReadLine();
            ateam.Name = teamname;

            Console.WriteLine("Enter an Team Email name");

            
            ateam.Email = teamname + "di.com";
            ctx.Teams.Add(ateam);


            

            ctx.SaveChanges();

           

            // list of Arena
            Console.WriteLine("List of Arena name------");


            foreach (var listarena in ctx.Arenas)
            {
                Console.WriteLine(listarena.Name);
            }

            // list of Team
            Console.WriteLine("List of Team name------");

            foreach (var alist in ctx.Teams)
            {
                Console.WriteLine(alist.Name);
            }
            Console.ReadKey();
          
        }
    }
}
