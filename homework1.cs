//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Введите N: ");
int inputN = GetIntInput();
NaturNum(inputN);

int GetIntInput()
{
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

void NaturNum(int inputN)
{
    if (inputN == 0)  return;
    NaturNum(inputN - 1);
    Console.Write($"{inputN} ");
}

