using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string allText = File.ReadAllText("C:/Users/kumhoidt/Downloads/macbeth2.txt");
            Console.WriteLine("Words: " + allText.WordCount());
            Console.WriteLine("Sentence: " + allText.SentenceCount());
            Console.WriteLine("Paragraph: " + allText.ParagraphCount());
            Console.ReadKey();
        }
    }
}
