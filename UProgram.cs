using System.Collections.Generic;

namespace CodeCamp2
{
    public class UProgram
    {
        private string name;
        
        public string Name
        {
            get { return name;}
            set { name = value;}
        }
        public UProgram(string name){
            Name = name;
        }
        public List<Degree> listDegree = new List<Degree>();

        public void addDegree(Degree dgr){
            listDegree.Add(dgr);
            System.Console.WriteLine("them thanh cong");
        }
        public void showDegree()
        {
            System.Console.WriteLine("Uprogram {0} co cac degree: ", name);
            foreach (var item in listDegree)
            {
                System.Console.WriteLine(item.Name);
            }
        }
        
    }
}