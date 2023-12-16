namespace SoftArch_NimphiusFinalProject.Classes
{
    public class Syrup
    {
        public string GetSyrup() 
        {
            int syrup;

            do
            {
                Console.Write("Enter number for corresponding syrup!" +
                    "\n\t0. None" +
                    "\n\t1. Vanilla" +
                    "\n\t2. Hazelnut" +
                    "\n\t3. Caramel" +
                    "\n\t4. Brown Sugar" +
                    "\nEnter Number of Shots: ");

                if (!int.TryParse(Console.ReadLine(), out syrup))
                {
                    Console.WriteLine("\n**Must Enter Num 0 - 4**");
                }
                else if (syrup >= 0 && syrup <= 4)
                {
                    SetSyrup(syrup);
                    break;
                }
                else
                {
                    Console.WriteLine("\n**Must Enter Num 0 - 4**");
                }

            } while (syrup! >= 0 || syrup! <= 4);

            return SetSyrup(syrup);
        }

        public string SetSyrup(int syrup)
        {
            string syrupNum = null;

            if (syrup == 0) 
            {
                syrupNum = "no syrup";
            }
            else if (syrup == 1)
            {
                syrupNum = "vanilla syrup"; 
            }
            else if (syrup == 2)
            {
                syrupNum = "hazelnut syrup";
            }
            else if (syrup == 3)
            {
                syrupNum = "caramel syrup";
            }
            else if (syrup == 4)
            {
                syrupNum = "brown sugar syrup";
            }
            return syrupNum;
        }
    }
}