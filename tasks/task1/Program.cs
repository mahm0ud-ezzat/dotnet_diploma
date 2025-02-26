namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Estimate for carpet cleaning service");
            Console.Write("Number of small carpets: ");
            int numOfS =Convert.ToInt32( Console.ReadLine());
            Console.Write("Number of large carpets: ");
            int numOfl = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Price per small room: $25\r\nPrice per large room: $35");
            long cost = (numOfS * 25) + (numOfl * 35);
            float tax = cost * 0.06f ;  
            Console.WriteLine($"Cost : {cost:C}");
            Console.WriteLine($"Tax : {tax:C}");
            Console.WriteLine("==============================================");
            Console.WriteLine($"Total estimate: {cost + tax:C}");
            Console.WriteLine("This estimate is valid for 30 days");
            



        }
    }
}
