using System;


namespace ShippngQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below. Press Enter to start.");
            Console.ReadLine();

            Console.WriteLine("Please enter how many pounds the package weighs");
            string weight = Console.ReadLine();
            int packageWeight = Convert.ToInt32(weight);
           

            if (packageWeight > 50)
                Console.WriteLine("Sorry. This Package is too heavy to be shipped. Have a great day");
            else 
            {
            Console.WriteLine("Please enter Width");
            string width = Console.ReadLine();
            int packageWidth = Convert.ToInt32(width);
            Console.WriteLine("Please enter the height");
            string height = Console.ReadLine();
            int packageheight = Convert.ToInt32(height);
            Console.WriteLine("Please enter the length");
            string length = Console.ReadLine();
            int packageLength = Convert.ToInt32(length);
               
            int total = packageWidth + packageLength + packageheight;
                

             if (total > 50) 
            Console.WriteLine("Sorry. This package is too big to be shipped. Have a great day");
               
            else
             {
            Console.WriteLine("Press Enter to see your quote");
            Console.ReadLine();
            Console.WriteLine(total * packageWeight / 100);
            Console.ReadLine();
             }              
            }
              
        }
    }
}
