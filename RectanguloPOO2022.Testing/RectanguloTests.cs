using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RectanguloPOO2022.Entidades;

namespace RectanguloPOO2022.Testing
{
    [TestClass]
    public class RectanguloTests
    {
        [TestMethod]
        public void RectanguloValidarValida()
        {
            //Arrange
            int ladoMayor = 10;
            int ladoMenor = 5;

            //Act
            var rectangulo = new Rectangulo();
            rectangulo.LadoMayor = ladoMayor;
            rectangulo.LadoMenor = ladoMenor;

            //Assert
            Assert.IsTrue(rectangulo.Validar());
        }
        [TestMethod]
        public void RectanguloValidarNoValida()
        {
            //Arrange
            int ladoMayor = 5;
            int ladoMenor = 5;

            //Act
            var rectangulo = new Rectangulo();
            rectangulo.LadoMayor = ladoMayor;
            rectangulo.LadoMenor = ladoMenor;

            //Assert
            Assert.IsFalse(rectangulo.Validar());
        }
        [TestMethod]
        public void RectanguloValidarNoValidaLadoMenor()
        {
            //Arrange
            int ladoMayor = 5;
            int ladoMenor = -5;

            //Act
            var rectangulo = new Rectangulo();
            rectangulo.LadoMayor = ladoMayor;
            rectangulo.LadoMenor = ladoMenor;

            //Assert
            Assert.IsFalse(rectangulo.Validar());
        }

        [TestMethod]
        public void RectanguloGetPerimetro()
        {
            //Arrange
            int ladoMayor =10;
            int ladoMenor = 5;

            //Act
            var rectangulo = new Rectangulo();
            rectangulo.LadoMayor = ladoMayor;
            rectangulo.LadoMenor = ladoMenor;

            //Assert
            Assert.AreEqual(30,rectangulo.GetPerimetro());
        }
        [TestMethod]
        public void RectanguloGetSuperficie()
        {
            //Arrange
            int ladoMayor = 10;
            int ladoMenor = 5;

            //Act
            var rectangulo = new Rectangulo();
            rectangulo.LadoMayor = ladoMayor;
            rectangulo.LadoMenor = ladoMenor;

            //Assert
            Assert.AreEqual(50,rectangulo.GetSuperficie());
        }
    }
}
