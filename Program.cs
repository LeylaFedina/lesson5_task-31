/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


Вариант 1
int [] getRandomArray (int length, int startPoint, int endPoint)
{
    int [] resultArray = new int [length];
    for (int i = 0; i < length; i ++)
    {
        resultArray [i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;
}
void printArray (int [] incommingArray)
{
    Console.Write("[");
    for (int i = 0; i < incommingArray.Length; i++)
    {
        Console.Write(incommingArray [i]);
        if (i < incommingArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine ("]");
}
int getSumOfPositiveNumbersInArray (int [] incommingArray)
{
    int result = 0;
    for (int i = 0; i < incommingArray.Length; i++)
    {
        if (incommingArray[i] > 0)
        {
            result += incommingArray [i];
        }
    }

    return result;
}
int getSumOfNegativeNumbersInArray (int [] incommingArray)
{
    int result = 0;
    for (int i = 0; i < incommingArray.Length; i++)
    {
        if (incommingArray[i] < 0)
        {
            result += incommingArray [i];
        }
    }

    return result;
}

int [] currentArray = getRandomArray(12,-9,9);
printArray (currentArray);

int sumOfPositive = getSumOfPositiveNumbersInArray (currentArray);
int sumOfNegarive = getSumOfNegativeNumbersInArray (currentArray);

Console.WriteLine($"сумма положительных {sumOfPositive}, сумма отрицательных {sumOfNegarive}");
*/

int [] getRandomArray (int length, int startPoint, int endPoint)
{
    int [] resultArray = new int [length];
    for (int i = 0; i < length; i ++)
    {
        resultArray [i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;
}
void printArray (int [] incommingArray)
{
    Console.Write("[");
    for (int i = 0; i < incommingArray.Length; i++)
    {
        Console.Write(incommingArray [i]);
        if (i < incommingArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine ("]");
}
int getSumOfPositiveNumbersInArray (int [] incommingArray)
{
    int result = 0;
    for (int i = 0; i < incommingArray.Length; i++)
    {
        if (incommingArray[i] > 0)
        {
            result += incommingArray [i];
        }
    }

    return result;
}
int getSumOfNegativeNumbersInArray (int [] incommingArray)
{
    int result = 0;
    for (int i = 0; i < incommingArray.Length; i++)
    {
        if (incommingArray[i] < 0)
        {
            result += incommingArray [i];
        }
    }

    return result;
}
// deviation = 1 если считать положительные и -1 если отрицательные
int getSumOfPositiveOrNegativeNumbersInArray(int incommingArray, int deviation)
{
    int result = 0;
    for (int i = 0; i < incommingArray.Length; i++)
    {
        if (incommingArray[i] * deviation < 0)
        {
            result += incommingArray [i];
        }
    }

    return result;
}
int [] currentArray = getRandomArray(12,-9,9);
printArray (currentArray);

int sumOfPositive = getSumOfPositiveNumbersInArray (currentArray);
int sumOfNegarive = getSumOfNegativeNumbersInArray (currentArray);

Console.WriteLine($"сумма положительных {sumOfPositive}, сумма отрицательных {sumOfNegarive}");

sumOfPositive = getSumOfPositiveOrNegativeNumbersInArray (currentArray, 1);
sumOfNegarive = getSumOfPositiveOrNegativeNumbersInArray (currentArray, -1);

Console.WriteLine($"сумма положительных {sumOfPositive}, сумма отрицательных {sumOfNegarive}");
