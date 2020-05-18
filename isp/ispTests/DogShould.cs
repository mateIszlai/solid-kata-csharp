using isp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispTests
{
    [TestFixture]
    public class DogShould
    {
        private StringBuilder _consoleContent = new StringBuilder();
        private Dog dog = new Dog();
        private StringWriter _writer;

        [SetUp]
        public void SetUp()
        {
            _writer = new StringWriter(_consoleContent);
            Console.SetOut(_writer);
        }


        [TearDown]
        public void TearDown()
        {
            _writer.Close();
            _writer = null;
            _consoleContent.Clear();
        }


        [Test]
        public void run()
        {
            dog.run();
            RemoveLineBreakers();
            Assert.AreEqual("Dog is running", _consoleContent.ToString());
        }

        [Test]
        public void bark()
        {
            dog.bark();
            RemoveLineBreakers();
            Assert.AreEqual("Dog is barking", _consoleContent.ToString());
        }

        private void RemoveLineBreakers()
        {
            _consoleContent.Remove(_consoleContent.Length - 2, 2);
        }
    }
}
