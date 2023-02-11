namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[] { a, b, c };

            Array.Sort(numbers);

            Console.WriteLine(numbers[2] + " " + numbers[1] + " " + numbers[0]);
        }
    }
}