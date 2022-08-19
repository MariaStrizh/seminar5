// Задача 33: Задайте массив. Напишите программу, 
//которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да
//Массивы к задачам 32 и 33 можно сделать рандомными. В задаче 33 на экран выводится ТОЛЬКО 
//одно сообщение: либо "да", либо "нет".

int[] array=new int[12];
Random rand=new Random();
 
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9,10);
}
Console.WriteLine(string.Join(",",array));

int findElement=Convert.ToInt32(Console.ReadLine());// элемент который мы ищем в массиве
bool flag=false; //если false  то эемента в массиве нет, иначе есть

for (int i = 0; i < array.Length; i++)
{
    if (findElement==array[i])
    {
        flag=true;
    }
}
if (flag==true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("нет");
}