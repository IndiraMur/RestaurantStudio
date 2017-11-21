using System;

namespace RestaurantStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();
            menu.AddMenuItem(new MenuItem("Hot Dogs", .99, "Mystery meat in link form.", "Main Course", false));
            //This second "duplicate" hot dog will not be added because of Equals method implemented in MenuItem 
            menu.AddMenuItem(new MenuItem("Hot Dogs", .99, "Mystery meat in link form.", "Main Course", false));
            menu.AddMenuItem(new MenuItem("Mac n Cheese", 1.99, "Macoroni and cheese powder.", "Side", false));
            menu.AddMenuItem(new MenuItem("Humus and Pita", 3, "Freshly made humus with pita.", "Appetizer", true));

            // This will use Menu.ToString() to create a string
            Console.WriteLine(menu);

            Console.ReadKey();
        }
    }
}
