using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ThirdLabNet
{
    public class Fraction //Создаем класс Дробь
    {
       public Int32 numerator; //Числитель
       public Int32 denominator; //Знаменатель
        public Fraction()
        {
            numerator = 0;
            denominator = 0;
        }
        public bool CheckFraction(int numerator, int denominator)
        {
            if (numerator > denominator)
                return true; //Если дробь правильная
            else
                return false; //Если дробь неправильная
        }
       public static Fraction operator +(Fraction first_frac,Fraction second_frac)
            {
            if (first_frac.denominator != second_frac.denominator)
            {
                second_frac.numerator *= first_frac.denominator;
                first_frac.denominator *= second_frac.denominator;
                first_frac.numerator *= second_frac.denominator;
                second_frac.denominator *= first_frac.denominator;
                
                
            }
            Fraction end_frac = new Fraction();
            end_frac.numerator = first_frac.numerator + second_frac.numerator;
            end_frac.denominator = first_frac.denominator;
            return end_frac;//new Fraction() { numerator = first_frac.numerator + second_frac.numerator, denominator = first_frac.denominator };
            }
        public static Fraction operator -(Fraction first_frac, Fraction second_frac)
        {
            if (first_frac.denominator != second_frac.denominator)
            {
                first_frac.numerator *= second_frac.denominator;
                second_frac.numerator *= first_frac.denominator;
                first_frac.denominator *= second_frac.denominator;
                second_frac.denominator *= first_frac.denominator;
                
            }
            Fraction end_frac = new Fraction();
            end_frac.numerator = first_frac.numerator - second_frac.numerator;
            end_frac.denominator = first_frac.denominator;
            return end_frac;
        }
        public static Fraction operator *(Fraction first_frac, Fraction second_frac)
        {
            Fraction end_frac = new Fraction();
            end_frac.numerator = first_frac.numerator * second_frac.numerator;
            end_frac.denominator = first_frac.denominator* second_frac.denominator;
            return end_frac;
        }
        public static Fraction Reduction(Fraction obj)
        {
            for (int i = 100; i >= 1; i--) //цикл для сокращения дроби
            {
                if (obj.numerator % i == 0 && obj.denominator % i == 0)
                {
                    obj.numerator /= i;
                    obj.denominator /= i;
                }
            }


            return new Fraction() { numerator = obj.numerator, denominator = obj.denominator };
        }
        public static Fraction Turn_over(Fraction obj)
        {
            return new Fraction() { numerator = obj.denominator, denominator = obj.numerator };
        }
    }
}
