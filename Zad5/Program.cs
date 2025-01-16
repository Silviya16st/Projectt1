namespace Zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            
            //Добавяне на елементите
            stack.Push(8);
            stack.Push(16);
            stack.Push(2);
            stack.Push(7);
           
            //Обхождане
            foreach (int item in stack)
            {
                Console.WriteLine(item); //Отпечатване на елеметите
            }
        }
    }
}