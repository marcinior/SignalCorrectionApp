using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalCorrectionApp.Classes
{
    public class ParityControl : AlgorithmBase
    {
        private int[] encodedSignal;
        private int[] interruptedSignal;

        public ParityControl()
        {
            
        }

        public override string GetEncodedSignal()
        {
            int[] messageArray = InputSignal.Select(c => int.Parse(c.ToString())).ToArray();
            
            if(messageArray.Length > 7){
                int arrayLength = messageArray.Length % 7 == 0 ? messageArray.Length + 
                    messageArray.Length/7 : messageArray.Length + messageArray.Length/7 + 1;
                int repetitionNumber = messageArray.Length/7;
                int[] encodedSignal = new int[arrayLength];
                if(messageArray.Length % 7 == 0){
                    for(int i = 0; i < repetitionNumber; i++)
                    {
                        int[] arrayPiece = new int[7];
                        Array.Copy(messageArray, i*7, arrayPiece, 0, 7);
                        Array.Copy(GetEncodedByte(arrayPiece), 0, encodedSignal, i*8, 8);
                    }
                }
                else{
                    int lengthEndPiece = messageArray.Length - repetitionNumber*7;
                    int[] arrayPieceEnd = new int[lengthEndPiece];
                    Array.Copy(messageArray, 0, arrayPieceEnd, 0, lengthEndPiece);
                    Array.Copy(GetEncodedByte(arrayPieceEnd), 0, encodedSignal, 0, lengthEndPiece + 1);

                    for(int i = 0; i < repetitionNumber; i++)
                    {
                        int[] arrayPiece = new int[7];
                        Array.Copy(messageArray, i * 7  + lengthEndPiece, arrayPiece, 0, 7);
                        Array.Copy(GetEncodedByte(arrayPiece), 0, encodedSignal, (i * 8) + lengthEndPiece + 1, 8);
                    }
                }
                
                this.encodedSignal = encodedSignal;
                return string.Join("", encodedSignal);
            }else{
                this.encodedSignal = GetEncodedByte(messageArray);
                return string.Join("", GetEncodedByte(messageArray));
            }
        }

        private int[] GetEncodedByte(int[] binaryArray) {
            
            int[] encodedSignal = new int[binaryArray.Length + 1];

            encodedSignal[0] = CountNumberOne(binaryArray) % 2 == 0 ? 0 : 1;    
            Array.Copy(binaryArray, 0, encodedSignal, 1, binaryArray.Length);

            return encodedSignal;
        }

        private int CountNumberOne(int[] binaryArray) 
        {
            int numberOneCount = 0;

            foreach(int i in binaryArray)
            {
                if(i == 1)
                    numberOneCount++;
            }

            return numberOneCount;
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

        public override string GetDecodedSignal()
        {
            int decodedSignalLength = this.interruptedSignal.Length % 8 == 0 ? this.interruptedSignal.Length - this.interruptedSignal.Length / 8 : 
                this.interruptedSignal.Length - this.interruptedSignal.Length / 8 - 1;
            int[] decodedSignal = new int[decodedSignalLength];
            
            if(this.interruptedSignal.Length % 8 == 0)
            {
                for(int i = 0; i < this.interruptedSignal.Length / 8; i++)
                {
                    Array.Copy(this.interruptedSignal, i * 8 + 1, decodedSignal, i * 7, 7);
                }
            }
            else
            {
                int arrayPieceLenght = this.interruptedSignal.Length % 8 - 1;
                Array.Copy(this.interruptedSignal, 1, decodedSignal, 0, arrayPieceLenght);
                for(int i = 0; i < this.interruptedSignal.Length / 8; i++)
                {
                    Array.Copy(this.interruptedSignal, i * 8 + arrayPieceLenght + 2, decodedSignal, i * 7 + arrayPieceLenght, 7);
                }
            }

            return string.Join("", decodedSignal);
        }

        public override int GetRedundantInfromationSize()
        {
            int arrayLength = InputSignal.Length % 7 == 0 ? InputSignal.Length + 
                    InputSignal.Length/7 : InputSignal.Length + InputSignal.Length/7 + 1;
            return arrayLength;
        }

        public bool checkSignal() {
            
            int repetitionNumber = this.interruptedSignal.Length/8;

            if(this.interruptedSignal.Length % 8 == 0)
            { 
                for(int i = 0; i < repetitionNumber; i++)
                {
                    int[] arrayPiece = new int[8];
                    Array.Copy(this.interruptedSignal, i*8, arrayPiece, 0, 8);
                    if(checkByte(arrayPiece))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                int arrayPieceLenght = this.interruptedSignal.Length - repetitionNumber * 8;
                int[] arrayPieceBegin = new int[arrayPieceLenght];
                Array.Copy(this.interruptedSignal, 0, arrayPieceBegin, 0, arrayPieceLenght);
                if(checkByte(arrayPieceBegin))
                    {
                        return false;
                    }

                for(int i = 0; i < repetitionNumber; i++)
                {
                    int[] arrayPiece = new int[8];
                    Array.Copy(this.interruptedSignal, i*8 + arrayPieceLenght, arrayPiece, 0, 8);
                    if(checkByte(arrayPiece))
                    {
                        return false;
                    }
                }
                return true;
            }

         }

        private bool checkByte(int[] byteArray){
            int[] arrayCode = new int[byteArray.Length - 1];
            Array.Copy(byteArray, 1, arrayCode, 0, byteArray.Length - 1);
            return CountNumberOne(arrayCode) % 2 != byteArray[0] ? true : false;
        }

    }
}
