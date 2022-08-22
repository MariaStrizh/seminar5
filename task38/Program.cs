//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] array=new double[5];
Random rand=new Random();

double count=0;


for (int i = 0; i < array.Length; i++)
{
    array[i]=rand.Next(1,15);
} 
double max=array[0];
double min=array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max=array[i];
    }

    if (array[i]<min)
    {
        min=array[i];
    }
}

count=max-min;
Console.WriteLine(string.Join(",",array));
Console.WriteLine($"Максимальное значение = {max}");
Console.WriteLine($"Минимальное значение = {min}");
Console.WriteLine($"Разница между макс и мин = {count}");