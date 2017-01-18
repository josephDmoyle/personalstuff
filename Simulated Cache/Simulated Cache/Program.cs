using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Joseph Moyle's Cache Simulator 2016
/// </summary>

namespace Simulated_Cache
{
    class Program
    {
       static void Main()
        {
            List<int> instructions = new List<int>() { 4, 8, 20, 24, 28, 36, 44, 20, 24, 28, 36, 40, 44, 68, 72, 92, 96, 100, 104, 108, 112, 100, 112, 116, 120, 128, 140 };
            List<string> binstructions = new List<string>();
            for (int i = 0; i < instructions.Count; i++)
            {
                binstructions.Add(Convert.ToString(instructions[i], 2));
            }
            for (int i = 0; i < instructions.Count; i++)
            {
                while (binstructions[i].Length < 16)
                {
                    binstructions[i] = "0" + binstructions[i];
                }
                Console.WriteLine(binstructions[i]);
            }
            Console.WriteLine("Direct Mapped");
            directMapped(binstructions);

            Console.WriteLine("Fully Associative");
            fullyAssociative(binstructions);

            Console.WriteLine("Set Associative");
            setAssociative(binstructions);

            Console.ReadLine();
        }

        static void setAssociative(List<string> binstructions)
        {
            int ways = 4;
            int offset = 3;
            int rowy = 1;
            int elapse = 0;
            int[][] LRU = new int[ways][];
            string[][] tags = new string[ways][];
            bool[][] valid = new bool[ways][];

            for (int i = 0; i < tags.Length; i++)
            {
                tags[i] = new string[Convert.ToInt32(Math.Pow(2, rowy))];
                valid[i] = new bool[Convert.ToInt32(Math.Pow(2, rowy))];
                LRU[i] = new int[Convert.ToInt32(Math.Pow(2, rowy))];
                for(int ii = 0; ii < tags[i].Length; ii++)
                {
                    tags[i][ii] = "";
                    valid[i][ii] = false;
                    LRU[i][ii] = 0;
                }
            }
            for (int j = 0; j < binstructions.Count; j++)
            {
                string row = binstructions[j].Substring(binstructions[j].Length - (offset + rowy), rowy);
                string tag = binstructions[j].Substring(0, binstructions[j].Length - (offset + rowy));
                int rowe = Convert.ToInt32(row, 2);
                bool isContained = false;
                for (int i = 0; i < tags.Length; i++)
                {
                    if (tags[i][rowe] == tag)
                    {
                        LRU[i][rowe] = 0;
                        isContained = true;
                        break;
                    }
                }
                if (!isContained)
                {
                    int max = 0;
                    for (int i = 0; i < LRU.Length; i++)
                    {
                        if (LRU[i][rowe] > LRU[max][rowe])
                        {
                            max = i;
                        }
                    }
                    LRU[max][rowe] = 0;
                    tags[max][rowe] = tag;
                    valid[max][rowe] = true;
                }
                for (int y = 0; y < LRU.Length; y++)
                {
                    LRU[y] = increment(LRU[y]);
                }
            }

            for (int j = 0; j < binstructions.Count; j++)
            {
                string row = binstructions[j].Substring(binstructions[j].Length - (offset + rowy), rowy);
                string tag = binstructions[j].Substring(0, binstructions[j].Length - (offset + rowy));
                int rowe = Convert.ToInt32(row, 2);
                bool isContained = false;
                for (int i = 0; i < tags.Length; i++)
                {
                    if (tags[i][rowe] == tag)
                    {
                        LRU[i][rowe] = 0;
                        isContained = true;
                        elapse++;
                        //Console.WriteLine(binstructions[j]+ " is a hit");
                        break;
                    }
                }
                if (!isContained)
                {
                    int max = 0;
                    for (int i = 0; i < LRU.Length; i++)
                    {
                        if (LRU[i][rowe] > LRU[max][rowe])
                        {
                            max = i;
                        }
                    }
                    LRU[max][rowe] = 0;
                    tags[max][rowe] = tag;
                    valid[max][rowe] = true;
                    elapse += 18;
                    elapse += 3 * Convert.ToInt32(Math.Pow(2, offset));
                    //Console.WriteLine(binstructions[j] + " is a miss");
                }
                for (int y = 0; y < LRU.Length; y++)
                {
                    LRU[y] = increment(LRU[y]);
                }
            }

            Console.WriteLine(elapse);
            Console.WriteLine("Total Bits:");
            Console.WriteLine(ways*(Math.Pow(2, rowy)*(rowy + (binstructions[0].Length - rowy - offset) + (8 * Convert.ToInt32(Math.Pow(2, offset))) + 1 + 2)));
            //ways *( rows*(row markers + TAG +  data + valid + LRU))
        }

