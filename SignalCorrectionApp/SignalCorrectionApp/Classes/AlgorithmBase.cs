using System;
using System.Collections.Generic;

namespace SignalCorrectionApp.Classes
{
    public abstract class AlgorithmBase
    {
        private string _inputSignal;

        public abstract string GetEncodedSignal();

        public abstract string GetInterruptedSignal(IList<int> distortedBits); //returns binary string and positions of distorted bits

        public abstract string GetDecodedSignal(); //returns decoded signal (without control data)

        public abstract int GetRedundantInfromationSize(); //returns redundant info size (bits)

        public string InputSignal //property converting number string to binary string
        {
            get => _inputSignal;

            set
            {
                if (int.TryParse(value, out int parsedNumber))
                {
                    this._inputSignal = Convert.ToString(parsedNumber, 2);
                    RealDataSize = this._inputSignal.Length.ToString();
                }
                else
                {
                    this._inputSignal = value;
                }
            }
        }

        public string RealDataSize { get; private set; } //size of input signal (bits)
    }
}