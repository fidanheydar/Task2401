using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2401
{
    public static  class ExtentionMethods
    {
       
            public static bool IsOdd(this int num)
            {
                if (num % 2 != 0)
                    return true;

                return false;
            }
            public static bool IsEven(this int num)
            {
                if (num % 2 == 0)
                    return true;

                return false;
            }
        public static bool IsContainsDigit(this string str)
        {
            if (String.IsNullOrWhiteSpace(str))
                return false;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    return true;
                }

            }
            return false;
        }
        public static string ToCapitalize(this string str)
        {

            if (String.IsNullOrWhiteSpace(str))
                return str;

            return char.ToUpper(str[0]) + str.Substring(1).ToLower();

        }
        public static string GetFirstSentence(this string str)
        {
            if (String.IsNullOrWhiteSpace(str))
                return str;

            return str.Substring(0, str.IndexOf('.'));

        }
        public static int[] GetValueIndexes(this string textStr, char searchedChar)
        {
            int count = 0;


            for (int i = 0; i < textStr.Length; i++)
            {
                if (textStr[i] == searchedChar)
                {
                    count++;
                }
            }
            int[] indexes = new int[count];

            int currentIndex = 0;
            for (int i = 0; i < textStr.Length; i++)
            {
                if (textStr[i] == searchedChar)
                {
                    indexes[currentIndex] = i;
                    currentIndex++;
                }
            }

            return indexes;
        }


        public static string GetSecondWord(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return str;

            int startIndex = str.IndexOf(' ');

            if (startIndex == -1)
            {
                return null;
            }

            startIndex++;

            int endIndex = str.IndexOf(' ', startIndex);

            if (endIndex == -1)
            {
                return str.Substring(startIndex);
            }

            int length = endIndex - startIndex;
            return str.Substring(startIndex, length);
        }


    }
}
