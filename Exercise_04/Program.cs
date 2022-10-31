// Пример работы с массивами на семинаре.

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr [i] = new Random().Next(0,2);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr [i] );
    }
}

int[] array = new int[8];
// int [] array = new int {1,0,10};

FillArray(array); 
PrintArray(array); 


