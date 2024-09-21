namespace ClassLibrary
{
    public class Class1
    {
        public static string ToTitleCase(string s)
        {
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
