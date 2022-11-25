string[] CreateArray()
{
    Console.WriteLine("Какого размера должен быть наш массив ");
    int size = Convert.ToInt32(Console.ReadLine());
    
    string[] myArray = new string[size];

    for(int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"Введите {i+1} элемент массива ");
        myArray[i] = Console.ReadLine();
    }
    return myArray;    
}

void ShowArray(string[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + " ");
    }
    Console.WriteLine();
}

string[] NewArray(string[] myArray, int symbolQuantity)
{
    int size = 0;

    for(int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i].Length <= symbolQuantity)
        {
            size++;
        }
    }

    string[] newArray = new string[size];

    int j = 0;

    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i].Length <= symbolQuantity)
        {
            newArray[j] = myArray[i];
            j++;
        }
    }
    return newArray;
}

string[] myArray = CreateArray();
Console.Write("Наш изначальный массив: ");
ShowArray(myArray);

Console.WriteLine();
Console.Write("Укажите максимальное количество символов (для выборки) ");
int symbolquantity = Convert.ToInt32(Console.ReadLine());

Console.Write("Результирующий массив: ");
string[] newArray = NewArray(myArray,symbolquantity);
ShowArray(newArray);
