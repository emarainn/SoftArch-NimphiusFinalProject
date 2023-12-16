using Microsoft.Extensions.Logging;
using Port_C_CoffeeShop.Classes;
using SoftArch_NimphiusFinalProject.Classes;
using SoftArch_NimphiusFinalProject.Dao;
using static CoffeeShop.Program;

namespace SoftArch_NimphiusFinalProject.Services
{
    public partial class MainService : IMainService
    {
        private readonly IRepository _repository;
        public string Line = "\n______________________________________________________________";
        public string MenuTxt = $"Main MenuYou have the following options:\n\t1. Create your own drink\n\t2. Drink Randomizer" +
                $"\n\t3. Display All Drinks\n\tX. Exit Application\nEnter your option here: ";

        public MainService(IRepository repository)
        {
            _repository = repository;
        }

        public void Invoke()
        {
            Console.WriteLine($"Hello And Welcome To Ema's Coffee Shop!!{Line}");
            string drinkFile = $"{Environment.CurrentDirectory}/Files/drinks.csv";

            _repository.CheckFile( drinkFile );

            Console.WriteLine($"\nMain Menu{Line}");

            string option = "";
            do
            {
                Console.Write(MenuTxt);
                option = Console.ReadLine().ToUpper();
                if (option == "1")
                {
                    _repository.CreateDrink( drinkFile );
                }
                else if (option == "2")
                {

                }
                else if (option == "3")
                {

                }else if (option == "X") { Console.WriteLine("\nThank You For Visiting!!\nSee You Soon!"); }

            } while (option != "X");
        }
    }
}
