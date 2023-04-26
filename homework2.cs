//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.


Console.WriteLine("Введите N: ");
int inputN = GetIntInput();
Console.WriteLine("Введите M: ");
int inputM = GetIntInput();
if (inputM > inputN) 
{
    Console.WriteLine(NaturNumSum(inputN, inputM - 1));
}
else if (inputM < inputN) 
{
    Console.WriteLine(NaturNumSum(inputM, inputN - 1));
}
else Console.WriteLine("Числа равны");

int GetIntInput()
{
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int NaturNumSum(int inputN, int inputM)
{
    if (inputM == inputN) return 0;
    else return NaturNumSum(inputN, inputM - 1) + inputM;
}