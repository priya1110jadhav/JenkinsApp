using System;
using MyMaths;
namespace JenkinsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hey Priya");
           
            MyMath m = new MyMath();
            
            Console.WriteLine("Addition" + m.Add(4, 5));
            Console.WriteLine("Multi" + m.mul(6, 7));
            Console.ReadLine();


        }
    }
}
