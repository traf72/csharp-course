Console.WriteLine("-----------------Symbols-----------------");

char a = 'A';
Console.WriteLine(a);         // A
Console.WriteLine((int)a);    // 65 (код буквы 'A' в кодировке Unicode)

int bCode = 66;               // Код буквы 'B' в кодировке Unicode
char b = (char)bCode;         // Получаем символ по его коду
Console.WriteLine(b);         // B

char c = (char)(b + 1);       // Получаем следующий символ, добавляя к текущему 1
Console.WriteLine(c);         // C


Console.WriteLine("\n-----------------English alphabet letters count-----------------");

char firstLetter = 'a';                            // Первая буква английского алфавита
char lastLetter = 'z';                             // Последняя буква английского алфавита

int lettersCount = lastLetter - firstLetter + 1;   // Вычисляем кол-во букв английского алфавита
Console.WriteLine(lettersCount);                   // 26


Console.WriteLine("\n-----------------Digit symbols-----------------");

char digit = '8';                 // Символ цифры 8
Console.WriteLine(digit);         // 8
Console.WriteLine((int)digit);    // 56 (код символа цифры 8)

digit++;                          // Получаем следующий символ, инкрементируя текущий
Console.WriteLine(digit);         // 9

digit++;                          // Получаем следующий символ, инкрементируя текущий
Console.WriteLine(digit);         // :


Console.WriteLine("\n-----------------Symbols comparison-----------------");

Console.WriteLine('k' == 'k');    // True
Console.WriteLine('k' == 'K');    // False (разный регистр)

Console.WriteLine('a' < 'z');     // True, так как код символа 'a' меньше кода символа 'z'
Console.WriteLine('a' < 'Z');     // False, так как код символа 'a' больше кода символа 'Z' (в Unicode маленькие английские буквы идут позже больших)


Console.WriteLine("\n----------------English alphabet-----------------");

// Вывод английского алфавита
for (char letter = 'a'; letter <= 'z'; letter++)
{
    Console.Write(letter);         // abcdefghijklmnopqrstuvwxyz
}


Console.WriteLine("\n-----------------Hex input and surrogate pairs-----------------");

// \u{xxxx}
char d = '\u0044';                    // 16-ричный код символа 'D'
Console.WriteLine(d);                 // D

char infinitySymbol = '∞';            // Символ бесконечности
Console.WriteLine(infinitySymbol);    // ∞

char infinityChar = '\u221e';         // 16-ричный код символа бесконечности
Console.WriteLine(infinityChar);      // ∞

// \ud83d\ude04
string smile = "😄";                 // Символ смайлика (имеет тип "string", так как это суррогатная пара, то есть, за кулисами представляется сразу двумя символами \ud83d\ude04)
//char smileChar = '😄';             // Не компилируется, так как данный символ представляется сразу двумя символами, поэтому требуется тип "string"
Console.WriteLine(smile);            // 😄


Console.WriteLine("\n-----------------Control escape sequences-----------------");

// \n   Разрыв строки    (соответствует нажатию клавиши "Enter")
// \t	Табуляция        (соответствует нажатию клавиши "Tab")
// \r	Возврат каретки  (возвращение курсора в начало строки, соответсвует нажатию клавиши "Home")
// \b	Backspace        (обратный пробел, соответсвует нажатию клавиши "Backspace")

Console.WriteLine("\tHello\b \nWorld!");


Console.WriteLine("\n-----------------Escaping of a Single Quote-----------------");

char singleQuote = '\'';          // Символ одинарной кавычки необходимо экранировать с помощью '\'
Console.WriteLine(singleQuote);   // '


Console.WriteLine("\n-----------------Char members-----------------");

Console.WriteLine(char.IsDigit('7'));    // True
Console.WriteLine(char.IsDigit('h'));    // False
Console.WriteLine(char.IsLetter('s'));   // True
Console.WriteLine(char.ToUpper('g'));    // G
