Console.WriteLine("Введите количество даных в массиве");
int a = int.Parse(Console.ReadLine()??"");
string[] arr = new string [a];
Console.WriteLine("Заполните массив");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Console.ReadLine()??"";
}