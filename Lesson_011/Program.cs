using System.Drawing;

Console.WriteLine("--------------------Bitwise operators---------------------");

int x = 14;
int y = 29;
int result = x & y;          // Побитовое "И" (AND)

Console.WriteLine(result);   // 12

// Составное присваивание (справедливо для всех побитовых операторов)
result &= 5;                 // result = result & 5;

Console.WriteLine(x | y);    // 31 - побитовое "ИЛИ" (OR)
Console.WriteLine(x ^ y);    // 19 - побитовое "Исключающее ИЛИ" (XOR)

Console.WriteLine(~x);       // -15 - побитовое "НЕ" (NOT)
Console.WriteLine(~y);       // -30 - побитовое "НЕ" (NOT)

Console.WriteLine(x << 1);   // 28  - сдвиг влево на 1 позицию (Left Shift)
Console.WriteLine(-5 << 3);  // -40 - сдвиг влево на 3 позиции (Left Shift)

Console.WriteLine(x >> 1);   // 7  - сдвиг вправо на 1 позицию (Right Shift)
Console.WriteLine(-20 >> 3); // -3 - сдвиг вправо на 3 позиции (Right Shift)
Console.WriteLine(20 >> 3);  // 2  - сдвиг вправо на 3 позиции (Right Shift)

Console.WriteLine("\n------------------Bitwise flags---------------------");
/*
    ------------------------------------------------
    |                 | Удаление | Запись | Чтение |
    |-----------------|----------|--------|--------|
    | Гость           |     0    |    0   |    1   |
    | Редактор        |     0    |    1   |    1   |
    | Админ           |     1    |    1   |    1   |
    ------------------------------------------------
*/

// Битовые флаги
const int read = 0b_001;
const int write = 0b_010;
const int delete = 0b_100;

Console.WriteLine(read);     // 1
Console.WriteLine(write);    // 2
Console.WriteLine(delete);   // 4

DisplayPermissions(read);    // 001
DisplayPermissions(write);   // 010
DisplayPermissions(delete);  // 100

// Битовые маски

// 001
const int guest = read;      // Гость
DisplayPermissions(guest);   // 001

/*
  001
  010
  ---
  011
*/
const int editor = read | write;          // Редактор
DisplayPermissions(editor);               // 011  

const int admin = read | write | delete;  // Админ
DisplayPermissions(admin);                // 111

const int readOrDelete = read | delete;   // Права на чтение или удаление
DisplayPermissions(readOrDelete);         // 101

// Проверка прав

/*
  001
  010
  ---
  000 (0)
*/
Console.WriteLine(guest & write);        // 0

/*
  011
  010
  ---
  010 (2)
*/
Console.WriteLine(editor & write);       // 2

/*
  111
  010
  ---
  010 (2)
*/
Console.WriteLine(admin & write);        // 2

/*
  001
  100
  ---
  000 (0)
*/
Console.WriteLine(guest & delete);       // 0

/*
  011
  100
  ---
  000 (0)
*/
Console.WriteLine(editor & delete);      // 0

/*
  111
  100
  ---
  100 (4)
*/
Console.WriteLine(admin & delete);       // 4

Console.WriteLine(HasAtLeastOnePermission(guest, write));         // False
Console.WriteLine(HasAtLeastOnePermission(editor, write));        // True
Console.WriteLine(HasAtLeastOnePermission(admin, write));         // True

Console.WriteLine(HasAtLeastOnePermission(guest, delete));        // False
Console.WriteLine(HasAtLeastOnePermission(editor, delete));       // False
Console.WriteLine(HasAtLeastOnePermission(admin, delete));        // True

/*
  001
  011
  ---
  001 (1)
*/
Console.WriteLine(HasAtLeastOnePermission(guest, read | write));  // True

DisplayPermissions(DisablePermissions(editor, read));             // 010
DisplayPermissions(DisablePermissions(admin, read | write));      // 100

// Отображает набор разрешений в двоичном виде
void DisplayPermissions(int permissions)
{
    Console.WriteLine(permissions.ToString("B3"));
}

// Проверяет, имеет ли роль хотя бы одно из переданных разрешений
bool HasAtLeastOnePermission(int role, int permissions)
{
    return (role & permissions) != 0;
}

// Отключает в роли переданные разрешения
int DisablePermissions(int role, int permissions)
{
    return role & ~permissions;
}


Console.WriteLine("\n------------------XOR--------------------");

// A ^ B ^ B = A      XOR - обратимая операция

int secretData = 48;
int key = 563;

// Шифруем данные (применяем операцию XOR между данными и ключом)
int encrypted = secretData ^ key;
Console.WriteLine(encrypted);   // 515

// Дешифруем данные данные (применяем операцию XOR между зашифрованными данными и тем же ключом)
int decrypted = encrypted ^ key;
Console.WriteLine(decrypted);   // 48


Console.WriteLine("\n------------------RGB--------------------");
byte red = 7, green = 8, blue = 9;

// Упаковывем три отдельных значения цвета в одну переменную
int color = red << 16 | green << 8 | blue;
Console.WriteLine($"#{color:X6}");           // #070809

// Распаковываем обратно отдельные цвета
byte extractedRed = (byte)(color >> 16);
byte extractedGreen = (byte)(color >> 8);
byte extractedBlue = (byte)(color);

Console.WriteLine(extractedRed);             // 7
Console.WriteLine(extractedGreen);           // 8
Console.WriteLine(extractedBlue);            // 9

Color.FromArgb(red, green, blue);  // Если перейти в исходники, то можно увидеть, что реализации RGB-цвета в BCL построена на том же принципе

int.IsEvenInteger(5);              // Внутри реализовано с помощью побитовых операторов
int.IsPow2(16);                    // Внутри реализовано с помощью побитовых операторов
