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
            StreamReader reader = new StreamReader(Console.ReadLine());
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
            string[] rules = new string[prodnum+1];
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
                int[] rulios = new int[terminals.Count + 1];
                int j = 0;
                foreach(char ch in line.ToCharArray())
                {
                    int mayy;
                    if (int.TryParse(ch.ToString(), out mayy))
                    {
                        rulios[j] = mayy;
                        Console.WriteLine("rulenum:");
                        Console.WriteLine(rulios[j]);
                        j++;
                    }
                }
                table[i] = rulios;
            }
            //finish me
            bool go = true;
            while (go)
            {
                string message = "yes";
                string test = Console.ReadLine();
                test = test + "$";
                stak.Push("$");
                stak.Push(nonterminals[0]);
                for(int i = 0; i < test.Length; i++)
                {
                    string red = test.Substring(i, 1);
                    bool keep = true;
                    while (keep)
                    {
                        while (stak.Peek() == "-")
                        {
                            stak.Pop();
                        }
                        if (red == "$")
                        {
                            keep = false;
                        }
                        if (stak.Peek() == red)
                        {
                            stak.Pop();
                            keep = false;
                        }
                        else
                        {
                            try
                            {
                                int[] keyble = table[nonterminals.IndexOf(stak.Peek())];
                                int hey = terminals.IndexOf(red);
                                switch (keyble[hey])
                                {
                                    case ((int)0):
                                        {
                                            message = "no";
                                            keep = false;
                                            break;
                                        }
                                    default:
                                        {
                                            stak.Pop();
                                            for (int y = rules[keyble[hey]].ToCharArray().Length - 1; y > -1; y--)
                                            {
                                                stak.Push(rules[keyble[hey]].ToCharArray()[y].ToString());
                                            }
                                            Console.WriteLine("So far so good.");
                                            break;
                                        }
                                }
                            }
                            catch (Exception)
                            {
                                message = "no";
                                keep = false;
                            }
                        }
                    }
                }
                Console.WriteLine(message);
            }
        }
    }
}
