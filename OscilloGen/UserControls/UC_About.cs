using OscilloGen.Src;

namespace OscilloGen.UserControls;

public partial class UC_About : UserControl
{
    public UC_About()
    {
        InitializeComponent();
        VersionLabel.Text = $"Version {About.MajorVersion}.{About.MinorVersion}";
    }
}
