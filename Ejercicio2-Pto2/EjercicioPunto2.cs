using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ejercicio2_Pto2
{
    [TestClass]
    public class EjercicioPunto2
    {
        [DataRow(4,2,2)]
        [DataRow(8,2,3)]
        [DataRow(1,0,1)]

        [TestMethod]
        public void DivisionTest(int a, int b, int expected)
        {
            //Arrange
            /*int a = 1;
            int b = 0;
            int expected = 1;*/

            //Act
            int actual = Division.div(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [DataRow(1, 0)]
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionCero_ThrowException(int a, int b)
        {
            //Arrange

            //Act
            try
            {
                Division.divisionCero(a, b);
            }
            catch(DivideByZeroException ex)
            {
                //Assert
                Assert.AreEqual("Solo Chuck Norris divide por cero!", ex.Message);
            }

        }
    }


}
