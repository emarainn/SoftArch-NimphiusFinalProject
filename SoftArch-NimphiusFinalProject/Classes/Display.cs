namespace SoftArch_NimphiusFinalProject.Classes
{
    public class Display 
    { 
        public void Read(string drinkFile)
        {
            if (File.Exists(drinkFile))
            {
                StreamReader sr = new StreamReader(drinkFile);
                while(sr.EndOfStream != true)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("File Not Found");
            }
        }

    }
}