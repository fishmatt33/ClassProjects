using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SampleWarmup
{
    public static class StringWarmups
    {
        // STRINGS //

        public static string SayHi(string name)
        {
            return string.Format("Hello {0}!", name);

        }

        public static string Abba(string a, string b)
        {
            return string.Format("{0}{1}{1}{0}", a, b);

        }

        public static string MakeTags(string tag, string content)
        {
            return string.Format("<{0}>{1}</{0}>", tag, content);
        }

        public static string InsertWord(string container, string word)
        {

            string beginning = container.Substring(0, 2);
            string middle = container.Substring(2, 2);
            return string.Format("{0}{1}{2}", beginning, word, middle);
        }

        public static string MultipleEndings(string test)
        {
            string replace = test.Substring(test.Length - 2, 2);
            return string.Format("{0}{0}{0}", replace);
        }

        public static string FirstHalf(string first)
        {
            return first.Substring(0, first.Length / 2);
        }

        public static string TrimOne(string trim)
        {
            int len = trim.Length;
            string firstOne = trim.Substring(1, len - 1);
            string lastOne = firstOne.Substring(0, firstOne.Length - 1);
            return string.Format("{0}", lastOne);

        }

        public static string LongInMiddle(string first, string second)
        {
            int firstLen = first.Length;
            int secondLen = second.Length;
            if (first.Length > second.Length)
            {
                return string.Format("{1}{0}{1}", first, second);
            }
            return string.Format("{0}{1}{0}", first, second);
        }

        public static string RotateLeft2(string blah)
        {
            if (blah.Length > 0)
            {
                return string.Format("{0}{1}", blah.Substring(2, blah.Length - 2), blah.Substring(0, 2));
            }
            return blah;
        }

        public static string RotateRight2(string ugh)
        {
            if (ugh.Length > 0)
            {
                return string.Format("{0}{1}", ugh.Substring(ugh.Length - 2, 2), ugh.Substring(0, ugh.Length - 2));
            }
            return ugh;
        }

        public static string TakeOne(string dough, bool duh)
        {
            if (duh == true)
            {
                return string.Format("{0}", dough.Substring(0, 1));
            }

            else
            {
                return string.Format("{0}", dough.Substring(dough.Length - 1, 1));
            }
        }

        public static string MiddleTwo(string ahhhh)
        {
            var NewMiddle = ahhhh.Substring(ahhhh.Length / 2 - 1, 2);
            return NewMiddle;
        }

        public static bool EndsWithLy(string take)
        {
            if (take.EndsWith("ly"))
            {
                return true;
            }
            return false;

        }

        public static string FrontAndBack(string str, int n)
        {
            string beginning = str.Substring(0, n);
            string ending = str.Substring(str.Length - n, n);
            return string.Format(beginning + ending);

        }

        public static string TakeTwoFromPosition(string str, int n)
        {
            string beginning = str.Substring(0, 2);

            if (n > str.Length - 2)
            {
                return string.Format(beginning);
            }
            string Ending = str.Substring(n, 2);
            return string.Format(Ending);
        }

        public static bool HasBad(string str)
        {
            string hasBad = str.Substring(0, 4);
            if (hasBad.Contains("bad"))
            {
                return true;
            }
            return false;
        }

        public static string AtFirst(string str)
        {
            if (str.Length > 1)
            {
                return str.Substring(0, 2);
            }
            else
            {
                return str + "@";
            }
        }

        public static string LastChars(string a, string b)
        {
            if (a.Length < 1 || b.Length < 1)
            {
                return a.Substring(0, 1) + "@";
            }
            return a.Substring(0, 1) + b.Substring(b.Length - 1);
        }

        public static string ConCat(string a, string b)
        {
            if (a == "")
            {
                return b;
            }
            if (b == "")
            {
                return a;
            }
            if (a.EndsWith(b.Substring(0, 1)) && b.StartsWith(a.Substring(a.Length - 1, 1)))
            {
                return a.Substring(0, a.Length - 1) + b;
            }
            return a + b;
        }

        public static string SwapLast(string str)
        {
            string first = str.Substring(0, str.Length - 2);
            string second = str.Substring(str.Length - 2, 1);
            string last = str.Substring(str.Length - 1, 1);
            return first + last + second;
        }


    }

    // LOOPS //

    public static class LoopWarmups
    {

        public static string StringTimes(string word, int n)
        {
            string resultString = string.Empty;
            for (int i = 0; i < n; i++)
            {
                resultString += word;
            }
            return resultString;

        }

        public static string FrontTimes(string str, int n)
        {
            string resultString = string.Empty;
            if (str.Length < 3)
            {
                for (int i = 0; i < n; i++)
                {
                    resultString += str;
                }
            }
            for (int i = 0; i < n; i++)
            {
                resultString += str.Substring(0, 3);
            }
            return resultString;
        }

        public static int CountXx(string str)
        {
            int numbers = 0;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str.Substring(i, 2).Equals("xx"))
                {
                    numbers++;
                }
            }
            return numbers;

        }

        /*public static bool DoubleXX(string str)
         {
            for (str.Contains("xx"))
             {
                if (FirstHalf('xx')) 
                return (true);
             }
             return false;
             
         }*/

        public static string EveryOther(string str)
        {
            string output = "";
            for (int i = 0; i < str.Length; i += 2)
            {
                output = output + str[i];
            }
            return output;
        }

        public static string StringExplosion(string str)
        {
            string strResult = "";
            for (int i = 0; i < str.Length; i++)
            {
                strResult += str.Substring(0, i + 1);
            }
            return strResult;
        }

        public static int Countlast2(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str.Substring(i, 2) == str.Substring(str.Length - 2, 2))
                {
                    count++;
                }


            }
            return count;

        }


        // #12 //
        public static string StringX(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if ((i == 0) || (i == str.Length - 1) || (str[i] != 'x'))
                {
                    result += str[i];
                }
            }
            return result;

        }

        public static string AltPairs(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 4 < 2)
                {
                    result += str[i];
                }
            }
            return result;
        }

        public static string DoNotYak(string str)
        {
            return str.Replace("yak", "");
        }

        public static int Array667(int[] numbers)
        {
            int count = 0;

            for (int i = 0; i < 8; i++)
            {
                if (i == 6 && (i == 6 || i == 7))
                {
                    count++;
                }
            }
            return count;
        }

        public static bool NoTriples(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1] && numbers[i + 1] == numbers[i + 2])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool Pattern51(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == 2 && numbers[i + 1] == 7 && numbers[i + 2] == 1)
                {
                    return true;
                }
            }
            return false;
        }
    }

    // CONDITIONALS  //

    public static class ConditionalWarmups
    {


        public static bool AreWeInTrouble(bool asmile, bool bsmile)
        {
            if (asmile == bsmile)
                return true;
            else
            {
                return false;
            }
        }

        public static bool sleepIn(bool isWeekday, bool isVacation)
        {
            if (isWeekday == false)
            {
                return true;
            }
            else if (isVacation == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int SumDouble(int a, int b)
        {
            if (a == b)
            {
                return ((a + b) * 2);
            }
            else
            {
                return (a + b);
            }
        }

        public static int Diff21(int n)
        {
            if (n == 21)
            {
                return (0);
            }
            else if (n > 21)
            {
                return ((n - 21) * 2);
            }
            else
            {
                return (21 - n);
            }
        }

        public static bool ParrotTrouble(bool isTalking, int hour)
        {
            if (isTalking == true && hour < 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Makes10(int a, int b)
        {
            if (a + b == 10)
            {
                return true;
            }
            else if (a == 10)
            {
                return true;
            }
            else if (b == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    // LOGIC  //

    public static class LogicWarmups
    {

        public static bool GreatParty(int cigars, bool isWeekend)
        {
            if (!isWeekend)
            {
                if (cigars >= 40 && cigars <= 60)
                    return true;
            }
            else if (isWeekend)
            {
                if (cigars >= 40)
                    return true;
            }

            return false;
        }

        public static int CanHazTable(int a, int b)
        {
            if (a >= 8 || b >= 8)
            {
                return (2);
            }
            if (a <= 2 || b <= 2)
            {
                return (0);
            }
            return (1);
            
        }

        public static bool PlayOutside(int temp, bool isSummer)
        {
            if (!isSummer)
            {
                if (temp >= 60 && temp <= 90)
                {
                    return true;
                }
            }
            else if (isSummer)
            {
                if (temp <= 100)
                    return true;
            }
            return false;
        }

        public static int CaughtSpeeding(int speed, bool isBirthday)
        {
            if (!isBirthday)
            {
                if (speed <= 60)
                {
                    return (0);
                }
                else if (speed >= 61 || speed <= 80)
                {
                    return (1);
                }
                return (2);
            }
            return (0);
        }

        public static int SkipSum(int a, int b)
        {


            if ((a + b) >= 10 && (a + b) <= 19)
            {
                return (20);
            }
            return (a + b);
        }

        public static string AlarmClock(int day, bool vacation)
        {
            if (!vacation)
            {
                if (day >= 1 && day <= 5)
                {
                    return ("7:00");
                }
                else if (day == 0 || day == 6)
                {
                    return ("10:00");
                }
                return ("Can not compute");
            }
            return ("10:00");
        }

        public static bool LoveSix(int a, int b)
        {
            if (a + b == 6)
            {
                return true;
            }
            else if (a == 6 || b == 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool InRange(int n, bool outsideMode)
        {
            if (!outsideMode)
            {
                if (n >= 1 && n <= 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;

        }

        public static bool SpecialEleven(int n)
        {
            if (n%11 == 0 || n%11 == 1)
            {
                return true;
            }
            return false;
        }

        public static bool Mod20(int n)
        {
            if (n%20 == 1 || n%20 == 2)
            {
                return true;
            }
            return false;
        }

        public static bool Mod35(int n)
        {
            if (n%15 == 0)
            {
                return false;
            }
            else if (n%3 == 0 || n%5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    // ARRAYS //

    public static class ArrayWarmups
    {
        public static int[] Fix23(int[] numbers)
        {
            int[] rearranged = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                rearranged[i] = numbers[i];

                if (numbers[i] == 2 && numbers[i + 1] == 3)
                {
                    numbers[i + 1] = 0;
                }
            }
            return rearranged;
        }

        public static int[] GetMiddle(int[] a, int[] b)
        {
            int[] rearranged = new int[2];
            rearranged[0] = a[1];
            rearranged[1] = b[1];
            return rearranged;
        }

        public static int[] MakePi(int n)
        {
            double pi = Math.PI;
            var str = pi.ToString().Remove(1, 1);
            var chararray = str.ToCharArray();
            var numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(chararray[i].ToString());
            }
            return numbers;

        }

        public static bool CommonEnd(int[] a, int[] b)
        {
            if ((a[0] == b[0]) || (a[a.Length -1] == b[b.Length -1]))
            {
                return true;
            }
            return false;
        }

        public static int Sum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static int[] RotateLeft(int[] numbers)
        {
            int first = 0;
            first = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i - 1] = numbers[i];
            }
            numbers[numbers.Length - 1] = first;
            return numbers;

        }

        public static int[] Reverse(int[] a)
        {
            Array.Reverse(a);
            return a;
        }

        public static int[] HigherWins(int[] numbers)
        {

            int max1 = Math.Max(numbers[0], numbers[numbers.Length - 1]);

            int[] returnValue = new[] {max1, max1, max1};

            return returnValue;
        }

        public static int[] GetMiddle1(int[] a, int[] b)
        {
            int midA = a[a.Length/2];
            int midB = b[b.Length/2];

            int[] MiddleAandB = new[] {midA, midB};

            return MiddleAandB;
        }

        public static bool HasEven(int[] numbers)
        {
            foreach (var num in numbers)
            {
                if (num%2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static int[] KeepLast(int[] numbers)
        {
            int length = numbers.Length;
            int[] nums2 = new int[length*2];
            int last = numbers[length - 1];
            nums2[nums2.Length - 1] = last;

            return nums2;

        }

        public static bool Double23(int[] numbers)
        {
            if (numbers.Length > 1)
            {
                return ((numbers[0] == 2 && numbers[1] == 2) || (numbers[0] == 3 && numbers[1] == 3 || (numbers[0] == 3 && numbers[3] == 3)));
            }
            else
            {
                return false;
            }

        }

        public static bool Unlucky1(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == 1 && numbers[i + 1] == 3)
                {
                    return true;
                }
            }
            return false;
        }

        public static int[] Make2(int[] a, int[] b)
        {
            int[] newArray = new int[2];

            if (a.Length >= 2)
            {
                newArray[0] = a[0];
                newArray[1] = a[1];
            }
            else if (a.Length == 1)
            {
                newArray[0] = a[0];
                newArray[1] = b[0];
            }
            else
            {
                newArray[0] = b[0];
                newArray[1] = b[1];
            }
            return newArray;
        }
    }

}








