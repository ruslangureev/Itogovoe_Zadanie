Console.WriteLine("Задан массив строк: ");
string[] Array = new string[5] { "Zadanie", "Son", "33", ":)", "1989" };
int count = 0;
for (int i = 0; i < Array.Length; i++)
{
    Console.Write($"{Array[i]},");
    if (Array[i].Length < 4)
    {
        count++;
    }
}
Console.WriteLine();

Console.WriteLine("Готовый массив:");

string[] Array2 = new string[count];
int j = 0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length < 4)
    {
        Array2[j] = Array[i];
        Console.Write($"{Array2[j]},");
        j++;
    }
}
