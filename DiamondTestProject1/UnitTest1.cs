using DiamondClassLibrary1;
using System.Diagnostics.Metrics;
using NUnit.Framework;
namespace DiamondTestProject1
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}
        [Test]
        public void Test_FailwhenSpace()
        {
            char input = ' ';
            string[] output = Class1.DiamontPrint(input);
            Assert.That(output[0], Is.EqualTo(" "));
            
        }
        [Test]
        public void Test_FailwhenSmallAlphabets()
        {
            char input = 'a';
            string[] output = Class1.DiamontPrint(input);
            Assert.That(output[0], Is.EqualTo("a"));

        }
        [Test]
        public void Test_FailwhenNumber()
        {
            char input = '1';
            string[] output = Class1.DiamontPrint(input);
            Assert.That(output[0], Is.EqualTo("A"));

        }
        [Test]
        public void Test_whenAthenA()
        {
            char input = 'A';
            string[] output = Class1.DiamontPrint(input);
            Assert.That(output[0], Is.EqualTo("A"));
         
        }
        [Test]
        public void Test_WhenBthen()
        {
            char input = 'B';
            string[] output = Class1.DiamontPrint(input);
            Assert.That(output[0], Is.EqualTo(" A "));
            Assert.That(output[1], Is.EqualTo("B B"));
            Assert.That(output[2], Is.EqualTo(" A "));
           
        }
        [Test]
        public void Test_WhenCthen()
        {
         
            char input = 'C';
            string[] output = Class1.DiamontPrint(input);
            Assert.That(output[0], Is.EqualTo("  A  "));
            Assert.That(output[1], Is.EqualTo(" B B "));
            Assert.That(output[2], Is.EqualTo("C   C"));
            Assert.That(output[3], Is.EqualTo(" B B "));
            Assert.That(output[4], Is.EqualTo("  A  "));

        }
        [Test]
        public void Test_WhenDthen()
        {

            char input = 'D';
            string[] output = Class1.DiamontPrint(input);
            Assert.That(output[0], Is.EqualTo("   A   "));
            Assert.That(output[1], Is.EqualTo("  B B  "));
            Assert.That(output[2], Is.EqualTo(" C   C "));
            Assert.That(output[3], Is.EqualTo("D     D"));
            Assert.That(output[4], Is.EqualTo(" C   C "));
            Assert.That(output[5], Is.EqualTo("  B B  "));
            Assert.That(output[6], Is.EqualTo("   A   "));
        }

    }
   
}