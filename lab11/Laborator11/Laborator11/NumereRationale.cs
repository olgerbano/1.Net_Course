using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolutieLaborator_11
{
    public class Rational
    {
        private int dividend;
        private int divisor;

        public Rational(int dividend)
        {
            this.dividend = dividend;
            divisor = 1;
        }
        public Rational(int dividend, int divisor)
        {
            this.dividend = dividend;
            if (divisor == 0)
                throw new ArgumentOutOfRangeException();
            this.divisor = divisor;
        }
        public decimal GetDecimalValue()
        {
            return (decimal)this.dividend / this.divisor;
        }


        public static bool operator ==(Rational r1, Rational r2)
        {
            if (r1.dividend * r2.divisor == r1.divisor * r2.dividend)
                return true;
            return false;
        }

        public static bool operator!=(Rational r1, Rational r2)
        {
            if (r1.dividend * r2.divisor != r1.divisor * r2.dividend)
                return true;
            return false;
        }

        public static bool operator<(Rational r1, Rational r2)
        {
            if (r1.dividend * r2.divisor < r1.divisor * r2.dividend)
                return true;
            return false;
        }

        public static bool operator >(Rational r1, Rational r2)
        {
            if (r1.dividend * r2.divisor > r1.divisor * r2.dividend)
                return true;
            return false;
        }

        public static bool operator <=(Rational r1, Rational r2)
        {
            if (r1.dividend * r2.divisor <= r1.divisor * r2.dividend)
                return true;
            return false;
        }
        

        public static bool operator >=(Rational r1, Rational r2)
        {
            if (r1.dividend * r2.divisor >= r1.divisor * r2.dividend)
                return true;
            return false;
        }
        public override bool Equals(object obj)
        {
            return this == (Rational)obj;
        }

        public override string ToString()
        {
            return this.dividend + "/" + this.divisor;
        }
    }
}
