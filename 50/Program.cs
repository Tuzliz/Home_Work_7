/*
Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/
int GetDemension(string message)
{
    Console.WriteLine(message);
    int demension = int.Parse(Console.ReadLine());
    return demension;
}


int[,] InitMatrix(int firstDemension, int secondDemension)
{
    int[,] matrix = new int[firstDemension, secondDemension];
    Random rnd = new Random();
    for (int i = 0; i < firstDemension; i++)
    {
        for (int j = 0; j < secondDemension; j++)
            matrix[i, j] = rnd.Next(1, 10);
    }

    return matrix;
}

int rowNumber = GetDemension("Введите номер строки искомого элемента: ");
int columnNumber = GetDemension("Введите номер столбца искомого элемента: ");

void FindElement(int[,] resultMatrix, int rowNumber, int columnNumber)
{
    if (rowNumber < resultMatrix.GetLength(0) && columnNumber < resultMatrix.GetLength(1))
        Console.WriteLine(resultMatrix[rowNumber, columnNumber]);
    else
        Console.WriteLine("Элемент отсутствует");


}

void PrintArray(int[,] resulMatrix)
{
    for (int i = 0; i < resulMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resulMatrix.GetLength(1); j++)
        {
            Console.Write(resulMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}



int firstDemension = GetDemension("Введите длину для первого разряда матрицы:");
int secondDemension = GetDemension("Введите длину для второго разряда матрицы:");
int[,] resultMatrix = InitMatrix(firstDemension, secondDemension);

PrintArray(resultMatrix);
FindElement(resultMatrix, rowNumber, columnNumber);