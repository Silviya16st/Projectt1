namespace Зад4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            if (stack.Contains(1))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}