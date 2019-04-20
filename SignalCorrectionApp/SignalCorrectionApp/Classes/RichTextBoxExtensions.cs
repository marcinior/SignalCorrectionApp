using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SignalCorrectionApp.Classes
{
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }

        public static void AppendTextWithSpecificColor(this RichTextBox box, string text, Color color, IList<int> positions)
        {
            IList<int> reversedPositions = positions.Select(position => text.Length - 1 - position).ToList();

            for(int i = 0; i < text.Length; i++)
            {
                if (reversedPositions.Contains(i))
                {
                    box.AppendText(text[i].ToString(), color);
                } else
                {
                    box.AppendText(text[i].ToString());
                }
            }
        }
    }
}