// Программа, формирующая из имеющегося массива строк  
// новый массив строк длиной 3 и меньше символа. 
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
string[] FillArray()
{
    Console.WriteLine("Введите через запятую элементы массива строк и нажмите клавишу Enter:");
    string imputedString = Console.ReadLine()!;
    string[] separator = imputedString.Split(',');
    string[] separatedString = new string[separator.Length];
    for (int i = 0; i < separator.Length; i++)
    {
        string temp = separator[i].Trim();
        separatedString[i] = temp;
    }
    return separatedString;
}
string[] FillNewArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    if (count == 0)
    {
        string[] newArray = new string[1];
        newArray[0] = "null";
        return newArray;
    }
    else
    {
        string[] newArray = new string[count];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                newArray[index] = array[i];
                index++;
            }
        }
        return newArray;
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
            Console.Write(", ");
    }
}
Console.WriteLine();
Console.WriteLine("Программа создания массива из строк длиной 3 символа и меньше");
Console.WriteLine("(новый массив создаётся из заданного пользователем массива).");
Console.WriteLine();
string[] array = FillArray();
string[] newArray = FillNewArray(array);
Console.WriteLine();
if (newArray[0] == "null")
{
    Console.WriteLine("В заданном массиве нет строк длиной 3 символа и меньше.");
}
else
{
    Console.WriteLine("Новый массив из строк длиной 3 символа и меньше:");
    PrintArray(newArray);
    Console.WriteLine();
}
Console.WriteLine();