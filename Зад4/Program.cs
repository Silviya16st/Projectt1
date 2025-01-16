namespace Зад4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack<int> stack = new Stack<int>();
           
            //Добавяне на елементи
            stack.Push(2);
            stack.Push(7);
            stack.Push(8);
            stack.Push(16);

            int n = int.Parse(Console.ReadLine());

            //Проверява дали стека съдържа числото
            if (stack.Contains(n))
            {
                //Отпечатва true ако стека съдържа числото
                Console.WriteLine("true"); 
            }
            else
            {
                //Отпечатва false ако стека не съдържа елемента 
                Console.WriteLine("false");
            }
        }
    }
}