using System;

namespace LanguageTest
{
    public class Language4
    {
        public string Name { get; set; }
        public int Version { get; set; }

        public Language4(string name, int version)
        {
            Name = name;
            Version = version;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Language: {Name}, Version: {Version}");
        }

        public static void Main(string[] args)
        {
            var language = new Language4("C#", 12);
            language.DisplayInfo();
        }
    }
}
