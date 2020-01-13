using System;

namespace WeekOne
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Replace String");
            Console.WriteLine("Enter 2 for Flip Coin");
            Console.WriteLine("Enter 3 for Leap Year");
            Console.WriteLine("Enter 4 for Power of 2");
            Console.WriteLine("Enter 5 for Harmonic Number") ;
            Console.WriteLine("Enter 6 for Factors");
            Console.WriteLine("Enter 7 for Gambler");
            Console.WriteLine("Enter 8 for Coupon Numbers");
            Console.WriteLine("Enter 9 for 2D Array");
            Console.WriteLine("Enter 10 for Triplets");
            Console.WriteLine("Enter 11 for Sqrt");
            Console.WriteLine("Enter 12 for String Permutation");
            Console.WriteLine("Enter 13 for StopWatch");
            Console.WriteLine("Enter 14 for Tic-Tac-Toe");
            Console.WriteLine("Enter 15 for Quadratic");
            Console.WriteLine("Enter 16 for Windchill");
            Console.WriteLine("Enter 17 for Anagram");
            Console.WriteLine("Enter 18 for Prime Range");
            Console.WriteLine("Enter 19 for Prime no that are Anagram and Palindrome");
            Console.WriteLine("Enter 20 for Triplets");
            Console.WriteLine("Enter 21 for Binary Recursion");
            Console.WriteLine("Enter 22 for Binary Search from file");
            Console.WriteLine("Enter 23 for Insertion Sort");
            Console.WriteLine("Enter 24 for Bubble Sort");
            Console.WriteLine("Enter 25 for Merge Sort");
            Console.WriteLine("Enter 26 for Vending Machine");
            Console.WriteLine("Enter 27 for Day of week");
            Console.WriteLine("Enter 28 for Temperature Conversion");
            Console.WriteLine("Enter 29 for Monthly Payment");
            Console.WriteLine("Enter 30 for SquareRoot");
            Console.WriteLine("Enter 31 for To Binary");
            Console.WriteLine("Enter 32 for Swap Nibble");
           
            int n = int.Parse(Console.ReadLine());

            switch(n)
            {

                case 1:
                    ReplaceString replaceString = new ReplaceString();
                    replaceString.replace();


                    break;



                case 2:
                    Flip flip = new Flip();
                    flip.flipc();
                    break;

                case 3:
                    LeapYear leapYear = new LeapYear();
                    leapYear.leap();

                    break;


                case 4:
                    PowerTwo powerTwo = new PowerTwo();
                    powerTwo.power();

                    break;

                case 5:
                    HarMonic harMonic = new HarMonic();
                    harMonic.harmonic();

                    break;

                case 6:
                    PrimeFactors primeFactors = new PrimeFactors();
                    PrimeFactors.factors();

                    break;



                case 7:
                    Gambler gambler = new Gambler();
                    gambler.gamble();


                    break;

                case 8:


                    break;

                case 9:
                    TwoDArray twoDArray = new TwoDArray();
                    
                    break;

                case 10:

                    SumOfThree sumOfThree = new SumOfThree();
                    sumOfThree.sum();
                    break;

                case 11:
                    Distance distance = new Distance();
                    distance.dist();

                    break;

                case 12:


                    break;

                case 13:
                    StopWatch stopWatch = new StopWatch();
                    stopWatch.elapsedTimer();


                    break;
                case 14:


                    break;

                case 15:
                    Quadratic quadratic = new Quadratic();
                    quadratic.quad();

                    break;
                case 16:
                    WindChill windChill = new WindChill();
                    windChill.windChill();


                    break;

                case 17:
                    AnagramDetection anagramDetection = new AnagramDetection();
                    anagramDetection.anag();

                        

                    break;
                case 18:
                    PrimeRange primeRange = new PrimeRange();
                    primeRange.range();

                    break;

                case 19:


                    break;
                case 20:
                    FindNumber findNumber = new FindNumber();
                    findNumber.randomNumber();

                    break;

                case 21:
                    InsertionSort insertionSort = new InsertionSort();
                    

                    break;
                case 22:
                    Bubble bubble = new Bubble();

                    break;

                case 23:


                    break;
                case 24:


                    break;

                case 25:
                    Calender calender = new Calender();
                    calender.calculate();

                    break;
                case 26:
                    ConvertTemperature convertTemperature = new ConvertTemperature();
                    convertTemperature.temperature();

                    break;

                case 27:
                    PaymentMonthly paymentMonthly = new PaymentMonthly();
                    paymentMonthly.calculate1();
                    break;
                case 28:
                    SquareRoot squareRoot = new SquareRoot();
                    squareRoot.square();

                    break;

                case 29:
                    Binary binary = new Binary();
                    binary.isBinary();

                    break;
                case 30:
                    SwapNibbles swapNibbles = new SwapNibbles();

                    break;

                case 31:


                    break;

            }
        }

    }
}
