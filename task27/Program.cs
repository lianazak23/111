//  Напишите программу, которая задаёт массив из 8 элементов случайных целых чисел от 1 до 50 и выводит их на экран.

int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[8];
for (int i = 0; i < 8; i++)
{
    randomArray[i] = new Random().Next(1,50);
    Console.Write(randomArray[i] + " ");
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
