using System;
using System.Diagnostics;

namespace Assignment1_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            PrintPattern(n);

            int n2 = 7;
            PrintSeries(n2);

            string s = "09:15:35PM";
            string t = UsfTime(s);
            Console.WriteLine(t);

            int n3 = 110;
            int k = 11;
            UsfNumbers(n3, k);

            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            PalindromePairs(words);


        }


        private static void PrintPattern(int n)
        {
            double num = 0;
            try
            {
                for (int count = n; count > 0; count--)
                {
                    for (int index = count; index > 0; index--)
                    {
                        var power = Math.Pow(10, (index - 1));

                        num += (index * power);

                    }
                    Console.WriteLine(num.ToString());
                    num = 0;
                }
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }
        }


        private static void PrintSeries(int n2)
        {
            try
            {
                int size = n2;
                double[] seriesarray = new double[size];
                for (int count = 1; count <= n2; count++)
                {
                    seriesarray[count - 1] = (1 + count) * count / 2;
                }

                Console.WriteLine(string.Join(",", seriesarray));
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printSeries");
            }
        }



        public static string UsfTime(string s)
        {
            try
            {
                Console.WriteLine("Enter Earth's time using the 12 hour clock format (i.e. hh:mm:ssAM or hh:mm:ssPM)");
                string earthtimeinput = Console.ReadLine();
                DateTime timeofearth = Convert.ToDateTime(earthtimeinput);

                int enteredhours = timeofearth.Hour;
                int enteredminutes = timeofearth.Minute;
                int enteredseconds = timeofearth.Second;
              
                int totalseconds = enteredhours * 3600 + enteredminutes * 60 + enteredseconds;

                int usfhours = totalseconds / (60 * 45);
                int usfminutes = (totalseconds - usfhours * (60 * 45)) / 45;
                int usfseconds = totalseconds - usfhours * (60 * 45) - usfminutes * 45;

                int[] usftime = new int[] {usfhours, usfminutes, usfseconds};

            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
            return null;
        }


        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                Console.WriteLine("Type numbers between 1 and 110, 11 numbers per line");
                string[] myIntArray = new string[110];
                int[] numbersArray = new int[110];
                for (int i = 1; i <= 110; i++)
                {
                    numbersArray[i - 1] = i;
                }
                foreach (int myNumber in numbersArray)
                {
                    if (myNumber % 15 == 0)
                    {
                        myIntArray[myNumber - 1] = "us";
                    }
                    else if (myNumber % 35 == 0)
                    {
                        myIntArray[myNumber - 1] = "sf";
                    }
                    else if (myNumber % 3 == 0)
                    {
                        myIntArray[myNumber - 1] = "u";
                    }
                    else if (myNumber % 5 == 0)
                    {
                        myIntArray[myNumber - 1] = "s";
                    }
                    else if (myNumber % 7 == 0)
                    {
                        myIntArray[myNumber - 1] = "f";
                    }
                    else
                    {
                        myIntArray[myNumber - 1] = myNumber.ToString();
                    }

                }
                for (int a = 0; a < myIntArray.Length; a++)
                {
                    Console.Write(myIntArray[a] + " ");
                    if ((a + 1) % 11 == 0)
                    {
                        Console.WriteLine();
                    }

                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }



        public static void PalindromePairs(string[] words)
        {
            try
            {
                string inputWords = Console.ReadLine();

                string outPutIndex = null;
                string[] wordsArray = inputWords.Split(" ");
                char[] inputWrdsAsChars = inputWords.ToCharArray();

                int lengthOfChars = inputWrdsAsChars.Length;
                char[] resortCharsArray = new char[lengthOfChars];

                for (int charIndex = 0; charIndex < lengthOfChars; charIndex++)
                {
                    resortCharsArray[charIndex] = inputWrdsAsChars[lengthOfChars - 1 - charIndex];
                }

                string resortInput = new string(resortCharsArray);

                Console.WriteLine("Resort: " + resortInput);

                string[] resortWordsArray = resortInput.Split(" ");

                int RL = resortWordsArray.Length;
                int NL = wordsArray.Length;
                int nResort = 0;
                int nIput = 0;
                int Index = 0;

                for (nResort = 0; nResort < RL; nResort++)
                {

                    for (nIput = 0; nIput < NL; nIput++)
                    {
                        if (nResort != (RL - 1 - nIput))
                        {
                            string resortWords = resortWordsArray[nResort];
                            string originalWords = wordsArray[nIput];
                            bool result = resortWords.Equals(originalWords);
                            if (result == true)
                            {
                                Index = RL - 1 - nResort;
                                outPutIndex = outPutIndex + "[" + Index.ToString() + "," + nIput.ToString() +
                                    "]" + " ";
                            }
                        }
                    }
                }
                Console.WriteLine("Output: " + outPutIndex);
            }
            catch
            {

                Console.WriteLine("Exception occured while computing PalindromePairs()");
            }
        }

        public static void Stones(int n4)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }


    }
}

