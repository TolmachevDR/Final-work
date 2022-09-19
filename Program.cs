// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Создание нового массива данных 
string[] CreateArray(int lengthArray)
{
    string[] array = new string[lengthArray];
    Console.WriteLine("Введите построчно " + lengthArray + " элемента массива");
    for (int i = 0; i < lengthArray; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

// Подсчет элементов в массиве данных по заданным параметрам
void CreateResultArray(string[] array)
{
    int count = 0;
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    // Выведение результата в терминал
    string[] arrayResult = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayResult[index] = array[i];
            Console.Write(arrayResult[index] + " ");
            index++;

        }
    }

}

// Итог
Console.WriteLine("Введите длину массива"); // Запрос величины массива
int lengthArray = int.Parse(Console.ReadLine()); // Введение и принятие массива в обработку
string[] array = CreateArray(lengthArray); // Обработка массива по заданным параметрам
CreateResultArray(array); // Выведение результата в терминал