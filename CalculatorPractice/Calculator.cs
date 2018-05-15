using System;
namespace CalculatorPractice
{
    public class Calculator
    {
		public string Name { get; set; }
		public double NumberOne { get; set; }
		public double NumberTwo { get; set; }
		public string Operator { get; set; }

        
        public string GetName()
		{
			Console.WriteLine("Hey! Welcome to the calculator!, Input your name");
			return Name = Console.ReadLine();
		}

		public void CalculatorGreeting()
		{
			Console.WriteLine("Hey, " + " " + Name + " " + "Hope you are well!");
		}


		public void Calculation()
		{
			while (true) 

			{  
             try
				{
					Console.WriteLine("Enter the first number: ");
                    NumberOne = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the second number: ");
                    NumberTwo = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Please enter an operator: (+) (-) (*) (/)  ");
                    Operator = Console.ReadLine();

                    if (Operator.Equals("+"))
                    {
                        Console.WriteLine("The Result is: " + (NumberOne + NumberTwo));
                    }
                    else if (Operator.Equals("-"))
                    {
                        Console.WriteLine("The Result is: " + (NumberOne - NumberTwo));
                    }
                    else if (Operator.Equals("*"))
                    {
                        Console.WriteLine("The Result is: " + (NumberOne * NumberTwo));
                    }
                    else if (Operator.Equals("/"))
                    {
                        Console.WriteLine("The Result is: " + (NumberOne / NumberTwo));
                    }
				}
				catch (FormatException)
				{
					Console.WriteLine("Invalid Input!!!");
				}
                
			}
            
		}
       
    }
}
