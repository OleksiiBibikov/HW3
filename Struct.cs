using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public struct ComplexNumber<T> where T : struct, IComparable, IFormattable
    {
        public T Re { get; }
        public T Im { get; }
        public ComplexNumber(T re, T im)
        {
            Re = re;
            Im = im;
        }
        public static bool IsNumericType()
        { 
            Type type = typeof(T);
            return type == typeof(int) 
                || type == typeof(float) 
                || type == typeof(double) 
                || type == typeof(decimal);
        }
        public static ComplexNumber<T> operator +(ComplexNumber<T> a, ComplexNumber<T> b)
        {
            if (!IsNumericType())
            {
                throw new InvalidOperationException("Type T is not a number");
            }

            dynamic re = a.Re;
            dynamic im = a.Im;

            if (!EqualityComparer<T>.Default.Equals(a.Re, default(T)) 
             && !EqualityComparer<T>.Default.Equals(b.Re, default(T)))
            {
                re = (dynamic)a.Re + (dynamic)b.Re;
            }

            if (!EqualityComparer<T>.Default.Equals(a.Im, default(T)) 
             && !EqualityComparer<T>.Default.Equals(b.Im, default(T)))
            {
                im = (dynamic)a.Im + (dynamic)b.Im;
            }

            return new ComplexNumber<T>(re, im);
        }

        public static ComplexNumber<T> operator -(ComplexNumber<T> a, ComplexNumber<T> b)
        {
            if (!IsNumericType())
            {
                throw new InvalidOperationException("Type T is not a number");
            }

            dynamic re = a.Re;
            dynamic im = a.Im;

            if (!EqualityComparer<T>.Default.Equals(a.Re, default(T))
             && !EqualityComparer<T>.Default.Equals(b.Re, default(T)))
            {
                re = (dynamic)a.Re - (dynamic)b.Re;
            }

            if (!EqualityComparer<T>.Default.Equals(a.Im, default(T))
             && !EqualityComparer<T>.Default.Equals(b.Im, default(T)))
            {
                im = (dynamic)a.Im - (dynamic)b.Im;
            }

            return new ComplexNumber<T>(re, im);
        }

        public void Print()
        {
            Console.WriteLine($"Complex number: {Re} + {Im}i");
        }
    }
}
