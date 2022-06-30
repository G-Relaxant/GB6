int[] array =  new int[InputData("Input array size: ")];
int[] arrayCopy = new int[array.Length];
FillArrayRandom(array);
Console.Write("Original array: ");
PrintArray(array);
CopyArray(array, arrayCopy);
Console.Write("Copied array: ");
PrintArray(arrayCopy);


int InputData(string output)
{
    Console.Write(output);
    int inpData = Convert.ToInt32(Console.ReadLine());
    return inpData;
}

void FillArrayRandom(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(0, 100);
    }
}

void PrintArray(int[] b)
{
    Console.Write("[");
    for(int i = 0; i < b.Length; i++)
    {
        Console.Write(b[i]);
        if(i < b.Length - 1)
            Console.Write(", ");
        else
            Console.WriteLine("]");
    }
}

void CopyArray(int[] a, int[] b)
{
    for(int i = 0; i < a.Length; i++)
    {
        b[i] = a[i];
    }
}