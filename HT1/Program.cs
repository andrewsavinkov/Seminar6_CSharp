/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
void PrintData(int[] inputArray)
{
    for (int i = 0; i < inputArray.Length; i++)
        Console.Write($"{inputArray[i]} ");
    Console.WriteLine();
}

int[] GetData(string line)
{
    Console.WriteLine(line);
    string inputArray = Console.ReadLine() ?? "";
    string[] numberArray = inputArray.Split(", ");
    int[] numbers = new int[numberArray.Length];
    bool correctInput = false;
    for (int i = 0; i < numberArray.Length; i++)
        correctInput = int.TryParse(numberArray[i], out numbers[i]);
        if (!correctInput)
            Console.WriteLine("Введите корректное число");
    return numbers;
}

void PositiveNumbers(int[] inputArr)
{
    int sum = 0;
    for (int i = 0; i < inputArr.Length; i++)
    {
        if(inputArr[i]>0)
            sum++;
    }
    Console.WriteLine($"чисел больше 0: {sum}");
}

int[] array = GetData("Введите числа через запятую: ");
PrintData(array);
PositiveNumbers(array);
