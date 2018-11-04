using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtension
{
     /// <summary>
     /// Class contains static method for transfering from one number system to another.
     /// </summary>
     public static class Parser
     {
          /// <summary>
          /// Transfer number to decimal system.
          /// </summary>
          /// <param name="source">
          /// String representation of a number.
          /// </param>
          /// <param name="base">
          /// Original number system.
          /// </param>
          /// <returns>
          /// Number in decimal system.
          /// </returns>
          public static int ToDecimal(this string source, int @base)
          {
               if (ReferenceEquals(source, null))
                    throw new ArgumentNullException();
               IConvertNumber convert = GetNameOfType(@base);
               return convert.ConvertToDecimal(source.ToUpper());
          }

          /// <summary>
          /// Find required class for transfering.
          /// </summary>
          /// <param name="base">
          /// Original number system.
          /// </param>
          /// <returns>
          /// Class instance.
          /// </returns>
          private static IConvertNumber GetNameOfType(int @base)
          {
               switch (@base)
               {
                    case 2: return new ToDecimalFrom2();
                    case 3: return new ToDecimalFrom3();
                    case 4: return new ToDecimalFrom4();
                    case 5: return new ToDecimalFrom5();
                    case 6: return new ToDecimalFrom6();
                    case 7: return new ToDecimalFrom7();
                    case 8: return new ToDecimalFrom8();
                    case 9: return new ToDecimalFrom9();
                    case 10: return new ToDecimalFrom10();
                    case 11: return new ToDecimalFrom11();
                    case 12: return new ToDecimalFrom12();
                    case 13: return new ToDecimalFrom13();
                    case 14: return new ToDecimalFrom14();
                    case 15: return new ToDecimalFrom15();
                    case 16: return new ToDecimalFrom16();
                    default: throw new ArgumentOutOfRangeException() ;
               }
          }
     }
}
