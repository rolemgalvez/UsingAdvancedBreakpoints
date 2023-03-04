namespace HomeworkFifteen
{
    public class Section
    {
        public static void Welcome()
        {
            Console.WriteLine("Homework Fifteen");
            Console.WriteLine("----------------");
            Console.WriteLine();
        }

        public static void Core()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("La");
                if (i == 73)
                {
                    throw new Exception("Something went wrong.");
                }
            }
            Console.WriteLine("========");
            Console.WriteLine("RAN CORE");
            Console.WriteLine("========");
        }

        public static void End()
        {
            Console.WriteLine();
            Console.WriteLine("End of program.");
            Console.ReadLine();
        }
    }
}
