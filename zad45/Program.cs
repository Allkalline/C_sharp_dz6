/* Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования. */

int[] GetArray(int size, int minValue, int maxValue) 
{
    int[] res = new int[size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(minValue,maxValue+1);
        // Console.Write($"{res[i]} ");
    }
    return res;
}

void PrintArray(int[] arr)
{
     for(int i=0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void CopyArray (int[] arr, int [] arr2)
{   
    for(int i=0; i<arr.Length; i++)
    {arr2[i]=arr[i];
    Console.Write($"{arr2[i]} ");
    }
}
int size = new Random().Next(5,10);
int[] array = GetArray(size,0,9);
int [] array2 = new int [size];
PrintArray(array);
Console.WriteLine();
CopyArray(array, array2);


