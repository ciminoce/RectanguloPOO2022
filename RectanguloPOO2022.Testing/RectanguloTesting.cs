using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RectanguloPOO2022.Entidades;

namespace RectanguloPOO2022.Testing
{
    [TestClass]
    public class RectanguloTesting
    {
        [TestMethod]
        public void RectanguloValidarOK()
        {
            //Arrange
            int ladoMenor = 5;
            int ladoMayor = 10;
            //Act
            var rectangulo = new Rectangulo(ladoMayor, ladoMenor);

            //Assert
            Assert.IsTrue(rectangulo.Validar());
        }

        [TestMethod]
        public void RectanguloValidarNoValidaLadoMenorNoValido()
        {
            //Arrange
            int ladoMenor = 10;
            int ladoMayor = 5;
            //Act
            var rectangulo = new Rectangulo(ladoMayor, ladoMenor);

            //Assert
            Assert.IsFalse(rectangulo.Validar());

        }
        [TestMethod]
        public void RectanguloValidarNoValidaLadoMayorMenorCero()
        {
            //Arrange
            int ladoMenor = 10;
            int ladoMayor = -5;
            //Act
            var rectangulo = new Rectangulo(ladoMayor, ladoMenor);

            //Assert
            Assert.IsFalse(rectangulo.Validar());

        }
        [TestMethod]
        public void RectanguloValidarNoValidaLadoMenorMenorCero()
        {
            //Arrange
            int ladoMenor = -10;
            int ladoMayor = 10;
            //Act
            var rectangulo = new Rectangulo(ladoMayor, ladoMenor);

            //Assert
            Assert.IsFalse(rectangulo.Validar());

        }
        [TestMethod]
        public void RectanguloGetPerimetro()
        {
            //Arrange
            int ladoMenor = 2;
            int ladoMayor = 3;
            //Act
            var rectangulo = new Rectangulo(ladoMayor, ladoMenor);

            //Assert
            Assert.AreEqual(10, rectangulo.GetPerimetro());

        }
        [TestMethod]
        public void RectanguloGetSuperficie()
        {
            //Arrange
            int ladoMenor = 2;
            int ladoMayor = 3;
            //Act
            var rectangulo = new Rectangulo(ladoMayor, ladoMenor);

            //Assert
            Assert.AreEqual(6, rectangulo.GetSuperficie());

        }
    }
}
