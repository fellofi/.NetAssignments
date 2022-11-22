using System;
using System.Collections.Generic;
using System.Text;
using Assignment1;

namespace Assignment1
{

    //derived class
    class BSCstudent : Student    
    {
        Student student = new Student();

        // overriding classes
        public override void GetStudentdata()
        {
            base.GetStudentdata();
        }

      

        // getting subject marks 
        public int dbms, os, ds;

        public void Getbscmarks()
        {

            Console.WriteLine("Enter Database Management System marks :");
            dbms = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operating System marks :  ");
            os = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Data Structure marks : ");
            ds = Convert.ToInt32(Console.ReadLine());
           
        }       
       

        // calculating total & percentage
        public void Resultcalculation()
        {
            int totalmarks = Convert.ToInt32(dbms) + Convert.ToInt32(os) + Convert.ToInt32(ds);
            int maximum_marks = 300;
            double percentage = totalmarks * 100 / maximum_marks;

            Console.WriteLine("Your total is : " + Convert.ToInt32(totalmarks));

            Console.WriteLine("Your percentage is : " + Convert.ToInt32(percentage) + "%");


        }
    }
}
