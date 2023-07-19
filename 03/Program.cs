// Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

int size = 8;
Random rnd = new Random();
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = rnd.Next(1, 15);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

for (int i = 0; i < size - 1; i++)
{
    int min = i;
    for (int j = i+1; j < size; j++)
        {
            if(array[j] < array[min])
                {
                    min = j;
                }
        } 
    int temporary =  array[i];
    array[i] = array[min];
    array[min] = temporary;     
}