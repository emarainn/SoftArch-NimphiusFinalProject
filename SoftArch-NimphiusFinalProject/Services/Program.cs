using System;
using System.Threading.Channels;
using SoftArch_NimphiusFinalProject.Classes;
using SoftArch_NimphiusFinalProject.Dao;

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
            MainService main = new MainService(new Repository(), new Create());
            main.Invoke();
        }
    }
}