using Lists;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTests
{
    public class Tests
    {
        [Test]
        public void SinglyLinkedTest()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            Assert.IsFalse(list.Contains("fred"));
            list.AddLast("fred");
            Assert.IsTrue(list.Contains("fred"));

            list.AddLast("wilma");
            list.AddLast("betty");
            list.AddLast("barney");
            Assert.IsTrue(list.Contains("wilma"));

            list.Delete("wilma");
            Assert.IsFalse(list.Contains("wilma"));
            Assert.That(list.Count() == 3);

            //assert_nil(list.find("wilma"))
            //list.add("wilma")
            //assert_equal("fred", list.find("fred").value())
            //assert_equal("wilma", list.find("wilma").value())
            //assert_equal(["fred", "wilma"], list.values())
        }
    }
}
