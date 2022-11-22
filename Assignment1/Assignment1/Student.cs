using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment1;

namespace Assignment1
{
    public class  Student  //parent class
    {
        public int id;
        public string name;
        public string university;

        //fetching student data 

        public virtual void GetStudentdata()
        {
            Console.WriteLine("Enter Student id : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student name : ");
            name = Console.ReadLine();             
            Console.WriteLine("Enter University name : ");
            university = Console.ReadLine();            
        }


        


    }
        

      

}
