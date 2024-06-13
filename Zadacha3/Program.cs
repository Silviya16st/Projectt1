namespace Zadacha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PersonGrades> gradesPerson = new List<PersonGrades>();
            PersonGrades p1 = new PersonGrades("ime",4.44, 5.55);
            List<PersonGrades> persons = new List<PersonGrades>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter student's name: ");
                string personName = Console.ReadLine();
                Console.WriteLine();
               
                Console.Write("Enter bel grade: ");
                double gradeBel = double.Parse(Console.ReadLine());
                Console.WriteLine();
               
                Console.Write("Enter maths grade: ");
                double gradeMaths = double.Parse(Console.ReadLine());

                double average = (gradeBel + gradeMaths) / 2;
                PersonGrades p2 = new PersonGrades(personName, gradeBel, gradeMaths);
                persons.Add(p2);
               

                Console.WriteLine($"name = {personName}, number: {i}, average = {average}");
                Console.WriteLine();
                Console.WriteLine($"Broi na slabite ocenki {persons.Count(g => gradeMaths < 3 || gradeBel < 3)}");
               
            }
           
           
        }
    }
}