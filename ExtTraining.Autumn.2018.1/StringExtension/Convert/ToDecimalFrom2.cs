using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtension
{
     /// <summary>
     /// Convert number to decimal system from string.
     /// </summary>
     public class ToDecimalFrom2 : IConvertNumber
     {
          /// <summary>
          /// Convert number from string.
          /// </summary>
          /// <param name="str">
          /// Input string .
          /// </param>
          /// <returns>
          /// Decimal number.
          /// </returns>
          public int ConvertToDecimal(string str)
          {
               checked
               {
                    CheckInput(str);
                    char[] array = str.ToCharArray();
                    Array.Reverse(array);
                    int result = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                         if (array[i] == '1')
                         {
                              if (i == 0)
                              {
                                   result += 1;
                              }
                              else
                              {
                                   result += (int)Math.Pow(2, i);
                              }
                         }
                    }

                    return result;
               }
          }

          /// <summary>
          /// Check input string.
          /// </summary>
          /// <param name="str">
          /// String containing number.
          /// </param>
          private void CheckInput(string str)
          {
               if (str == null)
               {
                    throw new ArgumentNullException();
               }

               string new_str = str;
               new_str = new_str.Replace("1", string.Empty);
               new_str = new_str.Replace("0", string.Empty);
               if (new_str != string.Empty)
               {
                    throw new ArgumentException($"Invalid {nameof(str)}");
               }
          }
     }
}
