using System;

namespace Ders_05_GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1985,
                FirstName = "MAHMUT",
                LastName = "AKBAŞ",
                IdentityNumber = 111111111
            });
            Console.WriteLine("Hello World!");
        }
    }
}
//Gamer,Game,Sales,