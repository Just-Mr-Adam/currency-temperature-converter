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
        SuspendLayout();
        // 
        // InputTextBox
        // 
        InputTextBox.Anchor = AnchorStyles.Left;
        InputTextBox.Location = new Point(146, 156);
        InputTextBox.Name = "InputTextBox";
        InputTextBox.Size = new Size(100, 23);
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
        OutputTextBox.Location = new Point(291, 156);
        OutputTextBox.Name = "OutputTextBox";
        OutputTextBox.Size = new Size(100, 23);
        OutputTextBox.TabIndex = 3;
        // 
        // FromUnitComboBox
        // 
        FromUnitComboBox.FormattingEnabled = true;
        FromUnitComboBox.Location = new Point(146, 185);
        FromUnitComboBox.Name = "FromUnitComboBox";
        FromUnitComboBox.Size = new Size(100, 23);
        FromUnitComboBox.TabIndex = 4;
        // 
        // ToUnitComboBox
        // 
        ToUnitComboBox.FormattingEnabled = true;
        ToUnitComboBox.Location = new Point(291, 185);
        ToUnitComboBox.Name = "ToUnitComboBox";
        ToUnitComboBox.Size = new Size(100, 23);
        ToUnitComboBox.TabIndex = 5;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(546, 323);
        Controls.Add(ToUnitComboBox);
        Controls.Add(FromUnitComboBox);
        Controls.Add(OutputTextBox);
        Controls.Add(ConvertButton);
        Controls.Add(InputTextBox);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
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
}
