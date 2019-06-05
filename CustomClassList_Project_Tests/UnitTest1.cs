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
        public void Add_AddItemToPopulatedList_ListHasFiveItems()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 6;
            int actual;
            //act
            testList.Add(expected);
            actual = testList[5];
            //assert
            Assert.AreEqual(expected, actual);
        }
        // ADDITIONAL TEST IDEA:

        // does the newly added item go to the correct spot? (index 5?)
        public void Add_AddItemToPopulatedList_ListHasTenItems()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 11;
            int actual;
            //act
            testList.Add(expected);
            actual = testList[9];
            //assert
            Assert.AreEqual(expected, actual);
        }

        //add a string to the array

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

        //add several pokemon to the pokedex
        public void Add_AddThreeStringsToTheEmptyList_FirstThreePokemon()
        {
            //arrange
            CustomList<string> testList = new CustomList<string>();
            string bulbasaur = "Bulbasaur";
            string ivysaur = "Ivysaur";
            string venusaur = "Venusaur";
            string actual;
            //act
            testList.Add(bulbasaur);
            testList.Add(ivysaur);
            testList.Add(venusaur);
            actual = testList[0, 1, 2];
            //assert
            Assert.AreEqual(bulbasaur, ivysaur, venusaur, actual);
        }

    }
}
