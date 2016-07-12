using System.Linq;
using LeetCode.Algorithms.ArrayAndString;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.ArrayAndString.Tests
{
    [TestClass]
    public class CharactersTests
    {
        [TestMethod]
        public void CharactersShouldReturnNumberOfBytesRead()
        {
            //GIVEN
            //const string stubContent = "abcdefghijklmnopqrstuvwxyz";
            var buffer = new char[5];
            var expectedBufforContent = new[] {'a', 'b', 'c', 'd', 'e'};
            var reader = new ReaderStub();
            var characters = new Characters(reader);

            //WHEN
            var bytesRead = characters.ReadOnce(buffer, 5);

            //THEN
            Assert.AreEqual(5, bytesRead);
            Assert.IsTrue(expectedBufforContent.SequenceEqual(buffer));
        }

        [TestMethod]
        public void CharactersShouldReadDataTwiceButSkipNotUtilizedCharacters()
        {
            //GIVEN
            var firstRead = new char[3];
            var secondRead = new char[3];

            var expectedFirstRead = new[] {'a', 'b', 'c'};
            var expectedSecondRead = new[] {'e', 'f', 'g'};

            var reader = new ReaderStub();
            var characters = new Characters(reader);

            //WHEN
            characters.ReadOnce(firstRead, 3);
            characters.ReadOnce(secondRead, 3);

            //THEN
            Assert.IsTrue(expectedFirstRead.SequenceEqual(firstRead));
            Assert.IsTrue(expectedSecondRead.SequenceEqual(secondRead));
        }

        [TestMethod]
        public void CharactersShouldReadDataTwiceButUtilizeAllCharacters()
        {
            //GIVEN
            var firstRead = new char[3];
            var secondRead = new char[3];

            var expectedFirstRead = new[] {'a', 'b', 'c'};
            var expectedSecondRead = new[] {'d', 'e', 'f'};

            var reader = new ReaderStub();
            var characters = new Characters(reader);

            //WHEN
            characters.ReadMany(firstRead, 3);
            characters.ReadMany(secondRead, 3);

            //THEN
            Assert.IsTrue(expectedFirstRead.SequenceEqual(firstRead));
            Assert.IsTrue(expectedSecondRead.SequenceEqual(secondRead));
        }
    }
}