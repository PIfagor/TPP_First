using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowInCSharp
{
    class Vector
    {
        double[] a; 
        int n; 
        Random rand;
        public Vector(int n)
        {
            this.a = new double[n];
            this.n = n;
            this.rand = new Random();
        }
        public int inputConsole()
        {
            for (int i = 0; i < n; i++)
            {
                string buf;
                buf = Console.ReadLine();
                a[i] = Convert.ToDouble(buf);
            }
            return (0);
        }

        public int fillVector(int left, int rigth)
        {
            for (int i = 0; i < n; i++)
            {
                a[i] = rand.Next(left, rigth);
            }
            return (0);
        }

        public int outputConsole()
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine("a[" + i + "]=" +
                a[i]);
            return (0);
        }
        public int perest(int k)
        {
            int kl = 0;
            if (k >= n) kl = -1;
            else
            {

                int cnt = 0;
                int pos = -1;
                double tmp;
                while (cnt < k)
                {
                    pos++;
                    if (a[pos] < 0) cnt++;
                } 
                tmp = a[pos]; 
                a[pos] = a[0];
                a[0] = tmp;
                kl = 0;
            }
            return kl;
        }

        public void insert(int i, double data)
        {
            a[i] = data;
        }

        public double getByIndex(int i)
        {
            if (i<n)
                return a[i];
            return -1;
        }
    }
}
