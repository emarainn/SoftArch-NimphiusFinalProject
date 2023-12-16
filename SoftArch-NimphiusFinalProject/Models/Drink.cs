using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SoftArch_NimphiusFinalProject.Models
{
    public class Drink : IDrink
    {
        public int Id { get; set; }
        public string Size { get; set; }
        public string HotOrCold { get; set; }
        public string Milk { get; set; }
        public string Syrup { get; set; }

        public Drink(int id, string size, string hotOrCold, string milk, string syrup)
        {
            Id = id;
            Size = size;
            HotOrCold = hotOrCold;
            Milk = milk;
            Syrup = syrup;
        }

        public override string ToString()
        {
            return $"{Size} {HotOrCold} coffee with {Milk} and {Syrup}!";
        }

    }
}