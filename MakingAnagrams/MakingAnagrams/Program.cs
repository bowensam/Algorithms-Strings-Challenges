﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingAnagrams
{
    class Program
    {
        static void Main(String[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int result = makingAnagrams(s1, s2);
            Console.WriteLine(result);
        }

        static int makingAnagrams(string s1, string s2)
        {
            // Complete this function
            Program p = new Program();
            char[] tempArray1 = s1.ToCharArray();
            char[] tempArray2 = s2.ToCharArray();

            short[] abcCountS1 = p.countLetters(tempArray1);
            short[] abcCountS2 = p.countLetters(tempArray2);

            return p.countLettersToDelete(abcCountS1, abcCountS2);
        }

        private short[] countLetters(char[] charArray)
        {
            short[] abcCount = new short[26]; //Each index corresponds to a letter in the English alphabet

            for (int i = 0; i < charArray.Length; i++)
            {
                int ascii = charArray[i]; //Obtain the ASCII value for that specific character
                abcCount[ascii - 97] += 1; //The ASCII value for "a" is 97, hence subtracted 97 to put "a" in Index 0
            }
            return abcCount;
        }

        private short countLettersToDelete(short[] abcCountS1, short[] abcCountS2)
        {
            //Note: Both parameters are generated by the countLetters method, hence they have the same length
            short deleteCount = 0;

            for (int i = 0; i < abcCountS1.Length; i++)
            {
                if (abcCountS1[i] != abcCountS2[i])
                    deleteCount += Math.Abs((short)(abcCountS1[i] - abcCountS2[i])); //Operations in C# automatically evaluates to int32 (int), hence need to explicit cast to int16 (short)
            }
            return deleteCount;
        }
    }
}
