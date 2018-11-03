using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtension
{
     class ToDecimalFrom2: IConvertNumber
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
                         if (array[i] == '1')
                              if (i == 0)
                                   result += 1;
                              else
                                   result += (int)Math.Pow(2, i);
                    return result;
               }
          }

          private void CheckInput(string str)
          {
               if(str == null)
                    throw new ArgumentException($"Invalid {nameof(str)}");
               string new_str = str;
               new_str = new_str.Replace("1", string.Empty);
               new_str = new_str.Replace("0", string.Empty);
               if(new_str != "")
                    throw new ArgumentException($"Invalid {nameof(str)}");
          }
     }
}
