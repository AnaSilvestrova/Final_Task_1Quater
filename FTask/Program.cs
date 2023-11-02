// // Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Задать два массива (строки)
 
//string [] array1 = new string [4] {"Hello", "2", "world", ":-)"};
//string [] array1 = new string [4] {"1234", "1567", "-2", "computer science"};
//string [] array1 = new string [4] {"Russia", "Denmark", "USA", "UK"};
string [] array1 = new string [6] {"Russia", "Denmark", "USA", "UK", "Sweden", "Poland"};
string[] array2 = new string[array1.Length];

// Метод для печати массива.

void PrintArray1(string[] array1)
    {
        for (int i = 0; i < array1.Length; i++)
        {
            Console.WriteLine($"{array1[i]}");
        }
        Console.WriteLine();
    }

// Метод для изменения массива, в ходе которого второй массив заполняется элементами первого, подходящими по условию, указанному в функции if.

void ModifyArray(string[] array1, string[] array2)
    {
        int count = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i].Length <= 3)
            {
                array2[count] = array1[i];
                count++;
            }
        }
    }

void PrintArray2(string[] array2)
    {
        for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine($"{array2[i]}");
            }
            Console.WriteLine();
    }

Console.WriteLine($"First array:");
PrintArray1(array1);

ModifyArray(array1, array2);

Console.WriteLine($"Modified array:");
PrintArray2(array2);