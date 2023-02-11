namespace ConsoleApp1
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

            int smallestNum = a;

            if (b < smallestNum)
            {
                smallestNum = b;
                Console.WriteLine(smallestNum);
            }
       
            if (c < smallestNum)
            {
                smallestNum = c;
                Console.WriteLine(smallestNum);
            }
            Console.WriteLine(smallestNum);

            }
    }
}