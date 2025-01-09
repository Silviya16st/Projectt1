namespace Zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
            list.AddLast(6);
            list.AddLast(7);
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}