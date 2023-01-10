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

Console.WriteLine("Введите разделитель между элементами!");
string divider = Convert.ToString(Console.ReadLine());

void Less_3_Array (string [] array){
      string[] NewArray = new string[array.Length];
      for (int j=0; j < array.Length; j++)
      {      
         if(array[j].Length<=3)
         {
         NewArray[j]=array[j];
         Console.ForegroundColor = ConsoleColor.Green;
         Console.Write($"{NewArray[j]}");
         Console.ResetColor();
            if(j < array.Length-1)
            {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{divider}");
            Console.ResetColor();
            }
         }
      }
        Console.WriteLine();
}

Less_3_Array(array);