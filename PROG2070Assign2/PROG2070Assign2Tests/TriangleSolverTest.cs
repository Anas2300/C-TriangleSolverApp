using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PROG2070Assign2
{
    [TestFixture]
    class TriangleSolverTest
    {
        /// <summary>
        /// Method that tests for Equalateral Triangle
        /// </summary>
        [Test]
        public void CheckEqualateral()
        {
            String Answer = TriangleSolver.Analyze(2, 2, 2);
            Assert.AreEqual("Your Triangle is Equilateral", Answer);
        }

        /// <summary>
        /// Method that tests for Isoceles Triangle
        /// </summary>
        [Test]
        public void CheckIsoceles()
        {
            String Answer = TriangleSolver.Analyze(1, 2, 1);
            Assert.AreEqual("Your Triangle is Isoceles", Answer);

        }

        /// <summary>
        /// Method that checks for Scalene Triangle
        /// </summary>
        [Test]
        public void CheckScalene()
        {
            String Answer = TriangleSolver.Analyze(1, 2, 3);
            Assert.AreEqual("Your Triangle is Scalene", Answer);

        }

        /// <summary>
        /// Method that check if the user inputs 0
        /// </summary>
        [Test]
        public void CheckValidTriangle()
        {
            String Answer = TriangleSolver.Analyze(0, 0, 0);
            Assert.AreEqual("This does not form a triangle", Answer);

        }

        /// <summary>
        /// Method that checks if user exceeds the upper limit
        /// </summary>
        [Test]
        public void CheckValuesUpperLimit()
        {
            String Answer = TriangleSolver.Analyze(10001, 5, 2);
            Assert.AreEqual("Values cannot exceed 1000", Answer);

        }

        /// <summary>
        /// Method that checks if the user inputs negative values
        /// </summary>
        [Test]
        public void CheckNegativeValues()
        {
            String Answer = TriangleSolver.Analyze(2, -5, 2);
            Assert.AreEqual("Negative values cannot be computed", Answer);

        }
    }
}
