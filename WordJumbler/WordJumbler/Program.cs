using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordJumbler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random words");
            doList(generateWords(3, 14));
            string first = Console.ReadLine();
            string[] firs = first.Split(' ');
            int wordNum = int.Parse(firs[0]);
            int wordLength = int.Parse(firs[1]);
            List<string> viable = new List<string>();
            List<string> obsolete = new List<string>();
            for (int i = 0; i < wordNum; i++)
            {
                string currentWord = Console.ReadLine();
                string sortedWord = sortWord(currentWord);
                if (!obsolete.Contains(sortedWord))
                {
                    if (viable.Contains(sortedWord))
                    {
                        obsolete.Add(sortedWord);
                    }
                    else
                    {
                        viable.Add(sortedWord);
                    }
                }
            }
            Console.WriteLine(viable.Count);
            Console.ReadLine();
        }
        static string sortWord(string word)
        {
            char[] letters = word.ToCharArray();
            Array.Sort(letters);
            return new string(letters);
        }
        static void doList(List<string> wurds)
        {
            int wordNum = wurds.Count;
            List<string> viable = new List<string>();
            List<string> obsolete = new List<string>();
            for (int i = 0; i < wordNum; i++)
            {
                string currentWord = Console.ReadLine();
                string sortedWord = sortWord(currentWord);
                if (!obsolete.Contains(sortedWord))
                {
                    if (viable.Contains(sortedWord))
                    {
                        obsolete.Add(sortedWord);
                    }
                    else
                    {
                        viable.Add(sortedWord);
                    }
                }
            }
        }
        static List<string> generateWords(int wordLen, int wordNum)
        {
            List<string> wurds = new List<string>();
            for (int i = 0; i < wordNum; i++)
            {
                wurds.Add(RandomString(wordLen));
                Console.WriteLine(wurds[i]);
            }
            return wurds;
        }

        static double msecs(Stopwatch sw)
        {
            return (((double)sw.ElapsedTicks) / Stopwatch.Frequency) * 1000;
        }

        private static Random random = new Random((int)DateTime.Now.Ticks);
        static string RandomString(int Size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < Size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            return builder.ToString();
        }
    }
}
