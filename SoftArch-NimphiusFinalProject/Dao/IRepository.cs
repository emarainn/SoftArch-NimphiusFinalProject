using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftArch_NimphiusFinalProject.Dao
{
    public interface IRepository
    {
        public bool CheckFile(string drinkFile);


        public string CreateDrink(string drinkFile);
        public int FindMaxDrinkId(string drinkFile);
    }
}
