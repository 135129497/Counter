using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2_5
{
    class Counter
    {
        protected int _numOne;
        protected int _numTwo;
        protected string _stringOne;
        protected string _stringTwo;
        protected char _character;

        public string StringOne
        {
            get { return _stringOne; }
            set { _stringOne = value; }
        }
        

        public string StringTwo
        {
            get { return _stringTwo; }
            set { _stringTwo = value; }
        }

        public int NumOne
        {
            get { return _numOne; }
            set { _numOne = value; }
        }
        

        public int NumTwo
        {
            get { return _numTwo; }
            set { _numTwo = value; }
        }

        public char Character
        {
            get { return _character; }
            set { _character = value; }
        }



        public double Add(int a, int b)
        {
            NumOne = a;
            NumTwo = b;
            return NumTwo + NumOne;
        }

        public string Add(string s1, string s2)
        {
            StringOne = s1;
            StringTwo = s2;
            return StringOne+StringTwo;
        }

        public string Subduction(string s1, string s2)
        {
            StringOne = s1;
            StringTwo = s2;
            string s = StringOne;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < StringTwo.Length; j++)
                {
                    if (s[i] == StringTwo[j])
                    {
                        s = s.Remove(i,1);
                    }
                }
            }
                return s;
        }

        public double Subduction(int a, int b)
        {
            NumOne = a;
            NumTwo = b;
            return NumOne - NumTwo;
        }

        public double Mult(int a, int b)
        {
            NumOne = a;
            NumTwo = b;
            return NumOne * NumTwo;
        }

        public double Devision(int a, int b)
        {
            NumOne = a;
            NumTwo = b;
            double d = (double)NumOne / NumTwo;
            return d;
        }

        public double Remainder(int a, int b)
        {
            NumOne = a;
            NumTwo = b;
            double d  = a%b;
            return d;
        }

        public double BitwiseAnd(int a, int b)
        {
            return a & b;
        }

        public void Count(int a, int b,char c)
        {
            Character = c;
            if (Character == '+')
            {
                Add(a,b);
            }
            else if (Character == '-')
            {
                Subduction(a, b);
            }
            else if (Character == '*')
            {
                Mult(a, b);
            }
            else if (Character == '/')
            {
                Console.WriteLine(Devision(a, b));
            }
            else if (Character == '%')
            {
                Console.WriteLine(Remainder(a,b));
            }
            else if (Character == '&')
            {
                Console.WriteLine(BitwiseAnd(a,b));
            }
        }

        public void Count(string a, string b,char c)
        {
            Character = c;
            if (Character == '+')
            {
                
                Console.WriteLine(Add(a, b));
            }
            else if (Character == '-')
            {
                Console.WriteLine(Subduction(a, b));
            }

        }

        public bool Equals(int a, int b)
        {
            if (a == b)
                return true;
            else
                return false;
        }

    }
}
