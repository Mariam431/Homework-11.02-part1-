namespace Homework_11._02
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

            if ((a > b) & (a > c))
            {
                Console.WriteLine(a);
            }
            else
            {
                if((b  > a) & (b > c))
                {
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(c);
                }
            }
        }
    }
}