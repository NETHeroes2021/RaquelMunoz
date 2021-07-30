using Microsoft.VisualStudio.TestTools.UnitTesting;
using RormularioRaquel;
using System;
using System.Collections.Generic;

namespace Proyecto04Raquel.Test
{
    [TestClass]
    public class UnitTestProyecto04Raquel
    {
        [TestClass]
        public class UnitTestCrearMateriales
        {
            [TestMethod]
            public void TestMethodaniadirMateriales()
            {
                var material = "Acero";
                var objeto = CrearMateriales.aniadirMateriales(material);
                Assert.IsTrue(objeto is Acero);
            }

            [TestMethod]
            public void TestMethodaniadirMaterialesmal()
            {
                var material = "Acero";
                var objeto = CrearMateriales.aniadirMateriales(material);
                Assert.IsFalse(objeto is Higo);
            }

            [TestClass]
            public class UnitestPesoMedioPerecedero
            {
                [TestMethod]
                public void TestMethodcalcularPesoPerecedero()
                {
                    List <IMaterializable> materiales = new List<IMaterializable>();
                    IMaterializable item1 = new Higo(50);
                    IMaterializable item2 = new Acero(70);
                    IMaterializable item3 = new Higo(40);
                    IMaterializable item4 = new Acero(10);

                    materiales.Add(item1);
                    materiales.Add(item2);
                    materiales.Add(item3);
                    materiales.Add(item4);


                    var higo = PesoPerecedero.calcularPesoPerecedero(materiales);
                    Assert.AreEqual((90).ToString(), higo);
                }


               
            }
            [TestClass]
            public class UnitestCalcularMediaNoPerecederos
            {
                [TestMethod]
                public void TestMethodCalcularMediaNP()
                {
                    List<IMaterializable> materiales = new List<IMaterializable>();
                    IMaterializable item1 = new Higo(50);
                    IMaterializable item2 = new Acero(70);
                    IMaterializable item3 = new Higo(40);
                    IMaterializable item4 = new Acero(10);

                    materiales.Add(item1);
                    materiales.Add(item2);
                    materiales.Add(item3);
                    materiales.Add(item4);


                    var media = CalcularMediaNoPerecederos.CalcularMediaNP(materiales);
                    Assert.AreEqual(Convert.ToDecimal(50.00), media);
                }

                [TestMethod]
                public void TestMethodCalcularMediaNPmal()
                {
                    List<IMaterializable> materiales = new List<IMaterializable>();
                    IMaterializable item1 = new Higo(50);
                    IMaterializable item2 = new Acero(70);
                    IMaterializable item3 = new Higo(40);
                    IMaterializable item4 = new Acero(10);

                    materiales.Add(item1);
                    materiales.Add(item2);
                    materiales.Add(item3);
                    materiales.Add(item4);


                    var media = CalcularMediaNoPerecederos.CalcularMediaNP(materiales);
                    Assert.AreNotEqual(Convert.ToDecimal(60.00), media);
                }



            }
        }





        
    }
}

