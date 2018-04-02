using System;
using UOW.Consumer.Repository;

namespace UOW.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var context = new DatabaseContext())
            {

                
            }
        }
    }
}
