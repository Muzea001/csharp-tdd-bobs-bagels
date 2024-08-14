using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using tdd_bobs_bagels.CSharp.Main;
namespace csharp_tdd_bobs_bagels.tests


{
    public class BagelTest
    {
        [Test]
        public void checkIfBagelAdded()
        {

            Basket shop = new Basket();
            //arrange

            string newBagelType = "roundBagle";

            //act
            shop.basket.Add(newBagelType);
            string expected_bagle = newBagelType;


            //assert
            Assert.IsTrue(shop.basket.Contains(expected_bagle));





        }

        [Test]

        [TestCase("AppleBagle", false)]
        [TestCase("OrangeBagle", false)]
        [TestCase("CidarlBagle", false)]
        [TestCase("ChocolateBagle", true)]
        [TestCase("CinnamonBagle", true)]
        public void checkIfBagelRemoved(string bagleToRemove, bool expectedOutcome)
        {

            Basket shop = new Basket();
            //arrange



            //act
            shop.basket.Add("CinnamonBagle");
            shop.basket.Add("ChocolateBagle");
            shop.basket.Remove(bagleToRemove);


            //assert
            Assert.IsTrue(!shop.basket.Contains(bagleToRemove));

        }
        [Test]

      
        public void checkIfLimitExists()
        {

            Basket shop = new Basket();
            //arrange

            string bagel1 = "smallBagle";
            string bagel2 = "smallBagle";
            string bagel3 = "smallBagle";
            string bagel4 = "smallBagle";
            string bagel5 = "smallBagle";
            


            //act
            shop.basket.Add(bagel1);
            shop.basket.Add(bagel2);
            shop.basket.Add(bagel3);
            shop.basket.Add(bagel4);
            shop.basket.Add(bagel5);
            
            int expectedBasketLimit = 5;
            

            //assert
            Assert.IsTrue(shop.basket.Count<=expectedBasketLimit);

        }





        [Test]
        
        [TestCase(5, true)]
        [TestCase(3, true)]
        public void checkIfLimitChanged(int newBagleLimit, bool expectedOutcome)
        {

            //arrange
            Basket shop = new Basket();
            string bagle1 = "bagle1";
            string bagle2 = "bagle2";
            string bagle3 = "bagle3";


            //act
            shop.setMax(newBagleLimit);
            shop.basket.Add(bagle1);
            shop.basket.Add(bagle2);
            shop.basket.Add(bagle3);
            Assert.IsTrue(shop.basket.Count<= newBagleLimit);





        }
        [Test]


        
        [TestCase("plainBagel", true)]
        [TestCase("sesameBagel", true)]
        public void checkIfElementIWannaDeleteExists(string bagleToDelete, bool expectedOutcome)
        {

            //arrange 
            Basket shop = new Basket();
            
            string testBagle1 = "plainBagel";
            string testBagle2 = "sesameBagel";


            //act
            shop.basket.Add(testBagle1);
            shop.basket.Add(testBagle2);
            Assert.IsTrue(shop.removeBagel(shop.basket, bagleToDelete));

        }
    }
}
