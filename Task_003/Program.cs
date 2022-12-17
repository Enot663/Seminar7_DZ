// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();

Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine()); // Ввод количества строк
Console.Write("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine());// Ввод количество столбцов

int [,] myArray = new int [n,m]; // Объявляем новый массив

Console.WriteLine();
// Заполняем массив произвольными целыми числами
FillMyArray(myArray); 
// Выводим заполнкнный массив на консоль
PrintMyArray(myArray);
Console.WriteLine();

for (int j = 0; j < myArray.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        sum += myArray[i, j];
    }
    sum = sum / n;
    Console.Write(Math.Round(sum, 2) + " || ");
}

void FillMyArray(int[,] array) // Метод ввода элементов массива
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(0, 10);
            }   
        }
}

void PrintMyArray(int[,] array) // Метод вывода массива на консоль
{
    for (int i = 0; i < array.GetLength(0); i++)
    {        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }   
        Console.WriteLine();
    }
}   
