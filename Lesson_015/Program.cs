using System.Globalization;

Console.WriteLine("-----------------Strings equality-----------------");

Console.WriteLine("cat" == "cat");                                               // True
Console.WriteLine("cat" != "dog");                                               // True
Console.WriteLine("cat" == "Cat");                                               // False (так как разный регистр)
Console.WriteLine("cat".ToUpper() == "Cat".ToUpper());                           // True  (привели к одному регистру)
Console.WriteLine("cat".Equals("Cat", StringComparison.OrdinalIgnoreCase));      // True  (сравнение без учёта регистра)

Console.WriteLine("-----------------Ordinal and invariant comparisons-----------------");

// é = \u00E9
// é = e\u0301

// Одно и то же слово, закодированное по-разному
string resume1 = "résume";
string resume2 = "re\u0301sume";

Console.WriteLine(resume1 == resume2);                                           // False (оператор "==" использует "Ordinal" сравнение)
Console.WriteLine(resume1.Equals(resume2, StringComparison.Ordinal));            // False (при использовании "Ordinal" сравниваются коды символов, а так как строки содержат даже разное кол-во символов, то они никак не могут быть равны)
Console.WriteLine(resume1.Equals(resume2, StringComparison.InvariantCulture));   // True  ("InvariantCulture" знает особенности кодирования и может их учитывать при сравнении)

Console.WriteLine(Thread.CurrentThread.CurrentCulture);                          // ru-RU

Console.WriteLine("-----------------Turkish nuances-----------------");

// В турецком языке две буквы I - одна с точкой, а другая без точки
// ı -> I
// i -> İ

var turkishCulture = new CultureInfo("tr-TR");
//Thread.CurrentThread.CurrentCulture = turkishCulture;

Console.WriteLine(string.Equals("ı", "I", StringComparison.CurrentCultureIgnoreCase));  // В зависимоти от текущей культуры
Console.WriteLine(string.Equals("i", "İ", StringComparison.CurrentCultureIgnoreCase));  // В зависимоти от текущей культуры
Console.WriteLine(string.Equals("i", "I", StringComparison.CurrentCultureIgnoreCase));  // В зависимоти от текущей культуры

Console.WriteLine();

Console.WriteLine(string.Compare("ı", "I", true, turkishCulture) == 0);   // True
Console.WriteLine(string.Compare("i", "İ", true, turkishCulture) == 0);   // True
Console.WriteLine(string.Compare("i", "I", true, turkishCulture) == 0);   // False

Console.WriteLine("-----------------Strings comparison-----------------");

//Console.WriteLine("cat" < "dog");               // Операторы <, >, <=, >= не могут быть применены к строкам

Console.WriteLine(string.Compare("cat", "dog"));  // -1
Console.WriteLine(string.Compare("dog", "cat"));  // 1
Console.WriteLine(string.Compare("cat", "cat"));  // 0

Console.WriteLine("cat".CompareTo("dog"));        // -1
Console.WriteLine("dog".CompareTo("cat"));        // 1
Console.WriteLine("cat".CompareTo("cat"));        // 0


Console.WriteLine("-----------------Strings sorting-----------------");

// CurrentCulture
{
    string[] words = ["ёлка", "яблоко", "арбуз"];
    Array.Sort(words);                                 // "CurrentCulture" по умолчанию
    Console.WriteLine(string.Join(", ", words));       // арбуз, ёлка, яблоко
}

// Ordinal
{
    string[] words = ["ёлка", "яблоко", "арбуз"];
    Array.Sort(words, StringComparer.Ordinal);
    Console.WriteLine(string.Join(", ", words));       // арбуз, яблоко, ёлка    
}


Console.WriteLine("-----------------Numbers and dates formatting-----------------");

var usCulture = new CultureInfo("en-US");

double number = 2589043.58923;
DateTime date = new(2024, 5, 7, 15, 9, 58);  // May 7, 2024, 15:09:58

Console.WriteLine("-----------------Number formatting-----------------");

Console.WriteLine(number.ToString("N", CultureInfo.CurrentCulture));     // 2 589 043,59
Console.WriteLine(number.ToString("N", usCulture));                      // 2,589,043.589
Console.WriteLine(number.ToString("N", CultureInfo.InvariantCulture));   // 2,589,043.59

Console.WriteLine("-----------------Currency formatting-----------------");

Console.WriteLine(number.ToString("C", CultureInfo.CurrentCulture));     // 2 589 043,59 ₽
Console.WriteLine(number.ToString("C", usCulture));                      // $2,589,043.59
Console.WriteLine(number.ToString("C", CultureInfo.InvariantCulture));   // ¤2,589,043.59

Console.WriteLine("-----------------Date default formatting-----------------");

Console.WriteLine(date.ToString(CultureInfo.CurrentCulture));            // 07.05.2024 15:09:58
Console.WriteLine(date.ToString(usCulture));                             // 5/7/2024 3:09:58 PM
Console.WriteLine(date.ToString(CultureInfo.InvariantCulture));          // 05/07/2024 15:09:58

Console.WriteLine("-----------------Date long formatting-----------------");

Console.WriteLine(date.ToString("F", CultureInfo.CurrentCulture));       // 7 мая 2024 г. 15:09:58
Console.WriteLine(date.ToString("F", usCulture));                        // Tuesday, May 7, 2024 3:09:58 PM
Console.WriteLine(date.ToString("F", CultureInfo.InvariantCulture));     // Tuesday, 07 May 2024 15:09:58


Console.WriteLine("-----------------Console input-----------------");

Console.Write("Enter a fraction number: ");
string fractionNumStr = Console.ReadLine();
double fractionNum = double.Parse(fractionNumStr, CultureInfo.InvariantCulture);
Console.WriteLine($"Num is {fractionNum}");
