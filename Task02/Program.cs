Console.Write("Enter first number: ");
int number_one = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int number_two = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number: ");
int number_three = Convert.ToInt32(Console.ReadLine());

int max_number = number_one;

if(number_two > max_number)
{
    max_number = number_two ;
}
else if(number_three > max_number)
{
    max_number = number_three;
}
Console.WriteLine("Max number is: " + max_number);