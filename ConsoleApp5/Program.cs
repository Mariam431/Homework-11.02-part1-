namespace ConsoleApp5
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

            if(( a % 2 == 0) || (b % 2 == 0) || (c % 2 == 0))
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(2);
            }
        }
    }
}