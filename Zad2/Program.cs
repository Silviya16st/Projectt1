namespace Zad2
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
            int n = int.Parse(Console.ReadLine());
            if (list.Contains(n))
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