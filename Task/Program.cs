// **Итоговая проверочная работа**  
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.  

// Примеры:  
// ["hello","2","world",";-)"] -> ["2",":-)"]  
// ["1,2,3,4","1567","-2","computer science"] -> ["-2"]  
// ["Rissia","Denmark","Kazan"] ->[ ]  

// Некоторые условности:
// 1. Допускаем, что пользователь вводит число при запросе длины базового массива. Т.е. обработчик ошибок не пишем
// 2. Длинна копируемого элемента указана в коде явно, что соответствует условию ТЗ.


// ---------------------------- МЕТОДЫ -------------------------

int FillBaseArrayAndReturnResultArrayLength(string[] baseArray, int lengthElement)  // метод заполнения основного массива пользователем. Возвращает длину результирующего массива
{
    int resultArrayLength = 0; // объявляем локальную переменную для хранения и возвращения методом длины результирующего массива
    for (int i = 0; i < baseArray.Length; i++)
    {
        System.Console.WriteLine($"Заполните {i} элемент массива:");
        baseArray[i] = Console.ReadLine();
        if (baseArray[i].Length <= lengthElement) resultArrayLength++;  // если длина элемента соотв. ТЗ то происходит увеличение значения длинны результирующего массива
    }
    return resultArrayLength;
}

void FillResultArray(string[] baseArray, string[] resultArray, int lengthElement) // заполняем результирующий массив
{
    int indexResultArray = 0; // обяъвялем локальную переменную индекса результирующего массива
    for (int i = 0; i < baseArray.Length; i++)
    {
        if (baseArray[i].Length <= lengthElement)
        {
            resultArray[indexResultArray] = baseArray[i];
            indexResultArray++;
        }

    }
}

void PrintArray(string[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) System.Console.Write($"'{array[i]}'");
        else System.Console.Write($"'{array[i]}', ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}

// --------------------------- Тело программы ---------------------


Console.Clear();

System.Console.WriteLine("Введите длинну базового массива строк: ");
string[] baseArray = new string[int.Parse(Console.ReadLine())];  // инициализируем базовый массив
int lengthElement = 3;   // задается длина элемента по ТЗ
int resultArrayLength = 0; // объявляется переменная под длину результирующего массива

resultArrayLength = FillBaseArrayAndReturnResultArrayLength(baseArray, lengthElement); // получаем длину результирующего массива и заполняем базовый массив

System.Console.WriteLine("Полученный массив: ");
PrintArray(baseArray);

string[] resultArray = new string[resultArrayLength]; // инициализируем результирующий массив с полученной длиной

FillResultArray(baseArray, resultArray, lengthElement); // заполняем результирующий массив по ТЗ

System.Console.WriteLine("Результирующий массив: ");
PrintArray(resultArray);