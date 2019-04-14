using System;

namespace SignalCorrectionApp.Classes
{
    internal abstract class AlgorithmBase
    {
        private string _inputSignal;

        public abstract string GetEncodedSignal();

        public abstract Tuple<string, int[]> GetInterruptedSignal(); //returns binary string and positions of distorted bits

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
                    RealDataSize = this._inputSignal.Length;
                }
                else
                {
                    this._inputSignal = value;
                }
            }
        }

        public int RealDataSize { get; private set; } //size of input signal (bits)
    }
}