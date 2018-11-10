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
     public class ToDecimalFrom5 : IConvertNumber
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
                              result += (int)Math.Pow(5, i);
                         }

                         if (array[i] == '2')
                         {
                              result += 2 * (int)Math.Pow(5, i);
                         }

                         if (array[i] == '3')
                         {
                              result += 3 * (int)Math.Pow(5, i);
                         }

                         if (array[i] == '4')
                         {
                              result += 4 * (int)Math.Pow(5, i);
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
               new_str = new_str.Replace("4", string.Empty);
               new_str = new_str.Replace("3", string.Empty);
               new_str = new_str.Replace("2", string.Empty);
               new_str = new_str.Replace("1", string.Empty);
               new_str = new_str.Replace("0", string.Empty);
               if (new_str != string.Empty)
               {
                    throw new ArgumentException($"Invalid {nameof(str)}");
               }
          }
     }
}
