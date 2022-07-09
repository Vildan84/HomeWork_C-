Console.Write("Enter first number: ");
int number_one = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int number_two = Convert.ToInt32(Console.ReadLine());

int max = 0;
int min = 0;

if(number_one > number_two)
{
    max = number_one;
    Console.WriteLine("Max number: " + max);
    min = number_two;
    Console.WriteLine("Min number: " + min);
}
else if(number_one < number_two)
{
    max = number_two;
    Console.WriteLine("Max number: " + max);
    min = number_one;
    Console.WriteLine("Min number: " + min);
}
else if(number_one == number_two)
{
    Console.WriteLine("Equal numbers");
}
else
{
    Console.WriteLine("Please enter correct numbers");
}