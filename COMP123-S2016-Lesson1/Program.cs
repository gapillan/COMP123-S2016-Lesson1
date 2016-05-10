using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Call the Hellow world to Console Method 
            HelloWorldToConsole();
        }

       
        public static string HelloWorldToConsole() 
        { 
          //* @description This is my Hello World Method @method HelloWorldToConsole @return (string) HelloWorldString //
            string HelloWorldString = "Hello, World!";
            Console.WriteLine(HelloWorldString);
            return HelloWorldString; 
        }
    }
}