        static void fullyAssociative(List<string> binstructions)
        {
            int offset = 3;
            int rowy = 9;
            int elapse = 0;
            int[] LRU = new int[rowy];
            string[] tags = new string[rowy];
            bool[] valid = new bool[rowy];
            for (int i = 0; i < tags.Length; i++)
            {
                tags[i] = "";
                valid[i] = false;
                LRU[i] = 0;
            }

            for (int i = 0; i < binstructions.Count; i++)
            {
                string offs = binstructions[i].Substring(binstructions[i].Length - offset, offset);
                string tag = binstructions[i].Substring(0, binstructions[i].Length - offset);
                if (tags.Contains(tag))
                {
                    //hit
                    LRU[Array.IndexOf(tags, tag)] = 0;
                }
                else
                {
                    //miss
                    int put = findMaxIndex(LRU);
                    tags[put] = tag;
                    valid[put] = true;
                    LRU[put] = 0;
                }
                LRU = increment(LRU);
            }

            for (int j = 0; j < binstructions.Count; j++)
            {
                string offs = binstructions[j].Substring(binstructions[j].Length - offset, offset);
                string tag = binstructions[j].Substring(0, binstructions[j].Length - offset);
                if (tags.Contains(tag))
                {
                    //hit
                    LRU[Array.IndexOf(tags, tag)] = 0;
                    elapse++;
                    //Console.WriteLine(binstructions[j] + " is a hit");
                }
                else
                {
                    //miss
                    int put = findMaxIndex(LRU);
                    tags[put] = tag;
                    valid[put] = true;
                    LRU[put] = 0;
                    elapse += 18;
                    elapse += 3 * Convert.ToInt32(Math.Pow(2, offset));
                    //Console.WriteLine(binstructions[j] + " is a miss");
                }
                LRU = increment(LRU);
            }
            Console.WriteLine(elapse);
            Console.WriteLine("Number of bits");
            Console.WriteLine(tags.Length*((binstructions[0].Length - offset) + 8 *  Math.Pow(2, offset) + 1 + 2));
            //bits = rows ( tag + data + valid + lru)
        }

        static void directMapped(List<string> binstructions)
        {
            int offset = 4;
            int rowy = 2;
            int elapse = 0;
            string[] tags = new string[Convert.ToInt32(Math.Pow(2, rowy))];
            bool[] valid = new bool[Convert.ToInt32(Math.Pow(2, rowy))];
            for(int i = 0; i < tags.Length; i++)
            {
                tags[i] = "";
                valid[i] = false;
            }
            for (int i = 0; i < binstructions.Count; i++)
            {
                string row = binstructions[i].Substring(binstructions[i].Length - (offset + rowy), rowy);
                string tag = binstructions[i].Substring(0, binstructions[i].Length - (offset + rowy));
                int indi = 0;
                indi = Convert.ToInt32(row, 2);
                if (tags[indi] == tag && valid[indi] == true)
                {
                    //hit
                    ;
                }
                else
                {
                    //miss
                    tags[indi] = tag;
                    valid[indi] = true;
                }
            }
            for (int j = 0; j < binstructions.Count; j++)
            {
                string row = binstructions[j].Substring(binstructions[j].Length - (offset + rowy), rowy);
                string tag = binstructions[j].Substring(0, binstructions[j].Length - (offset + rowy));
                int indi = 0;
                indi = Convert.ToInt32(row, 2);
                if (tags[indi] == tag && valid[indi] == true)
                {
                    //hit
                    elapse++;
                    //Console.WriteLine(binstructions[j] + " is a hit");
                }
                else
                {
                    //miss
                    tags[indi] = tag;
                    valid[indi] = true;
                    elapse += 18;
                    elapse += 3 * Convert.ToInt32(Math.Pow(2, offset));
                    //Console.WriteLine(binstructions[j] + " is a miss");
                }
            }
            Console.WriteLine(elapse);
            Console.WriteLine("Total Bits:");
            Console.WriteLine(Math.Pow(2, rowy) * (rowy + (binstructions[0].Length - offset - rowy) + 1 + (8 * Math.Pow(2, offset))));
            // rows(row tag valid data)
        }

        static int[] increment(int[] incr)
        {
            for(int i = 0; i < incr.Length; i++)
            {
                incr[i]++;
            }
            return incr;
        }

        static int findMaxIndex(int[] maxxy)
        {
            int maxy = 0;
            int indy = 0;
            for(int i = 0; i < maxxy.Length; i++)
            {
                if(maxxy[i] > maxy)
                {
                    maxy = maxxy[i];
                    indy = i;
                }
            }
            return indy;
        }

        static int findMax(int[] maxxy)
        {
            int maxy = 0;
            int indy = 0;
            for (int i = 0; i < maxxy.Length; i++)
            {
                if (maxxy[i] > maxy)
                {
                    maxy = maxxy[i];
                    indy = i;
                }
            }
            return maxy;
        }
    }
}