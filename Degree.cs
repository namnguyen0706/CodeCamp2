using System.Collections.Generic;
namespace CodeCamp2
{
    public class Degree
    {
        private string name;
        
        public string Name
        {
            get { return name;}
            set { name = value;}
        }
        public Degree(string name)
        {
            Name = name;
            countDegree++;
        }
        public List<Course> listCourse = new List<Course>();
        // public List<Course> ListCourses { get; set; } = new List<Course> ();
        private static int countDegree = 0;
        public static int CountDegree()
        {
            return countDegree;
        }
        public void addCourse(Course c)
        {
            listCourse.Add(c);
        }
        public void showCourse()
        {
            System.Console.WriteLine("degree {0} co cac khoa hoc: ",name);
            foreach (var item in listCourse)
            {
                System.Console.WriteLine(item.Name);
            }
        }

        
    }
}