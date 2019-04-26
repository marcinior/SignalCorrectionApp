using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalCorrectionApp.Classes
{
    class HammingAlgorithm : AlgorithmBase
    {
        public override string GetDecodedSignal()
        {
            throw new NotImplementedException();
        }

        public override string GetEncodedSignal()
        {
            throw new NotImplementedException();
        }

        public override string GetInterruptedSignal(IList<int> distortedBits)
        {
            throw new NotImplementedException();
        }

        public override int GetRedundantInfromationSize()
        {
            throw new NotImplementedException();
        }

        /*public List<Tuple<int,int>> getControlBitsPositions(int stringLength)
        {
            List<Tuple<int, int>> positions = new List<Tuple<int, int>>();
            int current = 1;
            while (current <= stringLength)
            {
                positions.Add(new Tuple<int, int>(current,0));
                current *= 2;
            }
            return positions;
        }*/

       public List<String> getOnes(String text)
        {
            List<String> onesPositions = new List<String>();
            for (int i = 0; i < text.Length; i++)
            {
                if (text.ElementAt(i).Equals("1"))
                {
                    onesPositions.Add(Convert.ToInt32((i + 1).ToString(), 2).ToString());
                }
            }
            return onesPositions;
        }
        
        public List<Tuple<int, int>> calculateValues(String text)
        {
            List<String> onesPositions = getOnes(text);
            List<Tuple<int, int>> values =new List<Tuple<int, int>>();
            Console.WriteLine(text);
            for (int i = 0; Math.Pow(2,i) <= text.Length; i++)
            {
                int value = 0;
                foreach (string v in onesPositions)
                {
                    value = value | Convert.ToInt32(v.ElementAt(v.Length - (1 + i)));
                }
                Console.WriteLine(value);
                values.Add(new Tuple<int, int>((int)Math.Pow(2,i), value));
            }
            return values;
        }
        public String encode(String textToEncode)
        {
            String converted = Convert.ToString(Convert.ToInt32(textToEncode), 2);
            this.calculateValues(converted);
            /*String encodedText = controlPositions.ElementAt(0).ToString()+controlPositions.ElementAt(1).ToString();
            for(int i = 2; i < textToEncode.Length; i++)
            {
                if (controlPositions.Contains(i+1))
                {
                    encodedText = (i + 1) + encodedText;
                }
                textToEncode
            }*/
            return "";
        }
    }
}
