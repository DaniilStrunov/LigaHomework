using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquationSolver.Tests
{
    [TestClass]
    public static class EquationSolverTest
    {
        [TestMethod]
        public static void Coefficients_ShouldBeEqualToDiscriminant()
        {

            int[] coefficients = new int[] { 1, 5, 4 };
            int discriminant = EquationSolver.reternDiscriminant(coefficients);
            int actualNumber = 9;
            Assert.AreEqual(actualNumber, discriminant);
        }
    }
}