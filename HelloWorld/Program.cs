// See https://aka.ms/new-console-template for more information
using HelloWorld;
using System;


namespace Helloworld
{

    class Program
    {
        static void Greet()
        {
            Console.WriteLine("Namaste");
        }


        static float average(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum / 3;
        }



        static void Main(string[] args)
        {
            //Single line Comment
            // Console.WriteLine("Hello, World!");

            //data types
            // int a = 12;
            // Console.WriteLine(a);

            // string abc = Console.ReadLine();
            // Console.WriteLine(abc);

            // float b = 12.12F;
            // bool isGreat = true;
            // Console.WriteLine(isGreat);

            /*
             * Multi Line Comment
             */

            //Type Casting

            //int t1 = (int)2.4;
            //Console.WriteLine(t1);

            //float var = 3.4F;
            //int ab = Convert.ToInt16(var);
            //Console.WriteLine(ab);

            //String concatination and with int variable
            //   Console.WriteLine("How Many Candies You Want");
            // string num = Console.ReadLine();
            //add () around Convert function to make priority so it will be operated first
            //  Console.WriteLine("You will get " +  (Convert.ToUInt32(num) + 4 + " Candies" ));

            //string functions
            /*

            string hello = "I am Kuldeep Naphri";
            Console.WriteLine(hello.Length);
            
            Console.WriteLine(hello + " and U");
            Console.WriteLine(string.Concat(hello, "By Concat Method"));

            */


            //String interpolation
            /*
           string name = Console.ReadLine();    
           string age = Console.ReadLine();
           Console.WriteLine($"Your Name is {name} and your age is {age}");
            */

            //Indexing 
            /*
            string hello = "I am Kuldeep";
           // Console.WriteLine(hello[0]);
           Console.WriteLine(hello.IndexOf("Kuldeep"));
           Console.WriteLine(hello.Substring(3,5));   // return new string 

            Console.WriteLine("I am Kuldeeo \" ");
            Console.WriteLine("I am Kuldeep \n ");
            */

            //if else
            /*
            int age = 45;
            if(age>18)
            {
                Console.WriteLine("You Can Drive");
            }
            else 
            {
                Console.WriteLine("You Cant");
            }

            */

            //switch case
            /*
            int age = 18;
            switch(age)
            {
                case 18:
                    Console.WriteLine("Please Wait");
                    break;
                case 20:
                    Console.WriteLine("You are 20");
                    break;
                    default: Console.WriteLine("Enjoy");
                    break;
                        }
            */

            //Loops 

            /*
            int i = 0;
            while(i<5)
            {
                Console.WriteLine(i);
                i++;
            }

            */


            /*
            int i = 0;
            do
            {
                Console.WriteLine(i + 1);
                i++;
            }while (i < 3);

            */

            /*

            for(int i = 0; i < 5; i++)
            {
                 if(i == 3)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            
            */


            // Greet();

            // Console.WriteLine(average(2, 3, 4));

            //INternal Class 

            Player abc= new Player();
            Console.WriteLine(abc.name);









        }
    }


}






