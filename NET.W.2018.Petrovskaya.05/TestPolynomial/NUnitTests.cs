﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestPolynomial
{
     /// <summary>
     /// Test methods of Polynomial
     /// </summary>
     [TestFixture]
     public class NUnitTests
     {
          private Polynomial.Polynomial poly1, poly2;

          [SetUp]
          public void Init()
          {
               double[] coefficients = new double[] { 1, -2, 3, 4, 5 };
               poly1 = new Polynomial.Polynomial(coefficients);
               coefficients = new double[] { 6, 7, -8 };
               poly2 = new Polynomial.Polynomial(coefficients);
          }

          /// <summary>
          /// Find the root of the equation.
          /// </summary>
          /// <param name="x">
          /// Input variable.
          /// </param>
          /// <returns>
          /// Root of the equation.
          /// </returns>
          [TestCase(0, ExpectedResult = 1)]
          [TestCase(1, ExpectedResult = 11)]
          public double CountPolynomialTest(float x)
          {
               return poly1.CountPolinomial(x);
          }

          /// <summary>
          /// Present polynomial as a string.
          /// </summary>
          /// <returns></returns>
          [TestCase(ExpectedResult = " 5*x^4 + 4*x^3 + 3*x^2 - 2*x + 1")]
          public string ToStringTest()
          {
               return poly1.ToString();
          }

          /// <summary>
          /// Polynomial comparison.
          /// </summary>
          [Test]
          public void EqualsTests()
          {
               Assert.AreEqual(poly1.Equals(poly2), false);
               Assert.AreEqual(poly1.Equals(poly1), true);
          }

          [Test]
          public void PlusTest()
          {
               double[] newCoefficients = new double[5] { 7, 5, -5, 4, 5 };
               Assert.AreEqual(poly1 + poly2, new Polynomial.Polynomial(newCoefficients));
          }

          [Test]
          public void MinusTest()
          {
               double[] newCoefficients = new double[5] { -5, -9, 11, 4, 5 };
               Assert.AreEqual(poly1 - poly2, new Polynomial.Polynomial(newCoefficients));
          }

          [Test]
          public void MultTest()
          {
               double[] newCoefficients = new double[7] { 6, -5, -4, 61, 34, 3, -40 };
               Assert.AreEqual(poly1 * poly2, new Polynomial.Polynomial(newCoefficients));
          }

          /// <summary>
          /// Check "==".
          /// </summary>
          [Test]
          public void OperatorEqualsTests()
          {
               Assert.AreEqual(poly1 == poly2, false);
               Assert.AreEqual(poly1 == poly1, true);
          }

          /// <summary>
          /// Check "!="
          /// </summary>
          [Test]
          public void OperatorNotEqualsTests()
          {
               Assert.AreEqual(poly1 != poly2, true);
               Assert.AreEqual(poly1 != poly1, false);
          }
     }
}
