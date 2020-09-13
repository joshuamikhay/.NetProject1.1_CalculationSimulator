using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2018326660145 Joshua Mikhay Kusuma
//Excercise 1.1
namespace _1._1
    //Create a simple Calculation Project
    //Input: 2 numbers, pick action, Output : Result
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" >>> Simple Calculation Project <<< \n" );
            double firstNumber = 0;
            double secondNumber = 0;
        startSimulation:
            try
            {
                Console.WriteLine("Please input the first Number : ");
                firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please input the second Number : " );
                secondNumber = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Input is Incorrect, Please try again! \n");
                goto startSimulation;
            }
            double result = 0;
            Console.WriteLine("Please select an operation to excecute :");
            Console.WriteLine("  1.Addition(+) \n  2.Substraction(-) \n  3.Multiplication(*) \n  4.Division(/) ");
            Console.WriteLine("Input Operation code Number (1-4) : ");
            string operationCode = Console.ReadLine();
            switch(operationCode)
            {
                case "1":
                    result = firstNumber+secondNumber; //addition
                    Console.WriteLine(firstNumber + " + " + secondNumber + " = " + result +"\n");
                    break;
                case "2":
                    result = firstNumber-secondNumber; //substraction
                    Console.WriteLine(firstNumber + " - " + secondNumber + " = " + result + "\n");
                    break;
                case "3":
                    result = firstNumber*secondNumber; //multiplication
                    Console.WriteLine(firstNumber + " * " + secondNumber + " = " + result + "\n");
                    break;
                case "4":
                    result = firstNumber / secondNumber; //division
                    Console.WriteLine(firstNumber + " / " + secondNumber + " = " + result + "\n");
                    break;
                default:
                    Console.WriteLine("The operation code is incorrect!");
                    break;
            }
            Console.WriteLine("Do you want to peform another operation ? (Y/N) ");
            string retry = Console.ReadLine();
            if ((retry == "Y") || (retry == "y"))
            {
                goto startSimulation;
            }
            else
                Console.WriteLine("Your Opeartion has sucesfully executed! \n");

        }
    }
}
