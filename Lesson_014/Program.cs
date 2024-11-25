using System.Text;

Console.WriteLine("-----------------String literals-----------------");

string greeting = "Hello";
string fullName = "Ivan Petrov";
string letterA = "A";  // Строка, не смотря на то что содержит всего один символ, так как используются двойные кавычки


Console.WriteLine("\n-----------------String constructors-----------------");

char[] charArray = ['K', 'e', 'e', 'p', ' ', 'l', 'e', 'a', 'r', 'n', 'i', 'n', 'g'];

string stringFromCharArray = new(charArray);  // Создание строки с помощью конструктора
Console.WriteLine(stringFromCharArray);       // Keep learning


Console.WriteLine("\n-----------------String concatenation using '+' operator-----------------");

string wolrdGreeting = greeting + ", World!";
Console.WriteLine(wolrdGreeting);  // Hello, World!

string ivanGreeting = greeting + ", " + fullName + "!";
Console.WriteLine(ivanGreeting);   // Hello, Ivan Petrov!


Console.WriteLine("\n-----------------String concatenation using 'Concat' method-----------------");

ivanGreeting = string.Concat(greeting, ", ", fullName, "!");
Console.WriteLine(ivanGreeting);   // Hello, Ivan Petrov!


Console.WriteLine("\n-----------------String concatenation using 'Format' method-----------------");

ivanGreeting = string.Format("{0}, {1}!", greeting, fullName);
Console.WriteLine(ivanGreeting);                     // Hello, Ivan Petrov!

Console.WriteLine("{0}, {1}!", greeting, fullName);  // Hello, Ivan Petrov!

string eventName = "Team Meeting";
string day = "Wednesday";
string time = "3:00 PM";
string location = "Conference Room B";

Console.WriteLine(
    "Reminder: {0} on {2} at {3}, located at {1}. Please be on time for the {0} at {3}, {1}.",
    eventName, location, day, time
);  // Reminder: Team Meeting on Wednesday at 3:00 PM, located at Conference Room B. Please be on time for the Team Meeting at 3:00 PM, Conference Room B.


Console.WriteLine("\n-----------------String formatting-----------------");

string destination = "Paris";
DateTime departureDate = new(2024, 9, 20, 15, 45, 0); // September 20, 2024, 15:45
decimal priceInDollars = 359;

Console.WriteLine("Travel to {0} on {1:dd.MM.yyyy} at {1:HH:mm}, Total Cost: ${2:F2}.", destination, departureDate, priceInDollars);  // Travel to Paris on 20.09.2024 at 15:45, Total Cost: $359,00.


Console.WriteLine("\n-----------------String interpolation-----------------");

Console.WriteLine($"{greeting}, {fullName.ToUpper()}!");  // Hello, IVAN PETROV!
Console.WriteLine($"Travel to {destination} on {departureDate:dd.MM.yyyy} at {departureDate:HH:mm}, Total Cost: ${priceInDollars:F2}.");  // Travel to Paris on 20.09.2024 at 15:45, Total Cost: $359,00.


Console.WriteLine("\n-----------------Escaping special characters-----------------");

Console.WriteLine("I'm working in \"Apple\"");   // I'm working in "Apple"

// C:\Program Files\MyApp
string filePath = "C:\\Program Files\\MyApp";
Console.WriteLine(filePath);                     // C:\Program Files\MyApp


Console.WriteLine("\n-----------------Verbatim strings-----------------");

string filePathVerbatim = @"C:\Program Files\MyApp";
Console.WriteLine(filePathVerbatim);             // C:\Program Files\MyApp

/*
    Twinkle, twinkle, little star,
    How I wonder what you are!
    Up above the world so high,
    Like a diamond in the sky.
*/

Console.WriteLine("Twinkle, twinkle, little star,\nHow I wonder what you are!\nUp above the world so high,\nLike a diamond in the sky.");

Console.WriteLine(@"
Twinkle, twinkle, little star,
How I wonder what you are!
Up above the world so high,
Like a diamond in the sky.");

Verse.Display(true);

Console.WriteLine();
Console.WriteLine(@"I'm working in ""Apple""");   // I'm working in "Apple"


Console.WriteLine("\n-----------------Raw string literals-----------------");

/*
{
    "subject": "example",
    "text" : "Some text"
}
 */

Console.WriteLine("{\n    \"subject\": \"example\",\n    \"text\" : \"Some text\"\n}");

Console.WriteLine(@"
{
    ""subject"": ""example"",
    ""text"" : ""Some text""
}");


Console.WriteLine(
    """
    {
        "subject": "example",
        "text" : "Some text"
    }
    """
);


Console.WriteLine("\n-----------------Strings immutability-----------------");

//greeting += ", everyone!";
//Console.WriteLine(greeting);  // Hello, everyone!


Console.WriteLine("\n-----------------Strings interning-----------------");

string greetingFirstPart = "Hel";
string greeting2 = string.Intern(greetingFirstPart + "lo");  // Интернирование строки вручную
Console.WriteLine(ReferenceEquals(greeting, greeting2));     // True (переменные указывают на один и тот же объект в памяти)


Console.WriteLine("\n-----------------StringBuilder-----------------");

string[] dataEntries = ["Chunk_1", "Chunk_2", "Chunk_3", "Chunk_4"];  // Представьте, что может быть намного больше данных, тысячи различных частей

var report = new StringBuilder();
foreach (string entry in dataEntries)
{
    report.Append($"{entry}; ");
}

Console.WriteLine(report);  // Chunk_1; Chunk_2; Chunk_3; Chunk_4;


class Verse
{
    public static void Display(bool toConsole)
    {
        if (toConsole)
        {
            Console.WriteLine(@"
Twinkle, twinkle, little star,
How I wonder what you are!
Up above the world so high,
Like a diamond in the sky.");
        }
    }
}
