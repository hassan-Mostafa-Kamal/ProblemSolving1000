using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ProblemSolving1000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Sum2Num(2, 5);
            //2
            Console.WriteLine(x);
            //===========================//

            //2
            int secods = ConvertToSecends(10);
            Console.WriteLine(secods);
            //===========================//

            //3
            int num = NumPlusOne(-5);
            Console.WriteLine(num);

            //=======================================//
            //4
            double power = Power(3, 110);
            Console.WriteLine(power);

            //================================================//
            //5
            double ageInDayes = AgeInDays(30);
            Console.WriteLine(ageInDayes);

            //=========================================
            //6
            double area = TriArea(3, 2);
            Console.WriteLine(area);

            //===================================
            //7
            int remainder = Remainder(5, 6);
            Console.WriteLine(remainder);

            //=====================
            //8
            //bool isLessThanOrEqualZero = IsLessThanOrEqualZero(-2);
            //Console.WriteLine(isLessThanOrEqualZero);

            Console.WriteLine(IsLessThanOrEqualZero(-2));

            //=================================================
            //9
            Console.WriteLine(IsSumLissThan100(20, 80));

            //===============================================
            //10
            Console.WriteLine(IsNum1EqualNum2(10, 10));

            //==============================================
            //11
            Console.WriteLine(TheNamewithNameWord("Hassan"));
            //============================================
            //12
            Console.WriteLine(IsFulfillTheTondition(60, 70));

            //===========================================
            //13
            Console.WriteLine(Perimeter(5, 3));

            //===================================
            //14
            Console.WriteLine(NumberOFLegsForAllAnimals(2, 2, 2));

            //=====================================
            //15
            Console.WriteLine(NumberOfPointesForTheTeam(3, 4, 2));

            //=====================================
            //16
            Console.WriteLine(Flip(0));

            //===================================
            //17
            Console.WriteLine(MaxEdge(8, 10));

            //===============================
            //18
            Console.WriteLine(Feets(324));

            //===============================
            //19
            Console.WriteLine(Points(7, 5));

            //==============================
            //20
            Console.WriteLine(Seconds(1, 3));

            //============================
            //21
            int number = 255;
            int len;
            len = lenght(number);

            Console.WriteLine(IsArmstrong(number, len));

            //=======================================
            //22

            List<int> fibonacciNumbers = Fibonacci(10);

            // Displaying the generated Fibonacci numbers
            Console.WriteLine("Generated Fibonacci Numbers:");
            foreach (int numb in fibonacciNumbers)
            {
                Console.Write(numb + " ");
            }
            //=======================================
            //23
            Console.WriteLine();
            Isleap(2020);
            //=====================================
            //24
            Console.WriteLine();
            IsPalindrome(1230321);
            //===========================================
            //25

            Console.WriteLine(PowerWithPositave(5, -4));
            //===========================================
            //26
            //(1) If the number under 10
             IsAutomorphic(9);

            //(2) If the number more than  9
            int number2 = 376;
            int numSquer = number2 * number2;
            if (IsAutomorphicPlus9(number2) ==1)
            {
                Console.WriteLine($"{number2}: Is Automorphic , the Squer = {numSquer}");
            }
            else
            {
                Console.WriteLine($"{number2}: Is Not Automorphic , the Squer = {numSquer}");
            }


        }



        //1:- Create A fun That take tow numbers as arguments and return their sum
        public static int Sum2Num(int num1, int num2)
        {
            return num1 + num2;
        }



        //2:- write a fun that take int Num and (mintus) that convert it to seconds
        public static int ConvertToSecends(int num)
        {
            num = num * 60;
            return num;
        }


        // 3- create a Fun that take a Num as argument that increment the num by 1 and return the result

        public static int NumPlusOne(int num)
        {
            return ++num;
        }


        //4: - Create A fun That take tow numbers as arguments and return their Power
        public static double Power(double num1, double num2)
        {
            return num1 * num2;
        }


        //5:- write a Fun take the age in years and return it u=in days

        public static double AgeInDays(double age)
        {
            return age * 365;
        }


        // 6:- write a fun take base and height of triangle and return the area

        public static double TriArea(double theBase, double height)
        {
            //  return (theBase * height) / 2;
            return 0.5 * theBase * height;
        }

        // 7:- write a fun take tow num and return the remainder 

        public static int Remainder(int a, int b)
        {
            return a % b;
        }

        //8:- write a fun take one num and return true if it less than or equal zero otherwise return false
        public static bool IsLessThanOrEqualZero(int num)
        {
            if (num <= 0) return true;
            else return false;
        }

        // 9:- write a fun take tow num and return true if the sum of tham less than 100 else return false
        public static bool IsSumLissThan100(int num1, int num2)
        {
            if ((num1 + num2) < 100) return true;
            return false;
        }

        // 10:- write a fun take tow num and return true if the num1=num2 else return false

        public static bool IsNum1EqualNum2(int num1, int num2)
        {
            if (num1 == num2) return true;
            return false;
        }
        // 11:- write a fun take string and return string"name" as a result
        public static string TheNamewithNameWord(string name)
        {

            // string result = name + "Name";
            string result = $"{name}Name";

            return result;

        }

        // 12:- write a fun take tow num and return true if the num1 && num2 equal the condition else return false
        public static bool IsFulfillTheTondition(int num1, int num2)
        {

            if (num1 > 50 && num2 > 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // محيط المستطيل
        // 13:- write a fun take length and width and return the perimeter of rectangle


        public static double Perimeter(double length, double widdth)
        {
            // return  2 * length + 2 * widdth;
            return (length + widdth) * 2;
        }

        // 14:- write a fun take three num of kinds of animals and return the number of legs for all animals
        //hint : chickens = 2 legs , cows = 4 legs , sheeps = 4 legs
        public static int NumberOFLegsForAllAnimals(int chickensNum, int CowsNum, int sheepsNum)
        {

            int allLegs = (chickensNum * 2) + (CowsNum * 4) + (sheepsNum * 4);

            return allLegs;
        }

        // 15:- write a fun take three num of wins and draws and losses for football team and return the number of points for the team
        //hint : wins = 3 points , draws = 1 points , losses = 0 points

        public static int NumberOfPointesForTheTeam(int wins, int draws, int losses)
        {
            int NumOfPointes = (wins * 3) + (draws * 1);
            return NumOfPointes;

        }

        // 16:- write a fun take one num (1 or 0) and return his opposite
        // hit Flip(1) => 0
        // hit Flip(0) => 1
        public static int Flip(int num)
        {
            //if (num == 1)
            //{
            //    return 0;
            //}
            //else return 1;

            return 1 - num;

        }

        //17:- write a fun that take tow int that are 2 edge of triangle and return the maximum length of the third edge
        //hint : maxLengthOFTriangleEdge= sum of tow edge - 1 (Law in mathematics)

        public static int MaxEdge(int edge1, int edge2)
        {
            int maxLengthOfThirdEdge = edge1 + edge2 - 1;
            return maxLengthOfThirdEdge;
        }

        //18:- write a fun Take int inches and return feet
        // hint : 12 Inches = 1 Feet
        public static int Feets(int inches)
        {

            return inches / 12;
        }

        //19:- in basketboll some scored with tow points and other with 3 points 
        // make a fu caluc the sum of points 
        public static int Points(int TowPointsScored, int ThreePointsScored)
        {

            return (TowPointsScored * 2) + (ThreePointsScored * 3);
        }

        //20:- write a fun that taketow int (hours and minutes ) and convert them to seconds and return the sum
        public static int Seconds(int hours, int minutes)
        {
            int seconds = (hours * 60 * 60) + (minutes * 60);
            return seconds;
        }

        // 21 :- check if the number is Armstrong or no
        public static string IsArmstrong(int num, int len)
        {
            int sum = 0, temp, digit;
            temp = num;

            while (temp != 0)
            {
                // to find the digit
                digit = temp % 10;

                // to add power and than sum
                sum = sum + (int)Math.Pow(digit, len);
                temp = temp / 10;

            }
            if (num == sum) return "Is Armstrong " + num;
            else return "Is Not Armstrong " + num;


        }
        public static int lenght(int num)
        {
            int len = 0;
            while (num != 0)
            {
                len++;
                num = num / 10;
            }
            return len;
        }

        //============================================================================
        //22:- Fibonacci

        public static List<int> Fibonacci(int num)
        {
            int a = 0, b = 1;
            int nextNum;

            List<int> fibNum = new List<int>();

            for (int i = 2; i < num; i++)
            {

                fibNum.Add(a);
                nextNum = a + b;
                a = b;
                b = nextNum;

            }

            return fibNum;
        }

        //============================================================================
        //23:- check If the year Is leap

        public static void Isleap(int yearNum)
        {
            if (yearNum % 400 == 0 || (yearNum % 4 == 0 && yearNum % 100 != 0))
            {
                Console.WriteLine("the year Is leap :" + yearNum);
            }
            else
            {
                Console.WriteLine("the year Is Not leap :" + yearNum);
            }
        }

        //============================================================================
        //24:- check If the year Is Palindrome
        public static void IsPalindrome(int number)
        {
            int temp = number;
            int reverse = 0;
            int reminder;
            while (temp > 0)
            {
                reminder = temp % 10;
                reverse = reverse * 10 + reminder;
                temp = temp / 10;
            }
            if (number == reverse)
            {
                Console.WriteLine(number);
                Console.WriteLine( reverse);
                Console.WriteLine($"the number is Palindrome::{number}" );

            }
            else
            {
                Console.WriteLine(number);
                Console.WriteLine(reverse);
                Console.WriteLine($"the number is Not Palindrome{number}");
            }

        }

        //=====================================================
        //25: Find the Power of a number(don't use  Math.Pow(2,4);

    
        public static double PowerWithPositave(double  baseNum ,double exponentNum)
        {
            bool ExponentState = true;
            if (exponentNum < 0)
            {
                ExponentState = false;
                exponentNum = exponentNum * -1;
            }

            double result = 1;
       
            for (int i = 1;i<=exponentNum; i++)
            {
                if (ExponentState)
                {
                    result = result * baseNum;
                }
                else
                {

                    result = result / baseNum;
                }
                
            }

            return result;
        }


        //=====================================================
        //26:- check If the Number is automorphic or Not
        // hint the automorphicNumber : when the squared of a number ends with the number it salf 
        //Ex : 5 => 25 ,    abc => 1254abc 

        //(1) if the number is under 10 (1,2,3,4,5,6,7,8,9)

                                          //ex 5 
        public static void IsAutomorphic(int num)
        {
            int numSquer = num * num;  // 25
            int numSquerLastDigit = numSquer % 10;  
            if (numSquerLastDigit == num)
            {
                Console.WriteLine($"{num}: Is an automorphic Number and the Squer is : {numSquer} ");
            }
            else
            {
                Console.WriteLine($"{num}: Is Not automorphic Number and the Squer is : {numSquer} ");

            }
        }

        //(2) if the number is Up 10 (10,11,........9999999)

                                    //ex 50
        public static int IsAutomorphicPlus9(int num)
        {
            // 50* 50 = 2500
            int numSquer = num * num;
            while (num != 0)
            {
               
                int NumDigit = num % 10;  // 50%10 = 0
                int numSquerDigit = numSquer % 10;   //2500 % 10 = 0
                if (NumDigit != numSquerDigit  )
                {                    
                      return 0;                             
                }
                else
                {
                    num /= 10;
                    numSquer /= 10;
                
                }            
            }
            return 1;
           

        }

    }
}
