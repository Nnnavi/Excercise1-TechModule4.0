using System;
using System.Reflection.Metadata.Ecma335;

namespace _2.Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool div2 = false;
            bool div3 = false;
            bool div6= false;
            bool div7=false;
            bool div10 = false;

            if (number%2==0)
            {
                div2 = true;
            }
            if (number%3==0)
            {
                div3 = true;
            }
            if (number%6==0)
            {
                div6 = true;
            }
            if (number%7==0)
            {
                div7 = true;
            }
            if (number%10==0)
            {
                div10 = true;
                Console.WriteLine("The number is divisible by 10");
                ;
            }

            if (div2 ==true && div3 ==true && div10==false)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (div7==true && div10==false)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (div2 == true && div6 == false && div10==false )
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else if (div3==true && div6==false && div10==false)
            {
                    Console.WriteLine("The number is divisible by 3");
            }
            else if (div2==false && div3 == false && div6== false && div7==false && div10 == false)
                {
                    Console.WriteLine("Not divisible");
                }
            
            
           

        }
    }
}
