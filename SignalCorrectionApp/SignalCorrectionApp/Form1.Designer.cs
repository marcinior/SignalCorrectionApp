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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.outputSignalNoControlDataTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.outputSignalTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.interruptedSignalTextBox = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.outputSignalNoControlDataTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.outputSignalTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.interruptedSignalTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.encodedSignalTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.inputSignalTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(303, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 548);
            this.panel1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(66, 512);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(184, 22);
            this.textBox3.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 492);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Redundand Information Size";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(66, 442);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 22);
            this.textBox2.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Real Data Size";
            // 
            // outputSignalNoControlDataTextBox
            // 
            this.outputSignalNoControlDataTextBox.Enabled = false;
            this.outputSignalNoControlDataTextBox.Location = new System.Drawing.Point(66, 366);
            this.outputSignalNoControlDataTextBox.Name = "outputSignalNoControlDataTextBox";
            this.outputSignalNoControlDataTextBox.Size = new System.Drawing.Size(389, 22);
            this.outputSignalNoControlDataTextBox.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Output Signal Without Control Data";
            // 
            // outputSignalTextBox
            // 
            this.outputSignalTextBox.Enabled = false;
            this.outputSignalTextBox.Location = new System.Drawing.Point(66, 286);
            this.outputSignalTextBox.Name = "outputSignalTextBox";
            this.outputSignalTextBox.Size = new System.Drawing.Size(389, 22);
            this.outputSignalTextBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Output Signal";
            // 
            // interruptedSignalTextBox
            // 
            this.interruptedSignalTextBox.Enabled = false;
            this.interruptedSignalTextBox.Location = new System.Drawing.Point(66, 212);
            this.interruptedSignalTextBox.Name = "interruptedSignalTextBox";
            this.interruptedSignalTextBox.Size = new System.Drawing.Size(389, 22);
            this.interruptedSignalTextBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Interrupted Signal";
            // 
            // encodedSignalTextBox
            // 
            this.encodedSignalTextBox.Enabled = false;
            this.encodedSignalTextBox.Location = new System.Drawing.Point(66, 140);
            this.encodedSignalTextBox.Name = "encodedSignalTextBox";
            this.encodedSignalTextBox.Size = new System.Drawing.Size(389, 22);
            this.encodedSignalTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Encoded Signal";
            // 
            // inputSignalTextBox
            // 
            this.inputSignalTextBox.Enabled = false;
            this.inputSignalTextBox.Location = new System.Drawing.Point(66, 63);
            this.inputSignalTextBox.Name = "inputSignalTextBox";
            this.inputSignalTextBox.Size = new System.Drawing.Size(389, 22);
            this.inputSignalTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 548);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.Gray;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sendButton.ForeColor = System.Drawing.Color.Black;
            this.sendButton.Location = new System.Drawing.Point(9, 280);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(239, 60);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // bitsToDistortTextBox
            // 
            this.bitsToDistortTextBox.Location = new System.Drawing.Point(9, 212);
            this.bitsToDistortTextBox.Name = "bitsToDistortTextBox";
            this.bitsToDistortTextBox.Size = new System.Drawing.Size(239, 22);
            this.bitsToDistortTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
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
            this.algorithmsComboBox.Location = new System.Drawing.Point(9, 140);
            this.algorithmsComboBox.Name = "algorithmsComboBox";
            this.algorithmsComboBox.Size = new System.Drawing.Size(239, 24);
            this.algorithmsComboBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Used Algorithm ";
            // 
            // orginalTextBox
            // 
            this.orginalTextBox.Location = new System.Drawing.Point(9, 63);
            this.orginalTextBox.Name = "orginalTextBox";
            this.orginalTextBox.Size = new System.Drawing.Size(239, 22);
            this.orginalTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Text";
            // 
            // bitDistortTooltip
            // 
            this.bitDistortTooltip.ShowAlways = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(894, 573);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MaximizeBox = false;
            this.Name = "Form1";
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
        private TextBox textBox3;
        private Label label10;
        private TextBox textBox2;
        private Label label9;
        private TextBox outputSignalNoControlDataTextBox;
        private Label label8;
        private TextBox outputSignalTextBox;
        private Label label7;
        private TextBox interruptedSignalTextBox;
        private Label label6;
        private TextBox encodedSignalTextBox;
        private Label label5;
        private TextBox inputSignalTextBox;
        private Label label4;
        private ToolTip bitDistortTooltip;
    }
}

