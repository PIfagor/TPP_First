using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Linq.Expressions;
namespace ThrowInCSharp
{
    class Program
    {
        delegate int del(int i);
        static void Main(string[] args)
        {

            Matrix mt = new Matrix(2, 2);
            Matrix mt2 = new Matrix(2, 2);
            mt.fillRandom(0, 6);
            mt.outputConsole();
            Console.WriteLine();
            mt2.fillRandom(4, 10);
            mt2.outputConsole();
            Console.WriteLine();

            Matrix res = mt * mt2;
            res.outputConsole();
            Console.WriteLine();
         //   Vector v = new Vector(4);
         //   v.fillVector(0, 75);
         //   v.outputConsole();
         //   string s = "abaaba";
         ////   s.Length;
         //   System.Console.WriteLine(s.Length);
         //  // string s2 = new Regex.Replace("[^b]","");
            
         //   //System.Console.WriteLine(s2);
         //   //char c = 'w';
         //   del myDelegate = (c) => { return (char)((117 < c ? c - 21 : c + 5)); };
         //   //char j = myDelegate('a');
         //  // System.Console.WriteLine(j);

         //   Expression<del> myET = x => x *x;
         //  // System.Console.WriteLine(myET(2));
         //  String ss =  System.Text.RegularExpressions.Regex.Replace(s, ".", "_ ");
         //  Console.WriteLine(ss.Substring(0,ss.Length-1));
         //  int a = 0;
         //  for (int i = 0; i < 32; i++)
         //  {
         //      a += i;
         //  }
         //  Console.WriteLine(a);

        }
    }
}
