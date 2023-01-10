// Задача: Написать программу, которая из имеющихся массива строк формирует массив из строк, длина которых меньше либо равна 3 символам.

Console.WriteLine("Сколько элементов будет в массиве?");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    array[i] = element;
}
