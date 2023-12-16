namespace SoftArch_NimphiusFinalProject.Classes
{
    public class HotOrCold
    {
        public string GetHotOrCold()
        {
            string hOrC;
            do {
                Console.Write("Would you like your drink Hot or Cold?" +
                    "\n\tH for Hot" +
                    "\n\tC for Cold" +
                    "\nEnter Decision Here: ");
                hOrC = Console.ReadLine().ToUpper();

                if(hOrC == "H" || hOrC == "C")
                {
                    SetHotOrCold(hOrC);
                    break;
                }
                else
                {
                    Console.WriteLine("\n**Must Enter H or C**");
                }

            } while (hOrC == "" || hOrC != "H" || hOrC != "C");

            return hOrC;
        }

        public string SetHotOrCold(string hOrC)
        {
            string ans = null;

            if(hOrC == "H")
            {
                ans = "hot";
            }
            else if(hOrC == "C")
            {
                ans = "iced";
            }

            return ans;
        }
    }
}