/* Задача 1. Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.

int[] Array(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(100, 1000);
}
return arr;
}
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = Array(size);
Console.WriteLine($"[{string.Join(",", arr)}]");
int count = 0;
for(int i = 0; i < arr.Length; i++) 
    {
    if (arr[i] % 2 == 0) 
        {
        count++;
        }
    }
    Console.WriteLine("Количество четных чисел в массиве: " + count);
*/

/* Задача 2. Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

int[] Array(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(-100, 100);
}
return arr;
}
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = Array(size);
Console.WriteLine($"[{string.Join(",", arr)}]");
int sum = 0;

for (int i = 1; i < arr.Length; i += 2) 
{
    sum += arr[i];
}

        Console.WriteLine("Сумма элементов, стоящих на нечетных позициях: " + sum);
*/

/* Задача 3. Задайте массив вещественных чисел(тип double). Найдите разницу 
между максимальным и минимальным элементов массива.

int[] Array(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(0, 100);
}
return arr;
}
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = Array(size);
Console.WriteLine($"[{string.Join(",", arr)}]");
 double max = arr[0];
        double min = arr[0];
        for (int i = 1; i < arr.Length; i++) {
            if (arr[i] > max) 
            {
                max = arr[i];
            }
            if (arr[i] < min) 
            {
                min = arr[i];
            }
        }
        double diff = max - min;

        Console.WriteLine("Максимальный элемент: " + max);
        Console.WriteLine("Минимальный элемент: " + min);
        Console.WriteLine("Разница между максимальным и минимальным элементами: " + diff);
*/