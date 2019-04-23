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

            switch (algorithmChoice)
            {
                case parity:
                    manageParityControl();
                    break;
                case hamming:
                    manageHammingCode();
                    break;
                case crc12:
                    manageCRC12();
                    break;
                case crc16:
                    manageCRC16();
                    break;
                case sdlc:
                    manageSDLC();
                    break;
                case atm:
                    manageATM();
                    break;
            }
        }

        private void manageParityControl()
        {

        }

        private void manageHammingCode()
        {

        }

        private void manageCRC12()
        {
            CRC crc12 = new CRC(0x180F);
            crc12.InputSignal = inputNumberUpDown.Value.ToString();
            inputSignalTextBox.Text = crc12.InputSignal;
            encodedSignalTextBox.Text = crc12.GetEncodedSignal();
            realDataSizeTextBox.Text = crc12.RealDataSize;
            controlDataSizeTextBox.Text = crc12.GetRedundantInfromationSize().ToString();

            string interruptedSignal = crc12.GetInterruptedSignal(bitsToDistort);
            interruptedSignalTextBox.AppendTextWithSpecificColor(interruptedSignal, Color.Red, bitsToDistort);

            if (crc12.IsSignalDemaged())
            {
                outputSignalTextBox.AppendText(interruptedSignal, Color.Red);
                outputSignalNoControlDataTextBox.AppendText(crc12.GetDecodedSignal(), Color.Red);
            }
            else
            {
                outputSignalTextBox.AppendText(interruptedSignal, Color.Green);
                outputSignalNoControlDataTextBox.AppendText(crc12.GetDecodedSignal(), Color.Green);
            }
        }

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

        }

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
