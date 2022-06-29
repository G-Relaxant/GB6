int number = InputData("Input number: ");
int digitsCount = 1;
int numCycle = number;
while(numCycle > 1)
{
    digitsCount++;
    numCycle = numCycle / 2;
}
int[] array = new int[digitsCount];
for(int i = 0; i < array.Length; i++)
{
    if(number % 2 == 1)
    {
        array[i] = 1;
    }
    else
    {
        array[i] = 0;
    }
    number = number / 2;
}
int[] arrayAnswer = new int[array.Length];
int i2 = array.Length - 1;
for(int i = 0; i < array.Length; i++)
{
    arrayAnswer[i] = array[i2];
    i2--;
}
PrintAnswer(arrayAnswer);


int InputData(string output)
{
    Console.Write(output);
    int inpData = Convert.ToInt32(Console.ReadLine());
    return inpData;
}

void PrintAnswer(int[] a)
{
    Console.Write("[");
    for(int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i]);
        if(i < a.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}