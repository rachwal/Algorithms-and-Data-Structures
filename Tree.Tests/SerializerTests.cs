using DataStructures.Tree.Printer;
using DataStructures.Tree.Serializer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Tree.Tests
{
    [TestClass]
    public class SerializerTests
    {
        [TestMethod]
        public void SerializerShouldDeserializeTreeSerializedByDfs()
        {
            //GIVEN
            const string inOrderSerializedTree = "# 1 2 3 4 5 6";
            var serializer = new TreeSerializer();

            //WHEN

            var tree = serializer.DeserializeDfs(inOrderSerializedTree);

            //THEN
            var printer = new TreePrinter();

            var printTreeInOrder = printer.InOrderTraversal(tree);
            var printTreeDfs = printer.DepthFirstTraversal(tree);
            var printTreeBfs = printer.BreadthFirstTraversal(tree);

            Assert.AreEqual("1 2 3 4 5 6", printTreeInOrder);
            Assert.AreEqual("3 1 2 5 4 6", printTreeDfs);
            Assert.AreEqual("3 1 5 # 2 4 6 # # # # # #", printTreeBfs);
        }
    }
}