using System;

namespace Hello
{
    class Program
    {
        static void great(string name)
        {
            Console.WriteLine("good morning" +name);
        }
        static float Average(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum / 3;
        }
        static float Average(int a, int b)
        {
            return (a + b) / 2;
        }
        static void Main(string[] args)
        {

            //string imp = Console.ReadLine();
            // Console.WriteLine(imp);
            // int harry = 44;
            // Console.WriteLine("Hello World!");
            // Console.WriteLine("i love c#" + harry);
            /*
            int a = 34;
            float b = 34.4f;
            double c = 34.4d;
            bool isGreat = true;
            char d = 'r';
            string  e = "this is a string";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(isGreat);
            Console.WriteLine(d);
            Console.WriteLine(e);
            */
            // type casting
            // int x = (int)3.5;
            // Console.WriteLine(x);
            /*
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("hey hello " + name);
            Console.WriteLine("How many candies do you  want?");
            string can = Console.ReadLine();
            Console.WriteLine("you will get 4 more candies: " +
                (Convert.ToInt32(can) + 4));
            */
            // arithematic operator
            /*  int a = 2;
              int b = 4;
              Console.WriteLine("thevalue of a + b is: " + (a + b));
              Console.WriteLine("thevalue of a - b is: " + (a - b));
              Console.WriteLine("thevalue of a * b is: " + (a * b));
              Console.WriteLine("thevalue of a / b is: " + (a / b));
  */
            // assignment operator
            //  int a = 4;
            // int b = a;
            //b += 4;
            //b -= 4;
            // b *= 4;
            // b   /=4;
            //Console.WriteLine(b);
            // logical operator
            /*       Console.WriteLine(true && false);
                   Console.WriteLine(true && true);
                   Console.WriteLine(false && true);
       */
            /* Console.WriteLine(true || false);
             Console.WriteLine(true || true);
             Console.WriteLine(false || true);*/
            /*     Console.WriteLine(!false);
                 Console.WriteLine(!true);*/
            // comarision operator
            /* Console.WriteLine(333 > 55);*/
            /*    int a = Math.Max(32, 333);*/


            /*   double a = Math.Abs(36);
               Console.WriteLine(a);*/
            /* string name = Console.ReadLine();
             string candies = Console.ReadLine();
             Console.WriteLine($"your name is {name}.you will get{candies}  candies");*/

            /*string hello = "hello world this is harry";
            *//*   Console.WriteLine(hello[1]);*//*
            Console.WriteLine(hello.IndexOf("is"));
            Console.WriteLine(hello.Substring(1));
            Console.WriteLine("hello");*/
            /*Console.WriteLine("Enter your age");
            string agestr = Console.ReadLine();
            int age = Convert.ToInt32(agestr);
            bool isBanned = true;


            if(age<2 || isBanned)
            {
                Console.WriteLine("you are just born or banned");

            }
            else if(age<10 || isBanned)
            {
                Console.WriteLine("please finish your high school or may be banned");
            }
            else if(age <18)
            {
                Console.WriteLine("you are below 18");
                
            }
            else if(age <75)
            {
                Console.WriteLine("you can drive");
            }
            else
         *//*   {
                Console.WriteLine("you cannot drive");
            }
*//*
            int age = 78;
            switch (age)
            {
                case 18:
                    Console.WriteLine("please wait for an year");
                    break;

                case 20:
                    Console.WriteLine("you are 20");
                    break;

                default:
                    Console.WriteLine("enjoy");
                    break;
            }*/
            // loops


            //while loop
            /*  int i = 0;
              while(i<5)
              {
                  Console.WriteLine(i);
                  i++;
              }*/
            // do while

            /*int i = 0;

            do
            {
                Console.WriteLine(i + 1);
                i++;
            } while (i < 5000);
            */
            /*for(int i =1; i<5; i++)
            {
                if(i ==1)
                {
                    continue;
                }
                Console.WriteLine(i + 1);
               // break;
            }*/
            /*  great("harry");
              great("rohan");
              Console.WriteLine(Average(2,4,5));
              float temp = Average(9, 3,7);
              Console.WriteLine(Average(2, 4));
              Console.WriteLine(temp);*/
            Player tommy = new Player();
            Console.WriteLine(tommy.health);
            tommy.sethealth(57);
            Console.WriteLine(tommy.health);

            Console.ReadLine();

        }
    }
}
