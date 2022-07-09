Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int tag = 1;

while(tag <= number)
{
    if(tag % 2 == 0)
    {
        Console.WriteLine(tag);
    }
    tag += 1;
}