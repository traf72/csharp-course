using System.Text;

Console.WriteLine("-----------------String Length-----------------");

const string testStr = "I love C#!";

Console.WriteLine(testStr.Length);  // 10 (длина строки, то есть, количество символов в ней)

//testStr.Length = 9;               // Свойство "Length" доступно только для чтения


Console.WriteLine("-----------------StringBuilder Length-----------------");

var strBuilder = new StringBuilder("I love C#!");  // Создание объекта "StringBuilder" с помощью конструктора

Console.WriteLine(strBuilder);                     // I love C#!
Console.WriteLine(strBuilder.Length);              // 10

strBuilder.Length = 6;                             // В объекте "StringBuilder" свойство "Length" доступно как на чтение, так и на запись

Console.WriteLine(strBuilder);                     // I love
Console.WriteLine(strBuilder.Length);              // 6

strBuilder.Length = 10;

Console.WriteLine(strBuilder);                     // I love
Console.WriteLine(strBuilder.Length);              // 10


Console.WriteLine("-----------------String Indexer-----------------");

char firstSymbol = testStr[0];     // Получение первого символа
Console.WriteLine(firstSymbol);    // I

char lastSymbol = testStr[9];      // Получение 10-го символа
Console.WriteLine(lastSymbol);     // !

lastSymbol = testStr[^1];          // Получение последнего символа
Console.WriteLine(lastSymbol);     // !

//Console.WriteLine(testStr[10]);  // System.IndexOutOfRangeException, так как символа с индексом 10 не существует

Console.WriteLine("-----------------StringBuilder Indexer-----------------");

strBuilder = new StringBuilder("I love C#!");

strBuilder[8] = '+';             // Меняем символ по индексу 8 на '+' (в объекте "StringBuilder" индексатор доступен как на чтение, так и на запись)
Console.WriteLine(strBuilder);   // I love C+!

strBuilder.Insert(9, '+');       // Вставляем символ '+' по индексу 9
Console.WriteLine(strBuilder);   // I love C++!


Console.WriteLine("-----------------Substring-----------------");

Console.WriteLine(testStr[2..]);             // love C#! (извлекаем подстроку, начиная с символа под индексом 2 и до конца исходной строки - то же самое, что и "testStr.Substring(2)")
Console.WriteLine(testStr.Substring(2, 4));  // love     (извлекаем подстроку, начиная с символа под индексом 2 и длинной в 4 символа)
Console.WriteLine(testStr[2..6]);            // love     (извлекаем подстроку, начиная с символа под индексом 2 и заканчивая символом под индексом 6 не включительно)


Console.WriteLine("-----------------Trim-----------------");

string strWithEdgeSpaces = "\t I love C#! \n";
Console.WriteLine($"'{strWithEdgeSpaces}'");
Console.WriteLine($"'{strWithEdgeSpaces.Trim()}'");  // 'I love C#!' (отсекаем пробельные символы в начале и в конце)


Console.WriteLine("-----------------Split-----------------");

string[] words = "Hello, how are you?".Split(' ');   // Разбиаем строку на подстроки по пробелу
string[] chunks = "one, two, three".Split(',');      // Разбиаем строку на подстроки по запятой


Console.WriteLine("-----------------string.Empty-----------------");

string emptyStr = string.Empty;  // Объявление пустой строки
string emptyStr2 = "";           // То же самое, что и выше, но другим способом

Console.WriteLine(emptyStr == emptyStr2);                  // True (строки равны между собой посимвольно)
Console.WriteLine(object.ReferenceEquals(emptyStr, emptyStr2));   // True (ссылки указывают на один и тот же объект в памяти)

// Использование пустой строки как стартовой точки при собирании конечной строки из нескольких частей
// string target = "";
// if ( /* something */ )
// {
//     target += "something";
// }
// if ( /* something else */ )
// {
//     target += "something else";
// }

// Сделать что-то, если строка не пустая
if (emptyStr != string.Empty)
{
    // Do something
}


Console.WriteLine("-----------------string.IsNullOrEmpty-----------------");

string nullStr = null;  // Присваивание строке значения "null"

Console.WriteLine(string.IsNullOrEmpty(emptyStr));  // True
Console.WriteLine(string.IsNullOrEmpty(nullStr));   // True
Console.WriteLine(string.IsNullOrEmpty(testStr));   // False


Console.WriteLine("-----------------string.IsNullOrWhiteSpace-----------------");

Console.WriteLine(string.IsNullOrWhiteSpace(emptyStr));       // True
Console.WriteLine(string.IsNullOrWhiteSpace(nullStr));        // True
Console.WriteLine(string.IsNullOrWhiteSpace("  \t  \n  "));   // True
Console.WriteLine(string.IsNullOrWhiteSpace(testStr));        // False


Console.WriteLine("-----------------string.Join-----------------");

string[] cities = ["Moscow", "New York", "Paris", "London"];  // Объявление массива строк

string citiesString = string.Join(", ", cities);              // Собираем массив в одну строку с разделителем ", "
Console.WriteLine(citiesString);                              // Moscow, New York, Paris, London


Console.WriteLine("-----------------ToString-----------------");

Display("Some string");   // Some string
Display(strBuilder);      // I love C++!
Display(12);              // 12

// Метод принимает объект типа "object", что означает, что в него можно передать объект любого типа,
// так как все типы C# неявно наследуются от "object"
static void Display(object input)
{
    Console.WriteLine(input);
}
