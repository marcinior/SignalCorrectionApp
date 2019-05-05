using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SignalCorrectionApp.Classes;

namespace SignalCorrectionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private IList<int> bitsToDistort;

        private void sendButton_Click(object sender, EventArgs e)
        {
            const string parity = "Parity Control";
            const string hamming = "Hamming Code";
            const string crc12 = "CRC 12";
            const string crc16 = "CRC 16";
            const string sdlc = "SDLC";
            const string atm = "ATM";

            string caption = Properties.Resources.inputError;
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            if (!isAlgorhitmComboBoxValid(algorithmsComboBox, caption, buttons)
                 || !isBitsToDistortValid(bitsToDistortTextBox, caption, buttons))
                return;

            string algorithmChoice = algorithmsComboBox.Text;
            bitsToDistort = bitsToDistortTextBox.Text.Split(';')
                .Where(s => s != string.Empty)
                .Select(s => int.Parse(s))
                .ToList();

            ClearAllFields();
            AlgorithmBase algorithm;
            switch (algorithmChoice)
            {
                case parity:
                    ParityControl parityAlgorith = new ParityControl();
                    manageParityControl(parityAlgorith);
                    break;
                case hamming:
                    HammingAlgorithm code = new HammingAlgorithm();
                    //algorithm.encode(inputNumberUpDown.Value.ToString());
                    manageHammingCode(code);
                    break;
                case crc12:
                    algorithm = new CRC(0x180F);
                    manageCRC(algorithm);
                    //manageCRC12();
                    break;
                case crc16:
                    algorithm = new CRC(0x18005);
                    manageCRC(algorithm);
                    //manageCRC16();
                    break;
                /*case sdlc:
                    //manageSDLC();
                    break;*/
                case atm:
                    algorithm = new CRC(0x107);
                    manageCRC(algorithm);
                    break;
                default:
                    return;
            }
            
        }
        private void manageCRC(AlgorithmBase algorithm)
        {
            algorithm.InputSignal = inputNumberUpDown.Value.ToString();
            inputSignalTextBox.Text = algorithm.InputSignal;
            encodedSignalTextBox.Text = algorithm.GetEncodedSignal();
            realDataSizeTextBox.Text = algorithm.RealDataSize;
            controlDataSizeTextBox.Text = algorithm.GetRedundantInfromationSize().ToString();

            string interruptedSignal = algorithm.GetInterruptedSignal(bitsToDistort);
            interruptedSignalTextBox.AppendTextWithSpecificColor(interruptedSignal, Color.Red, bitsToDistort);

            if (algorithm is CRC && ((CRC)algorithm).IsSignalDemaged())
            {
                outputSignalTextBox.AppendText(interruptedSignal, Color.Red);
                outputSignalNoControlDataTextBox.AppendText(algorithm.GetDecodedSignal(), Color.Red);
            }
            else
            {
                outputSignalTextBox.AppendText(interruptedSignal, Color.Green);
                outputSignalNoControlDataTextBox.AppendText(algorithm.GetDecodedSignal(), Color.Green);
            }
        }

        private void manageParityControl(ParityControl algorithm)
        {
            algorithm.InputSignal = inputNumberUpDown.Value.ToString();
            inputSignalTextBox.Text = algorithm.InputSignal;
            encodedSignalTextBox.Text = algorithm.GetEncodedSignal();
            realDataSizeTextBox.Text = algorithm.RealDataSize;
            controlDataSizeTextBox.Text = algorithm.GetRedundantInfromationSize().ToString();

            string interruptedSignal = algorithm.GetInterruptedSignal(bitsToDistort);
            interruptedSignalTextBox.AppendTextWithSpecificColor(interruptedSignal, Color.Red, bitsToDistort);

            if (algorithm.checkSignal())
            {
                outputSignalTextBox.AppendText(interruptedSignal, Color.Green);
                outputSignalNoControlDataTextBox.AppendText(algorithm.GetDecodedSignal(), Color.Green);
            }
            else
            {
                outputSignalTextBox.AppendText(interruptedSignal, Color.Red);
                outputSignalNoControlDataTextBox.AppendText(algorithm.GetDecodedSignal(), Color.Red);
            }
        }
        /*
        private void manageHammingCode()
        {

        }*/

            private void manageHammingCode(HammingAlgorithm hc)
        {
            hc.InputSignal = inputNumberUpDown.Value.ToString();
            inputSignalTextBox.Text = hc.InputSignal;
            encodedSignalTextBox.Text = hc.GetEncodedSignal();
            realDataSizeTextBox.Text = hc.RealDataSize;
            controlDataSizeTextBox.Text = hc.GetRedundantInfromationSize().ToString();

            string interruptedSignal = hc.GetInterruptedSignal(bitsToDistort);
            interruptedSignalTextBox.AppendTextWithSpecificColor(interruptedSignal, Color.Red, bitsToDistort);
            String decodedSignal = hc.GetDecodedSignal();
            int correctedBit = hc.correctedBit;
            List<int> invalidBits = hc.getInvalidBits(hc.encodedSignal, hc.interruptedSignal.ToString());
            int length = interruptedSignal.Length;

            for(int i = 0; i<length; i++)
            {
                Color color = Color.Green;
                if (invalidBits.Contains(i))
                    color = Color.Red;
                else if (i == correctedBit)
                    color = Color.Blue;
                outputSignalTextBox.AppendText(hc.interruptedSignal[i].ToString(), color);
            }

            Color textColor = Color.Red;
            if (hc.InputSignal.Equals(decodedSignal))
                textColor = Color.Green;
            outputSignalNoControlDataTextBox.AppendText(decodedSignal, textColor);
        }
        /*
        private void manageCRC16()
        {
            CRC crc16 = new CRC(0x18005);
            crc16.InputSignal = inputNumberUpDown.Value.ToString();
            inputSignalTextBox.Text = crc16.InputSignal;
            encodedSignalTextBox.Text = crc16.GetEncodedSignal();
            realDataSizeTextBox.Text = crc16.RealDataSize;
            controlDataSizeTextBox.Text = crc16.GetRedundantInfromationSize().ToString();

            string interruptedSignal = crc16.GetInterruptedSignal(bitsToDistort);
            interruptedSignalTextBox.AppendTextWithSpecificColor(interruptedSignal, Color.Red, bitsToDistort);

            if (crc16.IsSignalDemaged())
            {
                outputSignalTextBox.AppendText(interruptedSignal, Color.Red);
                outputSignalNoControlDataTextBox.AppendText(crc16.GetDecodedSignal(), Color.Red);
            }
            else
            {
                outputSignalTextBox.AppendText(interruptedSignal, Color.Green);
                outputSignalNoControlDataTextBox.AppendText(crc16.GetDecodedSignal(), Color.Green);
            }        
        }

        private void manageSDLC()
        {

        }

        private void manageATM()
        {

        }*/

        private bool isAlgorhitmComboBoxValid(ComboBox comboBox, string caption, MessageBoxButtons buttons)
        {
            if (comboBox.Text.Equals(String.Empty))
            {
                string message = Properties.Resources.algorithmError;
                MessageBox.Show(message, caption, buttons);
                return false;
            }

            return true;
        }

        private bool isBitsToDistortValid(TextBox textBox, string caption, MessageBoxButtons buttons)
        {
            string message = Properties.Resources.bitsDistortError;

            if (!textBox.Text.All(c => Char.IsDigit(c) || c.Equals(';')))
            {
                MessageBox.Show(message, caption, buttons);
                return false;
            }

            return true;
        }

        private void ClearAllFields()
        {
            inputSignalTextBox.Clear();
            encodedSignalTextBox.Clear();
            interruptedSignalTextBox.Clear();
            outputSignalTextBox.Clear();
            outputSignalNoControlDataTextBox.Clear();
            realDataSizeTextBox.Clear();
            controlDataSizeTextBox.Clear();
        }
    }
}
