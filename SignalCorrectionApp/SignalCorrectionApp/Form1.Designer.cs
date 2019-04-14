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
            this.outputSignalTextBox = new System.Windows.Forms.RichTextBox();
            this.interruptedSignalTextBox = new System.Windows.Forms.RichTextBox();
            this.redundantInfoSizeTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.realDataSizeTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.outputSignalNoControlDataTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.encodedSignalTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputSignalTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.bitsToDistortTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.algorithmsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orginalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bitDistortTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.outputSignalTextBox);
            this.panel1.Controls.Add(this.interruptedSignalTextBox);
            this.panel1.Controls.Add(this.redundantInfoSizeTextBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.realDataSizeTextBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.outputSignalNoControlDataTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.encodedSignalTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.inputSignalTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(341, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 616);
            this.panel1.TabIndex = 0;
            // 
            // outputSignalTextBox
            // 
            this.outputSignalTextBox.Location = new System.Drawing.Point(74, 324);
            this.outputSignalTextBox.Multiline = false;
            this.outputSignalTextBox.Name = "outputSignalTextBox";
            this.outputSignalTextBox.Size = new System.Drawing.Size(437, 24);
            this.outputSignalTextBox.TabIndex = 15;
            this.outputSignalTextBox.Text = "";
            // 
            // interruptedSignalTextBox
            // 
            this.interruptedSignalTextBox.Location = new System.Drawing.Point(74, 239);
            this.interruptedSignalTextBox.Multiline = false;
            this.interruptedSignalTextBox.Name = "interruptedSignalTextBox";
            this.interruptedSignalTextBox.Size = new System.Drawing.Size(437, 23);
            this.interruptedSignalTextBox.TabIndex = 14;
            this.interruptedSignalTextBox.Text = "";
            // 
            // redundantInfoSizeTextBox
            // 
            this.redundantInfoSizeTextBox.Enabled = false;
            this.redundantInfoSizeTextBox.Location = new System.Drawing.Point(74, 576);
            this.redundantInfoSizeTextBox.Name = "redundantInfoSizeTextBox";
            this.redundantInfoSizeTextBox.Size = new System.Drawing.Size(206, 24);
            this.redundantInfoSizeTextBox.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 554);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Redundant Information Size";
            // 
            // realDataSizeTextBox
            // 
            this.realDataSizeTextBox.Enabled = false;
            this.realDataSizeTextBox.Location = new System.Drawing.Point(74, 497);
            this.realDataSizeTextBox.Name = "realDataSizeTextBox";
            this.realDataSizeTextBox.Size = new System.Drawing.Size(206, 24);
            this.realDataSizeTextBox.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 475);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Real Data Size";
            // 
            // outputSignalNoControlDataTextBox
            // 
            this.outputSignalNoControlDataTextBox.Enabled = false;
            this.outputSignalNoControlDataTextBox.Location = new System.Drawing.Point(74, 412);
            this.outputSignalNoControlDataTextBox.Name = "outputSignalNoControlDataTextBox";
            this.outputSignalNoControlDataTextBox.Size = new System.Drawing.Size(437, 24);
            this.outputSignalNoControlDataTextBox.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Output Signal Without Control Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Output Signal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Interrupted Signal";
            // 
            // encodedSignalTextBox
            // 
            this.encodedSignalTextBox.Enabled = false;
            this.encodedSignalTextBox.Location = new System.Drawing.Point(74, 158);
            this.encodedSignalTextBox.Name = "encodedSignalTextBox";
            this.encodedSignalTextBox.Size = new System.Drawing.Size(437, 24);
            this.encodedSignalTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Encoded Signal";
            // 
            // inputSignalTextBox
            // 
            this.inputSignalTextBox.Enabled = false;
            this.inputSignalTextBox.Location = new System.Drawing.Point(74, 71);
            this.inputSignalTextBox.Name = "inputSignalTextBox";
            this.inputSignalTextBox.Size = new System.Drawing.Size(437, 24);
            this.inputSignalTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Input Signal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sendButton);
            this.groupBox1.Controls.Add(this.bitsToDistortTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.algorithmsComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.orginalTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 616);
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
            this.sendButton.Location = new System.Drawing.Point(10, 315);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(269, 68);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // bitsToDistortTextBox
            // 
            this.bitsToDistortTextBox.Location = new System.Drawing.Point(10, 238);
            this.bitsToDistortTextBox.Name = "bitsToDistortTextBox";
            this.bitsToDistortTextBox.Size = new System.Drawing.Size(268, 24);
            this.bitsToDistortTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
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
            this.algorithmsComboBox.Location = new System.Drawing.Point(10, 158);
            this.algorithmsComboBox.Name = "algorithmsComboBox";
            this.algorithmsComboBox.Size = new System.Drawing.Size(268, 26);
            this.algorithmsComboBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Used Algorithm ";
            // 
            // orginalTextBox
            // 
            this.orginalTextBox.Location = new System.Drawing.Point(10, 71);
            this.orginalTextBox.Name = "orginalTextBox";
            this.orginalTextBox.Size = new System.Drawing.Size(268, 24);
            this.orginalTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Text";
            // 
            // bitDistortTooltip
            // 
            this.bitDistortTooltip.ShowAlways = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1006, 645);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignalCorrectionApp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox orginalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox algorithmsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox bitsToDistortTextBox;
        private System.Windows.Forms.Label label3;
        private TextBox redundantInfoSizeTextBox;
        private Label label10;
        private TextBox realDataSizeTextBox;
        private Label label9;
        private TextBox outputSignalNoControlDataTextBox;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox encodedSignalTextBox;
        private Label label5;
        private TextBox inputSignalTextBox;
        private Label label4;
        private ToolTip bitDistortTooltip;
        private RichTextBox outputSignalTextBox;
        private RichTextBox interruptedSignalTextBox;
    }
}

