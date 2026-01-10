using ConverterApp.Converters;

namespace CurrencyApp;

public partial class Form1 : Form
{
    TemperatureConverter temperatureConverter = new TemperatureConverter();

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        ToUnitComboBox.Items.AddRange(temperatureConverter.GetUnits());
        FromUnitComboBox.Items.AddRange(temperatureConverter.GetUnits());
    }

    private void ConvertButton_Click(object sender, EventArgs e)
    {
        try
        {
            string FromUnit = FromUnitComboBox.Text;
            string ToUnit = ToUnitComboBox.Text;

            double value = Convert.ToDouble(this.InputTextBox.Text);

            this.OutputTextBox.Text = temperatureConverter.Convert(value, FromUnit, ToUnit).ToString();
        }
        catch
        {
            MessageBox.Show("Некоректный ввод");
        }
    }

}
