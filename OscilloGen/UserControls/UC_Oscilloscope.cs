using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OscilloGen.UserControls;

public partial class UC_Oscilloscope : UserControl
{
    readonly FormsPlot FormsPlot = new FormsPlot() { Dock = DockStyle.Fill };

    public UC_Oscilloscope()
    {
        InitializeComponent();

        PlotPanel.Controls.Add(FormsPlot);
        double[] data = ScottPlot.Generate.Sin();
        FormsPlot.Plot.Add.Signal(data);
        FormsPlot.Refresh();
    }

    private void StartButton_Click(object sender, EventArgs e)
    {

    }

    private void StopButton_Click(object sender, EventArgs e)
    {

    }
}


