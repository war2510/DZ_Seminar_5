// Random random = new Random();
// // Функция для заполнения двухмерного массива случайными значениями
// void CreateArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(10, 100);
//         }
//     }
// }

// // Функция для печати двухмерного массива
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// // Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// {
//     int[,] array = new int[3, 3];
// CreateArray(array);
// // Вводим координаты элемента
//         Console.Write("Введите номер строки: ");
//         int row = int.Parse(Console.ReadLine());

//         Console.Write("Введите номер столбца: ");
//         int col = int.Parse(Console.ReadLine());

//         // Получаем значение элемента или выводим сообщение о его отсутствии
//         int result = GetElement(array, row, col);
//         if (result != int.MinValue)
//         {
//             Console.WriteLine($"Значение элемента [{row}, {col}] равно {result}");
//         }
//         else
//         {
//             Console.WriteLine($"Элемента с координатами [{row}, {col}] нет в массиве");
//         }
//     }

//     static int GetElement(int[,] array, int row, int col)
//     {
//         // Проверяем, находятся ли указанные координаты в пределах массива
//         if (row >= 0 && row < array.GetLength(0) && col >= 0 && col < array.GetLength(1))
//         {
//             // Возвращаем значение элемента
//             return array[row, col];
//         }
//         else
//         {
//             // Если координаты выходят за пределы массива, возвращаем специальное значение (например, int.MinValue) 
//             // для обозначения отсутствия элемента с такими координатами
//             return int.MinValue;
//         }
//     }


// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
//     {   
//          {
//         // Создаем и инициализируем двумерный массив
//         int[,] array = {
//             {1, 2, 3},
//             {4, 5, 6},
//             {7, 8, 9}
//         };
//        Console.WriteLine("Исходный массив:");
//         PrintArray(array);

//         // Меняем местами первую и последнюю строки
//         SwapRows(array, 0, array.GetLength(0) - 1);

//         Console.WriteLine("Массив после замены строк:");
//         PrintArray(array);
//     }

//     // Функция для печати двумерного массива
//     static void PrintArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }

//     // Функция для обмена местами двух строк в двумерном массиве
//     static void SwapRows(int[,] array, int row1, int row2)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[row1, j];
//             array[row1, j] = array[row2, j];
//             array[row2, j] = temp;
//         }
//     }
// }   


// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// {
        // Создаем двумерный массив (например, 3x3)
        // int[,] array = new int[,]
        // {
        //     { 1, 2, 3 },
        //     { 4, 5, 6 },
        //     { 7, 8, 9 }
        // };

        // // Находим индексы наименьшего элемента
        // int minElement = int.MaxValue;
        // int minRow = -1;
        // int minColumn = -1;

        // for (int row = 0; row < array.GetLength(0); row++)
        // {
        //     for (int col = 0; col < array.GetLength(1); col++)
        //     {
        //         if (array[row, col] < minElement)
        //         {
        //             minElement = array[row, col];
        //             minRow = row;
        //             minColumn = col;
        //         }
        //     }
        // }

        // Создаем новый массив без строки и столбца с наименьшим элементом
        // int[,] trimmedArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
        // int newRow = 0;

        // for (int row = 0; row < array.GetLength(0); row++)
        // {
        //     if (row == minRow)
        //         continue;

        //     int newColumn = 0;
        //     for (int col = 0; col < array.GetLength(1); col++)
        //     {
        //         if (col == minColumn)
        //             continue;

        //         trimmedArray[newRow, newColumn] = array[row, col];
        //         newColumn++;
        //     }
        //     newRow++;
        // }

        // Выводим новый массив
    //     Console.WriteLine("Новый массив без строки и столбца с наименьшим элементом:");
    //     for (int row = 0; row < trimmedArray.GetLength(0); row++)
    //     {
    //         for (int col = 0; col < trimmedArray.GetLength(1); col++)
    //         {
    //             Console.Write(trimmedArray[row, col] + " ");
    //         }
    //         Console.WriteLine();
    //     }
    // }