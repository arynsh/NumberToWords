using System;
using System.Collections.Generic;

namespace NTW.Models
{
    public static class Number
    {
        static Dictionary<long,string> myDictLessHundred = new Dictionary<long,string>() {{0, ""}, {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"}, {10, "ten"}, {11, "eleven"}, {12, "twelve"}, {13, "thirteen"}, {14, "fourteen"}, {15, "fifteen"}, {16, "sixteen"}, {17, "seventeen"}, {18, "eighteen"}, {19, "nineteen"}, {20, "twenty"}, {30, "thirty"}, {40, "forty"}, {50,"fifty"}, {60, "sixty"}, {70, "seventy"}, {80, "eighty"}, {90, "ninety"}};
        // static Dictionary<long,string> myDictMoreHundred = new Dictionary<long, string>() {{100, "hundred"}, {1000, "thousand"}, {10^6, "million"}, {10^9, "billion"}, {10^12, "trillion"}};
        public static string NumberToWord(long userInput)
        {

            string result = "";
            result += LessTrillion(userInput);
            return result;
        }

        static string LessHundred (long number)
        {
            string result = "";
            if (number <= 20)
            {
                result += myDictLessHundred[number];
            } 
            else 
            {
                result += myDictLessHundred[number / 10 * 10] + " ";
                result += myDictLessHundred[number % 10];
            }
            return result;
        }
        static string LessThousand(long number)
        {
            string result = "";
            if (number > 100) 
            {
                result += myDictLessHundred[number / 100] + " hundred ";
                number = number % 100;
            }
            result += LessHundred(number);
            return result;
        }
        static string LessMillion(long number)
        {
            string result = "";
            if (number > 1000) 
            {
                result += LessThousand(number / 1000) + " thousand ";
                number = number % 1000;
            }
            result += LessThousand(number);
            return result;
        }
        static string LessBillion(long number)
        {
            string result = "";
            if (number > (1000000)) 
            {

                result += LessThousand(number / (1000000)) + " million ";
                number = number % (1000000);
            }
            result += LessMillion(number);
            return result;
        }
        static string LessTrillion(long number)
        {
            string result = "";
            if (number > (1000000000)) 
            {

                result += LessThousand(number / (1000000000)) + " billion ";
                number = number % (1000000000);
            }
            result += LessBillion(number);
            return result;
        }
    }
}
