using SoftArch_NimphiusFinalProject.Dao;
using SoftArch_NimphiusFinalProject.Models;
namespace SoftArch_NimphiusFinalProject.Classes
{
    public class Create
    {
        void TakeOrder(string drinkFile)
        {
            int drinkId = FindMaxDrinkId(drinkFile);
            
            Size size = new Size();
            string si = size.GetSize();

            HotOrCold hotOrCold = new HotOrCold();
            string hc = hotOrCold.GetHotOrCold();

            Milk milk = new Milk();
            string m = milk.GetMilk();

            Syrup syrup = new Syrup();
            string sy = syrup.GetSyrup();

            IDrink drink = new Drink(drinkId, si, hc, m, sy);
            StreamWriter sw = new StreamWriter(drinkFile, true);

            sw.WriteLine($"{drinkId}|{si},{hc},{m},{sy}");
            sw.Close();

            CreateDrink(drinkId, si, hc, m, sy);
        }

        public int FindMaxDrinkId(string drinkFile)
        {
            var maxId = 0;
            var lines = File.ReadLines(drinkFile).Skip(1);

            foreach (string line in lines)
            {
                var id = line.Split("|")[0];
                int newid = Convert.ToInt32(id);
                if (newid > maxId) { maxId = newid; }
                maxId++;
            }
            return maxId;
        }

        public string CreateDrink(int drinkId, string si, string hc, string m, string sy)
        {
            return $"Order Number {drinkId}:A {si} {hc} coffee with {m} and {sy}";
        }
    }
}
