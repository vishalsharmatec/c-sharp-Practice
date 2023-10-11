using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new List<string>();
         {
         
             student.Add("raman");
             student.Add("ankur");

            foreach(var sname in student)
            {
                Console.WriteLine(sname);

            }
            Console.ReadLine();
              

         }
        }
    }
}
