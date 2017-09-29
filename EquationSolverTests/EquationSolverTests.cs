using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquationSolverTests
{
    [TestClass]
    public class EquationSolverTests
    {
        [TestMethod]
        public void Coefficients_ShouldBeEqualToDiscriminant()
        {
            int[] coefficients = new int[] { 1, 5, 4 };
            int discriminant = EquationSolver.EquationSolver.reternDiscriminant(coefficients);
            int actualNumber = 9;
            Assert.AreEqual(actualNumber, discriminant);
        }
        [TestMethod]
        public void String_Coefficients()
        {
            string equationString = "-x^2-x-1=0";
            int[] coefficients = EquationSolver.EquationSolver.parseEquation(equationString);
            int[] actualCoefficients = new int[] { -1, -1, -1 };
            CollectionAssert.AreEqual(coefficients, actualCoefficients);
        }
        [TestMethod]
        public void EquationString_SouldBeValid()
        {
            string equation = "-123x^2+190223x-123124=0";
            bool valid = EquationSolver.EquationSolver.verifiesOfValidityOfEquation(equation);
            Assert.IsTrue(valid);
        }
        [TestMethod]
        public void CoefficientsAndDiscriminant_ShouldBeRightRoots()
        {
            int[] coefficients = new int[3] { 1, 5, 4 };
            int discriminant = 9;
            double actualFirstRoot = -1;
            double actualSecondRoot = -4;
            double firstRoot = EquationSolver.EquationSolver.findFirstRoot(discriminant, coefficients);
            double secondRoot = EquationSolver.EquationSolver.findSecondRoot(discriminant, coefficients);
            Assert.AreEqual(firstRoot, actualFirstRoot);
            Assert.AreEqual(secondRoot, actualSecondRoot);
        }
    }
}