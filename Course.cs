using System.Collections.Generic;
namespace CodeCamp2
{
    public class Course
    {
        private string name;
        
        public string Name
        {
            get { return name;}
            set { name = value;}
        }
        
        public List<Teacher> listTeacher = new List<Teacher>();
        public List<Student> listStudent = new List<Student>();
        public Course(string course){
            Name = course;
        }
        public void addStudent(Student st)
        {
            listStudent.Add(st);
            System.Console.WriteLine("them sv thanh cong.");
        }
        public void addTeacher(Teacher tc)
        {
            listTeacher.Add(tc);
            System.Console.WriteLine("them gv thanh cong.");
        }
        public void showInfo()
        {
            System.Console.WriteLine("thong tin course: {0} ",name);
            System.Console.WriteLine("so luong sv la: "+listStudent.Count);
            foreach (var item in listStudent)
            {
                System.Console.WriteLine(item.Name);
            }
            System.Console.WriteLine("so luong gv la: "+listTeacher.Count);
            foreach (var item in listTeacher)
            {
                System.Console.WriteLine(item.Name);
            }
            
        }
    }
}