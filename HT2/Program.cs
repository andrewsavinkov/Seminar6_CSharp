/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double[] GetData(string line)
{
    Console.WriteLine(line);
    string inputArray = Console.ReadLine() ?? "";
    string[] numberArray = inputArray.Split(',');
    double[] numbers = new double[numberArray.Length];
    bool correctInput = false;
    for (int i = 0; i < numberArray.Length; i++)
        correctInput = double.TryParse(numberArray[i], out numbers[i]);
    if (!correctInput)
        Console.WriteLine("Введите корректное число");
    return numbers;
}
void PrintData(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
       Console.Write($"{arr[i]}"); 
    }
    Console.WriteLine();
}

void Intersection(double[] inputArray)
{
    double bOne = inputArray[0];
    double kOne = inputArray[1];
    double bTwo = inputArray[2];
    double kTwo = inputArray[3];
    double x = (bTwo - bOne) / (kOne - kTwo);
    double y = (kOne * x) + bOne;
    Console.WriteLine($"координаты точки пересечения: ({x},{y})");
}

double[] coef = GetData("Введите значения b1, k1, b2, k2 через запятую: ");
PrintData(coef);
Intersection(coef);