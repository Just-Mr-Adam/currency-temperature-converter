using ConverterApp.Converters;

namespace CurrencyApp;

public partial class Form1 : Form
{
    TemperatureConverter temperatureConverter = new TemperatureConverter();
    CurrencyConverter currencyConverter = new CurrencyConverter();

    BaseConverter _currentConverter = new TemperatureConverter();

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        ConvertTemperatureSetButton.Checked = true;
    }

    private void ConvertButton_Click(object sender, EventArgs e)
    {
        try
        {
            string FromUnit = FromUnitComboBox.Text;
            string ToUnit = ToUnitComboBox.Text;

            double value = Convert.ToDouble(this.InputTextBox.Text);

            this.OutputTextBox.Text = _currentConverter.Convert(value, FromUnit, ToUnit).ToString();
        }
        catch
        {
            MessageBox.Show("Некоректный ввод");
        }
    }

    private void ConvertTemperatureSetButton_CheckedChanged(object sender, EventArgs e)
    {
        if (ConvertTemperatureSetButton.Checked)
        {
            _currentConverter = temperatureConverter;
        }
        else if (ConvertCurrencySetButton.Checked)
        {
            _currentConverter = currencyConverter;
        }

        ToUnitComboBox.Items.Clear();
        FromUnitComboBox.Items.Clear();

        ToUnitComboBox.Items.AddRange(_currentConverter.GetUnits());
        FromUnitComboBox.Items.AddRange(_currentConverter.GetUnits());
    }
}
