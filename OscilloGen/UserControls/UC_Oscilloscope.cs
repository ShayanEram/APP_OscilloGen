using OscilloGen.Src;
using ScottPlot.WinForms;
using System.IO.Ports;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OscilloGen.UserControls;

public partial class UC_Oscilloscope : UserControl
{
    readonly FormsPlot FormsPlot = new FormsPlot() { Dock = DockStyle.Fill };
    private System.Windows.Forms.Timer updateTimer;

    public UC_Oscilloscope()
    {
        InitializeComponent();
        InitializeTimer();
        PlotPanel.Controls.Add(FormsPlot);
    }

    private void StartButton_Click(object sender, EventArgs e)
    {
        SerialConnection.serialPort.DataReceived += SerialProtocol.SignalDataReceived;
    }

    private void StopButton_Click(object sender, EventArgs e)
    {
        SerialProtocol.StopOscilloscope();
    }

    private void InitializeTimer()
    {
        updateTimer = new System.Windows.Forms.Timer();
        updateTimer.Interval = 100; // Update every 100ms
        updateTimer.Tick += Timer_Tick;
        updateTimer.Start();
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        FormsPlot.Plot.Clear();
        FormsPlot.Plot.Add.Signal(SerialProtocol.signalBuffer);
        FormsPlot.Refresh();
    }
}


