using System.Security.Principal;
using System.Xml.Linq;

namespace task3
{
    internal class Program
    {


        static void DisplayOptions()
        {
            Console.WriteLine("\n---Main Menu--------------------------------------");
            Console.WriteLine("| P - Print numbers                              |");
            Console.WriteLine("| A - Add number                                 |");
            Console.WriteLine("| SUM - Sum of numbers                           |");
            Console.WriteLine("| M - Display mean of numbers                    |");
            Console.WriteLine("| S - Display the smallest number                |");
            Console.WriteLine("| L - Display the largest number                 |");
            Console.WriteLine("| F - Find a number                              |");
            Console.WriteLine("| C - Clear the whole list                       |");
            Console.WriteLine("| SOA - Sort elements ascending                  |");
            Console.WriteLine("| MED - Find the median of the list              |");
            Console.WriteLine("| REV - Reverse the list                         |");
            Console.WriteLine("| DUP - Remove duplicate numbers                 |");
            Console.WriteLine("| PS - Print special numbers                     |");
            Console.WriteLine("| CNT - Count special elements in the list       |");
            Console.WriteLine("| REM - Remove a specific number                 |");
            Console.WriteLine("| MUL - Multiply all numbers by a constant       |");
            Console.WriteLine("| Q - Quit                                       |");
            Console.WriteLine("--------------------------------------------------");
        }


        // iam trying to make them more generic for all int lists


