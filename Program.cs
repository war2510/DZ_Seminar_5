﻿//Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
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