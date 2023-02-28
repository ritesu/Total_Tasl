Console.WriteLine("Введите количество даных в массиве");
int a = int.Parse(Console.ReadLine() ?? "");
string[] arr = new string[a];

void FillArray()
{
    Console.WriteLine("Заполните массив");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Console.ReadLine() ?? "";
    }
}

void CheckArray()
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            PrintResult();
        }
    }
}
FillArray();
CheckArray();