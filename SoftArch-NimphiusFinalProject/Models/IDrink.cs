using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftArch_NimphiusFinalProject.Models
{
    public interface IDrink
    {
        public int Id { get; set; }
        public string Size { get; set; }
        public string HotOrCold { get; set; }
        public string Milk { get; set; }
        public string Syrup { get; set; }
    }
}
