string[] firstArray = new string[5] {"1234", "1567", "-2", "computer science", "123"};
string[] secondArray = new string[firstArray.Length];


string[] ArrayStringsLenMin(string[] firstArray, string[] secondArray)
{
    int count = 0;
    
    for (int i = 0; i < firstArray.Length; i++)
    {
    if(firstArray[i].Length <= 3)
        {
        secondArray[count] = firstArray[i];
        count++;
        }
    }

    return secondArray;
}


void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]} ");
        else Console.Write($"{arr[i]}");
    }
}

string[] arrayStringsLenMin = ArrayStringsLenMin(firstArray, secondArray);

Console.Write($"[");
PrintArray(arrayStringsLenMin);
Console.Write($"]");
