using System.Windows.Forms;

namespace SignalCorrectionApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.controlDataSizeTextBox = new System.Windows.Forms.RichTextBox();
            this.realDataSizeTextBox = new System.Windows.Forms.RichTextBox();
            this.outputSignalNoControlDataTextBox = new System.Windows.Forms.RichTextBox();
            this.encodedSignalTextBox = new System.Windows.Forms.RichTextBox();
            this.inputSignalTextBox = new System.Windows.Forms.RichTextBox();
            this.outputSignalTextBox = new System.Windows.Forms.RichTextBox();
            this.interruptedSignalTextBox = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.bitsToDistortTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.algorithmsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bitDistortTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.inputNumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumberUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.controlDataSizeTextBox);
            this.panel1.Controls.Add(this.realDataSizeTextBox);
            this.panel1.Controls.Add(this.outputSignalNoControlDataTextBox);
            this.panel1.Controls.Add(this.encodedSignalTextBox);
            this.panel1.Controls.Add(this.inputSignalTextBox);
            this.panel1.Controls.Add(this.outputSignalTextBox);
            this.panel1.Controls.Add(this.interruptedSignalTextBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(341, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 719);
            this.panel1.TabIndex = 0;
            // 
            // controlDataSizeTextBox
            // 
            this.controlDataSizeTextBox.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.controlDataSizeTextBox.Location = new System.Drawing.Point(75, 670);
            this.controlDataSizeTextBox.Multiline = false;
            this.controlDataSizeTextBox.Name = "controlDataSizeTextBox";
            this.controlDataSizeTextBox.Size = new System.Drawing.Size(221, 26);
            this.controlDataSizeTextBox.TabIndex = 20;
            this.controlDataSizeTextBox.Text = "";
            // 
            // realDataSizeTextBox
            // 
            this.realDataSizeTextBox.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.realDataSizeTextBox.Location = new System.Drawing.Point(75, 584);
            this.realDataSizeTextBox.Multiline = false;
            this.realDataSizeTextBox.Name = "realDataSizeTextBox";
            this.realDataSizeTextBox.Size = new System.Drawing.Size(221, 26);
            this.realDataSizeTextBox.TabIndex = 19;
            this.realDataSizeTextBox.Text = "";
            // 
            // outputSignalNoControlDataTextBox
            // 
            this.outputSignalNoControlDataTextBox.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outputSignalNoControlDataTextBox.Location = new System.Drawing.Point(75, 485);
            this.outputSignalNoControlDataTextBox.Multiline = false;
            this.outputSignalNoControlDataTextBox.Name = "outputSignalNoControlDataTextBox";
            this.outputSignalNoControlDataTextBox.Size = new System.Drawing.Size(436, 26);
            this.outputSignalNoControlDataTextBox.TabIndex = 18;
            this.outputSignalNoControlDataTextBox.Text = "";
            // 
            // encodedSignalTextBox
            // 
            this.encodedSignalTextBox.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.encodedSignalTextBox.Location = new System.Drawing.Point(75, 184);
            this.encodedSignalTextBox.Multiline = false;
            this.encodedSignalTextBox.Name = "encodedSignalTextBox";
            this.encodedSignalTextBox.Size = new System.Drawing.Size(436, 26);
            this.encodedSignalTextBox.TabIndex = 17;
            this.encodedSignalTextBox.Text = "";
            // 
            // inputSignalTextBox
            // 
            this.inputSignalTextBox.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputSignalTextBox.Location = new System.Drawing.Point(75, 83);
            this.inputSignalTextBox.Multiline = false;
            this.inputSignalTextBox.Name = "inputSignalTextBox";
            this.inputSignalTextBox.Size = new System.Drawing.Size(433, 26);
            this.inputSignalTextBox.TabIndex = 16;
            this.inputSignalTextBox.Text = "";
            // 
            // outputSignalTextBox
            // 
            this.outputSignalTextBox.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outputSignalTextBox.Location = new System.Drawing.Point(74, 378);
            this.outputSignalTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.outputSignalTextBox.Multiline = false;
            this.outputSignalTextBox.Name = "outputSignalTextBox";
            this.outputSignalTextBox.Size = new System.Drawing.Size(437, 27);
            this.outputSignalTextBox.TabIndex = 15;
            this.outputSignalTextBox.Text = "";
            // 
            // interruptedSignalTextBox
            // 
            this.interruptedSignalTextBox.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.interruptedSignalTextBox.Location = new System.Drawing.Point(74, 279);
            this.interruptedSignalTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.interruptedSignalTextBox.Multiline = false;
            this.interruptedSignalTextBox.Name = "interruptedSignalTextBox";
            this.interruptedSignalTextBox.Size = new System.Drawing.Size(437, 26);
            this.interruptedSignalTextBox.TabIndex = 14;
            this.interruptedSignalTextBox.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 646);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 21);
            this.label10.TabIndex = 12;
            this.label10.Text = "Control Data Size [bits]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 554);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 21);
            this.label9.TabIndex = 10;
            this.label9.Text = "Real Data Size [bits]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 454);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Output Signal Without Control Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 349);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Output Signal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Interrupted Signal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Encoded Signal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Input Signal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputNumberUpDown);
            this.groupBox1.Controls.Add(this.sendButton);
            this.groupBox1.Controls.Add(this.bitsToDistortTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.algorithmsComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(308, 719);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.Gray;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sendButton.ForeColor = System.Drawing.Color.Black;
            this.sendButton.Location = new System.Drawing.Point(10, 367);
            this.sendButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(269, 79);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // bitsToDistortTextBox
            // 
            this.bitsToDistortTextBox.Location = new System.Drawing.Point(10, 278);
            this.bitsToDistortTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bitsToDistortTextBox.Name = "bitsToDistortTextBox";
            this.bitsToDistortTextBox.Size = new System.Drawing.Size(267, 28);
            this.bitsToDistortTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bits to Distort";
            // 
            // algorithmsComboBox
            // 
            this.algorithmsComboBox.FormattingEnabled = true;
            this.algorithmsComboBox.Items.AddRange(new object[] {
            global::SignalCorrectionApp.Properties.Resources.parity,
            global::SignalCorrectionApp.Properties.Resources.hamming,
            global::SignalCorrectionApp.Properties.Resources.crc12,
            global::SignalCorrectionApp.Properties.Resources.crc16,
            global::SignalCorrectionApp.Properties.Resources.sdlc,
            global::SignalCorrectionApp.Properties.Resources.CRC4});
            this.algorithmsComboBox.Location = new System.Drawing.Point(10, 184);
            this.algorithmsComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.algorithmsComboBox.Name = "algorithmsComboBox";
            this.algorithmsComboBox.Size = new System.Drawing.Size(267, 29);
            this.algorithmsComboBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Used Algorithm ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Number";
            // 
            // bitDistortTooltip
            // 
            this.bitDistortTooltip.ShowAlways = true;
            // 
            // inputNumberUpDown
            // 
            this.inputNumberUpDown.Location = new System.Drawing.Point(10, 83);
            this.inputNumberUpDown.Name = "inputNumberUpDown";
            this.inputNumberUpDown.Size = new System.Drawing.Size(266, 28);
            this.inputNumberUpDown.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1006, 752);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignalCorrectionApp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumberUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox algorithmsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox bitsToDistortTextBox;
        private System.Windows.Forms.Label label3;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ToolTip bitDistortTooltip;
        private RichTextBox outputSignalTextBox;
        private RichTextBox interruptedSignalTextBox;
        private RichTextBox controlDataSizeTextBox;
        private RichTextBox realDataSizeTextBox;
        private RichTextBox outputSignalNoControlDataTextBox;
        private RichTextBox encodedSignalTextBox;
        private RichTextBox inputSignalTextBox;
        private NumericUpDown inputNumberUpDown;
    }
}

