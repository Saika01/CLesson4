﻿int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(0,2);
    }
    return array;
}

void OutputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }    
}

int[] arr = CreateArray(8);
OutputArray(arr);
