/* 

Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
            matrix[i, j] = rnd.Next();
    }

    return matrix;
}

string GetArithmeticMean(int[,] resultMatrix)
{
    double arithmeticMean = 0;
    string result = string.Empty;
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {

        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            arithmeticMean += resultMatrix[j, i];
        }
        arithmeticMean = arithmeticMean / resultMatrix.GetLength(0);
        result += arithmeticMean + ";";
        arithmeticMean = 0;

    }
    return result;
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
string res = GetArithmeticMean(resultMatrix);
PrintArray(resultMatrix);

