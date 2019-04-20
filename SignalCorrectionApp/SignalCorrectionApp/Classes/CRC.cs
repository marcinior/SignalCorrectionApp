using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalCorrectionApp.Classes
{
    public class CRC : AlgorithmBase
    {
        private int polynomial;
        private int[] polynomialArray;
        private int[] encodedSignal;
        private int[] interruptedSignal;

        public CRC(int polynomial)
        {
            this.polynomial = polynomial;
            this.polynomialArray = Convert.ToString(polynomial, 2).Select(c => int.Parse(c.ToString())).ToArray();
        }

        public override string GetDecodedSignal()
        {
            return string.Join("", this.interruptedSignal.Take(int.Parse(RealDataSize)));
        }

        public bool IsSignalDemaged()
        {
            int[] reminder = CalculateReminder((int[])interruptedSignal.Clone(), polynomialArray);

            return !reminder.All(b => b == 0);
        }
 
        public override string GetEncodedSignal()
        {
            int[] messageArray = InputSignal.Select(c => int.Parse(c.ToString())).ToArray();
            int[] encodedSignal = new int[messageArray.Length + polynomialArray.Length - 1];
            Array.Copy(messageArray, encodedSignal, messageArray.Length);

            int[] reminder = CalculateReminder((int[])encodedSignal.Clone(), polynomialArray);
            Array.Copy(reminder, 0, encodedSignal, messageArray.Length, reminder.Length);
            this.encodedSignal = encodedSignal;

            return string.Join("", encodedSignal);
        }

        public override string GetInterruptedSignal(IList<int> distortedBits)
        {
            IList<int> revertedDistortedBits = distortedBits.Select(position => encodedSignal.Length - 1 - position).ToList();
            this.interruptedSignal = (int[])encodedSignal.Clone();

            foreach(var bitPosition in revertedDistortedBits)
            {
                if (bitPosition >= encodedSignal.Length)
                    continue;

                this.interruptedSignal[bitPosition] = this.interruptedSignal[bitPosition] ^ 1;
            }

            return string.Join("", this.interruptedSignal);
        }

        public override int GetRedundantInfromationSize ()  => polynomialArray.Length - 1;

        private int[] CalculateReminder(int[] dividend, int[] divisor)
        {
            for (int i = 0; i <= dividend.Length - divisor.Length; i++)
            {
                if (dividend[i] != 1)
                    continue;

                for (int j = 0; j < divisor.Length; j++)
                {
                    dividend[i + j] = dividend[i + j] ^ divisor[j];
                }
            }

            return dividend.Skip(dividend.Length - divisor.Length + 1).ToArray();
        }
    }
}
