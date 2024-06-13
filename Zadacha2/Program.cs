namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PersonGrades> gradesPerson = new List<PersonGrades>();
            PersonGrades p1 = new PersonGrades(3.33, 4.44);
            List<PersonGrades> persons = new List<PersonGrades>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter bel grade: ");
                double gradeBel = double.Parse(Console.ReadLine());
                
                Console.Write($"Enter maths grade: ");
                double gradeMaths = double.Parse(Console.ReadLine());

                PersonGrades p2 = new PersonGrades(gradeBel, gradeMaths);
                persons.Add(p2);
            }

            for (int i = 0; i < persons.Count; i++)
            {
                double ocenkaBel = persons[i].GradeBel;
                double ocenkaMat = persons[i].GradeMat;
                double average = (ocenkaBel + ocenkaMat) / 2;
                
                if (Math.Round(ocenkaBel) == Math.Round(ocenkaMat))
                {
                    Console.WriteLine($"Nomer: {i}: {ocenkaBel}, {ocenkaMat} = {average}");
                }
                else
                {
                    Console.WriteLine($"{i} --> {average}");
                }
            }

        }
    }
}