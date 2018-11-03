﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtension
{
     class ToDecimalFrom14 : IConvertNumber
     {
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
                         if (array[i] == '1') result += (int)Math.Pow(14, i);
                         if (array[i] == '2') result += 2 * (int)Math.Pow(14, i);
                         if (array[i] == '3') result += 3 * (int)Math.Pow(14, i);
                         if (array[i] == '4') result += 4 * (int)Math.Pow(14, i);
                         if (array[i] == '5') result += 5 * (int)Math.Pow(14, i);
                         if (array[i] == '6') result += 6 * (int)Math.Pow(14, i);
                         if (array[i] == '7') result += 7 * (int)Math.Pow(14, i);
                         if (array[i] == '8') result += 8 * (int)Math.Pow(14, i);
                         if (array[i] == '9') result += 9 * (int)Math.Pow(14, i);
                         if (array[i] == 'A') result += 10 * (int)Math.Pow(14, i);
                         if (array[i] == 'B') result += 11 * (int)Math.Pow(14, i);
                         if (array[i] == 'C') result += 12 * (int)Math.Pow(14, i);
                         if (array[i] == 'D') result += 13 * (int)Math.Pow(14, i);
                    }
                    return result;
               }
          }

          private void CheckInput(string str)
          {
               if (str == null)
                    throw new ArgumentException($"Invalid {nameof(str)}");
               string new_str = str;
               new_str = new_str.Replace("D", string.Empty);
               new_str = new_str.Replace("C", string.Empty);
               new_str = new_str.Replace("B", string.Empty);
               new_str = new_str.Replace("A", string.Empty);
               new_str = new_str.Replace("9", string.Empty);
               new_str = new_str.Replace("8", string.Empty);
               new_str = new_str.Replace("7", string.Empty);
               new_str = new_str.Replace("6", string.Empty);
               new_str = new_str.Replace("5", string.Empty);
               new_str = new_str.Replace("4", string.Empty);
               new_str = new_str.Replace("3", string.Empty);
               new_str = new_str.Replace("2", string.Empty);
               new_str = new_str.Replace("1", string.Empty);
               new_str = new_str.Replace("0", string.Empty);
               if (new_str != "")
                    throw new ArgumentException($"Invalid {nameof(str)}");
          }
     }
}