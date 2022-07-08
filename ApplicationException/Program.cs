using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ApplicationExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter number");
                int a = int.Parse(Console.ReadLine());
                if (a==5)
                {
                    throw new ApplicationException();
                }
            }
            catch (ApplicationException e)
            {
                Console.WriteLine(e.Message);
               
            }
            Console.ReadLine(); 
        }
    }
}
