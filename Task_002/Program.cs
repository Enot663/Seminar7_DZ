// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

Console.Write("Введите номер строки: ");
int n = int.Parse(Console.ReadLine()); // Ввод номера строки
Console.Write("Введите номер столбца: ");
int m = int.Parse(Console.ReadLine());// Ввод номера столбца

int [,] myArray = new int [5,5]; // Объявляем новый массив

Console.WriteLine();
// Заполняем массив произвольными целыми числами
FillMyArray(myArray); 
// Выводим заполнкнный массив на консоль
PrintMyArray(myArray);
Console.WriteLine();

if (n > myArray.GetLength(0) || m > myArray.GetLength(1)) // Условие если номера полученных данных больше
// размера массива
{
    Console.WriteLine("Элемента с указанными позициями нет в данном массиве.");
}
else // Если данные в массиве.
{
    Console.WriteLine($"Значение элемента {n} строки и {m} столбца равно: {myArray[n-1,m-1]}");
}

void FillMyArray(int[,] array) // Метод ввода элементов массива
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100);
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
