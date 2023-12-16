namespace SoftArch_NimphiusFinalProject.Classes
{
    public interface ICreate
    {
        void TakeOrder(string drinkFile);
        string CreateDrink(int drinkId, string si, string hc, string m, string sy);
        int FindMaxDrinkId(string drinkFile);
        
    }
}
