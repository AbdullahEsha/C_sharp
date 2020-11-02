using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St
{
    class Program
    {
        public struct st
        {
           public int a;
           private String [] aa;
           public st(int i) {
               a = i;
               aa = new string[] { "pizza", "burger" };
           }

           public int A { get { return a; } set { a = value; } }

           public String this[int index] { get { return this.aa[index]; } 
               set { this.aa[index] = value; } 
           }
           public void AA()
           {
               foreach(var i in aa){
                   Console.WriteLine(i);
           }
           }
           public int Length
           {
               get { return aa.Length; }
           }
            
        }

        static void Main(string[] args)
        {
            //Program p = new Program();
            st s = new st(5);
            //s.A= 5;
            //Console.WriteLine(s.A);
            //s[0] = "pasta";
            //Console.WriteLine(s[0]);
            //Console.WriteLine(s.Length);
            s.AA();
        }
    }
}