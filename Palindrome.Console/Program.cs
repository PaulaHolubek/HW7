using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {

        static void getStringReversed(char[] charArr) => Array.Reverse(charArr);  //method that reverses the letters of the word the user entered

        static void Main(string[] args)
        {
            try
            {
                while (true) // Continue the game until the user does want to anymore...
                {
                    Console.WriteLine();
                    Console.Write("Enter text to see if it’s a palindrome:");
                    string sentence = Console.ReadLine();
                    char[] charArr = sentence.ToCharArray();
                    getStringReversed(charArr); //calls function to reverse letters of the word user entered
                    foreach (char ch in charArr)
                    {
                        Console.WriteLine(ch);
                        Console.WriteLine();
                    }
                    //Console.WriteLine(charArr);

                        while (true) 
                        {
                            Console.Write("Do you want to play again [Yes/Exit]?");

                            string answer = Console.ReadLine().ToUpper();
                            if (answer == "YES")
                                break; // Exit the inner while-loop and continue in the outer while loop.
                            if (answer == "EXIT")
                                return; // Exit the Main-method.
                        }
                }
            }

            catch (IndexOutOfRangeException IOREx)
            {
                Console.WriteLine("Index Out of Range Exception Caught!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Exception Thrown " + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}




