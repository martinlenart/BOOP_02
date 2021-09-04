using System;

namespace BOOP_02_16
{
    class Program
    {
        public enum Favorites { Cars, Boats, Motorcycles, Other }
        static void Main(string[] args)
        {
            Favorites yourFavorite = Favorites.Cars;

            // using the switch statement
            string myFavorite;
            switch (yourFavorite)
            {
                case Favorites.Cars:
                    myFavorite = "I enjoy driving cars fast.";
                    break;
                case Favorites.Motorcycles:
                    myFavorite = "I love riding motorcycles!";
                    break;
                case Favorites.Boats:
                    myFavorite = "I don't particular care for boats.";
                    break;
                default:
                    myFavorite = "Well...";
                    break;
            }

            string maybeTogether;
            switch (yourFavorite)
            {
                case Favorites.Cars:
                case Favorites.Motorcycles:
                    maybeTogether = "Lets go together!";
                    break;
                default:
                    maybeTogether = "Pls go alone!";
                    break;
            }

            Console.WriteLine(myFavorite);
            Console.WriteLine(maybeTogether);
        }
    }
}
