const int smallPrice = 25;
const int largePrice = 35;
const double taxNum = 0.06;
const int days = 30;

Console.WriteLine("Welcome to our Carpet Cleaning Service\n");
Console.WriteLine("***********INFORMATION***********");
Console.WriteLine("Charges: ");
Console.WriteLine("* 25$ per small\n* 35$ per large  ");
Console.WriteLine("* Sales tax is 6% of the total cost\n");

Console.Write("Do you want to get a carpet cleaning estimate? \n-Enter 1 for yes, 2 for no: ");
int answer = Convert.ToInt32(Console.ReadLine());

switch (answer)
{
    case 1:
    {
            Console.Write("\nEnter the number of small carpets: ");
            int smallNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of large carpets: ");
            int largeNum = Convert.ToInt32(Console.ReadLine());

            int smallCost = smallPrice * smallNum;
            int largeCost = largePrice * largeNum;

            int cost = smallCost + largeCost;

            double tax = cost * taxNum;

            double total = tax + cost;

            Console.WriteLine("\n \t -Estimate for carpet cleaning service-\t \n");

            Console.WriteLine($"Number of small carpets: {smallNum} ");
            Console.WriteLine($"Number of large carpets: {largeNum} ");

            Console.WriteLine($"Cost: {cost}$");
            Console.WriteLine($"Tax: {tax}$");

            Console.WriteLine("=======================================");

            Console.WriteLine($"Total estimate: {total}$");
            Console.WriteLine($"This estimate is valid for {days} days.");

            Console.WriteLine("\nThanks for your time.");

            break;
    }
    case 2:
        {
            Console.WriteLine("\nThanks! Have a nice day.");

            break;
        }
    default:
        {
            Console.WriteLine("\nInvalid choice,try again please! ");

            break;
        }
}

Console.ReadKey();









