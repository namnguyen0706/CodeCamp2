using System;
using System.Collections.Generic;


namespace CodeCamp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //GuessANumber();
            // checkArrayNumber();

            //Bai 2:
            UProgram IT = new UProgram("Information Technology");

            Degree degree1 = new Degree("Bachelor");
            Degree degree2 = new Degree("Engineering");
            IT.listDegree = new List<Degree>(){degree1,degree2};// them  doi tuong bang vao Uprogram.

            Course c1 = new Course("Programming with C#");
            Course c2 = new Course("Javascript for beginner");
            Course c3 = new Course("Dotnet Core MVC");

            degree1.listCourse = new List<Course>(){c1,c2};
            degree2.listCourse = new List<Course>(){c3};

            Student st1 = new Student("Lukaku");
            Student st2 = new Student("Messi");
            Student st3 = new Student("Ronaldo");
            Student st4 = new Student("Neymar");
            Student st5 = new Student("Anthony Martial");
            Student st6 = new Student("Alexis Sanchez");
            Student st7 = new Student("Marcus Rasford");
            
            Teacher tc1 = new Teacher("Mourinho");
            Teacher tc2 = new Teacher("Pep guardiola");
            Teacher tc3 = new Teacher("Conte");

            
            c1.listStudent = new List<Student>(){st1,st2,st3};
            c1.listTeacher = new List<Teacher>(){tc1};

            c1.showInfo();// in Số lượng và danh sách học sinh và giáo viên trong từng Course

            c2.listStudent = new List<Student>(){st4,st5,st6,st7};
            c2.listTeacher = new List<Teacher>(){tc2,tc3};
            c2.showInfo(); // in Số lượng và danh sách học sinh và giáo viên trong từng Course


            System.Console.WriteLine("Tong so sv cua toan truong la: "+ Student.CountStudent());
            System.Console.WriteLine("tong so gv cua toan truong la: "+Teacher.CountTeacher());
            
            // in ten cua cac course trong tung degree
            degree1.showCourse();
            degree2.showCourse();

            // in ten Uprogram va cac degree
            IT.showDegree();
            
        }

        static void GuessANumber()
        {
            try
            {
                int randomNumber;
                Random rd = new Random();
                randomNumber = rd.Next(-100,100);
                
                System.Console.WriteLine("moi ban doan: ");
                int guessNumber = int.Parse(Console.ReadLine());
                if(guessNumber==randomNumber)
                    System.Console.WriteLine("You win with ... guesses. The correct number is: "+randomNumber);
                else if(guessNumber>randomNumber)
                    System.Console.WriteLine("Guess Higher");
                else
                    System.Console.WriteLine("Guess Lower");
                System.Console.Write("so ngau nhien la: "+randomNumber);
            }
            catch (Exception ex)
            {
            
                System.Console.WriteLine(ex.Message);
            }
        }

        // bai 3: Viết một chương trình yêu cầu người dùng nhập vào 1 mảng số nguyên và kiểm tra xem mảng này có chứa các số liền nhau không.

        static void checkArrayNumber()
        {
            try
            {
                System.Console.WriteLine("moi ban nhap so phan tu cua mang: ");
                int n = int.Parse(Console.ReadLine());
                int[] arrayNumber = new int[n];
                System.Console.WriteLine("moi ban nhap cac phan tu: ");
                for(int i =0;i<n;i++)
                {
                    arrayNumber[i] = int.Parse(Console.ReadLine());
                }
                foreach (var item in arrayNumber)
                {
                    System.Console.Write(item+" ");
                }
                bool result = true;
                for(int i =0;i<(n-1);i++)
                {
                    
                    if(arrayNumber[i+1]-arrayNumber[i]==1 || arrayNumber[i+1]-arrayNumber[i]== -1)
                    {}
                    else 
                    {
                        result = false;
                        break;
                    }
                    
                }
                System.Console.WriteLine();
                if(result)
                    System.Console.WriteLine("Yes. This is a consecutive array of numbers");
                else
                    System.Console.WriteLine("No. This is not a consecutive array of numbers");   
            }
            catch (Exception ex)
            {
            
                System.Console.WriteLine(ex.Message);
            }
            
        }

        // bai 2: 
    }
}
