//Задача 50 

void PrintArray(int[,] matr) // Создание матрицы 
{
    for (int i = 0; i  < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int [,] matr) // Заполнение массива рандомными данными
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr [i,j] = new Random().Next(1,100);
        }
    }
}

int [,] array = new int [4,4];

FillArray(array);
PrintArray(array);

Console.WriteLine("введите позицию на какой строке");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите позицию в каком столбце");
int columnsVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число для проверки");
int numberTest = Convert.ToInt32(Console.ReadLine());

if (array[linesVol,columnsVol] == numberTest)
{
    Console.WriteLine ($"Такое число - {numberTest} в массиве есть ");
}
else
{
    Console.WriteLine ($"Такое число отсутствует {numberTest}!!");
}