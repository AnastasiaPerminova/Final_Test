// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите  количество элементов в массиве : ");
int number = Convert.ToInt32(Console.ReadLine ());
string[] array = new string [number];
int count =0;
for (int i = 0; i < array.Length; i++)
{   
    Console.WriteLine($"Введите {i + 1}-й элемент  в массив : ");
    string element =Console.ReadLine ();
    array [i] = element;
    if (element.Length <= 3)
    {
        count++;
    }

}
Console.WriteLine("Были введены строки: ");
Console.WriteLine('[' + string.Join(", ", array) + ']');
string[] array2 =  new string [count];
int count2 = 0;
for (int i = 0; i < array.Length; i++)
{   
  
    if (array [i].Length <= 3)
    {
        array2[count2] = array[i];
        count2++;
    }

}

Console.WriteLine("Строки длина которых меньше, либо равна 3 символам: ");
Console.WriteLine('[' + string.Join(", ", array2) + ']');