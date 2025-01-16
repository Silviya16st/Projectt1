namespace Zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(8);
            list.AddLast(16);
            list.AddLast(2);
            list.AddLast(17);
            
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}