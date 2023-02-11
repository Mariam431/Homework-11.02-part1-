namespace ConsoleApp3
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



            if (((a == 1) & (b == 1) & (c != 1)) || (a == 1) & (b != 1) & (c == 1) || ((a != 1) & (b == 1) & (c == 1)))
            {
                Console.WriteLine("True");
            }

            else
            {
                Console.WriteLine("False");
            }
        }
    }
}