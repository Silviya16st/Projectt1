namespace Zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> stack = new LinkedList<int>();
            stack.AddFirst(1);
            stack.AddLast(2);
            stack.AddLast(3);
           
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}