using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleToIEEE754
{
     public static class ToIEEE754
     {
          static int baseSystem;
          static int maxOffset;
          static int bitsOfMantissa;
          public static string ConvertToIEEE754(this double number)
          {
               string result;
               baseSystem = 2; 
               maxOffset = 1023;
               bitsOfMantissa = 52;
               int offset = 0;
               // find sign
               if (number < 0 || double.IsNaN(number) || double.IsNegativeInfinity(number) || double.IsNegativeInfinity(1/number))
               {
                    result= "1";
               }
               else
               {
                    result = "0";
               }
               number = Math.Abs(number);
               // find offset
               if (double.IsInfinity(number) || double.IsNaN(number))
                    offset = (int)Math.Pow(2, 11) - 1;
               else
                    offset = GetOffset(ref number);
               // convert offset to binary and add to result-string
               result = result + ConvertDecimalToBinary(offset);
               // count mantissa and add to result-string
               result = result + ConvertFractionDecimalToBinary(number - 1);
               // result = <sign><offset><mantissa>
               return result;
          }

          // count offset : try to find number between 1 and 2
          private static int GetOffset(ref double num)
          {
               int result = 0;
               if (num < 1)
               {
                    if (num == 0.0)
                    {
                         result = 0;
                         return result;
                    }
                    else
                    {
                         while (num < 1)
                         {
                              num = num * baseSystem;
                              result--;
                         }
                    }
               }
               else
               {
                    while (num > 2)
                    {
                         num = num / baseSystem;
                         result++;
                    }
               }
               result = result + maxOffset;
               if (result < 0)
               {
                    return 0;
               }
               else
               {
                    return result;
               }
          }

          // convert offset to binary number
          private static string ConvertDecimalToBinary(int decimalNumber)
          {
               int temp = 0;
               string result = "";
               if (decimalNumber == 0)
               {
                    result = "00000000000";
               }
               List<int> arrOfInt = new List<int>();
               while (decimalNumber > 0)
               {
                    temp = decimalNumber % 2;
                    decimalNumber = decimalNumber / 2;
                    arrOfInt.Add(temp);
               }
               for (int i = arrOfInt.Count - 1; i >= 0; i--)
               {
                    if (arrOfInt[i] == 1)
                    {
                         result += "1";
                    }
                    else
                    {
                         result += "0";
                    }
               }
               return result;
          }

          // convert fraction part of number to binary 
          private static string ConvertFractionDecimalToBinary(double fraction)
          {
               if (double.IsNegativeInfinity(fraction))
               {
                    fraction = 0;
               }
               if (double.IsNaN(fraction))
               {
                    fraction = 0.5;
               }
               string result = "";
               int integerOverflow = 0;
               int length = bitsOfMantissa;
               if (fraction == 0)
               {
                    fraction = Math.Pow(2, -bitsOfMantissa);
               }
               
               for (int i = 0; i < length; i++)
               {
                    fraction *= 2;
                    integerOverflow = (int)fraction % 2;
                    fraction -= integerOverflow;
                    result += integerOverflow.ToString();
               }
               return result;
          }
     }
}
