namespace SoftArch_NimphiusFinalProject.Classes
{
    public interface ICreate
    {
        public void TakeOrder(string drinkFile);
        string CreateDrink(int drinkId, string si, string hc, string m, string sy);
        int FindMaxDrinkId(string drinkFile);
        
    }
}
