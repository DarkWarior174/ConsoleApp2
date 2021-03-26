using System;

namespace ConsoleApp2
{
    class DecimalFraction
    {
        public int numerator { get; set; }
        public int denominator { get; set; }
        public int wholePart { get; set; }

        public static DecimalFraction operator +(DecimalFraction dp1, DecimalFraction dp2)
        {
            return
                (new DecimalFraction
                {
                    wholePart = dp1.wholePart + dp2.wholePart,
                    denominator = dp1.denominator + dp2.denominator,
                    numerator = dp1.numerator + dp2.numerator
                }
                );
        }

        public static DecimalFraction operator -(DecimalFraction dp1, DecimalFraction dp2)
        {
            return
                (new DecimalFraction
                {
                    wholePart = dp1.wholePart - dp2.wholePart,
                    denominator = dp1.denominator - dp2.denominator,
                    numerator = dp1.numerator - dp2.numerator
                }
                );
        }

        public static DecimalFraction operator *(DecimalFraction dp1, DecimalFraction dp2)
        {
            return
                (new DecimalFraction
                {
                    wholePart = dp1.wholePart * dp2.wholePart,
                    denominator = dp1.denominator * dp2.denominator,
                    numerator = dp1.numerator * dp2.numerator
                }
                );
        }

        public static DecimalFraction operator /(DecimalFraction dp1, DecimalFraction dp2)
        {
            return
                (new DecimalFraction
                {
                    wholePart = dp1.wholePart / dp2.wholePart,
                    denominator = dp1.denominator / dp2.denominator,
                    numerator = dp1.numerator / dp2.numerator
                }
                );
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DecimalFraction dp1 = new DecimalFraction { wholePart = 1, numerator = 4, denominator = 3 };
            DecimalFraction dp2 = new DecimalFraction { wholePart = 4, numerator = 5, denominator = 6 };
            DecimalFraction dp3 = dp1 + dp2;
            DecimalFraction dp4 = dp1 * dp2;
            if (dp3.numerator >= dp3.denominator)
            {
                int ch;
                ch = dp3.numerator / dp3.denominator;
                dp3.wholePart = dp3.wholePart + ch;
                dp3.numerator = dp3.numerator % dp3.denominator;
            }
            
            Console.WriteLine(dp3.wholePart + "."+ dp3.numerator + "/"+ dp3.denominator);
            Console.WriteLine(dp4.wholePart + "." + dp4.numerator + "/" + dp4.denominator);

            Console.ReadKey();
        }
    }
}
