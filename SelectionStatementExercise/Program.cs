namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(10);

            Console.WriteLine("Gues the number:");

            var userInput = int.Parse(Console.ReadLine());

            if (favNumber > userInput)
            {
                Console.WriteLine("too low");
            }
            else if (favNumber < userInput)
            {
                Console.WriteLine("too high");
            }
            else
            {
                Console.WriteLine("You guesse it!!!");
            }
        }
    }
}
