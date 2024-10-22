Console.WriteLine("----------------------Number literals--------------------------");

var usersCount = 100;                 // int (по умолчанию)
var worldPopulation = 8_100_000_000;  // long (по умолчанию, если не хватает int)
Console.WriteLine(worldPopulation);   // 8100000000 (разделитель служит только для удобства разработчиков)

short pageNum = 342;      // Явное указание типа
var floor = (byte)4;      // Явное приведение типа

var distance = 100UL;     // Использование суффиксов (U - unsigned, L - long)

var weight = 5.0;         // double  (по умолчанию для дробных чисел)
var height = 20.5f;       // float   (суффикс f или F)
var price = 45.6m;        // decimal (суффикс m или M)


Console.WriteLine("\n----------------Specifying numbers in different number systems------------------");

var dec = 255;            // 255 в 10-ичной системе счисления
var hex = 0xFF;           // 255 в 16-ричной системе счисления (литерал начинаем с 0x)
var bin = 0b_1111_1111;   // 255 в 2-ичной системе счисления   (литерал начинаем с 0b)

Console.WriteLine(dec);   // 255
Console.WriteLine(hex);   // 255
Console.WriteLine(bin);   // 255


Console.WriteLine("\n----------------Exponential notation------------------");

var bigNumber = 8.1e9;               // 8.1 * 10^9
Console.WriteLine(bigNumber);        // 8100000000

var smallNumber = 8.1E-4;            // 8.1 * 10^-4
Console.WriteLine(smallNumber);      // 0,00081 


Console.WriteLine("\n----------------Arithmetic operations------------------");

Console.WriteLine(15 + 10);          // 25
Console.WriteLine(15 - 10);          // 5
Console.WriteLine(15 * 10);          // 150
Console.WriteLine(20 / 10);          // 2
Console.WriteLine(18 / 10);          // 1 (из-за того что оба литерала целые, дробная часть отбрасывается)
Console.WriteLine((double)18 / 10);  // 1,8
Console.WriteLine(18.0 / 10);        // 1,8
Console.WriteLine(18.0F / 10);       // 1,8
Console.WriteLine(5 % 2);            // 1 (остаток от деления 5 на 2 равен 1)
Console.WriteLine(10 % 2);           // 0 (остаток от деления 10 на 2 равен 0, так как 10 делится на 2 нацело)


Console.WriteLine("\n----------------Increment and decrement------------------");

//Console.WriteLine(5++);   // Инкремент и декремент не работает с литералами

var x = 5;
x++;                        // Постфиксный инкремент
Console.WriteLine(x);       // 6

var y = 10.1;
y--;                        // Постфиксный декремент
Console.WriteLine(y);       // 9,1
                            
++x;                        // Префиксный инкремент
Console.WriteLine(x);       // 7
                            
var n = 0;                  
Console.WriteLine(++n);     // 1
Console.WriteLine(n++);     // 1 (из-за постфиксной формы инкремента)
Console.WriteLine(n);       // 2


Console.WriteLine("\n----------------Operations precedence------------------");

Console.WriteLine(2 + 2 * 2);    // 6  (умножение, потом сложение)
Console.WriteLine((2 + 2) * 2);  // 8  (сложение, потом умножение - меняем приоритет скобками)
Console.WriteLine(15 / 3 * 2);   // 10 (деление, потом умножение - слева направо)

var k = 5;
Console.WriteLine(k++ + 10 / 2); // 10 - почему?


Console.WriteLine("\n----------------Assignment operator------------------");

var speed = 60;
int a, b, c;
a = b = c = 50;        // a = 50, b = 50, c = 50 (выполняется справа налево)

a = b = 5 + 6 / 3;     // Присваивание имеет низкий приоритет (a = b = 7)

Console.WriteLine(a);  // 7
Console.WriteLine(b);  // 7

a += 10;               // То же самое, что и "a = a + 10"
Console.WriteLine(a);  // 17

a -= 10;               // То же самое, что и "a = a - 10"
a *= 10;               // То же самое, что и "a = a * 10"   
a /= 10;               // То же самое, что и "a = a / 10"
a %= 10;               // То же самое, что и "a = a % 10"


Console.WriteLine("\n----------------Inaccuracy in the representation of floating-point numbers------------------");

double sum = 0.1 + 0.2;
Console.WriteLine(sum == 0.3);              // False

// 0.0001100110011(0011)                    // 0.1 в двоичной системе

// Для double
Console.WriteLine($"{0.1:F20}");             // 0,10000000000000000555
Console.WriteLine($"{0.2:F20}");             // 0,20000000000000001110
Console.WriteLine($"{0.3:F20}");             // 0,29999999999999998890
Console.WriteLine($"{0.1 + 0.2:F20}");       // 0,30000000000000004441

Console.WriteLine("----------------------");

// Для decimal
Console.WriteLine($"{0.1m:F20}");            // 0,10000000000000000000
Console.WriteLine($"{0.2m:F20}");            // 0,20000000000000000000
Console.WriteLine($"{0.3m:F20}");            // 0,30000000000000000000
Console.WriteLine($"{0.1m + 0.2m:F20}");     // 0,30000000000000000000

decimal sumD = 0.1m + 0.2m;
Console.WriteLine(sumD == 0.3m);                     // True


Console.WriteLine("\n----------------Comparing floating point numbers using a tolerance------------------");

double tolerance = 1e-6;
Console.WriteLine(Math.Abs(sum - 0.3) < tolerance);  // True
