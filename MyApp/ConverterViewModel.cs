using Avalonia;
using Avalonia.Controls;
using System.ComponentModel;

namespace MyApp;

public class ConverterViewModel : INotifyPropertyChanged
{
    // The event delegate collection
    public event PropertyChangedEventHandler? PropertyChanged;

    // A standard property for the value
    public int ConverterValue { get; set; } = 0;

    // A property for the text which fires change events
    private string _converterText = "Specify a value and click Convert!";
    public string ConverterText
    {
        get => _converterText;
        set
        {
            _converterText = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ConverterText)));
        }
    }

    // A basic method for doing conversion
    // Just using the properties
    public void ConvertToCelsius()
    {

        double fahrenheit = ConverterValue;
        double celsius = (fahrenheit - 32) / 180 * 100;
        ConverterText = $"{fahrenheit} Fahrenheit is the same as {celsius}C";
    }

}