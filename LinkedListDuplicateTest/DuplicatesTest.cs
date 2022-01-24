using LLDuplicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LinkedListDuplicateTest
{
    [TestClass]
    public class DuplicatesTest
    {
        [TestMethod]
        public void CheckDuplicatesTest()
        {
            //Arrange
            Program LLDuplicates = new();
            LinkedList<char> linkedlist = new LinkedList<char>();
            linkedlist.AddFirst('E');
            linkedlist.AddLast('B');
            linkedlist.AddLast('E');

            //Act
            LinkedList<char> result = LLDuplicates.DuplicateValues(linkedlist);
            //Assert
            LinkedList<char> vs = new LinkedList<char>();
            vs.AddFirst('E');
            vs.AddLast('B');
            vs.AddLast('E');
            CollectionAssert.AreEqual(vs, result);
        }

        [TestMethod]
        public void CheckDuplicatesOnly2()
        {
            //Arrange
            Program LLDuplicates = new();
            
            LinkedList<char> linkedlist = new LinkedList<char>();
            linkedlist.AddFirst('E');
            linkedlist.AddLast('B');
            //Act
            LinkedList<char> result = LLDuplicates.DuplicateValues(linkedlist);
            //Assert
            LinkedList<char> vs = new LinkedList<char>();
            vs.AddFirst('E');
            vs.AddLast('B');
            CollectionAssert.AreEqual(vs, result);
        }

        [TestMethod]
        public void CheckDuplicatesMultiple()
        {
            //Arrange
            Program LLDuplicates = new();

            LinkedList<char> linkedlist = new LinkedList<char>();
            linkedlist.AddFirst('E');
            linkedlist.AddLast('B');
            linkedlist.AddLast('E');
            linkedlist.AddLast('E');
            linkedlist.AddLast('B');
            linkedlist.AddLast('A');
            linkedlist.AddLast('B');

            //Act
            LinkedList<char> result = LLDuplicates.DuplicateValues(linkedlist);
            //Assert
            LinkedList<char> vs = new LinkedList<char>();
            vs.AddFirst('E');
            vs.AddLast('B');
            vs.AddLast('E');
            vs.AddLast('B');
            vs.AddLast('A');

            CollectionAssert.AreEqual(vs, result);
        }
    }
}
