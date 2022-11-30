// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Math.Pow использовать нельзя
//

int NuturalDegree(int numberA, int numberB)
{
    int result = 1;
    int i = 1;
    while (i <= numberB)
    {
        result = result * numberA;
        i++;
    }
    return result;
}
Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int exponentiation = NuturalDegree(numberA, numberB);
Console.WriteLine (exponentiation);