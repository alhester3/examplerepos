
const double SWEATSHIRT_COST = 25.99;
const double PERSONALIZATION_COST = 4.00;
const double TRANSACTION_FEE = 0.30;
const double SHIPPING_COST = 6.20;

System.Console.WriteLine("How many sweatshirts would you like?");
int numberOfSweatshirts = int.Parse(Console.ReadLine());

System.Console.WriteLine("How many personalizations would you like?");
int personalizations = int.Parse(Console.ReadLine());

double totalSweatShirtCost = (SWEATSHIRT_COST*numberOfSweatshirts);
double totalPersonalizationCost = (PERSONALIZATION_COST*personalizations);

double totalOrderCost = (totalSweatShirtCost + totalPersonalizationCost + (TRANSACTION_FEE * numberOfSweatshirts) + SHIPPING_COST);

System.Console.WriteLine("Your total order cost is "+ totalOrderCost);