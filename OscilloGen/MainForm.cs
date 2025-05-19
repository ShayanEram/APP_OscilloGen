//using ScottPlot.WinForms;

using OscilloGen.UserControls;

namespace OscilloGen;

public partial class MainForm : Form
{
    //private FirmwareUpdate firmwareData;

    //private struct SignalType
    //{
    //    public bool noise;
    //    public bool sine;
    //    public bool square;
    //    public bool triangle;
    //    public bool saw;

    //    public SignalType()
    //    {
    //        noise = false;
    //        sine = false;
    //        square = false;
    //        triangle = false;
    //        saw = false;
    //    }
    //}

    //private struct FirmwareUpdate
    //{
    //    public bool firmwareFileOk;
    //    public string firmwarePath;

    //    public FirmwareUpdate(bool fileOk, string path)
    //    {
    //        firmwareFileOk = fileOk;
    //        firmwarePath = path;
    //    }
    //}

    public MainForm()
    {
        InitializeComponent();
    }

    private void LoadPage(UserControl page)
    {
        MainPanel.Controls.Clear(); // Remove previous content
        MainPanel.Controls.Add(page); // Add new UserControl
        page.Dock = DockStyle.Fill; // Ensure it fills the panel
    }

    //private void MainForm_Load(object sender, EventArgs e)
    //{
    //    VersionLabel.Text = $"Version {About.MajorVersion}.{About.MinorVersion}";
    //}

    private void FuncGenButton_Click(object sender, EventArgs e)
    {
        LoadPage(new UC_FunctionGenerator());
    }

    private void OscillButton_Click(object sender, EventArgs e)
    {
        LoadPage(new UC_Oscilloscope());
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
        LoadPage(new UC_Update());
    }

    private void AboutButton_Click(object sender, EventArgs e)
    {
        LoadPage(new UC_About());
    }

    //#region FunctionGenerator
    //private void GenButton_Click(object sender, EventArgs e)
    //{
    //    SignalType type = new();
    //    float frequency = 0;
    //    float amplitude = 0;
    //    float offset = 0;

    //    // Radio btns
    //    if (NoiseRadioButton.Checked)
    //    {
    //        type.noise = true;
    //    }
    //    else if (SineRadioButton.Checked)
    //    {
    //        type.sine = true;
    //    }
    //    else if (SquareRadioButton.Checked)
    //    {
    //        type.square = true;
    //    }
    //    else if (TriangleRadioButton.Checked)
    //    {
    //        type.triangle = true;
    //    }
    //    else if (SawRadioButton.Checked)
    //    {
    //        type.saw = true;
    //    }
    //    else
    //    {
    //        type.sine = true;
    //        SineRadioButton.Checked = true;
    //    }

    //    // Text boxes
    //    if (float.TryParse(FreqTextBox.Text, out frequency))
    //    {
    //        frequency = FuncGen.CheckFrequency(frequency);
    //        FreqTextBox.Text = frequency.ToString();
    //    }

    //    if (float.TryParse(AmpliTextBox.Text, out amplitude))
    //    {
    //        amplitude = FuncGen.CheckAmplitude(amplitude);
    //        AmpliTextBox.Text = amplitude.ToString();
    //    }

    //    if (float.TryParse(OffsetTextBox.Text, out offset))
    //    {
    //        offset = FuncGen.CheckOffset(offset);
    //        OffsetTextBox.Text = offset.ToString();
    //    }
    //}
    //#endregion

    //#region Oscilloscope
    //private void StartButton_Click(object sender, EventArgs e)
    //{

    //}

    //private void StopButton_Click(object sender, EventArgs e)
    //{

    //}
    //#endregion

    //#region Update
    //private void FwFileButton_Click(object sender, EventArgs e)
    //{
    //    OpenFileDialog openFileDialog = new OpenFileDialog();
    //    openFileDialog.Filter = "Binary & Hex Files (*.bin;*.hex)|*.bin;*.hex|All Files (*.*)|*.*";
    //    openFileDialog.Title = "Select Firmware File";

    //    if (openFileDialog.ShowDialog() == DialogResult.OK)
    //    {
    //        firmwareData = new FirmwareUpdate(true, openFileDialog.FileName);
    //        FwFileTextBox.Text = firmwareData.firmwarePath;
    //    }
    //    else
    //    {
    //        firmwareData = new FirmwareUpdate(false, "");
    //    }
    //}

    //private void FwVersionButton_Click(object sender, EventArgs e)
    //{
    //    if (firmwareData.firmwareFileOk)
    //    {
    //        string password = Microsoft.VisualBasic.Interaction.InputBox("Enter Password:", "Password Required", "", -1, -1);
    //        if (UpdateFw.CheckPassword(password))
    //        {
    //            MessageBox.Show("Access Granted.");

    //            if (UpdateFw.ReadBinaryFile(firmwareData.firmwarePath))
    //            {
    //                MessageBox.Show("Firmware Upgrade Successful");
    //            }
    //            else
    //            {
    //                MessageBox.Show("Firmware Upgrade Failed");
    //            }
    //        }
    //        else
    //        {
    //            MessageBox.Show("Incorrect Password. Access Denied.");
    //        }
    //    }
    //    else
    //    {
    //        MessageBox.Show("Please select a firmware file.");
    //    }
    //}
    //#endregion


}
