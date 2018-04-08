using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick an age: ");
            int ageGuess = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = false;
            
            while (!isGuessed)
            {
                switch(ageGuess)
                {
                    case 19:
                        Console.WriteLine("Sorry you're not old enought to drink yet!");
                        Console.WriteLine("Pick an age: ");
                        ageGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 21:
                        Console.WriteLine("Wooo! You're legal - time for shots!");
                        isGuessed = true;
                        break;
                    case 50:
                        Console.WriteLine("Half a century, major props.");
                        isGuessed = true;
                        break;
                    case 56:
                        Console.WriteLine("56! You're the same age as Jim Carrey - tell us a joke!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Hmm...that number isn't very interesting. Try again.");
                        Console.WriteLine("Pick an age: ");
                        ageGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.Read();
        }
    }
}
