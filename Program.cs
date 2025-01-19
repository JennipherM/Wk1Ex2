using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk1Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?"); //prints question
            string firstName = Console.ReadLine(); //receives input and assigns it as firstName
            Console.WriteLine("What is your last name?"); //prints question
            string lastName = Console.ReadLine(); //receives input and assigns it as lastName

            Console.WriteLine("What is your age?"); //prints question
            int age = Convert.ToInt16(Console.ReadLine()); //receives input, assigns it as age, and converts input to an int type
            Console.WriteLine("What is your favorite color?"); //prints question
            string color = Console.ReadLine(); //receives input and assigns it as color

            Console.WriteLine("Hello, " +firstName+ " " +lastName+ "! You are " +age+ " years old and your favorite color is " +color+ "."); //prints phrase with inputted information
        }
    }
}
