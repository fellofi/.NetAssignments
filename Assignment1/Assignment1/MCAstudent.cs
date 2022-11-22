using System;
using System.Collections.Generic;
using System.Text;
using Assignment1;

namespace Assignment1
{

    //derived class
    class MCAstudent : Student       
    {

        Student student = new Student();

        // overriding classes
        public override void GetStudentdata()
        {
            base.GetStudentdata();
        }

       

        // getting subject marks 
        public int advjava, aiml, blockchain;
       
        public void Getmcamarks()
        {
          
            Console.WriteLine("Enter Advanced Java marks :");
            advjava = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Artificial Intelligience marks :  ");
            aiml = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Blockchain marks : ");
            blockchain = Convert.ToInt32(Console.ReadLine());
           
        }




        // calculating total & percentage
        public void Resultcalculation()
        {
           
            int totalmarks = Convert.ToInt32(advjava) + Convert.ToInt32(aiml) + Convert.ToInt32(blockchain);
            int maximum_marks = 300;
            double percentage = totalmarks * 100 / maximum_marks;

            Console.WriteLine("Your total is : " + Convert.ToInt32(totalmarks));

            Console.WriteLine("Your percentage is : " + Convert.ToInt32(percentage) + "%");
        }
    }
}
