int a = InputData("Input side a: ");
int b = InputData("Input side b: ");
int c = InputData("Input side c: ");
int min1 = a;
int min2 = b;
int max = c;

if(a == b && b == c && a == c)
{
    Console.Write("Yes, with that sides is possible an equilateral triangle");   
}
else
{
    if(a >= b && a >= c)
    {
        max = a;
        min1 = b;
        min2 = c;
    }    
    if(b >= a && b >= c)
    {
        max = b;
        min1 = a;
        min2 = c;
    }

    if(max < min1 + min2)
    {
        Console.Write("Yes, triangle is possible");
    }
    else
    {
        Console.Write("No, triangle is impossible");
    }
}


int InputData(string output)
{
    Console.Write(output);
    int inpData = Convert.ToInt32(Console.ReadLine());
    return inpData;
}