using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){


                // variables representing interest rates
                double annualInterestRate = 0.0;    // annual rate
                double monthlyInterestRate = 0.0;   // monthly rate

                // other variables
                int numberOfYears = 0;      // number of years for loan
                int numPayments = 0;        // total number of payments
                double loanAmount = 0.0;    // loan amount

                // setting initial values (we will later replace some of these with input statements)
                Console.Write("Enter the yearly interest rate as a percentage (no % sign): ");
                String inputValue = Console.ReadLine();
                annualInterestRate = double.Parse(inputValue) / 100;
                monthlyInterestRate = annualInterestRate / 12;
                Console.Write("Enter the loan term in years: ");
                inputValue = Console.ReadLine();
                numberOfYears = int.Parse(inputValue);
                numPayments = numberOfYears * 12;
                Console.Write("Enter the loan amount in dollars (no $ sign): ");
                inputValue = Console.ReadLine();


                // calculate the monthly payment
                double monthlyPayment = (monthlyInterestRate + (monthlyInterestRate
                        / (Math.Pow(1 + monthlyInterestRate, numPayments) - 1))) * loanAmount;

                // format payment to the nearest dollar
                int formattedPaymentAmount = (int)(monthlyPayment * 100);
                monthlyPayment = (double)formattedPaymentAmount / 100;

                // display monthly payment
                Console.Write("Monthly Payment: " + monthlyPayment + "\nTotal Interest Paid: " + ((monthlyPayment * numberOfYears * 12) - loanAmount));
                Console.WriteLine("\n\n\n");
            }

        }
    }
}
