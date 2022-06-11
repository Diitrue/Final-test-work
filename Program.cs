Console.WriteLine("Введите строку массива: ");
string [] mass = new string [5];
void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
            array[i] = Console.ReadLine();
    }
}

void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}
FillArray(mass);
for (int j = 0; j < mass.Length; j++)
{
    if (mass[j].Length <= 3)
    {
        Console.Write(mass[j]+ " ");
    }
}