using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignalCorrectionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            const string parity = "Parity Control";
            const string hamming = "Hamming Code";
            const string crc12 = "CRC 12";
            const string crc16 = "CRC 16";
            const string sdlc = "SDLC";
            const string sth = "sth"; //TO DO proper name

            string caption = Properties.Resources.inputError;
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            if (!isInputTextValid(orginalTextBox, caption, buttons)
                 || !isAlgorhitmComboBoxValid(algorithmsComboBox, caption, buttons)
                 || !isBitsToDistortValid(bitsToDistortTextBox, caption, buttons))
                return;

            string algorithmChoice = algorithmsComboBox.Text;

            switch (algorithmChoice)
            {
                case parity:
                    manageParityControl();
                    break;
                case hamming:
                    manageHammingCode();
                    break;
                case crc12:
                    manageCrc12();
                    break;
                case crc16:
                    manageCrc16();
                    break;
                case sdlc:
                    manageSdlc();
                    break;
                case sth:
                    manageSth();
                    break;
            }
        }

        private void manageParityControl()
        {

        }

        private void manageHammingCode()
        {

        }

        private void manageCrc12()
        {

        }

        private void manageCrc16()
        {

        }

        private void manageSdlc()
        {

        }

        private void manageSth()
        {
            //to do change mathod name
        }

        private bool isInputTextValid(TextBox textBox, string caption, MessageBoxButtons buttons)
        {
            if (textBox.Text.Equals(String.Empty))
            {
                string message = Properties.Resources.inputTextError;
                MessageBox.Show(message, caption, buttons);
                return false;
            }

            return true;
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
            if (textBox.Text.Equals(String.Empty))
            {
                MessageBox.Show(message, caption, buttons);
                return false;
            }

            Regex digitsOnly = new Regex(@"[^\d;]");
            string textWithoutLetters = digitsOnly.Replace("2;1;a;5;", String.Empty);

            if (!textBox.Text.All(c => Char.IsDigit(c) || c.Equals(';')))
            {
                MessageBox.Show(message, caption, buttons);
                return false;
            }

            return true;
        }
    }
}
