// Задание 1. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.WriteLine("Задание 1. Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

string Numbers(int m, int n)
{
    if (m == n) return n.ToString();
    else return m.ToString() + ", " + Numbers(m += 1, n);
}

Console.WriteLine(Numbers(numM, numN));

// Задание 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Задание 2");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSumm(m, n, temp=0);

void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов= {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}


// Задание 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29


Console.Clear();
Console.WriteLine("Задание 3. Решение функции Аккермана.");
Console.WriteLine();
int numberM = EnterUserData("Введите m:");
int numberN = EnterUserData("Введите n:");
if (numberM < 0 || numberN < 0)
{
    Console.WriteLine("Введите положительные числа m и n.");
    return;
}
int result = AckermannFunction(numberM, numberN);
Console.WriteLine(result);

int AckermannFunction(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    else if (numberM > 0 && numberN == 0)
    {
        return AckermannFunction(numberM - 1, 1);
    }
    else if (numberM > 0 && numberN > 0)
    {
        return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
    }
    return AckermannFunction(numberM, numberN);
}

int EnterUserData(string nameUserData)
{
    Console.Write($"{nameUserData}");
    return Convert.ToInt32(Console.ReadLine());
}
