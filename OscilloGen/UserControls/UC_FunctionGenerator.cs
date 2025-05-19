using OscilloGen.Src;

namespace OscilloGen.UserControls;

public partial class UC_FunctionGenerator : UserControl
{
    public UC_FunctionGenerator()
    {
        InitializeComponent();
    }

    private void GenButton_Click(object sender, EventArgs e)
    {
        FuncGen.SignalType type = new();

        // Radio btns
        if (NoiseRadioButton.Checked)
        {
            type.noise = true;
        }
        else if (SineRadioButton.Checked)
        {
            type.sine = true;
        }
        else if (SquareRadioButton.Checked)
        {
            type.square = true;
        }
        else if (TriangleRadioButton.Checked)
        {
            type.triangle = true;
        }
        else if (SawRadioButton.Checked)
        {
            type.saw = true;
        }
        else
        {
            type.sine = true;
            SineRadioButton.Checked = true;
        }

        // Text boxes
        if (float.TryParse(FreqTextBox.Text, out float frequency))
        {
            frequency = FuncGen.CheckFrequency(frequency);
            FreqTextBox.Text = frequency.ToString();
        }

        if (float.TryParse(AmpliTextBox.Text, out float amplitude))
        {
            amplitude = FuncGen.CheckAmplitude(amplitude);
            AmpliTextBox.Text = amplitude.ToString();
        }

        if (float.TryParse(OffsetTextBox.Text, out float offset))
        {
            offset = FuncGen.CheckOffset(offset);
            OffsetTextBox.Text = offset.ToString();
        }

        SerialProtocol.EncodeSendData(FuncGen.GetSignalType(type), frequency, amplitude, offset);
    }
}
