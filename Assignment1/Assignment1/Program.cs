using System;
using Assignment1;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.GetStudentdata();

            
            MCAstudent m1 = new MCAstudent();
           

            BSCstudent b1 = new BSCstudent();
           


            Console.WriteLine("Enter your stream :");
            string stream = Console.ReadLine();

            if (stream == "MCA") 
            {
                m1.Getmcamarks();
                m1.Resultcalculation();
            }
                   
            else if (stream == "BSC")
            {
                b1.Getbscmarks();
                b1.Resultcalculation();
            }

            else
            {
                Console.WriteLine("Stream does not exist!");
            }


            






        }
    }
}
