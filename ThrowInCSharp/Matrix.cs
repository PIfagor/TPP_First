using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowInCSharp
{
    class Matrix
    {


        private double[,] _data;
        private Vector[] _dataV;
        private int _n;
        private int _m;
        private Random rand;
        public Matrix(int n, int m)
        {
            this._n = n;
            this._m = m;
            _data = new double[_n, _m];
            _dataV = new Vector[_n];
            for (int i = 0; i < _n; i++)
                _dataV[i] = new Vector(_m);
            rand = new Random();

        }

        //for first tack    
        public Vector getAvarageColumn()
        {
           
            double min = _data[0, 0];
            int index = 0;
            for (int i = 0; i < _n; i++)
            {
                var temp = 0.0;

                for (int j = 0; j < _m; j++)
                    temp += _data[i, j];

                if (temp < min)
                {
                    min = temp;
                    index = i;
                }
                    

            }
            return _dataV[index];
        }

        //for second tack
        public Vector getDiagonMinColumn()
        {
            double min = _data[0, 0];
            int index = 0;
            for (int i = 0; i < _n; i++)
            {
               if (_data[i, i] < min)
                {
                    min = _data[i, i];
                    index = i;
                }


            }
            return _dataV[index];
        }

        public Matrix transpose()
        {
            Matrix trs = new Matrix(this._m, this._m);
            for (int i = 0; i < _n; i++)
            { 
                    Vector temp = new Vector(_m);
                    for (int j = 0; j < _m; j++)
                        temp.insert(j,_data[j,i]);
                    trs.insertVector(temp, i);
            }
            return trs;
         }

        public void insertVector(Vector v, int index)
        {
            for (int i = 0; i < _m; i++)
                _data[index, i] = v.getByIndex(i);
          
           
            _dataV[index] = v;
        }

        public int fillRandom(int left, int rigth)
        {
            for (int i = 0; i < _n; i++)
                for (int j = 0; j < _m; j++)
                    _data[i, j] = rand.Next(left, rigth);

            for (int i = 0; i < _n; i++)
                for (int j = 0; j < _m; j++)
                    _dataV[i].insert(j, _data[i, j]);
            return (0);
        }

        public int inputConsole()
        {
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; i < _m; i++)
                {
                    string buf;
                    buf = Console.ReadLine();
                    _data[i, j] = Convert.ToDouble(buf);
                }

            }
            for (int i = 0; i < _n; i++)
                for (int j = 0; j < _m; j++)
                    _dataV[i].insert(j, _data[i, j]);
            return (0);
        }

        public static bool operator ==(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows) return false;
             if (a.Colums != b.Colums) return false;


             for (int i = 0; i < a.Rows; i++)
                 for (int j = 0; j < a.Colums; j++)
                     if (a._data[i, j] != b._data[i, j])
                         return false;
            return true;
        }
        public static bool operator !=(Matrix a, Matrix b)
        {
            return !(a == b);
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows) return a;
            if (a.Colums != b.Colums) return b;

            Matrix ans = new Matrix(a.Rows,a.Colums);
            if (a.Rows == 2)
            {
                ans._data[0, 0] = a._data[0, 0] * b._data[0, 0] + a._data[0, 1] * b._data[1, 0];
                ans._data[0, 1] = a._data[0, 0] * b._data[0, 1] + a._data[0, 1] * b._data[1, 1];
                ans._data[1, 0] = a._data[1, 0] * b._data[0, 0] + a._data[1, 1] * b._data[1, 0];
                ans._data[1, 1] = a._data[1, 0] * b._data[0, 1] + a._data[1, 1] * b._data[1, 1];
            }

            return ans;
        }

        public int outputConsole()
        {
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _m; j++)
                {
                    Console.Write(_data[i, j] + " ");
                }
                Console.WriteLine();
            }
            return (0);
        }

        public int Rows
        {
            get { return _n; }
           // set { _seconds = value; }
        }
        public int Colums
        {
            get { return _m; }
            // set { _seconds = value; }
        }

        public double [,] source()
        {
            return _data;
        }

    }
}
