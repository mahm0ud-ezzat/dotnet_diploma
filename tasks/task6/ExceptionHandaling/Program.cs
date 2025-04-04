using System;
using System.Collections.Generic;
namespace ExceptionHandling
{
    class DoesnotContainVowlsException : Exception
    {
        public DoesnotContainVowlsException(string message) : base(message)
        {

        }
    }

    class Program
{
    static void Main(string[] args)
    {
            #region Duplcate values
            try
            {
                List<int> l = new List<int>(10);
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("enter value ");
                    int val = Convert.ToInt32(Console.ReadLine());
                    if (l.Contains(val))
                    {
                        //Exception ex = new InvalidOperationException() ;
                        //throw ex; 
                        throw new InvalidOperationException();
                        //InvalidOperationException  n C# happens when you try to perform an operation that is not allowed in the current state of an object.
                    }

                    l.Add(val);
                }
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("please enter vaild values");
            }

            catch (Exception ex) // like add string or not vaild value cant casting to integer
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            #endregion

            string s;
           s= Console.ReadLine()??string.Empty;
            ContainingVowels(s);

        }
        public static bool ContainingVowels(string s)
        {
            try
            {
                string vowels = "aeiou";
                s = s.ToLower();

                foreach (char c in s)
                {
                    if (vowels.Contains(c))
                    {
                        Console.WriteLine("no exceptions");
                        return true;
                    }
                }
                throw new DoesnotContainVowlsException("The string does not contain vowels");
            }
            catch (DoesnotContainVowlsException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

    }
}

