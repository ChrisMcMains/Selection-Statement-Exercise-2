namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");
            
            string subject = Console.ReadLine();
            switch (subject.ToLower()) 
            {
                case "math":
                    Console.WriteLine("Math is fun");
                    break;
                case "science":
                    Console.WriteLine("Science is magical");
                    break;
                case "gym":
                case "pe":
                    Console.WriteLine("Gym is my favorite");
                    break;
                case "history":
                    Console.WriteLine("History is boring");
                    break;
                case "english":
                    Console.WriteLine("English is needed in America");
                    break;
                default:
                    Console.WriteLine("I don't know that subject");
                    break;

            }
        }
    }
}