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
        public void Add_AddItemToIndiceFive_ItemGoesToFive()
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

        public void Add_SwapIndicies_FromZeroToThree()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected;
            int actual;
            //act
            testList.AddInts(expected, );
            actual = testList[1];
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
