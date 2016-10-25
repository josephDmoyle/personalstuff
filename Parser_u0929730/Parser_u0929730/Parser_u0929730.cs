using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser_u0929730
{
    class Parser_u0929730
    {
        static void Main(string[] args)
        {
            Stack<string> stak = new Stack<string>();
            StreamReader reader = new StreamReader(args[0]);
            char[] vars = reader.ReadLine().ToCharArray();
            List<string> nonterminals = new List<string>();
            foreach(char ch in vars)
            {
                nonterminals.Add(ch.ToString());
                Console.WriteLine("nonterminal:");
                Console.WriteLine(ch.ToString());
            }
            char[] terms = reader.ReadLine().ToCharArray();
            List<string> terminals = new List<string>();
            foreach (char ch in terms)
            {
                terminals.Add(ch.ToString());
                Console.WriteLine("terminal:");
                Console.WriteLine(ch.ToString());
            }
            int prodnum = int.Parse(reader.ReadLine());
            Console.WriteLine(prodnum);
            List<string> rules = new List<string>(prodnum+1);
            for(int i = 1; i < prodnum + 1; i++)
            {
                string line = reader.ReadLine();
                line = line.Substring(2);
                rules[i] = line;
                Console.WriteLine("rule:");
                Console.WriteLine(line);
            }
            int[][] table = new int[nonterminals.Count][];
            for(int i =0; i < nonterminals.Count; i++)
            {
                string line = reader.ReadLine();
                int[] rulios = new int[nonterminals.Count + 1];
                int j = 1;
                foreach(int inty in line.Split(',').Select(x => int.Parse(x)))
                {
                    rulios[j] = inty;
                    j++;
                }
                table[i] = rulios;
            }
            //finish me
        }
    }
}
