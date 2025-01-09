namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine()); //Декларираме число от тип int и го четем от конзолата

            for (int num = 1; num <= n; num++) //обхождаме чрез цикъл for като преминава през всички числа от 1 до n
            {
                int sumOfDigits = 0;
                int digits = num;

               
               //Изчисляваме сумата на цифрите на числото 
                while (digits > 0) 
                {

                    sumOfDigits += digits % 10;

                    digits = digits / 10;

                }

                //Проверяваме дали числото е специално 
                //Числото е специално ако сумата е равна на 5, 7 или 11
                bool special = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits ==11); 

                Console.WriteLine("{0} -> {1}", num, special); //Отпечатваме резултата

            }

        }
    }
}