namespace ex20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int difference = Math.Abs(num1 - num2);

            if (num1 > num2)
            {
                difference *= 2;
            }

            Console.WriteLine("Result: " + difference);
        }
    }
}
