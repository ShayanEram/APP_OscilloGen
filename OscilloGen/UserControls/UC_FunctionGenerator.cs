namespace OscilloGen.UserControls;

public partial class UC_FunctionGenerator : UserControl
{
    private struct SignalType
    {
        public bool noise;
        public bool sine;
        public bool square;
        public bool triangle;
        public bool saw;

        public SignalType()
        {
            noise = false;
            sine = false;
            square = false;
            triangle = false;
            saw = false;
        }
    }

    public UC_FunctionGenerator()
    {
        InitializeComponent();
    }

    private void GenButton_Click(object sender, EventArgs e)
    {
        SignalType type = new();
        float frequency = 0;
        float amplitude = 0;
        float offset = 0;

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
        if (float.TryParse(FreqTextBox.Text, out frequency))
        {
            frequency = FuncGen.CheckFrequency(frequency);
            FreqTextBox.Text = frequency.ToString();
        }

        if (float.TryParse(AmpliTextBox.Text, out amplitude))
        {
            amplitude = FuncGen.CheckAmplitude(amplitude);
            AmpliTextBox.Text = amplitude.ToString();
        }

        if (float.TryParse(OffsetTextBox.Text, out offset))
        {
            offset = FuncGen.CheckOffset(offset);
            OffsetTextBox.Text = offset.ToString();
        }
    }
}
