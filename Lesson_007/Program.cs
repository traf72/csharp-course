namespace Lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Args length: {args.Length}");
            foreach (string item in args)
            {
                Console.WriteLine(item);
            }

            int sum = Add(5, 6);
            Console.WriteLine(sum);  // 11
        }

        static int Add(int x, int y)
        {
            int result = x + y;
            return result;
        }
    }
}
