namespace SoftArch_NimphiusFinalProject.Classes
{
    public class Size
    {
        public string GetSize()
        {
            int ozSize;

            do
            {
                Console.Write("How many oz would you like:" +
                    "\n\t12" +
                    "\n\t16" +
                    "\n\t20" +
                    "\nEnter Number of Size: ");

                if (!int.TryParse(Console.ReadLine(), out ozSize))
                {
                    Console.WriteLine("\n**Must Enter: 12, 16, OR 20**");
                }
                else if (ozSize == 12 || ozSize == 16 || ozSize == 20)
                {
                    SetSize(ozSize);
                    break;
                }
                else
                {
                    Console.WriteLine("\n**Must Enter: 12, 16, OR 20**");
                }

            } while (ozSize != 12 || ozSize != 16 || ozSize != 20);

            return SetSize(ozSize);
        }
        public string SetSize(int ozSize)
        {
            string size = null;

            if (ozSize == 12)
            {
                size = "small";
            }
            else if (ozSize == 16)
            {
                size = "medium";
            }
            else if (ozSize == 20)
            {
                size = "large";
            }

            return size;
        }
    }
}