using static CoffeeShop.Program;

namespace Port_C_CoffeeShop.Classes;
public class CreateDrink
{
    public void Create(string drinkFile)
    {
        int drinkId = FindMaxId(drinkFile);

        Size size = new Size();
        string si = size.GetSize();

        HotOrCold hotOrCold = new HotOrCold();
        string hc = hotOrCold.GetHotOrCold();

        Milk milk = new Milk();
        string m = milk.GetMilk();

        Syrup syrup = new Syrup();
        string sy = syrup.GetSyrup();

        Expresso expresso = new Expresso();
        string e = expresso.GetExpresso();

        IDrink drink = new Drinks(drinkId, si, hc, m, sy, e);
        StreamWriter sw = new StreamWriter(drinkFile, true);

        sw.WriteLine($"{drinkId}|{si},{hc},{m},{sy},{e}");
        sw.Close();

        Console.WriteLine($"Order Number {drinkId}:A {si} {hc} coffee with {m}, {sy}, and {e}");


    }
    public static int FindMaxId(string drinkFile)
    {
        var maxId = 0;
        var lines = File.ReadLines(drinkFile).Skip(1);

        foreach (string line in lines)
        {
            var id = line.Split("|")[0];

            int newid = Convert.ToInt32(id);

            if (newid > maxId)
            {
                maxId = newid;
            }
            maxId++;
        }
        return maxId;
    }
}
