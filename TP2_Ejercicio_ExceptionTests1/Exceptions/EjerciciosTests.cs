using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP2_Ejercicio_Exception.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_Ejercicio_Exception.Exceptions.Tests
{
    [TestClass()]
    public class EjerciciosTests
    {
        //Consigna 1
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionTest1()
        {
            //Arrange
            int num1 = 20;
            int num2 = 0;

            //Act
            DivisionExtension.division(num1, num2);

        }


        //Consigna 2
        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void DivisionTest2()
        {
            //Arrange
            int num1 = 20;

            //Act
            DivisionExtension.division(num1, null);

        }
    }
}