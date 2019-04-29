using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalCorrectionApp.Classes
{
    class HammingAlgorithm : AlgorithmBase
    {

        public StringBuilder interruptedSignal { get; set; }
        public String encodedSignal { get; set; }

        public HammingAlgorithm()
        {
            this.interruptedSignal = new StringBuilder();
            this.encodedSignal = "";
        }

        public override string GetDecodedSignal()
        {
            List<int> ones = this.getDecodedOnes(this.interruptedSignal.ToString());
            int interruptedValue = this.interruptedSignal.Length - this.generateValue(ones);
            if (interruptedValue < this.interruptedSignal.Length)
                this.interruptedSignal[interruptedValue] = Char.Parse(((int)Char.GetNumericValue(this.interruptedSignal[interruptedValue]) ^ 1).ToString());
            int additionalData = this.interruptedSignal.Length - this.InputSignal.Length;
            int length = this.interruptedSignal.Length;
            for (int i = 0; i < additionalData; i++)
            {
                this.interruptedSignal.Remove(length - (int)Math.Pow(2, i), 1);
            }
            return this.interruptedSignal.ToString();
        }

        public override string GetEncodedSignal()
        {
            List<int> onesPositions = getOnes(this.InputSignal);
            int powerControl = 1;
            String encodedText = Convert.ToString(generateValue(onesPositions), 2).PadLeft(8,'0');
            this.encodedSignal = this.encodedSignal + encodedText.ElementAt(encodedText.Length - 1);
            for (int i = 1; i <= this.InputSignal.Length; i++)
            {
                if ((i + powerControl) == (int)Math.Pow(2, powerControl))
                {
                    this.encodedSignal = encodedText.ElementAt(encodedText.Length - powerControl - 1) + this.encodedSignal;
                    powerControl++;
                }
                this.encodedSignal = this.InputSignal.ElementAt(this.InputSignal.Length - i) + this.encodedSignal;
            }
            return encodedSignal;
        }

        public override string GetInterruptedSignal(IList<int> distortedBits)
        {
            IList<int> revertedDistortedBits = distortedBits.Select(position => encodedSignal.Length - 1 - position).ToList();
            this.interruptedSignal.Append(encodedSignal);
            foreach (var bitPosition in revertedDistortedBits)
            {
                if (bitPosition >= encodedSignal.Length || bitPosition < 0)
                    continue;

                this.interruptedSignal[bitPosition] = Char.Parse(((int)Char.GetNumericValue(this.interruptedSignal[bitPosition]) ^ 1).ToString());
            }
            return this.interruptedSignal.ToString();
        }

        public override int GetRedundantInfromationSize()
        {
            return this.encodedSignal.Length - this.InputSignal.Length;
        }

        public List<int> getOnes(String text)
        {
            List<int> onesPositions = new List<int>();
            int positionsController = 2;
            for (int i = 0; i < text.Length; i++)
            {               
                if (Math.Pow(2, positionsController) == i + 1 + positionsController)
                {
                    positionsController++;
                }
                if (text.ElementAt(text.Length - 1 - i).Equals('1'))
                {
                    onesPositions.Add(i + 1 + positionsController);
                }
            }
            return onesPositions;
        }

        public List<int> getDecodedOnes(String text)
        {
            List<int> onesPositions = new List<int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (text.ElementAt(i).Equals('1'))
                {
                    onesPositions.Add(text.Length - i);
                }
            }
            return onesPositions;
        }

        public int generateValue(List<int> onesPositions)
        {
            int value = onesPositions.ElementAt(0);
            for (int i = 1; i < onesPositions.Count; i++)
            {
                value = value ^ onesPositions.ElementAt(i);
            }
            return value;
        }
    }
}
