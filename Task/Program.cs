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

int count = 0;
void CheckArray()
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
}

string[] arr2 = new string[count];

void FillNewArray()
{
 arr2 = new string[count];
 int b = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arr2[b] = arr[i];
            b++;
        }
    }
}

void Result()
{
    Console.WriteLine();
    foreach (var i in arr2)
    {
        Console.Write(i + " ");
    }
}

FillArray();
CheckArray();
FillNewArray();
Result();
