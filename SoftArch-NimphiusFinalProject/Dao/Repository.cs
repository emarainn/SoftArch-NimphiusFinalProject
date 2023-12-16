
using SoftArch_NimphiusFinalProject.Classes;

namespace SoftArch_NimphiusFinalProject.Dao
{
    public class Repository : IRepository
    {
        private readonly ICreate _create;
        
        public Repository (ICreate create)
        {
            _create = create;
        }
        public bool CheckFile(string drinkFile)
        {
            bool exists = false;
            if (File.Exists(drinkFile)) { exists = true; }   
            return exists; 
        }

        public string CreateDrink(string drinkFile)
        {
            int drinkId = FindMaxDrinkId(drinkFile);
            _create.
            return null;
        }

        public int FindMaxDrinkId(string drinkFile)
        {
            var maxId = 0;
            var lines = File.ReadLines(drinkFile).Skip(1);

            foreach (string line in lines)
            {
                var id = line.Split("|")[0];
                int newid = Convert.ToInt32(id);
                if ( newid > maxId ){ maxId = newid; }
                maxId++;
            }
            return maxId;
        }
    }
}
