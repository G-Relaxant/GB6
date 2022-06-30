int countNumber = InputData("Input number: ");
PrintFibonachi(countNumber);



int InputData(string output)
{
    Console.Write(output);
    int inpData = Convert.ToInt32(Console.ReadLine());
    return inpData;
}

void PrintFibonachi(int a)
{
    int numPrev = 0;
    int numNext = 1;
    if(a < 1)
    {
        Console.Write("Incorrect number");
    }
    if(a == 1)
    {
        Console.Write("Fibonachi number: " + numPrev);
    }
    if(a == 2)
    {
        Console.Write("Fibonachi numbers: " + numPrev + ", " + numNext);
    }
    if(a > 2)
    {
        int numCurrent = numPrev + numNext;
        Console.Write("Fibonachi numbers: " + numPrev + ", " + numNext + ", ");
        for(int i = 2; i < a; i++)
        {
            numCurrent = numPrev + numNext;
            numPrev = numNext;
            numNext = numCurrent;
            Console.Write(numCurrent);
            if(i < a - 1)
            {
                Console.Write(", ");
            }
        }
    }
}