namespace ConsoleApp4
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

            if((a + b > c) & (a + c > b) & (b + c > a))
            {
                Console.WriteLine("y = 1");
            }
            else { Console.WriteLine("y = 2"); }
        }
    }
}