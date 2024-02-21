void PrintArrayRecurs(int[] arr, int index)
{
    if (index >= arr.Length - 1)
    {
        Console.Write($"{arr[index]} ");
        return;
    }
    PrintArrayRecurs(arr,index + 1);
    Console.Write($"{arr[index]} ");
}
int[] array = {1,2,3,4,5,6};
PrintArrayRecurs(array,0);