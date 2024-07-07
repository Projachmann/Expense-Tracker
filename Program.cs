namespace Expense_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double expense = 0;
            Console.WriteLine("Welcome to the Expense Tracker!");
            FirstQuestion();

            while (input != "calc")
            {
                Console.WriteLine("Do you want to add an expense, an income or calculate expenses?\n(Please write \"add ex\" for adding an expense, \"add in\" for adding an income or \"calc\" for calculating the expenses)");
                input = Console.ReadLine();
                Switch(input);
            }

            void FirstQuestion()
            {
                Console.WriteLine("Do you want to add an expense or an income?\n(Please write \"add ex\" for adding an expense or \"add in\" for adding an income)");
                input = Console.ReadLine();
                Switch(input);
            }

            void Switch(string input)
            {
                switch (input)
                {
                    case "add ex":
                        AddingExpense();
                        break;
                    case "add in":
                        AddingIncome();
                        break;
                    case "calc":
                        if (expense > 0)
                        {
                            Console.WriteLine($"You have {expense} left over. Put them in some index fund like S&P 500!");
                        }
                        else if (expense < 0)
                        {
                            Console.WriteLine($"You are {-expense} in debt. Work harder!");
                        }
                        else
                        {
                            Console.WriteLine("You do not have anything left over neither are you in debt. Not the best but also not the worst.");
                        }
                        break;
                    default:
                        Console.WriteLine("Please write \"add ex\" for adding an expense, \"add in\" for adding an income or \"calc\" for calculating the expenses.");
                        break;
                }
            }

            void AddingExpense()
            {
                Console.WriteLine("How much did you spend?");
                expense -= Convert.ToDouble(Console.ReadLine());
            }

            void AddingIncome()
            {
                Console.WriteLine("How much did you earn?");
                expense += Convert.ToDouble(Console.ReadLine());
            }
        }
    }
}
