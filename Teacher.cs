namespace CodeCamp2
{
    public class Teacher
    {
        private string name;
        private static int countTeacher = 0;
        public static int CountTeacher(){
            return countTeacher;
        }
        
        public string Name
        {
            get { return name;}
            set { name = value;}
        }
        public Teacher(string name){
            Name = name;
            countTeacher++;
        }
        
    }
}