//Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//  {
        // Создаем двумерный массив (например, 3x3)
        // int[,] array = new int[,]
        // {
        //     { 1, 2, 3 },
        //     { 4, 5, 6 },
        //     { 7, 8, 9 }
        // };

        // Получаем позиции элемента от пользователя
        // Console.Write("Введите номер строки: ");
        // int row = int.Parse(Console.ReadLine());

        // Console.Write("Введите номер столбца: ");
        // int column = int.Parse(Console.ReadLine());

        // Проверяем, что введенные позиции находятся в пределах массива
        // if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
        // {
            // Возвращаем значение элемента
    //         int value = array[row, column];
    //         Console.WriteLine($"Значение элемента [{row}, {column}]: {value}");
    //     }
    //     else
    //     {
    //         Console.WriteLine("Указанные позиции находятся за пределами массива.");
    //     }
    // }



// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
//  {
        // Создаем двумерный массив (например, 3x3)
        // int[,] array = new int[,]
        // {
        //     { 1, 2, 3 },
        //     { 4, 5, 6 },
        //     { 7, 8, 9 }
        // };

        // Меняем местами первую и последнюю строки
        // int rowCount = array.GetLength(0);
        // int columnCount = array.GetLength(1);

        // for (int i = 0; i < columnCount; i++)
        // {
        //     int temp = array[0, i];
        //     array[0, i] = array[rowCount - 1, i];
        //     array[rowCount - 1, i] = temp;
        // }

        // Выводим измененный массив
    //     Console.WriteLine("Измененный массив:");
    //     for (int row = 0; row < rowCount; row++)
    //     {
    //         for (int col = 0; col < columnCount; col++)
    //         {
    //             Console.Write(array[row, col] + " ");
    //         }
    //         Console.WriteLine();
    //     }
    // }



//  Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//  {
        // Создаем прямоугольный двумерный массив (например, 3x4)
        // int[,] array = new int[,]
        // {
        //     { 1, 2, 3, 4 },
        //     { 5, 6, 7, 8 },
        //     { 9, 10, 11, 12 }
        // };

        // Находим строку с наименьшей суммой элементов
    //     int minSum = int.MaxValue;
    //     int minSumRowIndex = -1;

    //     for (int row = 0; row < array.GetLength(0); row++)
    //     {
    //         int rowSum = 0;
    //         for (int col = 0; col < array.GetLength(1); col++)
    //         {
    //             rowSum += array[row, col];
    //         }

    //         if (rowSum < minSum)
    //         {
    //             minSum = rowSum;
    //             minSumRowIndex = row;
    //         }
    //     }

    //     if (minSumRowIndex != -1)
    //     {
    //         Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRowIndex}");
    //     }
    //     else
    //     {
    //         Console.WriteLine("Массив пуст.");
    //     }
    // }


    // Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. Под удалением понимается создание нового двумерного массива без строки и столбца

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