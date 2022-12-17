// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
Console.Clear();
Console.WriteLine("Для заполнения массива СЛУЧАЙНЫМИ ВЕЩЕСТВЕННЫМИ ЧИСЛАМИ введите:");
Console.WriteLine();

void OutputArrayData(double[,] array)
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

double[,] CreatingAndFillingArray(int rows, int columns, int leftRange, int rightRange) // Метод заполнения массива
{
   double[,] array = new double[rows, columns];
   for (int i = 0; i < rows; i++)
   {
      for( int j = 0; j < columns; j++)
      {
         array[i, j] =Convert.ToDouble(new Random().Next(leftRange, rightRange))/10;
      }
   }
   return array;
}

int EnteringArrayData(string message) // Метод ввода данных двумерного массива
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
// EnteringArrayData  - Получение данных. Пользователь с консоли вводит данные размера массива
int m = EnteringArrayData("Введите число строк массива: ");
int n = EnteringArrayData("Введите число столбцов массива: ");

// CreatingAndFillingArray - Заполняем массив данного размера СЛУЧАЙНЫМИ ВЕШЕСТВЕННЫМИ ЧИСЛАМИ
double[,] matrix = CreatingAndFillingArray(m, n, -100, 100);


// OutputArrayData - Выводим заданный массив на консоль.
OutputArrayData(matrix);

