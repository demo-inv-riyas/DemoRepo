using System;
using trial.Model;

namespace trial
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.WriteLine("Riyas World!");
            Console.WriteLine("Riyas Final commit for history review!");
            Console.WriteLine("sudeep commit for history review!");
            SumofTwoNumber sumofTwoNumber = new SumofTwoNumber();
            sumofTwoNumber
                .AddTwoNumbers(2, 5)
                .AddTwoNumbers(5, 8).AddTwoNumbers(1, 1);
            Console.WriteLine(sumofTwoNumber.ToString());
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

    }

    public class SumofTwoNumber
    {
        SumValueModel sumValueModel = new SumValueModel();
        public SumofTwoNumber()
        {

        }
        public SumofTwoNumber AddTwoNumbers(double a, double b)
        {
            sumValueModel.FirstNumber = a;
            sumValueModel.SecondNumber = b;
            return this;
        }
        public override string ToString()
        {
            return sumValueModel.ToString();
        }
    }

}
