using System.Collections.Generic;
using NUnit.Framework;
using SignalCorrectionApp.Classes;

namespace SignalCorrectionApp.Tests
{
    public class CRCTests
    {
        public CRC crc12;
        public CRC crc16;

        [SetUp]
        public void TestSetup()
        {
            crc12 = new CRC(0x180F);
            crc16 = new CRC(0x18005);
        }

        [Test]
        [TestCase("25", "110011000000001010101")]
        [TestCase("194", "110000101000001010001111")]
        public void EncodeCRC16_Success(string inputNumber, string expectedSignal)
        {
            crc16.InputSignal = inputNumber;
            string encodedSignal = crc16.GetEncodedSignal();
            Assert.AreEqual(expectedSignal, encodedSignal);
        }

        [Test]
        [TestCase("25")]
        [TestCase("194")]
        public void CRC16_SignalInterrupted(string inputNumber)
        {
            crc16.InputSignal = inputNumber;
            string encodedSignal = crc16.GetEncodedSignal();
            string interruptedSignal = crc16.GetInterruptedSignal(new List<int>() { 0, encodedSignal.Length - 1 });

            string expectedBitValue = (int.Parse(encodedSignal[0].ToString()) ^ 1).ToString();
            Assert.AreEqual(interruptedSignal[0].ToString(), expectedBitValue);

            expectedBitValue = (int.Parse(encodedSignal[encodedSignal.Length - 1].ToString()) ^ 1).ToString();
            Assert.AreEqual(interruptedSignal[encodedSignal.Length - 1].ToString(), expectedBitValue);

            bool isSignalDemaged = crc16.IsSignalDemaged();
            Assert.AreEqual(true, isSignalDemaged);
        }

        [Test]
        [TestCase("25", "11001100011111111")]
        [TestCase("194", "11000010111110010001")]
        public void EncodeCRC12_Success(string inputNumber, string expectedSignal)
        {
            crc12.InputSignal = inputNumber;
            string encodedSignal = crc12.GetEncodedSignal();
            Assert.AreEqual(expectedSignal, encodedSignal);
        }

        [Test]
        [TestCase("25")]
        [TestCase("194")]
        public void CRC12_SignalInterrupted(string inputNumber)
        {
            crc12.InputSignal = inputNumber;
            string encodedSignal = crc12.GetEncodedSignal();
            string interruptedSignal = crc12.GetInterruptedSignal(new List<int>() { 0, encodedSignal.Length - 1 });

            string expectedBitValue = (int.Parse(encodedSignal[0].ToString()) ^ 1).ToString();
            Assert.AreEqual(interruptedSignal[0].ToString(), expectedBitValue);

            expectedBitValue = (int.Parse(encodedSignal[encodedSignal.Length - 1].ToString()) ^ 1).ToString();
            Assert.AreEqual(interruptedSignal[encodedSignal.Length - 1].ToString(), expectedBitValue);

            bool isSignalDemaged = crc12.IsSignalDemaged();
            Assert.AreEqual(true, isSignalDemaged);
        }
    }
}
