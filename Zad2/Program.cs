namespace Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            
            //Добавя в началото
            list.AddFirst(8); 
            list.AddFirst(16);  
            
            //Добавя в края
            list.AddLast(2);
            list.AddLast(7);
           
            int n = int.Parse(Console.ReadLine());
            
            if (list.Contains(n)) //Проверява дали списъка съдържа числото
            {
                Console.WriteLine("true"); //Отпечатва true ако се съдържа
            }
            else
            {
                Console.WriteLine("false"); //Опечатва false ако не се съдържа
            }
        } 
    }
    
}