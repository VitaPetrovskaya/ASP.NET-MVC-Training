using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StringExtension;

namespace NumberConvertTest
{
    [TestFixture]
    public class NUnitTests
    {
          [Test]
          public void StringToDecimal_NullString_ThrowsArgumentNullException()
            => Assert.Throws<ArgumentNullException>(() => ((string)null).ToDecimal(2));

          [TestCase(1)]
          [TestCase(-5)]
          [TestCase(17)]
          [TestCase(20)]
          public void StringToDecimal_WrongBase_ThrowsArgumentOutOfRangeException(int @base) =>
              Assert.Throws<ArgumentOutOfRangeException>(() => "a".ToDecimal(@base));

          [TestCase("1AeF101", 2)]
          [TestCase("SA123", 2)]
          [TestCase("43256", 3)]
          [TestCase("10102", 2)]
          [TestCase("-sdfj", 3)]
          public void StringToDecimal_SymbolsNotInBase_ThrowsArgumentException(string source, int @base) =>
              Assert.Throws<ArgumentException>(() => source.ToDecimal(@base));

          [TestCase("111111111111111111111111111111111", 2)]
          [TestCase("535A79889", 13)]
          [TestCase("1550104015504", 6)]
          public void StringToDecimal_TooBigValue_ThrowsArgumentException(string source, int @base) =>
              Assert.Throws<OverflowException>(() => source.ToDecimal(@base));

          [TestCase("0110111101100001100001010111111", 2, ExpectedResult = 934331071)]
          [TestCase("01101111011001100001010111111", 2, ExpectedResult = 233620159)]
          [TestCase("11101101111011001100001010", 2, ExpectedResult = 62370570)]
          [TestCase("1AeF101", 16, ExpectedResult = 28242177)]
          [TestCase("1ACB67", 16, ExpectedResult = 1756007)]
          [TestCase("764241", 8, ExpectedResult = 256161)]
          [TestCase("10011", 2, ExpectedResult = 19)]
          [TestCase("10", 5, ExpectedResult = 5)]
          [TestCase("437abc", 16, ExpectedResult = 4422332)]
          [TestCase("332", 4, ExpectedResult = 62)]
          [TestCase("bc3215", 13, ExpectedResult = 4433902)]
          [TestCase("213423412", 10, ExpectedResult = 213423412)]
          public int StringToDecimal_ValidInput_ValidResult(string source, int @base)
              => source.ToDecimal(@base);

          [TestCase("11001100", ExpectedResult = 204)]
          public int CheckBinary(string binary)
          {
               return binary.ToDecimal(2);
          }

          [Test]
          public void CheckBinaryException()
          {
               Assert.Throws<ArgumentException>(() => "1PA01201".ToDecimal(2));
          }

          [TestCase("12201101", ExpectedResult = 4168)]
          public int CheckTernary(string binary)
          {
               return binary.ToDecimal(3);
          }

          [Test]
          public void CheckTernaryException()
          {
               Assert.Throws<ArgumentException>(() => "AB6578".ToDecimal(3));
          }

          [TestCase("2300131", ExpectedResult = 11293)]
          public int CheckQuaternary(string binary)
          {
               return binary.ToDecimal(4);
          }

          [Test]
          public void CheckQuaternaryException()
          {
               Assert.Throws<ArgumentException>(() => "899989".ToDecimal(4));
          }


          [TestCase("543210", ExpectedResult = 181896)]
          public int CheckOctal(string binary)
          {
               return binary.ToDecimal(8);
          }
     }
}
