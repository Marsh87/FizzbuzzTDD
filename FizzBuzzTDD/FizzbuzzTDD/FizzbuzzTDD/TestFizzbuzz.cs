using System.Collections.Generic;
using NUnit.Framework;

namespace FizzbuzzTDD
{
    [TestFixture]
    public class TestFizzbuzz
    {
        [Test]
        public void GetFizzBuzz_Given1_ShouldReturn1()
        {
            //---------------Set up test pack-------------------
            const int input = 1;
            const string expected = "1";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = GetFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_Given2_ShouldReturn2()
        {
            //---------------Set up test pack-------------------
            const int input = 2;
            const string expected = "2";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = GetFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
            
        }

        [Test]
        public void GetFizzBuzz_Given3_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            const int input = 3;
            const string expected = "Fizz";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = GetFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
            
        }

        [Test]
        public void GetFizzBuzz_Given4_ShouldReturn4()
        {
            //---------------Set up test pack-------------------
            const int input = 4;
            const string expected = "4";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = GetFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
            
        }

        [Test]
        public void GetFizzBuzz_Given5_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            const int input = 5;
            const string expected = "Buzz";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = GetFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
            
        }

        [Test]
        public void GetFizzBuzz_Given6_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            const int input = 6;
            const string expected = "Fizz";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = GetFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
            
        }

        [Test]
        public void GetFizzBuzz_Given9_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            const int input = 9;
            const string expected = "Fizz";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = GetFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
            
        }

        [Test]
        public void GetFizzBuzz_Given10_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            const int input = 10;
            const string expected = "Buzz";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = GetFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
            
        }

        [Test]
        public void GetFizzBuzz_Given15_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            const int input = 15;
            const string expected = "FizzBuzz";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = GetFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
            
        }

        [Test]
        public void GetFizzBuzz_Given20_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            const int input = 20;
            const string expected = "Buzz";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = GetFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
            
        }

        [Test]
        public void GetFizzBuzz_Given30_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            const int input = 30;
            const string expected = "FizzBuzz";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = GetFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void GetFizzBuzzList_GivenCounterOf1_ShouldReturnOneItem()
        {
            //---------------Set up test pack-------------------
            const int counter = 1;
            const int expected = 1;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = GetFizzBuzzList(counter);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result.Count);

        }

        [Test]
        public void GetFizzBuzzList_GivenCounterOf2_ShouldReturnTwoItems()
        {
            //---------------Set up test pack-------------------
            const int counter = 2;
            const int expected = 2;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = GetFizzBuzzList(counter);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result.Count);

        }

        [Test]
        public void GetFizzBuzzList_GivenCounterOf3_ShouldReturnManyItems()
        {
            //---------------Set up test pack-------------------
            const int counter = 3;
            const int expected = 3;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = GetFizzBuzzList(counter);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result.Count);

        }

        [Test]
        public void GetFizzBuzzList_GivenCounterOf15_ShouldReturnsFizzBuzzItems()
        {
            //---------------Set up test pack-------------------
            const int counter = 15;
            var expectedFizzBuzzItems = new[] { "1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"};
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = GetFizzBuzzList(counter);
            //---------------Test Result -----------------------
            CollectionAssert.AreEquivalent(expectedFizzBuzzItems, result);

        }

        private List<string> GetFizzBuzzList(int counter)
        {
            var fizzBuzzList = new List<string>();
            for (int count = 0; count < counter; count++)
            {
                fizzBuzzList.Add(GetFizzBuzz(count+1));
            }
            return fizzBuzzList;
        }


        private string GetFizzBuzz(int input)
        {
            if (input % 3==0 && input % 5==0 ) return "FizzBuzz";
            if (input % 5==0) return "Buzz";
            if (input % 3==0) return "Fizz";
            return input.ToString();
        }
        
    }
}
