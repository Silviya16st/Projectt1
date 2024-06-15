namespace Zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine(string.Join(" ", nums.Reverse().ToArray()));

            Console.WriteLine($"Min = {0} {nums.Min()}, --> Max = {0} {nums.Max()}");
        }
    }
}