        //nethod that  doesnot take a pramter  and return a string optian
        static string ReadOptions()
        {
            string optioan = Console.ReadLine() ?? "";
            optioan = optioan.ToUpper();
            return optioan;
        }
        static void PrintList(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("[ ] - the list is empty ");
            }
            else
            {
                Console.Write("[");
                for (int i = 0; i < list.Count; ++i)
                {
                    Console.Write($" {list[i]}");
                }
                Console.Write(" ]");
            }

        }
        static void Add(List<int> list)
        {
            int value;
            Console.Write("enter number to add  : ");
            value = Convert.ToInt32(Console.ReadLine());
            list.Add(value);
            Console.WriteLine($"{value} added");

        }
        static long SumOfList(List<int> list)
        {
            long sum = 0;
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("the list is empty :| \n");
                return 0;
            }
            for (int i = 0; i < list.Count; ++i)
            {
                sum += list[i];
            }
            return sum;

        }
        static void ClearList(List<int> list)
        {
            list.Clear();
            Console.WriteLine("list cleared");

        }
        //method tahat calc mean of the list  element and returned -1 if list empty
        static double CalcMean(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Unable to calculate the mean - no data ");
                return -1;
            }

            return (SumOfList(list) / (double)list.Count);

        }
        // datatype? i searched about it , it called nullable datatype that can accept in addtion to int values it can accept null 
        //which is useful here to handle if list is empty
        //i think in int.maxvalue but if all elments are int .maxvalue it can't handle this logic
        // we can handle it in the function but it will be very specifc or just  print it not return the value 
        // this method return the smallest element in the list if the list empty it return null  
        //waiting feedback :)
        static int? Smallest(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Unable to determine the smallest number - list is empty");
                return null;
            }
            int smallest = list[0];
            for (int i = 1; i < list.Count; ++i)
            {
                if (list[i] < smallest)
                {
                    smallest = list[i];
                }
            }
            return smallest;
        }
        static int? largest(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Unable to determine the largest number - list is empty");
                return null;
            }
            int largest = list[0];
            for (int i = 1; i < list.Count; ++i)
            {
                if (list[i] > largest)
                {
                    largest = list[i];
                }
            }
            return largest;

        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        // function to sort elements in the array using buble sort algorthm 

        static void SortList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;

                    }
                }
            }
        }
        // find the first occurance of any value 
        static int? FindVal(List<int> list, int key)
        {
            if (list == null || list.Count == 0)
            {
                return null;

            }
            int idx = -1;
            for (int i = 0; i < list.Count; ++i)
            {
                if (key == list[i])
                {
                    idx = i;
                    return idx;
                }
            }
            return -1; 
           

        }
        static int? Median(List<int> list)
        {
            List<int> sortedList = new List<int>(list);
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("the lis is empty");
                return null;
            }
            SortList(sortedList);
            int n = sortedList.Count / 2;
            if (list.Count % 2 == 0)
            {
                return (sortedList[n] + sortedList[n - 1]) / 2;
            }
            else
            {
                return sortedList[n];

            }

        }
        static void ReverseList(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("the list is empty");
                return;
            }
            int start = 0, end = list.Count -1 ;
            while(start < end)
            {
                int temp = list[start];
                list[start] = list[end];
                list[end] = temp;
                end--;
                start++; 
            }
            Console.WriteLine("list reversed");
        }
        // here i will remove duplicates fromthe acual list 
        // we can clone it and just print it without duplicates
        static void RemoveDuplicates(List<int> list)
        {
            if (list == null ||list.Count == 0)
            {
                Console.WriteLine("the list is empty");
                return ;
            }
            for (int i =0;i<list.Count;i++)
            {
                for(int j =i+1;j<list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        list.RemoveAt(j);
                        --j;
                    }
                }
            }
            Console.WriteLine("Duplicates removed");

        }
        // function that print list witout duplication with no change in the orginal list
        static void PrintSpeciaNumbers(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("the list is empty");
                return ;
            }
            List <int> speciaList = new List<int>(list);
            RemoveDuplicates(speciaList);
            PrintList(speciaList);

        }
        static int CountSpecialNumbers(List<int> list)
        {
            if(list == null || list.Count == 0)
            {
                Console.WriteLine("the list is empty\n");
                return 0; 
            }
            List<int> speciaList = new List<int>(list);
            RemoveDuplicates(speciaList);
            return speciaList.Count; 

        }
        static void MultiplyNumbers(List<int> list , int factor)
        {
            for (int i = 0; i < list.Count ; i++)
            {
                list[i] *= factor;
                
            }

        }
        //remove at specific number with duplcates
        //the other two cases first oocurance and at specific index are built in maybe this also :)
        static void RemoveNumber(List<int> list ,int value)
        {
            for (int i = 0 ; i < list.Count; i++)
            {
                if (list[i] == value)
                {
                    list.RemoveAt(i);
                    --i;
                }
            }


        }
        static void Main(string[] args)
        {
            List<int> konafaBilBastasho = new List<int>();
            string op;

            do
            {
                DisplayOptions();
                op = ReadOptions();
                switch (op)
                {
                    case "P":
                        PrintList(konafaBilBastasho);
                        break;

                    case "A":
                        Add(konafaBilBastasho);
                        break;

                    case "SUM":
                        Console.WriteLine($"Sum of list elements : {SumOfList(konafaBilBastasho)}");
                        break;

                    case "M":

                        if (CalcMean(konafaBilBastasho) == -1)
                        {

                            break;
                        }
                        Console.WriteLine($"mean : {CalcMean(konafaBilBastasho)}");
                        break;

                    case "S":

                        if (Smallest(konafaBilBastasho) == null)
                        {
                            break;
                        }
                        Console.WriteLine($"The smallest number is : {Smallest(konafaBilBastasho)}");

                        break;

                    case "L":

                        if (largest(konafaBilBastasho) == null)
                        {
                            break;
                        }
                        Console.WriteLine($"The smallest number is : {largest(konafaBilBastasho)}");
                        if (Median(konafaBilBastasho) == null)
                        {

                            break;
                        }
                        Console.WriteLine($"mean : {CalcMean(konafaBilBastasho)}");
                        break;

                    case "F":
                        Console.WriteLine("enter value that you want to search about ");
                        int fval = Convert.ToInt32(Console.ReadLine());

                        if (FindVal(konafaBilBastasho, fval) == null)
                        {
                            Console.WriteLine(" the list is empty :/ ");
                            break;
                        }

                        else if (FindVal(konafaBilBastasho, fval) != -1)
                        {
                            Console.WriteLine($"the {fval} found at index {FindVal(konafaBilBastasho, fval)}");
                        }
                        else
                        {
                            Console.WriteLine($"the {fval} not found in the list  ");
                        }

                        break;

                    case "C":
                        ClearList(konafaBilBastasho);
                        break;

                    case "SOA":
                        SortList(konafaBilBastasho);
                        break;
                    case "MED":
                        if (Median(konafaBilBastasho) == null)
                        {
                            break;
                        }

                        Console.WriteLine($"median : {Median(konafaBilBastasho)}");
                        break;
                    case "REV":
                        ReverseList(konafaBilBastasho);
                        break;
                    case "DUP":
                        RemoveDuplicates(konafaBilBastasho);
                        break;
                    case "PS":
                        PrintSpeciaNumbers(konafaBilBastasho);
                        break;
                    case "CNT":
                        Console.WriteLine($" the number of special numbers in the lis is {CountSpecialNumbers(konafaBilBastasho)}");                       
                        break;
                    case "REM":
                        Console.WriteLine("enetr the valu which will delted with her duplicates ");
                        int rVal = Convert.ToInt32(Console.ReadLine());
                        RemoveNumber(konafaBilBastasho,rVal);
                        break;
                    case "MUL":
                        Console.WriteLine("enter the factor you want to multiplay ");
                        int value = Convert.ToInt32(Console.ReadLine());
                        MultiplyNumbers(konafaBilBastasho , value);
                        break;

                    case "Q": Console.WriteLine("Goodbye"); break;
                    default: Console.WriteLine("Unknown selection, please try again"); break;
                }



            } while (op != "Q");
        }
    }
}
