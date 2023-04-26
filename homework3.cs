// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите m: ");
int inputM = GetIntInput();
Console.WriteLine("Введите n: ");
int inputN = GetIntInput();
if (inputM > 0 && inputN > 0) Console.WriteLine(GetAkkerman(inputM, inputN));
else Console.WriteLine("Числа неположительные");

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

int GetAkkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return GetAkkerman(n - 1, 1);
    else
      return GetAkkerman(n - 1, GetAkkerman(n, m - 1));
}