using System;

namespace SortStringTest
{
    class TestCase
    {
        public int numberOfLine { get; set; }
        public string[] lines { get; set; }
    }
    class Program
    {



        static string OrderLettersAlphabeticallyButFirstDuplicates(string letters)
        {

            char[] ordered = letters.ToCharArray();
            for (int i = 0; i < ordered.Length; i++)
            {
                for (int j = i + 1; j < ordered.Length; j++)
                {
                    if (ordered[i] > ordered[j])
                    {
                        char temp = ordered[i];
                        ordered[i] = ordered[j];
                        ordered[j] = temp;
                    }
                }
            }

            string duplicates = "";

            string uniques = "";

            for (int i = 0; i < ordered.Length; i++)
            {
                string letter = ordered[i].ToString();
                if ((i + 1) < ordered.Length && letter == ordered[i + 1].ToString())
                {
                    duplicates += ordered[i].ToString();
                }
                else if (i > 0 && letter == ordered[i - 1].ToString())
                {
                    duplicates += ordered[i].ToString();
                }
                else
                {
                    uniques += ordered[i].ToString();
                }
            }

            return duplicates + uniques;
        }
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());

            string[] lines1 = {"dulgvgzwqg",
                                    "gxtjtmtywr" ,
                                    "hnlnxiupgt" ,
                                    "gzjotckivp" ,
                                    "dpwwsdptae" ,
                                    "pcscpilknb" ,
                                    "btvyhhmflf" ,
                                    "artrtnqxcr" ,
                                    "nrtcmcoadn" ,
                                    "fkdsgnekft" };
            string[] lines2 = {"qakmc",
                                "rrtbk",
                                "vaixn",
                                "wmpnj",
                                "uproi",
                                "btska",
                                "ejgwr",
                                "elwlg",
                                "oaoiy",
                                "hrqkn"};
            string[] lines3 = { "pzjim",
                                "njnfq",
                                "xyohs"
                                };

            string[] lines4 = { "xqycs", "beoax", "afkso", "bldit", "gwrys" };

            TestCase test1 = new TestCase { numberOfLine = 10, lines = lines1 };
            TestCase test2 = new TestCase { numberOfLine = 10, lines = lines2 };
            TestCase test3 = new TestCase { numberOfLine = 3, lines = lines3 };
            TestCase test4 = new TestCase { numberOfLine = 5, lines = lines4 };


            TestCase[] testCases = { test1, test2, test3, test4 };


            int counter = 0;
            foreach (var test in testCases)
            {
                counter++;
                Console.WriteLine($"\nTest Case {counter}");
                Console.WriteLine("Input : \n");
                foreach (string line in test.lines)
                {
                    Console.WriteLine(line);

                }
                string[] result = new string[test.numberOfLine];
                for (int i = 0; i < test.numberOfLine; i++)
                {
                    string ordered = Program.OrderLettersAlphabeticallyButFirstDuplicates(test.lines[i]);
                    result[i] = ordered;

                }
                Console.WriteLine("\nResult : \n");
                foreach (string line in result)
                {
                    Console.WriteLine(line);

                }


            }

        }
    }
}
  