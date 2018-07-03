using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TListaCorreo()
        {
            Correo auxC = new Correo();

            if (auxC.Paquetes == null)
            {
               Assert.Fail();
            }
        }

        [TestMethod]
        public void TIDPaquete()
        {
            Correo auxC = new Correo();
            Paquete auxP1 = new Paquete("TestUno", "TrackingUno");
            Paquete auxP2 = new Paquete("TestDos", "TrackingUno");

            auxC += auxP1;

            try
            {
                auxC += auxP2;
                Assert.Fail();
            }
            catch (TrackingIDRepetidoException e)
            {

            }
        }
    }
}
