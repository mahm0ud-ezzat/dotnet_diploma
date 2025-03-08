
namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lo3a = new List<int>();
            string optioan = "";
            do
            {
                Console.WriteLine("");
                Console.WriteLine("---Main Menu--------------------------------------");
                Console.WriteLine("| P - Print numbers                              |");
                Console.WriteLine("| A - Add number                                 |");
                Console.WriteLine("| SUM - Add number                               |");
                Console.WriteLine("| M - Display mean of numbers                    |");
                Console.WriteLine("| S - Displaythe smallest number                 |");
                Console.WriteLine("| L - Displaythe largest number                  |");
                Console.WriteLine("| F - Find a number                              |");
                Console.WriteLine("| C - Clear the whole list                       |");
                Console.WriteLine("| SOA - Sort elemnets accending                  |");
                Console.WriteLine("| C - Clear the whole list                       |");
                Console.WriteLine("| Q - quit                                       |");
                Console.WriteLine("--------------------------------------------------");
                optioan = Console.ReadLine() ?? ""; // i searched about this because it give me warning 
                /*Console.ReadLine() can return null if the user simply presses Enter without typing anything.
                    ?? is the null-coalescing operator.
                    If Console.ReadLine() returns a non-null value, that value is assigned to optioan.
                    If Console.ReadLine() returns null, the right-hand side ("", an empty string) is assigned instead.
                 */
                optioan = optioan.ToUpper();

                // iam trying to make it moduler :\



                switch (optioan)
                {
                    case "P":
                        if (lo3a.Count == 0)
                        {
                            Console.WriteLine("[ ] - the list is empty ");
                        }
                        else
                        {
                            Console.Write("[");
                            for (int i = 0; i < lo3a.Count; ++i)
                            {
                                Console.Write($" {lo3a[i]}");
                            }
                            Console.Write(" ]");
                        }
                        break;

                    case "A":
                        int value;
                        Console.Write("enter number to add  : ");
                        value = Convert.ToInt32(Console.ReadLine());
                        lo3a.Add(value);
                        Console.WriteLine($"{value} added");
                        break;

                    case "M":

                        if (lo3a.Count == 0)
                        {
                            Console.WriteLine("Unable to calculate the mean - no data ");
                            break;
                        }

                        int asum = 0;
                        for (int i = 0; i < lo3a.Count; ++i)
                        {
                            asum += lo3a[i];
                        }
                        double mean = (double)asum / lo3a.Count;
                        Console.WriteLine($"mean : {mean}");
                        break;

                    case "S":
                        if (lo3a.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
                            break;
                        }

                        int smallest = lo3a[0];
                        for (int i = 1; i < lo3a.Count; ++i)
                        {
                            if (lo3a[i] < smallest)
                            {
                                smallest = lo3a[i];
                            }
                        }
                        Console.WriteLine($"The smallest number is : {smallest} ");

                        break;

                    case "L":
                        if (lo3a.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the largest number - list is empty");
                            break;
                        }
                        int largest = lo3a[0];
                        for (int i = 1; i < lo3a.Count; ++i)
                        {
                            if (lo3a[i] > largest)
                            {
                                largest = lo3a[i];
                            }
                        }
                        Console.WriteLine($"the largest value  in the list is : {largest} ");

                        break;

                    case "F":
                        if (lo3a.Count == 0)
                        {
                            Console.WriteLine(" the list is empty :/ ");
                            break ;
                        }

                        Console.WriteLine("enter value that you want to search about ");
                        //first occurance of fval 
                        int idx = -1;
                        int fval = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < lo3a.Count; ++i)
                        {
                            if(fval == lo3a[i])
                            {
                                idx = i; 


                            }
                        }
                        if (idx != -1)
                        {
                            Console.WriteLine($"the {fval} found at index {idx}");
                        }
                        else
                        { 
                            Console.WriteLine($"the {fval} not found in the list  ");
                        }
                        break;

                    case "C":
                        lo3a.Clear();
                        Console.WriteLine("list cleared");

                        break;

                    case "SOA":
                        for (int i = 0; i < lo3a.Count; i++)
                        {
                            for (int j = 0; j < lo3a.Count - i - 1; j++)
                            {
                                if (lo3a[j] > lo3a[j + 1])
                                {
                                    
                                    int temp = lo3a[j];
                                    lo3a[j] = lo3a[j + 1];
                                    lo3a[j + 1] = temp;
                                }
                            }
                        }
                                break;
                    case "SUM":
                        if (lo3a.Count == 0)
                        {
                            Console.WriteLine(" the list is empty :| ");
                            break;
                        }
                        double sum = 0;
                        for (int i = 0; i < lo3a.Count; ++i)
                        {
                            sum += lo3a[i];
                        }
                        Console.WriteLine($"Sum of list elements : {sum}");
                        break;
                    

                    case "Q":
                        Console.WriteLine("Goodbye");
                        break;

                    default:
                        Console.WriteLine("Unknown selection, please try again");
                        break;
                }

            }
            while (optioan != "Q");
        }
    }
}
