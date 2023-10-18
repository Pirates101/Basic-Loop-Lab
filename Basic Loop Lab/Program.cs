namespace Basic_Loop_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateSumOfNumbers();
        }

        static void CalculateSumOfNumbers()
        {
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            int inputInt = int.Parse(input);

            int total = 0;
            for (int i = 0 ; i <= inputInt; i++) 
            {
                total += i;
                
            }
            Console.WriteLine($"The sum from 0 to {inputInt} is {total}");
        }
    }
}