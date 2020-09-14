using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Create an app that lets you enter a bunc hof integers until the
    /// end of line with a CTRL-Z. We will say that a "clump" of these numbers
    /// is a series of 2 or more adjacent elements of the same value. The app will
    /// simply print out the number that is the count of these clumps.
    /// </summary>
    public class CountClumps
    {
        public static void Main()
        {
            // Write your codes here

            int count = 0;
            int prev = 0;
            int clumps = 0;
            bool first = true;
            for (; ; )
            {
                string s = Console.ReadLine();
                if (s == null) break;
                int n = int.Parse(s);
                if (first == true)
                {
                    prev = n;
                    first = false;
                }
                else
                {
                    if (prev == n)
                    {
                        count++;
                        if (count == 2)
                        {
                            clumps++;
                        }
                        else { count = 1; }
                    }

                }
                prev = n;
            }
            Console.WriteLine(clumps);
        }
    }
}
