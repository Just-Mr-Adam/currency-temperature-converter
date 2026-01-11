using ConverterApp.Converters;

namespace CurrencyApp;

public partial class Form1 : Form
{
    TemperatureConverter temperatureConverter = new TemperatureConverter();
    CurrencyConverter currencyConverter = new CurrencyConverter();

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        ToUnitComboBox.Items.AddRange(currencyConverter.GetUnits());
        FromUnitComboBox.Items.AddRange(currencyConverter.GetUnits());
    }

    private void ConvertButton_Click(object sender, EventArgs e)
    {
        try
        {
            string FromUnit = FromUnitComboBox.Text;
            string ToUnit = ToUnitComboBox.Text;

            double value = Convert.ToDouble(this.InputTextBox.Text);

            this.OutputTextBox.Text = currencyConverter.Convert(value, FromUnit, ToUnit).ToString();
        }
        catch
        {
            MessageBox.Show("Некоректный ввод");
        }
    }

}
