Console.WriteLine("-----------------Implicit and explicit type casting-----------------");

short s = 300;
int i = s;        // Неявное приведение к типу "int" (расширяющее преобразование безопасно, поэтому происходит неявно)

byte b = unchecked((byte)s);  // Явное приведение к типу "byte" при сужающем преобразовании. Также явное указание игнорировать ошибки переполнения с помощью оператора "unchecked".
Console.WriteLine(b);         // 44 (так как произошло переполнение)

ushort us = 500;
i = us;           // Неявное приведение к типу "int" (расширяющее преобразование безопасно, поэтому происходит неявно)

us = (ushort)i;   // Явное приведение к типу "ushort" при сужающем преобразовании.

float f = 100.8F;
double d = f;     // Неявное приведение к типу "double" (расширяющее преобразование безопасно, поэтому происходит неявно)
f = (float)d;     // Явное приведение к типу "float" при сужающем преобразовании.

decimal dec = (decimal)f;  // Приведение "float" и "double" к "decimal" всегда требует явного преобразования

dec = us;         // Целочисленные типы приводятся к "decimal" неявно

f = i;            // Преобразование целочисленных типов к типам IEEE 754 cчитается расширяющим и происходит неявно (см. нюанс в ответах на домашнее задание)

i = (int)f;       // Явное приведение к типу "int" при сужающем преобразовании (дробная часть просто отбрасывается).

byte carSpeed = 60;
byte bikeSpeed = (byte)(carSpeed + 40);  // Необходимо явное приведение, так как при арифметических операциях с целыми числами операнды подтягиваются до "int" или "long", если не хватает "int" 

carSpeed = (byte)(carSpeed - 20);        // Необходимо явное приведение даже при присваивании той же переменной  
carSpeed -= 20;                          // При составном присваивании явное приведение не требуется

uint strLength = (uint)"str".Length;     // Необходимо явное приведение, так как свойство "Length" имеет тип "int"
int strLen = "str".Length;               // Явное приведение не требуется, так как типы совпадают


Console.WriteLine("\n-----------------Overflow-----------------");

// Двоичное представление чисел
// 0000 0001 0010 1100  - 300 в short
//           0010 1100  - 44  в byte

//byte notCompiled = 256;             // Код не компилируется, так как компилятор сразу видит переполнение
//byte notCompiled2 = 200 + 56;       // Код не компилируется, так как компилятор сразу видит переполнение (компилятор умеет выполнять арифметические операции с литералами)

//const int constNum = 56;
//byte notCompiled3 = 200 + constNum;  // Код не компилируется, так как компилятор сразу видит переполнение (компилятор умеет выполнять арифметические операции с константами)

int num = 56;
byte overflow1 = (byte)(200 + num);             // Код компилируется и приводит к переполнению на этапе выполнения (компилятор не умеет выполнять арифметические операции с переменными)    
//byte overflow1 = checked((byte)(200 + num));  // Явная проверка переполнения с помощью оператора "checked" (произойдёт ошибка)

Console.WriteLine(overflow1);  // 0 (так как произошло переполнение)

byte overflow2 = 255;
overflow2++;

// Явная проверка переполнения с помощью блочного выражения "checked" (произойдёт ошибка)
//checked
//{
//    overflow2++;
//}

Console.WriteLine(overflow2);  // 0 (так как произошло переполнение)


Console.WriteLine("\n-----------------No overflow for IEEE 754 floating types-----------------");

float infinity = float.MaxValue * 2;
Console.WriteLine(infinity);          // ∞

Console.WriteLine(5.0 / 0);           // ∞
Console.WriteLine(0.0 / 0);           // NaN при делении на ноль чисел с плавающей точкой

//int zero = 0;
//Console.WriteLine(5 / zero);        // Ошибка "System.DivideByZeroException" при целочисленном делении на 0


Console.WriteLine("\n-----------------Numeric types members-----------------");

Console.WriteLine(int.MinValue);             // -2147483648
Console.WriteLine(int.MaxValue);             // 2147483647

Console.WriteLine(int.IsEvenInteger(10));    // True
Console.WriteLine(int.Abs(-5));              // 5

Console.WriteLine(double.Pi);                // 3,141592653589793
Console.WriteLine(double.E);                 // 2,718281828459045
Console.WriteLine(double.NegativeInfinity);  // -∞


Console.WriteLine("\n-----------------Parse numbers from strings-----------------");

int intNum = int.Parse("25");                // Парсинг целого числа из строки
double doubleNum = double.Parse("5,8");      // Парсинг дробного числа из строки
//int notNum = int.Parse("Hello!");          // Ошибка "System.FormatException" при парсинге числа, так как строка содержит не число

Console.Write("Enter a number: ");           // Enter a number: 
string numberStr = Console.ReadLine();       // Считывание введённой в консоль строки и помещение её в переменную "numberStr"
Console.WriteLine(numberStr);                // Вывод считанной строки в консоль

//int number = int.Parse(numberStr);         // Парсинг считанной строки в число
int number = Convert.ToInt32(numberStr);     // Аналог строки выше, но с помощью класса "Convert". За кулисами всё равно используется "int.Parse".
int doubled = number * 2;                    // Умножение числа на 2
bool isPositive = int.IsPositive(number);    // Проверка, является ли число положительным
