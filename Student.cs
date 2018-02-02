namespace CodeCamp2
{
    public class Student
    {
        private string name;
        private static int countStudent = 0;
        public static int CountStudent(){
            return countStudent;
        }
        
        public string Name
        {
            get { return name;}
            set { name = value;}
        }
        public Student(string name){
            Name = name;
            countStudent++;
        }
        
    }
}