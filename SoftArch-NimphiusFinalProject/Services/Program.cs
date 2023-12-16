using System;
using System.Threading.Channels;

namespace SoftArch_NimphiusFinalProject.Services
{
    public class Program
    {
        /*
         
            Prrogram Must Implement:        
                - GRASP / Encapsulation / SOLID
                - The Strategy Pattern
                - The Singleton Pattern
                - The Factory Method
                - An Additional Pattern (10 points Extra)
                - JUnit

         */
        public static void Main(string[] args)
        {
            MainService main = new MainService();
            main.Invoke();
        }
    }
}