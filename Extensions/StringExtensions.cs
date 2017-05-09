using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{

    /// <summary>
    /// Extensions for the String type
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Method to count the number of words in a document
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static int WordCount(this string text)
        {
            return text.Split(' ').Length;
        }

        /// <summary>
        /// Method to count the number of sentences in a document
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static int SentenceCount(this string text)
        {
            text = text.Replace("...","");
            return text.Split('.').Length;
        }

        public static int ParagraphCount(this string text)
        {
            return text.Split('\n').Length;
        }
    }
}
