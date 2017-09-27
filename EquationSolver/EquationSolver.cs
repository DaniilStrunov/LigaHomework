using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace EquationSolver
{
    public static class EquationSolver
    {
        public static int[] parseEquation(string Equation)
        {
            int[] intCoefficients = new int[3];
            string[] stringCoefficients = Equation.Split(new String[] { "x^2", "x", "X^2", "X", "=0" }, StringSplitOptions.None);
            if (stringCoefficients[0] == "")
            {
                stringCoefficients[0] = "1";
            }
            if (stringCoefficients[0] == "-")
            {
                stringCoefficients[0] = "-1";
            }
            if (stringCoefficients[1] == "" || stringCoefficients[1] == "+")
            {
                stringCoefficients[1] = "1";
            }
            if (stringCoefficients[1] == "-")
            {
                stringCoefficients[1] = "-1";
            }
            intCoefficients[0] = Convert.ToInt16(stringCoefficients[0]);
            intCoefficients[1] = Convert.ToInt16(stringCoefficients[1]);
            intCoefficients[2] = Convert.ToInt16(stringCoefficients[2]);
            return intCoefficients;
        }
        public static int reternDiscriminant(int[] coefficients)
        {
            int discriminant = coefficients[1] * coefficients[1] - 4 * coefficients[0] * coefficients[2];
            return discriminant;
        }
        public static bool verifiesOfValidityOfEquation(string equation)
        {
            string pattern = "[+-]?\d*[x^2][+-]?\d*[x][+-]?\d*=0$";
            bool valid = Regex.IsMatch(equation, pattern, RegexOptions.IgnoreCase);
            return valid;
        }
        public static double findFirstRoot(int discriminant, int[] coefficients)
        {
            double firstRoot = (-coefficients[1] + Math.Sqrt(discriminant)) / 2;
            return firstRoot;
        }
        public static double findSecondRoot(int discriminant, int[] coefficients)
        {
            double secondRoot = (-coefficients[1] - Math.Sqrt(discriminant)) / 2;
            return secondRoot;
        }
        public static void WriteAnswer(double firstRoot, double secondRoot)
        {
            Console.WriteLine("The fitst root of equation: " + firstRoot + "\n" +
                "The second root of equation: " + secondRoot);
        }

    }
}
