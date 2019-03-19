using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stat
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiters = { ' ', ',', '.' };
            string s = "Вот дом, Который построил Джек. А это пшеница, Кото­рая в темном  чулане хранится В доме, Который построил Джек. А это веселая птица­ синица, Которая часто вору­ет пшеницу, Которая в темном чулане хранится В доме, Который построил Джек";
            string[] words = s.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            CountWords cw = new CountWords();
            foreach (string i in words)
            {
                cw.AddWord(i);
            }
            cw.Print();
        }
    }
}
