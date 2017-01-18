using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordJumbler
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string [] firs = first.Split(' ');
            //
            int wordNum = int.Parse(firs[0]);
            int wordLength = int.Parse(firs[1]);
            List<string> viable = new List<string>();
            List<string> obsolete = new List<string>();
            for(int i = 0; i < wordNum; i++)
            {
                string currentWord = Console.ReadLine();
                string sortedWord = sortWord(currentWord);
                if (!obsolete.Contains(sortedWord))
                {
                    if (viable.Contains(sortedWord))
                    {
                        viable.Remove(sortedWord);
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
    }
}
