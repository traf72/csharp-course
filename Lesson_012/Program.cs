Console.WriteLine("\n------------Boolean type------------");

bool no = false;
bool yes = true;

Console.WriteLine(no);   // False
Console.WriteLine(yes);  // True

bool a = 10 > 5;         // true
bool b = 2 == 3;         // false

Console.WriteLine(a);    // True
Console.WriteLine(b);    // False


Console.WriteLine("\n------------Comparison operators------------");

// ==
Console.WriteLine(10 == 10);  // True
Console.WriteLine(7 == 8);    // False

// !=
Console.WriteLine(10 != 10);  // False
Console.WriteLine(7 != 8);    // True

// <, >, <=, >=
Console.WriteLine(10 < 8);    // False
Console.WriteLine(8 < 8);     // False
Console.WriteLine(8 <= 8);    // True

int age = 17;
if (age >= 18)
{
    Console.WriteLine("Allow voting");
}
else
{
    Console.WriteLine("Forbid voting");
}


Console.WriteLine("\n------------Logical operators------------");

Console.WriteLine("\nAND (& / &&)");

Console.WriteLine(no && no);     // False
Console.WriteLine(no && yes);    // False
Console.WriteLine(yes && no);    // False
Console.WriteLine(yes && yes);   // True


Console.WriteLine("\nOR (| / ||)");

Console.WriteLine(no || no);     // False
Console.WriteLine(no || yes);    // True
Console.WriteLine(yes || no);    // True
Console.WriteLine(yes || yes);   // True


Console.WriteLine("\nNOT (!)");

Console.WriteLine(!no);         // True
Console.WriteLine(!yes);        // False


Console.WriteLine("\nXOR (^)");

Console.WriteLine(no ^ no);     // False
Console.WriteLine(no ^ yes);    // True
Console.WriteLine(yes ^ no);    // True
Console.WriteLine(yes ^ yes);   // False

bool hasPassport = true;
age = 25;
if (age >= 18 && hasPassport)   // Проверка сразу двух условий, используя логическое "И"
{
    Console.WriteLine("Allow voting");
}
else
{
    Console.WriteLine("Forbid voting");
}


Console.WriteLine("\n------------Difference between full and short-circuit operators------------");

bool result = False() & True();  // Полная версия оператора - всегда будут вычисляться оба операнда.
Console.WriteLine(result);       // False

result = False() && True();      // Short-circuit версия оператора - второй операнд вычисляться не будет, так как первый операнд равен "false", а значит результат уже не зависит от значения второго операнда и тоже будет равен "false".
Console.WriteLine(result);       // False

result = True() && False();      // Short-circuit версия оператора - второй операнд всё равно будет вычисляться, так как первый операнд равен "true", и одного данного значения не достаточно для определения конечного результата.
Console.WriteLine(result);       // False

result = True() | False();       // Полная версия оператора - всегда будут вычисляться оба операнда.
Console.WriteLine(result);       // True

result = True() || False();      // Short-circuit версия оператора - второй операнд вычисляться не будет, так как первый операнд равен "true", а значит результат уже не зависит от значения второго операнда и тоже будет равен "true".
Console.WriteLine(result);       // True

bool False()
{
    Console.WriteLine("False has been called");
    return false;
}

bool True()
{
    Console.WriteLine("True has been called");
    return true;
}


Console.WriteLine("\n------------Operators priorities------------");

result = 2 < 3 == 10 > 6;
Console.WriteLine(result);           // True

result = 5 < 8 && 7 == 7;
Console.WriteLine(result);           // True

result = (5 < 8) || (7 == 7);        // Скобки необязательны, но улучшают читаемость
Console.WriteLine(result);           // True

result = !true || true;
Console.WriteLine(result);           // True

result = false || (true && false);   // Скобки необязательны, но улучшают читаемость
Console.WriteLine(result);           // False

result = (true && !true) || false;   // Скобки необязательны, но улучшают читаемость
Console.WriteLine(result);           // False

result = true ^ false && false;      // (true ^ false) && false, так как полные операторы имеют приоритет над short-circuit операторами
Console.WriteLine(result);           // False

result = true | false && false;      // (true | false) && false, так как полные операторы имеют приоритет над short-circuit операторами
Console.WriteLine(result);           // False
