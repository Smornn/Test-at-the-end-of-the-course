string[] start_mas = { "1234", "1567", "-2", "computer science" };
string[] second_mas = new string[start_mas.Length];

void FindSecondMas (string[] start_mas, string[] second_mas)
{
    int temp = 0;
    for (int i = 0; i < start_mas.Length; i++)
    {
        if (start_mas[i].Length <= 3)
        {
            second_mas[temp] = start_mas[i];
            temp++;
        }
    }
}

void PrintArray(string[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write($"{mas[i]} ");
    }
    Console.WriteLine();
}

FindSecondMas(start_mas, second_mas);
PrintArray(second_mas);