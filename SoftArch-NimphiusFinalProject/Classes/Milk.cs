namespace SoftArch_NimphiusFinalProject.Classes
{
    public class Milk
    {
        public string GetMilk()
        {
            int milk;

            do
            {
                Console.Write("Enter number of wanted milk: " +
                    "\n\t1. Whole Milk" +
                    "\n\t2. 1% Milk" +
                    "\n\t3. Almond" +
                    "\n\t4. Coconut" +
                    "\n\t5. Cashew" +
                    "\nEnter number of corrisponding milk:");

                if (!int.TryParse(Console.ReadLine(), out milk))
                {
                    Console.WriteLine("\n**Must Enter Num 1 - 5**");
                }
                else if (milk >= 0 && milk <= 5)
                {
                    SetMilk(milk);
                    break;
                }
                else
                {
                    Console.WriteLine("\n**Must Enter Num 1 - 5**");
                }

            } while (milk! >= 0 || milk! <= 5);

            return SetMilk(milk);
        }

        public string SetMilk(int milk)
        {
            string milkNum = null;

            if (milk == 1)
            {
                milkNum = "whole milk";
            }
            else if (milk == 2)
            {
                milkNum = "1% milk";
            }
            else if (milk == 3)
            {
                milkNum = "almond milk";
            }
            else if (milk == 4)
            {
                milkNum = "coconut milk";
            }
            else if (milk == 5)
            {
                milkNum = "cashew milk";
            }

            return milkNum;
        }
    }
}