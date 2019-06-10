using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomClassList_Project_Tests
{
    [TestClass]
    public class CustomClassList_Project_Test
    {
        [TestMethod]
        public void Add_AddItemToEmptyList_ItemGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;
            // act
            testList.Add(expected);
            actual = testList[0];
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToEmptyList_CountIncrementsToOne()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;
            // act
            testList.Add(698);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        // If we add an item to a list that already has 5 things in it,
        [TestMethod]
        public void Add_AddItemToPopulatedList_ListHasFiveItems()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(0);
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            testList.Add(7);
            int expected = 7;
            int actual;
            //act
            testList.Add(expected);
            actual = testList[7];
            //assert
            Assert.AreEqual(expected, actual);
        }
        // ADDITIONAL TEST IDEA:

        // does the newly added item go to the correct spot? (index 5?)
        [TestMethod]
        public void Add_AddItemToPopulatedList_ListHasTenItems()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(0);
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            testList.Add(7);
            testList.Add(8);
            testList.Add(9);
            testList.Add(10);
            int expected = 10;
            int actual;
            //act
            actual = testList[10];
            //assert
            Assert.AreEqual(expected, actual);
        }

        //add a string to the array
        [TestMethod]
        public void Add_AddStringToTheList_Pokemon()
        {
            //arrange
            CustomList<string> testList = new CustomList<string>();
            string expected = "Bulbasaur";
            string actual;
            //act
            testList.Add(expected);
            actual = testList[0];
            //assert
            Assert.AreEqual(expected, actual);
        }
        //add a string to the list at the beginning
        [TestMethod]
        public void Add_AddPokemonToEmptyList_CountIncrementsToOne()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();
            int expected = 1;
            int actual;
            // act
            testList.Add("Bulbasaur");
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        //add several pokemon to the pokedex
        [TestMethod]
        public void Add_AddThreeStringsToTheEmptyList_FirstThreePokemon()
        {
            //arrange
            CustomList<string> testList = new CustomList<string>();
            string bulbasaur = "Bulbasaur";
            string ivysaur = "Ivysaur";
            string venusaur = "Venusaur";
            int expected = 3;
            int actual;
            

            //act
            testList.Add(bulbasaur);
            testList.Add(ivysaur);
            testList.Add(venusaur);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        //Inserting Pokemon into the list at specific locations
        //[TestMethod]
        //public void Add_AddPokemonToSpecificIndiciesInPopulatedList_EvolvedForms()
        //{
        //    //arrange
        //    CustomList<string> testList = new CustomList<string>();
        //    string bulbasaur = "Bulbasaur";
        //    testList.Add(bulbasaur);
        //    string ivysaur = "Ivysaur";
        //    testList.Add(ivysaur);
        //    string venusaur = "Venusaur";
        //    string charmander = "Charmander";
        //    testList.Add(charmander);
        //    string charmeleon = "Charmeleon";
        //    testList.Add(charmeleon);
        //    string charizard = "Charizard";
        //    string squirtle = "Squirtle";
        //    testList.Add(squirtle);
        //    string wartortle = "Wartortle";
        //    testList.Add(wartortle);
        //    string blastoise = "Blastoise";
        //    int expected = 9;
        //    int actual;


        //    //act
        //    testList.Insert(2, venusaur);
        //    testList.Insert(5, charizard);
        //    testList.Insert(8, blastoise);
        //    actual = testList.Count;

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}
        [TestMethod]
        public void Remove_RemoveFirstItemInList_IndexZero()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            int expected = 2;
            int actual;


            //act
            testList.Remove(1);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveFirstItemInList_IndexZeroSecondTest()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            int expected = 3;
            int actual;


            //act
            testList.Remove(0);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveItemInList_IndexTwo()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            int expected = testList[4];
            int actual;


            //act
            testList.Remove(2);
            actual = testList[3];

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveItemInList_IndexTwoSecondTest()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            int expected = 5;
            int actual;


            //act
            testList.Remove(2);
            actual = testList[3];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveItemInList_IndexFive()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            int expected = testList[5];
            int actual;


            //act
            testList.Remove(5);
            actual = testList[4];

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveItemInList_IndexFiveSecondTest()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            int expected = 5;
            int actual;


            //act
            testList.Remove(5);
            actual = 5;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemovePokemonFromList_ByeBulbasaur()
        {
            //arrange
            CustomList<string> testList = new CustomList<string>();
            string bulbasaur = "Bulbasaur";
            testList.Add(bulbasaur);

            string ivysaur = "Ivysaur";
            testList.Add(ivysaur);

            string venusaur = "Venusaur";
            testList.Add(venusaur);

            string expected = testList[1];
            string actual;

            //act
            testList.Remove(bulbasaur);
            actual = testList[0];

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemovePokemonFromList_ByeBulbasaurSecondTest()
        {
            //arrange
            CustomList<string> testList = new CustomList<string>();
            string bulbasaur = "Bulbasaur";
            testList.Add(bulbasaur);

            string ivysaur = "Ivysaur";
            testList.Add(ivysaur);

            string venusaur = "Venusaur";
            testList.Add(venusaur);

            string expected = testList[2];
            string actual;

            //act
            testList.Remove(bulbasaur);
            actual = testList[1];

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ToString_IndexZeroToString_NumberOne()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            string expected = "one";
            string actual;

            //act
            testList.Add(1);
            testList.ToString();
            actual =  "one";

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_IndexZeroToString_NumberOneFailure()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(5);
            string expected = "5 ";
            string actual;

            //act
            actual = testList.ToString();

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void OverLoadPlusOperator_AddingTwoLists()
        {
            //arrange
            CustomList<int> one = new CustomList<int>();
            one.Add(11);
            one.Add(33);
            one.Add(55);
            CustomList<int> two = new CustomList<int>();
            two.Add(22);
            two.Add(44);
            two.Add(66);
            CustomList<int> result = new CustomList<int>();
            string expected = "11 33 55 22 44 66 ";
            string actual;

            //act
            result = one + two;
            actual = result.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void OverLoadPlusOperator_AddingTwoLists_TripleDigits()
        {
            //arrange
            CustomList<int> one = new CustomList<int>();
            one.Add(111);
            one.Add(333);
            one.Add(555);
            CustomList<int> two = new CustomList<int>();
            two.Add(222);
            two.Add(444);
            two.Add(666);
            CustomList<int> result = new CustomList<int>();
            string expected = "111 333 555 222 444 666 ";
            string actual;

            //act
            result = one + two;
            actual = result.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverLoadSubtractionOperator_AddingTwoLists_RemovingListTwo()
        {
            //arrange
            CustomList<int> one = new CustomList<int>();
            one.Add(11);
            one.Add(33);
            one.Add(55);
            CustomList<int> two = new CustomList<int>();
            two.Add(22);
            two.Add(44);
            two.Add(66);
            CustomList<int> result = new CustomList<int>();
            string expected = "11 33 55 ";
            string actual;

            //act
            result = one - two;
            actual = result.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverLoadSubtractionOperator_AddingTwoLists_RemovingListOne()
        {
            //arrange
            CustomList<int> one = new CustomList<int>();
            one.Add(11);
            one.Add(33);
            one.Add(55);
            CustomList<int> two = new CustomList<int>();
            two.Add(22);
            two.Add(44);
            two.Add(66);
            CustomList<int> result = new CustomList<int>();
            string expected = "22 44 66 ";
            string actual;

            //act
            result = two - one;
            actual = result.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverLoadSubtractionOperator_AddingTwoLists_DifferentSizeLists()
        {
            //arrange
            CustomList<int> one = new CustomList<int>();
            one.Add(11);
            one.Add(33);
            one.Add(55);
            CustomList<int> two = new CustomList<int>();
            two.Add(22);
            two.Add(44);
            CustomList<int> result = new CustomList<int>();
            string expected = "22 44 ";
            string actual;

            //act
            result = two - one;
            actual = result.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverLoadSubtractionOperator_AddingTwoLists_ReversingOrder()
        {
            //arrange
            CustomList<int> one = new CustomList<int>();
            one.Add(11);
            one.Add(55);
            CustomList<int> two = new CustomList<int>();
            two.Add(22);
            two.Add(44);
            two.Add(66);
            CustomList<int> result = new CustomList<int>();
            string expected = "11 55 ";
            string actual;

            //act
            result = one - two;
            actual = result.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZipMethodTest_CombiningLists_NumericalOrder()
        {
            //arrange
            CustomList<int> odd = new CustomList<int>();
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            CustomList<int> even = new CustomList<int>();
            even.Add(2);
            even.Add(4);
            even.Add(6);
            CustomList<int> result = new CustomList<int>();
            string expected = "1 2 3 4 5 6 ";
            string actual;
            CustomList<int>.OperatorZip(odd, even);

            //act
            result = CustomList<int>.OperatorZip(odd, even);
            actual = result.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZipMethodTest_CombiningLists_Duplicates()
        {
            //arrange
            CustomList<int> odd = new CustomList<int>();
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            CustomList<int> even = new CustomList<int>();
            even.Add(1);
            even.Add(3);
            even.Add(5);
            CustomList<int> result = new CustomList<int>();
            string expected = "1 1 3 3 5 5 ";
            string actual;
            CustomList<int>.OperatorZip(odd, even);

            //act
            result = CustomList<int>.OperatorZip(odd, even);
            actual = result.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZipMethodTest_CombiningLists_DifferentSizeLists()
        {
            //arrange
            CustomList<int> odd = new CustomList<int>();
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            CustomList<int> even = new CustomList<int>();
            even.Add(2);
            even.Add(4);
            CustomList<int> result = new CustomList<int>();
            string expected = "1 2 3 4 5 ";
            string actual;
            CustomList<int>.OperatorZip(odd, even);

            //act
            result = CustomList<int>.OperatorZip(odd, even);
            actual = result.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipMethodTest_CombiningDifferentSizeLists_EvenIsBigger()
        {
            //arrange
            CustomList<int> odd = new CustomList<int>();
            odd.Add(1);
            odd.Add(3);
            CustomList<int> even = new CustomList<int>();
            even.Add(2);
            even.Add(4);
            even.Add(6);
            CustomList<int> result = new CustomList<int>();
            string expected = "1 2 3 4 6 ";
            string actual;
            CustomList<int>.OperatorZip(odd, even);

            //act
            result = CustomList<int>.OperatorZip(odd, even);
            actual = result.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
