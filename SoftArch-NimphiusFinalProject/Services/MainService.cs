using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftArch_NimphiusFinalProject.Classes;
using SoftArch_NimphiusFinalProject.Dao;

namespace SoftArch_NimphiusFinalProject.Services
{
    public partial class MainService : IMainService
    {
        private readonly IRepository _repository;
        private readonly ICreate _create;
        public string Line = "\n______________________________________________________________";
        public string MenuTxt = $"Main MenuYou have the following options:\n\t1. Create your own drink\n\t2. Display All Drinks\n\tX. Exit Application\nEnter your option here: ";

        public MainService()
        {
            Invoke();
        }

        public MainService(IRepository repository, ICreate create)
        {
            _repository = repository;
            _create = create;
        }

        public void Invoke()
        {
            Console.WriteLine($"Hello And Welcome To Ema's Coffee Shop!!{Line}");
            string drinkFile = $"{Environment.CurrentDirectory}/Files/drinks.csv";

            //_repository.CheckFile(drinkFile);
            if (File.Exists(drinkFile))
            {
                Console.WriteLine($"\nMain Menu{Line}");

                string option = "";
                do
                {
                    Console.Write(MenuTxt);
                    option = Console.ReadLine().ToUpper();
                    if (option == "1")
                    {
                        _create.TakeOrder(drinkFile);
                        
                    }
                    else if (option == "2")
                    {
                        Display display = new Display();
                        Console.WriteLine("\n");
                        display.Read(drinkFile);
                    }
                    else if (option == "X")
                    {
                        Console.WriteLine("\nThank You For Visiting!!\nSee You Soon!");
                    }
                    else
                    {
                        Console.WriteLine("\n** Ivalid Input **");
                    }
                } while (option != "X");
            }else
            {
                Console.WriteLine("No File Found");
            }
        }
    }
}
