namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            nums.Reverse().ToList();
           
            Console.WriteLine($"Min = {nums.Min()}, --> Max = {nums.Max()}");
           
            

        }
    }
}