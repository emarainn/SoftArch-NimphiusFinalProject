
using SoftArch_NimphiusFinalProject.Classes;

namespace SoftArch_NimphiusFinalProject.Dao
{
    public class Repository : IRepository
    {
        public bool CheckFile(string drinkFile)
        {
            bool exists = false;
            if (File.Exists(drinkFile)) { exists = true; }   
            return exists; 
        }

    }
}
