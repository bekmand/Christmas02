using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_02
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] text = System.IO.File.ReadAllLines(@"C:\Users\Public\Documents\ChristmasWrap.txt");

            foreach(string line in text)
            {
                int lengthStart = line.IndexOf("x");
                int lengthEnd = line.LastIndexOf("x");

                if(lengthStart == 1)
                {
                    
                }

                string l = line.Substring(0, 1);
                string w = line.Substring(3, 4);
                string h = line.Substring(6, 7);

            }
        }
    }
}
