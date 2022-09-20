// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] array = { "tom", "ben", "anna", "max", "1", "+)", "GeekBrains" };
int size = array.Length;
int count = 0;
for (int i = 0; i < size; i++)
{
    if (array[i].Length <= 3) count++;
}
if (count == 0)
    Console.WriteLine("array elements in which the number of characters is less than or equal to three were not found");
if (count > 0)
{
    string[] newArray = new string[count];
    for (int i = 0; i < count; i++)
    {
        for (int j = 0; j < size; j++)
            if (array[j].Length <= 3)
            {
                newArray[i] = array[j];
                i++;
            }
    }
    for (int i = 0; i < count - 1; i++)
    {
        Console.Write($"{newArray[i]}, ");
    }
    Console.WriteLine(newArray[count - 1]);
}
