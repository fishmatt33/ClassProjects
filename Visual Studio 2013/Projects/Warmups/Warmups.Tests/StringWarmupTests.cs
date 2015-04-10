using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using SampleWarmup;

namespace Warmups.Tests
{
    internal class StringWarmupTests
    {
//STRINGS //

        [TestCase("Bob", "Hello Bob!")]
        [TestCase("Alice", "Hello Alice!")]
        [TestCase("X", "Hello X!")]
        public void SayHiTest(string a, string expected)
        {
            string result = StringWarmups.SayHi(a);
            Assert.AreEqual(expected, result);
        }

        [TestCase("hi", "bye", "hibyebyehi")]
        [TestCase("yo", "alice", "yoalicealiceyo")]
        [TestCase("what", "up", "whatupupwhat")]
        public void Abbatest(string a, string b, string expected)
        {
            string result = StringWarmups.Abba(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase("i", "Yay", "<i>Yay</i>")]
        [TestCase("i", "Hello", "<i>Hello</i>")]
        [TestCase("cite", "Yay", "<cite>Yay</cite>")]
        public void MakeTagsTest(string a, string b, string expected)
        {
            string result = StringWarmups.MakeTags(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase("<<>>", "Yay", "<<Yay>>")]
        [TestCase("<<>>", "WooHoo", "<<WooHoo>>")]
        [TestCase("[[]]", "word", "[[word]]")]
        public void InsertWord(string a, string b, string expected)
        {
            string result = StringWarmups.InsertWord(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase("Hello", "lololo")]
        [TestCase("ab", "ababab")]
        [TestCase("Hi", "HiHiHi")]
        public void MultipleEndings(string a, string expected)
        {
            string result = StringWarmups.MultipleEndings(a);
            Assert.AreEqual(expected, result);
        }

        [TestCase("WooHoo", "Woo")]
        [TestCase("HelloThere", "Hello")]
        [TestCase("abcdef", "abc")]
        public void FirstHalf(string a, string expected)
        {
            string result = StringWarmups.FirstHalf(a);
            Assert.AreEqual(expected, result);
        }

        [TestCase("Hello", "ell")]
        [TestCase("Java", "av")]
        [TestCase("Coding", "odin")]
        public void TrimOne(string a, string expected)
        {
            string result = StringWarmups.TrimOne(a);
            Assert.AreEqual(expected, result);
        }

        [TestCase("hello", "hi", "hihellohi")]
        [TestCase("hi", "hello", "hihellohi")]
        [TestCase("aaa", "b", "baaab")]
        public void LongInMiddle(string a, string b, string expected)
        {
            string result = StringWarmups.LongInMiddle(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase("hello", "llohe")]
        [TestCase("java", "vaja")]
        [TestCase("hi", "hi")]
        public void RotateLeft2(string a, string expected)
        {
            string result = StringWarmups.RotateLeft2(a);
            Assert.AreEqual(expected, result);
        }

        [TestCase("hello", "lohel")]
        [TestCase("java", "vaja")]
        [TestCase("hi", "hi")]
        public void RotateRight2(string a, string expected)
        {
            string result = StringWarmups.RotateRight2(a);
            Assert.AreEqual(expected, result);
        }

        [TestCase("Hello", true, "H")]
        [TestCase("Hello", false, "o")]
        [TestCase("oh", true, "o")]
        public void TakeOne(string a, bool b, string expected)
        {
            string result = StringWarmups.TakeOne(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase("string", "ri")]
        [TestCase("code", "od")]
        [TestCase("Practice", "ct")]
        public void MiddleTwo(string a, string expected)
        {
            string result = StringWarmups.MiddleTwo(a);
            Assert.AreEqual(expected, result);
        }

        [TestCase("oddly", true)]
        [TestCase("y", false)]
        [TestCase("oddy", false)]
        public void EndsWithLy(string a, bool expected)
        {
            bool result = StringWarmups.EndsWithLy(a);
            Assert.AreEqual(expected, result);
        }

        [TestCase("Hello", 2, "Helo")]
        [TestCase("Chocolate", 3, "Choate")]
        [TestCase("Chocolate", 1, "Ce")]
        public void FrontAndBack(string str, int n, string expected)
        {
            string result = StringWarmups.FrontAndBack(str, n);
            Assert.AreEqual(expected, result);
        }

        [TestCase("java", 0, "ja")]
        [TestCase("java", 2, "va")]
        [TestCase("java", 3, "ja")]
        public void TakeTwoFromPosition(string str, int n, string expected)
        {
            string result = StringWarmups.TakeTwoFromPosition(str, n);
            Assert.AreEqual(expected, result);
        }

        [TestCase("badxx", true)]
        [TestCase("xbadxx", true)]
        [TestCase("xxbadxx", false)]
        public void HasBad(string str, bool expected)
        {
            bool result = StringWarmups.HasBad(str);
            Assert.AreEqual(expected, result);
        }

        [TestCase("hello", "he")]
        [TestCase("hi", "hi")]
        [TestCase("h", "h@")]
        public void AtFirst(string a, string expected)
        {
            string result = StringWarmups.AtFirst(a);
            Assert.AreEqual(expected, result);
        }

        [TestCase("last", "chars", "ls")]
        [TestCase("yo", "mama", "ya")]
        [TestCase("hi", "", "h@")]
        public void LastChars(string a, string b, string expected)
        {
            string result = StringWarmups.LastChars(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase("abc", "cat", "abcat")]
        [TestCase("dog", "cat", "dogcat")]
        [TestCase("abc", "", "abc")]
        public void ConCat(string a, string b, string expected)
        {
            string result = StringWarmups.ConCat(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase("coding", "codign")]
        [TestCase("cat", "cta")]
        [TestCase("ab", "ba")]
        public void SwapLast(string a, string expected)
        {
            string result = StringWarmups.SwapLast(a);
            Assert.AreEqual(expected, result);
        }



//  LOOPS  //

        [TestCase("Hi", 2, "HiHi")]
        [TestCase("Hi", 3, "HiHiHi")]
        [TestCase("Hi", 1, "Hi")]
        public void StringTimes(string a, int i, string expected)
        {
            string result = LoopWarmups.StringTimes(a, i);
            Assert.AreEqual(expected, result);
        }

        [TestCase("Chocolate", 2, "ChoCho")]
        [TestCase("Chocolate", 3, "ChoChoCho")]
        [TestCase("Abc", 2, "AbcAbc")]
        public void FrontTimes(string a, int b, string expected)
        {
            string result = LoopWarmups.FrontTimes(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase("abcxx", 1)]
        [TestCase("xxx", 2)]
        [TestCase("xxxx", 3)]
        public void CountXx(string str, int expected)
        {
            var result = LoopWarmups.CountXx(str);
            Assert.AreEqual(expected, result);
        }

        /*[TestCase("axxbb", true)]
        [TestCase("axaxxax", false)]
        [TestCase("xxxxxx", true)]
        public void DoubleXX(string str, bool expected)
        {
            bool result = LoopWarmups.DoubleXX(str);
            Assert.AreEqual(expected, result);
        }*/

        [TestCase("Hello", "Hlo")]
        [TestCase("Hi", "H")]
        [TestCase("Heeololeo", "Hello")]
        public void EveryOther(string str, string expected)
        {
            string result = LoopWarmups.EveryOther(str);
            Assert.AreEqual(expected, result);
        }

        [TestCase("Code", "CCoCodCode")]
        [TestCase("abc", "aababc")]
        [TestCase("ab", "aab")]
        public void StringExplosion(string str, string expected)
        {
            string result = LoopWarmups.StringExplosion(str);
            Assert.AreEqual(expected, result);
        }

        [TestCase("hixxhi", 1)]
        [TestCase("xaxxaxaxx", 1)]
        [TestCase("axxxaaxx", 2)]
        public void CountLast2(string str, int expected)
        {
            var result = LoopWarmups.Countlast2(str);
            Assert.AreEqual(expected, result);
        }

        //8//


        //12//

        [TestCase("xxHxix", "xHix")]
        [TestCase("abxxxcd", "abcd")]
        [TestCase("xabxxxcdx", "xabcdx")]
        public void StringX(string a, string expected)
        {
            string result = LoopWarmups.StringX(a);
            Assert.AreEqual(expected, result);
        }

        [TestCase("kitten", "kien")]
        [TestCase("Chocolate", "Chole")]
        [TestCase("CodingHorror", "Congrr")]
        public void AltPairs(string a, string expected)
        {
            string result = LoopWarmups.AltPairs(a);
            Assert.AreEqual(expected, result);
        }

        [TestCase("yakpak", "pak")]
        [TestCase("pakyak", "pak")]
        [TestCase("yak123ya", "123ya")]
        public void DoNotYak(string a, string expected)
        {
            string result = LoopWarmups.DoNotYak(a);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] {6, 6, 2}, 1)]
        [TestCase(new int[] {6, 6, 2, 6}, 1)]
        [TestCase(new int[] {6, 7, 2, 6}, 1)]
        public void Array667(int[] numbers, int expected)
        {
            int result = LoopWarmups.Array667(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] {1, 1, 2, 2, 1}, true, TestName = "one")]
        [TestCase(new int[] {1, 1, 2, 2, 2, 1}, false, TestName = "two")]
        [TestCase(new int[] {1, 1, 1, 2, 2, 2, 1}, false, TestName = "three")]
        public void NoTriples(int[] numbers, bool expected)
        {
            bool result = LoopWarmups.NoTriples(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] {1, 2, 7, 1}, true)]
        [TestCase(new int[] {1, 2, 8, 1}, false)]
        [TestCase(new int[] {2, 7, 1}, true)]
        public void Pattern51(int[] numbers, bool expected)
        {
            bool result = LoopWarmups.Pattern51(numbers);
            Assert.AreEqual(expected, result);
        }



        // CONDITIONALS //


        [TestCase(true, true, true)]
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        public void AreWeInTrouble(bool asmile, bool bsmile, bool expected)
        {
            bool result = ConditionalWarmups.AreWeInTrouble(asmile, bsmile);
            Assert.AreEqual(expected, result);
        }

        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, true)]
        public void sleepIn(bool isWeekday, bool isVacation, bool expected)
        {
            bool result = ConditionalWarmups.sleepIn(isWeekday, isVacation);
            Assert.AreEqual(expected, result);
        }

        [TestCase(1, 2, 3)]
        [TestCase(3, 2, 5)]
        [TestCase(2, 2, 8)]
        public void SumDouble(int a, int b, int expected)
        {
            int result = ConditionalWarmups.SumDouble(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase(23, 4)]
        [TestCase(10, 11)]
        [TestCase(21, 0)]
        public void Diff21(int n, int expected)
        {
            int result = ConditionalWarmups.Diff21(n);
            Assert.AreEqual(expected, result);
        }

        [TestCase(true, 6, true)]
        [TestCase(true, 7, false)]
        [TestCase(false, 6, false)]
        public void ParrotTrouble(bool isTalking, int hour, bool expected)
        {
            bool result = ConditionalWarmups.ParrotTrouble(isTalking, hour);
            Assert.AreEqual(expected, result);
        }

        [TestCase(9, 10, true)]
        [TestCase(9, 9, false)]
        [TestCase(1, 9, true)]
        public void Makes10(int a, int b, bool expected)
        {
            bool result = ConditionalWarmups.Makes10(a, b);
            Assert.AreEqual(expected, result);
        }




        //  LOGIC // 


        [TestCase(30, false, false)]
        [TestCase(50, false, true)]
        [TestCase(70, true, true)]
        public void GreatParty(int cigars, bool isWeekend, bool expected)
        {
            bool result = LogicWarmups.GreatParty(cigars, isWeekend);
            Assert.AreEqual(expected, result);
        }

        [TestCase(5, 10, 2)]
        [TestCase(5, 2, 0)]
        [TestCase(5, 5, 1)]
        public void CanHazTable(int a, int b, int expected)
        {
            int result = LogicWarmups.CanHazTable(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase(70, false, true)]
        [TestCase(95, false, false)]
        [TestCase(95, true, true)]
        public void PlayOutside(int a, bool b, bool expected)
        {
            bool result = LogicWarmups.PlayOutside(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase(60, false, 0)]
        [TestCase(65, false, 1)]
        [TestCase(65, true, 0)]
        public void CaughtSpeeding(int a, bool b, int expected)
        {
            int result = LogicWarmups.CaughtSpeeding(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase(3, 4, 7)]
        [TestCase(9, 4, 20)]
        [TestCase(10, 11, 21)]
        public void SkipSum(int a, int b, int expected)
        {
            int result = LogicWarmups.SkipSum(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase(1, false, "7:00")]
        [TestCase(5, false, "7:00")]
        [TestCase(0, false, "10:00")]

        public void AlarmClock(int a, bool b, string expected)
        {
            string result = LogicWarmups.AlarmClock(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase(6, 4, true)]
        [TestCase(4, 5, false)]
        [TestCase(1, 5, true)]
        public void LoveSix(int a, int b, bool expected)
        {
            bool result = LogicWarmups.LoveSix(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase(5, false, true)]
        [TestCase(11, false, false)]
        [TestCase(11, true, true)]
        public void InRange(int n, bool outdoorMode, bool expected)
        {
            bool result = LogicWarmups.InRange(n, outdoorMode);
            Assert.AreEqual(expected, result);
        }

        [TestCase(22, true)]
        [TestCase(23, true)]
        [TestCase(24, false)]
        public void SpecialEleven(int n, bool expected)
        {
            bool result = LogicWarmups.SpecialEleven(n);
            Assert.AreEqual(expected, result);
        }

        [TestCase(20, false)]
        [TestCase(21, true)]
        [TestCase(22, true)]
        public void Mod20(int n, bool expected)
        {
            bool result = LogicWarmups.Mod20(n);
            Assert.AreEqual(expected, result);
        }

        [TestCase(3, true)]
        [TestCase(10, true)]
        [TestCase(15, false)]
        public void Mod35(int n, bool expected)
        {
            bool result = LogicWarmups.Mod35(n);
            Assert.AreEqual(expected, result);
        }

        //  ARRAYS  //

        [TestCase(new int[] {1, 2, 3}, new int[] {1, 2, 0}, TestName = "Validate1")]
        [TestCase(new int[] {2, 3, 5}, new int[] {2, 0, 5}, TestName = "Validate2")]
        [TestCase(new int[] {1, 2, 1}, new int[] {1, 2, 1}, TestName = "Validate3")]
        public void Validate_Fix23(int[] numbers, int[] expected)
        {
            int[] result = ArrayWarmups.Fix23(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] {1, 2, 3}, new int[] {4, 5, 6}, new int[] {2, 5}, TestName = "Validate1")]
        [TestCase(new int[] {7, 7, 7}, new int[] {3, 8, 0}, new int[] {7, 8}, TestName = "Validate2")]
        [TestCase(new int[] {5, 2, 9}, new int[] {1, 4, 5}, new int[] {2, 4}, TestName = "Validate3")]
        public void GetMiddle(int[] a, int[] b, int[] expected)
        {
            int[] result = ArrayWarmups.GetMiddle(a, b);
            Assert.AreEqual(expected, result);

        }

        [TestCase(3, new int[] {3, 1, 4})]
        public void MakePi(int n, int[] expected)
        {
            int[] result = ArrayWarmups.MakePi(n);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] {1, 2, 3}, new int[] {7, 3}, true)]
        [TestCase(new int[] {1, 2, 3}, new int[] {7, 3, 2}, false)]
        [TestCase(new int[] {1, 2, 3}, new int[] {1, 3}, true)]
        public void CommonEnd(int[] a, int[] b, bool expected)
        {
            bool result = ArrayWarmups.CommonEnd(a, b);
            Assert.AreEqual(expected, result);

        }

        [TestCase(new int[] {1, 2, 3}, 6)]
        [TestCase(new int[] {5, 11, 2}, 18)]
        [TestCase(new int[] {7, 0, 0}, 7)]
        public void Sum(int[] numbers, int expected)
        {
            int result = ArrayWarmups.Sum(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] {1, 2, 3}, new int[] {2, 3, 1})]
        [TestCase(new int[] {5, 11, 9}, new int[] {11, 9, 5})]
        [TestCase(new int[] {7, 0, 0}, new int[] {0, 0, 7})]
        public void RotateLeft(int[] numbers, int[] expected)
        {
            int[] result = ArrayWarmups.RotateLeft(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] {1, 2, 3}, new int[] {3, 2, 1})]
        [TestCase(new int[] {4, 5, 6}, new int[] {6, 5, 4})]
        [TestCase(new int[] {7, 8, 9}, new int[] {9, 8, 7})]
        public void Reverse1(int[] a, int[] expected)
        {
            int[] result = ArrayWarmups.Reverse(a);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] {1, 2, 3}, new int[] {3, 3, 3})]
        [TestCase(new int[] {11, 5, 9}, new int[] {11, 11, 11})]
        [TestCase(new int[] {2, 11, 3}, new int[] {3, 3, 3})]
        public void HigherWins(int[] numbers, int[] expected)
        {
            int[] result = ArrayWarmups.HigherWins(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] {1, 2, 3}, new int[] {4, 5, 6}, new int[] {2, 5})]
        [TestCase(new int[] {7, 7, 7}, new int[] {3, 8, 0}, new int[] {7, 8})]
        [TestCase(new int[] {5, 2, 9}, new int[] {1, 4, 5}, new int[] {2, 4})]
        public void GetMiddle1(int[] a, int[] b, int[] expected)
        {
            int[] result = ArrayWarmups.GetMiddle1(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] {2, 5}, true)]
        [TestCase(new int[] {4, 3}, true)]
        [TestCase(new int[] {7, 5}, false)]
        public void HasEven(int[] numbers, bool expected)
        {
            bool result = ArrayWarmups.HasEven(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[]{4, 5, 6}, new int[]{0, 0, 0, 0, 0, 6})]
        [TestCase(new int[]{1, 2}, new int[]{0, 0, 0, 2})]
        [TestCase(new int[]{3}, new int[]{0, 3})]

        public void KeepLast(int[] numbers, int[] expected)
        {
            int[] result = ArrayWarmups.KeepLast(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] {2, 2, 3}, true)]
        [TestCase(new int[] {3, 4, 5, 3}, true)]
        [TestCase(new int[] {2, 3, 2, 2}, false)]
        public void Double23(int[] numbers, bool expected)
        {
            bool result = ArrayWarmups.Double23(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] {1, 3, 4, 5}, true)]
        [TestCase(new int[] {2, 1, 3, 4, 5}, true)]
        [TestCase(new int[] {1, 1, 1}, false)]
        public void Unlucky1(int[] numbers, bool expected)
        {
            bool result = ArrayWarmups.Unlucky1(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] {4, 5}, new int[] {1, 2, 3}, new int[] {4, 5})]
        [TestCase(new int[] {4}, new int[] {1, 2, 3}, new int[] {4, 1})]
        [TestCase(new int[] {}, new int[] {1, 2}, new int[] {1, 2})]
        public void Make2(int[] a, int[] b, int[] expected)
        {
            int[] result = ArrayWarmups.Make2(a, b);
            Assert.AreEqual(expected, result);
        }

    }
}
