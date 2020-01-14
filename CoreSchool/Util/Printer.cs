using static System.Console;

namespace CoreSchool.Util
{
    public static class Printer
    {
        public static void DrawLinea(int size = 10)
        {
            var line = "".PadLeft(size, '=');
            WriteLine(line);
        }

        public static void WriteTitle(string title)
        {
            DrawLinea(title.Length);
            WriteLine(title);
            DrawLinea(title.Length);
        }
    }
}