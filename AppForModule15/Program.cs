namespace AppForModule15
{
    internal class Program
    {
        static void Main()
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine("Имена всех студентов: \n{0}", string.Join("\n", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            var result = from stud in classes
                         from student in stud.Students
                         select student;
            return result.ToArray();
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}