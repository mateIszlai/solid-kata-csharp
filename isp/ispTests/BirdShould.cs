﻿using isp;
using NUnit.Framework;
using System;
using System.CodeDom;
using System.IO;
using System.Text;

namespace ispTests
{
    [TestFixture]
    public class BirdShould
    {
        private StringBuilder _consoleContent = new StringBuilder();
        private Bird bird = new Bird();
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
            bird.run();
            RemoveLineBreakers();
            Assert.AreEqual("Bird is running", _consoleContent.ToString());
        }

        [Test]
        public void fly()
        {
            bird.fly();
            RemoveLineBreakers();
            Assert.AreEqual("Bird is flying", _consoleContent.ToString());
        }

        private void RemoveLineBreakers()
        {
            _consoleContent.Remove(_consoleContent.Length - 2, 2);
        }
    }
}
