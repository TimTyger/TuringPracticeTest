using System;
using System.Collections.Generic;
using System.Linq;

namespace TuringTest
{
   class Solution
    {
        public int CalPoints(string[] ops)
        {
            var newList = new List<int>(); int[] ints;
            for (int i = 0; i < ops.Length-1; i++)
            {
                var count = newList.Count;
                if (ops[i]=="C")
                {
                    newList.RemoveAt(count - 1);
                }
                else if (ops[i]=="D")
                {
                    newList.Add((newList[count-1])*2) ;
                }
                else if (ops[i]=="+")
                {
                    newList.Add(newList[count-1]+ newList[count - 2]) ;
                }
                else newList.Add(int.Parse(ops[i])) ;
            }
            ints = newList.ToArray();
            return ints.Sum();
        }

        public bool IsValid(string s)
        {
            var array = s.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] == ')' && array[i - 1] != '(')||(array[i] == '}' && array[i - 1] != '{')||(array[i] == ']' && array[i - 1] != '[')) return false;
                //if (array[i] == '}' && array[i - 1] != '{') return false;
               // if (array[i] == ']' && array[i - 1] != '[') return false;
            }
            return true;
        }
    }

    class CalPoints
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            if (solution.IsValid(Console.ReadLine())) Console.WriteLine("valid");
            else Console.WriteLine("invalid");
            
        }
    }
}
