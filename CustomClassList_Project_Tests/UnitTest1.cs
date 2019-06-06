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
            testList.Add(0);
            testList.Add(1);
            testList.Add(2);
            int expected = 1;
            int actual;


            //act
            testList.Remove(1);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
