namespace Zadacha3
{
    internal class Program
    {


       static List<PersonGrades> gradesPerson = new List<PersonGrades>();
       static PersonGrades p1 = new PersonGrades("ime", 4.44, 5.55);
       static List<PersonGrades> persons = new List<PersonGrades>();
       static int n = int.Parse(Console.ReadLine());
        static void Main(string[] args)
        {
            

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
                int slabiOcenki = 0;
                if (gradeMaths < 3 || gradeBel < 3)
                {
                    slabiOcenki = persons.Count();
                }


                Console.WriteLine(slabiOcenki);

                for (int j = 0; j < persons.Count; j++)
                {
                    double ocenkaBel = persons[i].GradeBel;
                    double ocenkaMat = persons[i].GradeMat;
                    

                    if (Math.Round(ocenkaBel) < 3 || Math.Round(ocenkaMat) < 3)
                    {
                        Console.WriteLine($"Slabi ocenki: {persons.Count()}");
                    }
                    
                }
            
            }



            





        }
    }
}