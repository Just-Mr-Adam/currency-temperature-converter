namespace CurrencyApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        InputTextBox = new TextBox();
        ConvertButton = new Button();
        OutputTextBox = new TextBox();
        openFileDialog1 = new OpenFileDialog();
        FromUnitComboBox = new ComboBox();
        ToUnitComboBox = new ComboBox();
        label1 = new Label();
        ConvertCurrencySetButton = new RadioButton();
        ConvertTemperatureSetButton = new RadioButton();
        panel1 = new Panel();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        panel2 = new Panel();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // InputTextBox
        // 
        InputTextBox.Anchor = AnchorStyles.Left;
        InputTextBox.Location = new Point(3, 18);
        InputTextBox.Name = "InputTextBox";
        InputTextBox.Size = new Size(176, 23);
        InputTextBox.TabIndex = 0;
        // 
        // ConvertButton
        // 
        ConvertButton.Location = new Point(327, 266);
        ConvertButton.Name = "ConvertButton";
        ConvertButton.Size = new Size(188, 45);
        ConvertButton.TabIndex = 2;
        ConvertButton.Text = "Конвертировать";
        ConvertButton.UseVisualStyleBackColor = true;
        ConvertButton.Click += ConvertButton_Click;
        // 
        // OutputTextBox
        // 
        OutputTextBox.Location = new Point(213, 18);
        OutputTextBox.Name = "OutputTextBox";
        OutputTextBox.Size = new Size(176, 23);
        OutputTextBox.TabIndex = 3;
        // 
        // FromUnitComboBox
        // 
        FromUnitComboBox.FormattingEnabled = true;
        FromUnitComboBox.Location = new Point(3, 75);
        FromUnitComboBox.Name = "FromUnitComboBox";
        FromUnitComboBox.Size = new Size(176, 23);
        FromUnitComboBox.TabIndex = 4;
        // 
        // ToUnitComboBox
        // 
        ToUnitComboBox.FormattingEnabled = true;
        ToUnitComboBox.Location = new Point(213, 75);
        ToUnitComboBox.Name = "ToUnitComboBox";
        ToUnitComboBox.Size = new Size(176, 23);
        ToUnitComboBox.TabIndex = 5;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(99, 15);
        label1.TabIndex = 8;
        label1.Text = "Конвертировать:";
        // 
        // ConvertCurrencySetButton
        // 
        ConvertCurrencySetButton.AutoSize = true;
        ConvertCurrencySetButton.Location = new Point(3, 12);
        ConvertCurrencySetButton.Name = "ConvertCurrencySetButton";
        ConvertCurrencySetButton.Size = new Size(66, 19);
        ConvertCurrencySetButton.TabIndex = 9;
        ConvertCurrencySetButton.TabStop = true;
        ConvertCurrencySetButton.Text = "Валюту";
        ConvertCurrencySetButton.UseVisualStyleBackColor = true;
        ConvertCurrencySetButton.CheckedChanged += ConvertTemperatureSetButton_CheckedChanged;
        // 
        // ConvertTemperatureSetButton
        // 
        ConvertTemperatureSetButton.AutoSize = true;
        ConvertTemperatureSetButton.Location = new Point(3, 37);
        ConvertTemperatureSetButton.Name = "ConvertTemperatureSetButton";
        ConvertTemperatureSetButton.Size = new Size(96, 19);
        ConvertTemperatureSetButton.TabIndex = 10;
        ConvertTemperatureSetButton.TabStop = true;
        ConvertTemperatureSetButton.Text = "Температуру";
        ConvertTemperatureSetButton.UseVisualStyleBackColor = true;
        ConvertTemperatureSetButton.CheckedChanged += ConvertTemperatureSetButton_CheckedChanged;
        // 
        // panel1
        // 
        panel1.Controls.Add(ConvertTemperatureSetButton);
        panel1.Controls.Add(ConvertCurrencySetButton);
        panel1.Location = new Point(12, 36);
        panel1.Name = "panel1";
        panel1.Size = new Size(106, 66);
        panel1.TabIndex = 12;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(3, 0);
        label2.Name = "label2";
        label2.Size = new Size(60, 15);
        label2.TabIndex = 13;
        label2.Text = "Значение";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(213, 0);
        label3.Name = "label3";
        label3.Size = new Size(60, 15);
        label3.TabIndex = 14;
        label3.Text = "Результат";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(3, 57);
        label4.Name = "label4";
        label4.Size = new Size(95, 15);
        label4.TabIndex = 15;
        label4.Text = "конвертация из:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(213, 57);
        label5.Name = "label5";
        label5.Size = new Size(89, 15);
        label5.TabIndex = 16;
        label5.Text = "конвертация в:";
        // 
        // panel2
        // 
        panel2.Controls.Add(label5);
        panel2.Controls.Add(label4);
        panel2.Controls.Add(label3);
        panel2.Controls.Add(label2);
        panel2.Controls.Add(ToUnitComboBox);
        panel2.Controls.Add(FromUnitComboBox);
        panel2.Controls.Add(OutputTextBox);
        panel2.Controls.Add(InputTextBox);
        panel2.Location = new Point(82, 108);
        panel2.Name = "panel2";
        panel2.Size = new Size(395, 110);
        panel2.TabIndex = 17;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(546, 323);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Controls.Add(label1);
        Controls.Add(ConvertButton);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox InputTextBox;
    private Button ConvertButton;
    private TextBox OutputTextBox;
    private OpenFileDialog openFileDialog1;
    private ComboBox FromUnitComboBox;
    private ComboBox ToUnitComboBox;
    private Label label1;
    private RadioButton ConvertCurrencySetButton;
    private RadioButton ConvertTemperatureSetButton;
    private Panel panel1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Panel panel2;
}
