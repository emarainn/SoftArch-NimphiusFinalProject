namespace NimphiusFinalProject
{
    public class Notes
    {
        private static string Line = "_______________________________________________________";
        public static void ProgramImplementation()
        {
            Console.WriteLine("Program Must Implement:" +
                "\n\t1. GRASP / Encapsulation / SOLID" +
                "\n\t2. The Strategy Pattern" +
                "\n\t3. The Singleton Pattern" +
                "\n\t4. The Factory Method" +
                "\n\t5. An Additional Pattern (10 points Extra)" +
                "\n\t6. JUnit");

            string yN = "";

            Console.Write("\nWould you like to learn more about a topic?" +
                "\n\n(Y / N): ");
            while(yN == "" || yN != "Y")
            
            Console.WriteLine($"\nG  R  A  S  P{Line}" +
                $"\n\tG.eneral" +
                $"\n\tR.esponsibility" +
                $"\n\tA.ssignment" +
                $"\n\tS.oftware" +
                $"\n\tP.rinciples");
        }
        //General Responsibility Assignment Software Principles
    }
}