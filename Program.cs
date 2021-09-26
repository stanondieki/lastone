using System;

namespace lastone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ONE LAST PROJECT SYSTEM");
            Console.WriteLine("Hello user, Welcome to our new system!");
            Console.WriteLine("Once prompted to fill in your details Please do so!");
            {
                Console.WriteLine("Are you beyond 18(Yes/No)");
                var response=Console.ReadLine();
                Console.WriteLine( "Enter your age");
                var age=Console.ReadLine();
                Console.WriteLine("Enter your first name please!");
                var Fname=Console.ReadLine();
                Console.WriteLine("Enter your second name please");
                var Sname=Console.ReadLine();

                var Age=int.Parse(age);
            }
            Console.WriteLine("Are you a Kenyan(True/False)");
            var ans=Console.ReadLine(); 
            if(ans=="true")
            {
                Console.WriteLine("Enter the name of your county");
                var county=Console.ReadLine();
            }
            Console.WriteLine("Type the number of your best day in a week in the 7 days(1,2,3,...7)");
            var number=Console.ReadLine(); 
            
            if(number=="1")
            {
                Console.WriteLine("Monday");
                Console.WriteLine("Your best day is: Monday");
            }
            if(number=="2")
            {
                Console.WriteLine("Tuesday");
                Console.WriteLine("Your best day is: Tuesday");
            }
            if(number=="3")
            {
                Console.WriteLine("Wednesday");
                Console.WriteLine("Your best day is: Wednesday");
            }
            if(number=="4")
            {
                Console.WriteLine("Thursday");
                Console.WriteLine("Your best day is: Thursday");
            }
            if(number=="5")
            {
                Console.WriteLine("Friday");
                Console.WriteLine("Your best day: Friday");
            }
            if(number=="6")
            {
                Console.WriteLine("Saturday");
                Console.WriteLine("Your best day is: Saturday");
            }
            if(number=="7")
            {
                Console.WriteLine("Sunday");
                Console.WriteLine("Your best day is: Sunday");
            }
        }
    }
}
