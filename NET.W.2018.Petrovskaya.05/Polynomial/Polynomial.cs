using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial
{
     /// <summary>
     /// Description of Polinomial.
     /// </summary>
     class Polynomial
     {

          private readonly double[] coefficients;

          /// <summary>
          /// Constructor fills in an array of coefficients.
          /// </summary>
          /// <param name="receivedCoefficients">
          /// Input coefficients of a polynomial.
          /// </param>
          public Polynomial(double[] receivedCoefficients)
          {
               if(CheckCoef(receivedCoefficients))
               {
                    coefficients = new double[receivedCoefficients.Length];
                    for (int i = 0; i < receivedCoefficients.Length; i++)
                    {
                         coefficients[i] = receivedCoefficients[i];
                    }
               }
          }

          /// <summary>
          /// Check coefficients.
          /// </summary>
          /// <param name="checkCoefficients"></param>
          /// <returns>
          /// True if coefficients are correct.
          /// False if coefficients are incorrect.
          /// </returns>
          private bool CheckCoef(double[] checkCoefficients)
          {
               if (checkCoefficients.Length == 0 )
               {
                    return false;
               }
               if (checkCoefficients == null)
               {
                    return false;
               }
               return true;
          }

          /// <summary>
          /// Find result of polynomial with input x.
          /// </summary>
          /// <param name="x">
          /// Input variable.
          /// </param>
          /// <returns>
          /// Result of count.
          /// </returns>
          public double CountPolinomial(float x)
          {
               double result = 0;
               for (int i = 0; i < coefficients.Length; i++)
               {
                    result += coefficients[i] * Math.Pow(x, i);
               }
               return result;
          }

          /// <summary>
          /// Property to access coefficients.
          /// </summary>
          /// <param name="index">
          /// Index of necessary coefficient.
          /// </param>
          /// <returns>
          /// Necessary coefficient.
          /// </returns>
          public double this[int index]
          {
               get
               {
                    if (index < 0 || index >= coefficients.Length)
                         throw new ArgumentOutOfRangeException();
                    return coefficients[index];
               }
          }

          /// <summary>
          /// Property to get length of polynomial.
          /// </summary>
          public int Length
          {
               get
               {
                    return coefficients.Length;
               }
          }

          /// <summary>
          /// Create the same polynomial.
          /// </summary>
          /// <returns></returns>
          public object Clone()
          {
               return new Polynomial(coefficients);
          }

          #region Override methods

          /// <summary>
          /// Present polynomial as a string.
          /// </summary>
          /// <returns>
          /// String containing polynomial.
          /// </returns>
          public override string ToString()
          {
               string result = "";
               for (int i = Length - 1; i >= 0; i--)
               {
                    if (i != Length - 1)
                    {
                         if(i == 0)
                         {
                              if (coefficients[i] > 0)
                                   result += "+ " + coefficients[i].ToString();
                              else
                                   result += "- " + Math.Abs(coefficients[i]).ToString();
                         }
                         else
                         {
                              if (i == 1)
                              {
                                   if (coefficients[i] > 0)
                                        result += "+ " + coefficients[i].ToString() + "*x ";
                                   else
                                        result += "- " + Math.Abs(coefficients[i]).ToString() + "*x ";
                              }
                              else
                              {
                                   if (coefficients[i] > 0)
                                        result += "+ " + coefficients[i].ToString() + "*x^" + i.ToString() + " ";
                                   else
                                        result += "- " + Math.Abs(coefficients[i]).ToString() + "*x^" + i.ToString() + " ";
                              }
                         }
                    }
                    else
                    {
                         result += " " + coefficients[i].ToString() + "*x^" + i.ToString() + " ";
                    }
               }
               return result;
          }

          public override int GetHashCode()
          {
               return coefficients.GetHashCode();
          }

          /// <summary>
          /// Compare coefficients of current polynomial with coefficients of input polynomial.
          /// </summary>
          /// <param name="obj">
          /// Input polynomial.
          /// </param>
          /// <returns>
          /// True if coefficients are the same. False if they are not the same.
          /// </returns>
          public override bool Equals(Object obj)
          {
               Polynomial polylomial = obj as Polynomial;
               if (obj == null)
               {
                    return false;
               }
               for(int i = 0; i < Length; i++)
               {
                    if(polylomial[i] != coefficients[i])
                         return false;
               }
               return true;
          }

          #endregion

          #region Overloaded operators

          /// <summary>
          /// Sum of two polynomials.
          /// </summary>
          /// <param name="p1">
          /// First input polynomial.
          /// </param>
          /// <param name="p2">
          /// Second input polynomial.
          /// </param>
          /// <returns>
          /// New polynomial as the result of sum.
          /// </returns>
          public static Polynomial operator +(Polynomial p1, Polynomial p2)
          {
               if (p1 == null && p2 == null)
                    return null;
               if (p1 != null && p2 == null)
                    return p1;
               if (p1 == null && p2 != null)
                    return p2;

               double[] newCoefficients;
               if (p1.Length < p2.Length)
                    newCoefficients = GetAddCoef(p1, p2);
               else
                    newCoefficients = GetAddCoef(p2, p1);
               return new Polynomial(newCoefficients);
          }

          /// <summary>
          /// Sum coefficients of two polynomials.
          /// </summary>
          /// <param name="minPolynomial"></param>
          /// <param name="maxPolynomial"></param>
          /// <returns>
          /// New array of coefficients.
          /// </returns>
          private static double[] GetAddCoef(Polynomial minPolynomial, Polynomial maxPolynomial)
          {
               double[] result = new double[maxPolynomial.Length];
               for(int i = 0; i < minPolynomial.Length; i++)
                    result[i] = minPolynomial[i] + maxPolynomial[i];
               if (minPolynomial.Length < result.Length)
                    for (int j = minPolynomial.Length; j < result.Length; j++)
                         result[j] = maxPolynomial[j];
               return result;
          }

          /// <summary>
          /// Difference of two polynomials.
          /// </summary>
          /// <param name="p1">
          /// First input polynomial.
          /// </param>
          /// <param name="p2">
          /// Second input polynomial.
          /// </param>
          /// <returns>
          /// New polynomial as the result of difference.
          /// </returns>
          public static Polynomial operator -(Polynomial p1, Polynomial p2)
          {
               double[] newCoefficients;
               if (p1 == null && p2 == null)
                    return null;
               if (p1 != null && p2 == null)
                    return p1;
               if (p1 == null && p2 != null)
               {
                    newCoefficients = new double[p2.Length];
                    for (int i = 0; i < p2.Length; i++)
                         newCoefficients[i] = p2[i]*(-1);
                    return p2;
               }
               newCoefficients = GetDeleteCoef(p1, p2);
               return new Polynomial(newCoefficients);
          }

          /// <summary>
          /// Difference between coefficients of polynomials.
          /// </summary>
          /// <param name="p1"></param>
          /// <param name="p2"></param>
          /// <returns>
          /// Array of result coefficients.
          /// </returns>
          private static double[] GetDeleteCoef(Polynomial p1, Polynomial p2)
          {
               double[] result;
               if (p1.Length > p2.Length)
               {
                    result = new double[p1.Length];
                    for (int i = 0; i < p2.Length; i++)
                         result[i] = p1[i] - p2[i];
                    for (int j = p2.Length; j < result.Length; j++)
                         result[j] = p1[j];
               }
               else
               {
                    result = new double[p2.Length];
                    for (int i = 0; i < p1.Length; i++)
                         result[i] = p1[i] - p2[i];
                    for (int j = p1.Length; j < result.Length; j++)
                         result[j] = p2[j]*(-1);
               }
               
               return result;
          }

          /// <summary>
          /// Multiplication of two polynomials.
          /// </summary>
          /// <param name="p1"></param>
          /// <param name="p2"></param>
          /// <returns>
          /// New polynomial as the result of multiplication.
          /// </returns>
          public static Polynomial operator *(Polynomial p1, Polynomial p2)
          {
               if (p1 == null && p2 == null)
                    return null;
               if (p1 != null && p2 == null)
                    return p1;
               if (p1 == null && p2 != null)
                    return p2;

               double[] newCoefficients = new double[p1.Length + p2.Length - 1];

               for (int i = 0; i < p1.Length; i++)
               {
                    for (int j = 0; j < p2.Length; j++)
                    {
                         newCoefficients[i + j] += p1[i] * p2[j];
                    }
               }
               return new Polynomial(newCoefficients);
          }

          /// <summary>
          /// Compare two polynomials.
          /// </summary>
          /// <param name="p1"></param>
          /// <param name="p2"></param>
          /// <returns>
          /// True if coefficients are the same. False if they are not the same.
          /// </returns>
          public static bool operator ==(Polynomial p1, Polynomial p2)
          {
               if ((object)p1 == null || (object)p2 == null || p1.Length != p2.Length)
                    return false;
               
               for(int i = 0; i < p1.Length; i++)
               {
                    if (p1[i] != p2[i])
                    {
                         return false;
                    }
               }
               return true;
          }

          /// <summary>
          /// Compare two polynomials.
          /// </summary>
          /// <param name="p1"></param>
          /// <param name="p2"></param>
          /// <returns>
          /// True if coefficients are not the same. False if they are the same.
          /// </returns>
          public static bool operator !=(Polynomial p1, Polynomial p2)
          {
               if (p1.Length != p2.Length || p1 == null || p2 == null)
                    return true;

               for (int i = 0; i < p1.Length; i++)
               {
                    if (p1[i] != p2[i])
                    {
                         return true;
                    }
               }
               return false;
          }

          #endregion

     }
}
